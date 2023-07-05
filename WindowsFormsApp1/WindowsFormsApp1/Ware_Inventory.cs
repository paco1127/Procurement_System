using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Ware_Inventory : UserControl
    {
        public Ware_Inventory()
        {
            InitializeComponent();
        }
        string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
        Ware_EditStock eStock = new Ware_EditStock();

        int indexRow = 0;

        private void update()
        {
            DataSet ds = new DataSet();
            string sqlStr = "Select Stock.ItemID, ItemName, Qty from [Stock],[Item] WHERE Stock.ItemID = Item.ItemID AND Place = 'Warehouse' ";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            oleDbDataAdapter.Fill(ds);
            dgvStockList.DataSource = ds.Tables[0];
        }

        private void Ware_Inventory_Load(object sender, EventArgs e)
        {
            dgvStockList.ReadOnly = true;
            update();
        }

        private void dgvStockList_SelectionChanged(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            if (dgvStockList.CurrentCell != null && dgvStockList.CurrentRow.Index < dgvStockList.Rows.Count)
            {
                indexRow = dgvStockList.CurrentCell.RowIndex;
                DataGridViewRow row = dgvStockList.Rows[indexRow];
                string sqlStr = "Select Stock.ItemID, ItemName, Qty, Picture from [Stock], [Item] Where Stock.ItemID = Item.ItemID AND Place = 'Warehouse' AND Stock.ItemID = @ItemID ";
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();
                OleDbCommand command = new OleDbCommand(sqlStr, conn);
                command.Parameters.AddWithValue("@ItemID", row.Cells[0].Value.ToString());
                OleDbDataReader drd = command.ExecuteReader();
                while (drd.Read())
                {

                    eStock.txtIID.Text = drd["ItemID"].ToString();
                    eStock.txtIName.Text = drd["ItemName"].ToString();
                    eStock.txtIStock.Text = drd["Qty"].ToString();
                    
                    if (drd.GetValue(3) == DBNull.Value)
                    {
                        path += "\\Itempic\\null.jpg";
                    }
                    else
                    {
                        path = Path.Combine(path + "\\" + drd.GetValue(3).ToString());
                    }
                    eStock.picBoxItemImage.Image = Image.FromFile(path);

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            eStock.ShowDialog();
            update();
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
