using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Resource_Monitor
{
    public partial class Monitor : Form
    {

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

        private void btn_cpu_Click(object sender, EventArgs e)
        {
            openChildForm(new form_cpu());
        }

        private void btn_ram_Click(object sender, EventArgs e)
        {
            openChildForm(new form_ram());
        }
    }
}
