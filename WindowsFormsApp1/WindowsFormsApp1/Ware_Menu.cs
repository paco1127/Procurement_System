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
    public partial class Ware_Menu : UserControl
    {
        public int deli = 0;
        public int inv = 0;
        public int po = 0;
        public Ware_Menu()
        {
            InitializeComponent();
        }

        private void WarehouseMenu_Load(object sender, EventArgs e)
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

        private void btndeliord_Click(object sender, EventArgs e)
        {
            deli++;
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            inv++;
        }

        private void btnordhis_Click(object sender, EventArgs e)
        {
            po++;
        }
    }
}
