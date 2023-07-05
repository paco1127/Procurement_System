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
    public partial class Ware_EditStock : Form
    {
        public Ware_EditStock()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "UPDATE Stock SET Qty=@Qty WHERE ItemID=@ItemID";
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;
                cmd.Parameters.AddWithValue("@Qty", Int32.Parse(txtIStock.Text));
                cmd.Parameters.AddWithValue("@ItemID", txtIID.Text);

                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Stock Updated ");
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please input integer digits.");
            }
            finally
            {
                conn.Close();
            }
        }
    } 
}
