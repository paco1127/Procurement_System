using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Ware_POSign : UserControl
    {
        public Ware_POSign()
        {
            InitializeComponent();
        }
        string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";

        private void update()
        {
            DataSet ds = new DataSet();
            string sqlStr = "SELECT PurchaseOrders.PO_ID, PurchaseOrderItems.ItemID, QuantityOrdered, Qty AS WareQTY FROM Stock, PurchaseOrders, PurchaseOrderItems " +
                "Where PurchaseOrders.PO_ID=PurchaseOrderItems.PO_ID AND PurchaseOrderItems.ItemID=Stock.ItemID AND Status='delivery'";
            OleDbConnection conn1 = new OleDbConnection(connStr);
            conn1.Open();
            OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter(sqlStr, conn1);
            oleDbDataAdapter1.Fill(ds);
            dgvOrder.DataSource = ds.Tables[0];
        }

        private void Ware_POSign_Load(object sender, EventArgs e)
        {
            update();
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string poID = dgvOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                string itemID = dgvOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
                int qty = int.Parse(dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString());
                int stockQty = int.Parse(dgvOrder.Rows[e.RowIndex].Cells[4].Value.ToString());
                string sqlStr = "UPDATE PurchaseOrders SET Status=@Status WHERE ItemID=@ItemID AND PO_ID=@PO_ID";
                OleDbConnection conn = new OleDbConnection(connStr);
                OleDbCommand cmd = new OleDbCommand(sqlStr, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Status", "received");
                cmd.Parameters.AddWithValue("@ItemID", itemID);
                cmd.Parameters.AddWithValue("@PO_ID", poID);
                cmd.ExecuteNonQuery();
                conn.Close();
                
                int updatestock = qty + stockQty;
                conn.Open();
                string sqlupdatestock = "UPDATE Stock SET QTY = @updatestock WHERE itemID = @itemID AND Place = 'Warehouse'";
                OleDbCommand cmd2 = new OleDbCommand(sqlupdatestock, conn);
                cmd2.Parameters.AddWithValue("@updatestock", updatestock);
                cmd2.Parameters.AddWithValue("@itemID", itemID);
                cmd2.ExecuteNonQuery();
                conn.Close();
                update();            
            }
        }
    }
}
