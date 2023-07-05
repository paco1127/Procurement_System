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

namespace WindowsFormsApp1
{
    public partial class Purc_viewInv : UserControl
    {
        public Purc_viewInv()
        {
            InitializeComponent();
        }

        string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
        private void Purc_viewInv_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string sqlStr = "Select Stock.ItemID, ItemName, Qty from [Stock],[Item] WHERE Stock.ItemID = Item.ItemID AND Place = 'Warehouse' ";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            oleDbDataAdapter.Fill(ds);
            dgvStockList.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string sqlStr = "Select Stock.ItemID, ItemName, Qty, Picture from [Stock], [Item] Where Stock.ItemID = Item.ItemID AND Place = 'Warehouse' AND Stock.ItemID =" + txtSearch.Text;

            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();

            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            oleDbDataAdapter.Fill(ds);
            dgvStockList.DataSource = ds.Tables[0];
        }
    }
}
