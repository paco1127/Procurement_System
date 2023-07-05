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
    public partial class AccountingMenu : UserControl
    {
        public AccountingMenu()
        {
            InitializeComponent();
        }

        private void AccountingMenu_Load(object sender, EventArgs e)
        {
            // Assign the event handlers to all Button controls in the form
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.MouseEnter += new EventHandler(AllButtons_MouseEnter);
                    button.MouseLeave += new EventHandler(AllButtons_MouseLeave);
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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
