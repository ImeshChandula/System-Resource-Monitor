using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void showSubMenu()
        {
            pnl_button.Visible = true;
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            customDesign();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            showSubMenu();
        }
    }
}
