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
    public partial class Rest_menu : UserControl
    {
        public int restdash = 0;
        public int restreq = 0;
        public int restord = 0;
        public int restordsign = 0;
        public int restinv = 0;

        public Rest_menu()
        {
            InitializeComponent();
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            restreq++;
        }
        private void btnrestdash_Click_1(object sender, EventArgs e)
        {   
            restdash++;
        }
        private void btnordhis_Click(object sender, EventArgs e)
        {
            restord++;
        }
        private void btnordsign_Click(object sender, EventArgs e)
        {
            restordsign++;
        }
        private void btnrestinv_Click(object sender, EventArgs e)
        {
            restinv++;
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

        private void Restaurantmenu_Load(object sender, EventArgs e)
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

        
    }
}
