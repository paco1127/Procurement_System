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
    public partial class Cate_Menu : UserControl
    {
        public int editItem = 0;
        public int map = 0;
        public int addvitem=0;
        public Cate_Menu()
        {
            InitializeComponent();
        }

        private void CategoryMenu_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            editItem++;
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

        private void btnmap_Click(object sender, EventArgs e)
        {
            map++;
        }

    }
}
