using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sys_Menu : UserControl
    {
        public int ac = 0;
        public int lg = 0;
        public Sys_Menu()
        {
            InitializeComponent();
        }

        private void SystemMenu_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.MouseEnter += new EventHandler(AllButtons_MouseEnter);
                    button.MouseLeave += new EventHandler(AllButtons_MouseLeave);
                }
            }
        }

        private void btnsysac_Click_1(object sender, EventArgs e)
        {
       
            ac++;
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            lg++;
        }
        private void AllButtons_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.BlueViolet;
            }
        }

        private void AllButtons_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.Transparent;
            }
        }

    }
}
