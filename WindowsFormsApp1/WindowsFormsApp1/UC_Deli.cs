using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class UC_Deli : UserControl
    {
        int height = 28;
        public void addHeight()
        {
            height += 28;
        }
        public UC_Deli()
        {
            InitializeComponent();
        }

        private void DeliUC_Load(object sender, EventArgs e)
        {
            if (height >= 300) 
            {
                dgvdeli.Size = new Size(1000, 300);
            }
            else
            {
                dgvdeli.Size = new Size(1000, height);
            }
            
            dgvdeli.Columns[0].HeaderText = "ItemID";
            dgvdeli.Columns[1].HeaderText = "Qty";

        }
    }
}
