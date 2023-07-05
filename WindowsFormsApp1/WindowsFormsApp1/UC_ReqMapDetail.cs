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
    public partial class UC_ReqMapDetail : UserControl
    {
        public int i = 0;

        public UC_ReqMapDetail()
        {
            InitializeComponent();
        }

        private void btndetail_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                this.Size = new System.Drawing.Size(1050, 400);
                this.pnldeli.Size = new System.Drawing.Size(1020, 400);
                i =1;
            }
            else if(i == 1){
                this.Size = new System.Drawing.Size(1050, 100);
                i=0;
            }
            
        }

        private void ReqMapDetail_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1050, 100);
        }


    }
}
