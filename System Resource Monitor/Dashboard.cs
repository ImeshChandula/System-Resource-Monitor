using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Resource_Monitor
{
    public partial class Monitor : Form
    {
        PerformanceCounter perfCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter perfRAM = new PerformanceCounter("Memory","Available MBytes");
        PerformanceCounter perfSYS = new PerformanceCounter("System","System Up Time");

        public Monitor()
        {
            InitializeComponent();
        }

        private void customDesign()
        {
            pnl_button.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu(pnl_button);
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void hideSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {

            }
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close(); //closing active forms
            }
            
            activeForm = childForm;
            childForm.TopLevel = false; //remove form top
            childForm.FormBorderStyle = FormBorderStyle.None; //remove form border
            childForm.Dock = DockStyle.Fill;
            pnl_right_up.Controls.Add(childForm);
            pnl_right_up.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            customDesign();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_button);
        }

        private void stopAll()
        {
            lbl_cpu_v.Text = ":";
            lbl_ram_v.Text = ":";
            lbl_upTime_v.Text = ":";
            lbl_cores_v.Text = ":";
            lbl_P_cpu_v.Text = ":";
            lbl_L_cpu_v.Text = ":";

            pgBar_CPU.Value = 0;
            pgBar_RAM.Value = 0;
        }

        private void btn_cpu_Click(object sender, EventArgs e)
        {
            //openChildForm(new form_cpu());
            timer1.Start();

            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
            {
                lbl_P_cpu_v.Text = ": " + item["NumberOfProcessors"];
            }

            int coreCount = 0;
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }

            lbl_cores_v.Text = ": " + coreCount.ToString();
        }

        private void btn_ram_Click(object sender, EventArgs e)
        {
            //openChildForm(new form_ram());
            timer1.Stop();
            stopAll();
        }


        private int countOfPhysicalCores()
        {
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            string socketDesign = string.Empty;
            List<string> phyCPU = new List<string>();

            if(!phyCPU.Contains(socketDesign))
            {
                phyCPU.Add(socketDesign);
            }

            return phyCPU.Count;
        }

        private int countOfLogicalCores()
        {
            int logCPU = 0;
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();

            logCPU++;

            return logCPU;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = "Date : " + DateTime.Now.ToShortDateString();
            lbl_time.Text = "Time : " + DateTime.Now.ToShortTimeString();

            lbl_cpu_v.Text = ": " + (int)perfCPU.NextValue() + " %";
            lbl_ram_v.Text = ": " + (int)perfRAM.NextValue() + " MB";
            lbl_upTime_v.Text = ": " + (int)perfSYS.NextValue()/60 + " Minutes";

            lbl_L_cpu_v.Text = ": " + Environment.ProcessorCount;

            chart1.Series["CPU"].Points.AddY((int)perfCPU.NextValue());
            chart1.Series["RAM"].Points.AddY((int)perfRAM.NextValue());

            pgBar_CPU.Value = (int)perfCPU.NextValue();
            pgBar_RAM.Value = (int)perfRAM.NextValue()/100;
        }
        

    }
}
