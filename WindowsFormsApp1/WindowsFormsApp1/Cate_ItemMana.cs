using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cate_ItemMana : UserControl
    {
        public Cate_ItemMana()
        {
            InitializeComponent();
        }
        public int indexRow;
        Cate_edititem eItem = new Cate_edititem();

        private void update()
        {
            DataSet ds = new DataSet();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "Select ItemID, VirtualID, ItemName, Category, AcceptUOM, supID, BrandID from Item ";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            oleDbDataAdapter.Fill(ds);
            dgvItemList.DataSource = ds.Tables[0];
        }
        private void ItemMana_Load(object sender, EventArgs e)
        {
            dgvItemList.ReadOnly = true;
            update();
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Cate_additem aItem = new Cate_additem();
            aItem.ShowDialog();
            update();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            eItem.ShowDialog();
            update();
        }
        private void DgvItemList_SelectionChanged(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            if (dgvItemList.CurrentCell != null && dgvItemList.CurrentRow.Index < dgvItemList.Rows.Count)
            {
                indexRow = dgvItemList.CurrentCell.RowIndex;
                DataGridViewRow row = dgvItemList.Rows[indexRow];
                string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
                string sqlStr = "Select * from Item where ItemID = @ItemID ";
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();
                OleDbCommand command = new OleDbCommand(sqlStr, conn);
                command.Parameters.AddWithValue("@ItemID", row.Cells[0].Value.ToString());
                OleDbDataReader drd = command.ExecuteReader();
                while (drd.Read())
                {
                   
                    eItem.txtIID.Text = drd["ItemID"].ToString(); 
                    eItem.txtIName.Text = drd["ItemName"].ToString();
                    eItem.cbICategory.Text = drd["Category"].ToString();
                    eItem.txtDesc.Text = drd["ItemDesc"].ToString();
                    eItem.cbIUOM.Text = drd["AcceptUOM"].ToString();
                    eItem.cbSupID.Text = drd["supID"].ToString();
                    eItem.txtIUnitPrice.Text = drd["UnitPrice"].ToString();
                    eItem.txtIUnit.Text = drd["Unit"].ToString();
                    eItem.cbBrandID.Text = drd["BrandID"].ToString();
                    eItem.txtIPOO.Text = drd["POO"].ToString();
                    eItem.cbStorage.Text = drd["Storage"].ToString();
                    if (drd.GetValue(6) == DBNull.Value)
                    {
                        path += "\\Itempic\\null.jpg";
                    }
                    else
                    {
                        path = Path.Combine(path + "\\" + drd.GetValue(6).ToString());
                    }
                    eItem.picbItemPic.Image = Image.FromFile(path);

                }
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "Select ItemID, VirtualID, ItemName, Category, AcceptUOM, supID, BrandID from Item Where " + cbSearch.Text + " Like @text";

            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();

            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            oleDbDataAdapter.SelectCommand.Parameters.Add("@text", OleDbType.VarChar).Value = "%" + tbKeyword.Text + "%";


            oleDbDataAdapter.Fill(ds);
            dgvItemList.DataSource = ds.Tables[0];
        }

        private void dgvItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItemList.CurrentCell != null && dgvItemList.CurrentRow.Index < dgvItemList.Rows.Count)
            {
                try
                {
                    indexRow = dgvItemList.CurrentCell.RowIndex;
                    DataGridViewRow row = dgvItemList.Rows[indexRow];
                    string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
                    string sqlStr = "Delete from Item where ItemID = @ItemID ";
                    OleDbConnection conn = new OleDbConnection(connStr);
                    conn.Open();
                    OleDbCommand command = new OleDbCommand(sqlStr, conn);
                    command.Parameters.AddWithValue("@ItemID", row.Cells[0].Value.ToString());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted. ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    update();
                }
            }
        }

        private void tbKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
