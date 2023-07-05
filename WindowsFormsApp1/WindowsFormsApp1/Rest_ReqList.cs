using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class RestOrd : UserControl
    {
        public string RID = "";
        

        public RestOrd()
        {
            InitializeComponent();
        }
        private void update()
        {
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "Select FORMAT(RestReq.RID,'R-000') As RequestID,RestaurantID,ReqDate,Status from RestReq Where Status = 'Processing' AND DATEDIFF('h', ReqDate, NOW()) < 2";
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sqlStr, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataadapter.Fill(ds, "RestReq");
            conn.Close();
            dgvorder.DataSource = ds;
            dgvorder.DataMember = "RestReq";
        }
        private void RestOrd_Load(object sender, EventArgs e)
        {
            update();
            dgvorder.ReadOnly = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            var Order = new Rest_request();
            Order.Show();
            update();
            Order = null;
            GC.Collect();
        }

        private void dgvorder_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvorder.CurrentCell != null && dgvorder.CurrentRow.Index < dgvorder.Rows.Count)
            {
                    RID = dgvorder.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            var Order = new Rest_request(RID);
            Order.Show();
            update();
            Order = null;
            GC.Collect();
        }
    }
}
