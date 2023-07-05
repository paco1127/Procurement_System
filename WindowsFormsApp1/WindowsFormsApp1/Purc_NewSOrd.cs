using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Purc_NewSOrd : Form
    {
        public Purc_NewSOrd()
        {
            InitializeComponent();
        }
        string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";


        private void Purc_NewSOrd_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string sqlStr3 = "SELECT supID FROM Supplier";
            string sqlStr4 = "SELECT ItemID FROM Item";
            OleDbConnection conn = new OleDbConnection(connStr); 
            OleDbCommand cmd = new OleDbCommand();
            
            conn = new OleDbConnection(connStr);
            cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr4;
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbItemID.Items.Add(reader["ItemID"].ToString());
            }
            conn.Close();

            conn = new OleDbConnection(connStr);
            cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr3;
            conn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbSupID.Items.Add(reader["supID"].ToString());
            }
            conn.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr1 = "INSERT INTO [PurchaseOrderItems] ([itemID],[QuantityOrdered],[UnitPrice]) VALUES (@itemID,@QuantityOrdered,@UnitPrice)";
                string sqlStr2 = "INSERT INTO [PurchaseOrders] ([SupplierID],[OrderDate],[Status]) VALUES (@SupplierID,@OrderDate,@Status)";

                OleDbConnection conn = new OleDbConnection(connStr);
                OleDbCommand cmd2 = new OleDbCommand(sqlStr2, conn);
                conn.Open();
                cmd2.Parameters.AddWithValue("@SupplierID", cbSupID.Text);
                cmd2.Parameters.AddWithValue("@OrderDate", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                cmd2.Parameters.AddWithValue("@Status", "delivery");
                cmd2.ExecuteNonQuery();
                conn.Close();
                OleDbCommand cmd1 = new OleDbCommand(sqlStr1, conn);
                conn.Open();
                cmd1.Parameters.AddWithValue("@ItemID", cbItemID.Text);
                cmd1.Parameters.AddWithValue("@QuantityOrdered", Int32.Parse(txtPQty.Text));
                cmd1.Parameters.AddWithValue("@UnitPrice", Int32.Parse(txtPrice.Text));
                cmd1.ExecuteNonQuery();
                MessageBox.Show("New Order is Created.");
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("Please make sure you filled all box");
            }
        }
    }
}
