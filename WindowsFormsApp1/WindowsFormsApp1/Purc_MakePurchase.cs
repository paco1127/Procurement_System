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
using System.Diagnostics.Contracts;
using System.Diagnostics;
using System.Security.Cryptography;
using Sunny.UI.Win32;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Purc_MakePurchase : Form
    {
        public Purc_MakePurchase()
        {
            InitializeComponent();
        }

        String date = DateTime.Now.ToString("dd/MM/yyyy");
        int updateqty = 0;
        int indexRow = 0;

        string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";


        private void update(string connStr)
        {
            DataSet ds = new DataSet();
            string sqlStr = "SELECT ItemID, SUM(Quantity) AS TotalQty FROM ItemOrder WHERE Status='unaccept' Group By ItemID";
            OleDbConnection conn1 = new OleDbConnection(connStr);
            conn1.Open();
            OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter(sqlStr, conn1);
            oleDbDataAdapter1.Fill(ds);
            dgvUnacceptItem.DataSource = ds.Tables[0];
        }
        private void Purc_MakePurchase_Load(object sender, EventArgs e)
        {
            update(connStr);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvUnacceptItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = "";

            if (e.ColumnIndex == 0)
            {
                id = dgvUnacceptItem.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            BPA(id);
            CPA(id);
            if (dgvBPA.Rows.Count == 0 && dgvCPA.Rows.Count == 0)
            {
                MessageBox.Show("No mapping. Please update contract information or go to 'Create Standard Order' complete your oreder.");
            }
        }

        private void BPA(string id)
        {
            DataSet ds = new DataSet();
            string sqlStr = "SELECT Contract.ContractID, ItemID, supID, PromisedQty, Price FROM Contract, ContractLine " +
                "Where Contract.ContractID=ContractLine.ContractID AND Type = 'BPA' AND ItemID = '" + id + "' AND " + date + " < EffectiveDate AND ExpirationDate > " + date;
            OleDbConnection conn1 = new OleDbConnection(connStr);
            conn1.Open();
            OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter(sqlStr, conn1);
            oleDbDataAdapter1.Fill(ds);
            dgvBPA.DataSource = ds.Tables[0];
        }

        private void CPA(string id)
        {

            DataSet ds = new DataSet();
            string sqlStr = "SELECT Contract.ContractID, ItemID, supID FROM Contract, ContractLine " +
                "Where Contract.ContractID=ContractLine.ContractID AND Type = 'CPA' AND ItemID = '" + id + "' AND " + date + " < EffectiveDate AND ExpirationDate > " + date;
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            oleDbDataAdapter.Fill(ds);
            dgvCPA.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void dgvBPA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    string supID = "", itemID = "", contractID = "";
                    int qty, price, orderqty, updateqty, promisedQty, updateContractQty, orderContractQty;
                
                    supID = dgvBPA.Rows[e.RowIndex].Cells[4].Value.ToString();
                    itemID = dgvBPA.Rows[e.RowIndex].Cells[3].Value.ToString();
                    contractID = dgvBPA.Rows[e.RowIndex].Cells[2].Value.ToString();
                    qty = int.Parse(dgvBPA.Rows[e.RowIndex].Cells[1].Value.ToString());
                    promisedQty = int.Parse(dgvBPA.Rows[e.RowIndex].Cells[5].Value.ToString());
                    orderqty = int.Parse(dgvUnacceptItem.Rows[e.RowIndex].Cells[2].Value.ToString());
                    orderContractQty = int.Parse(dgvBPA.Rows[e.RowIndex].Cells[1].Value.ToString());
                    price = int.Parse(dgvBPA.Rows[e.RowIndex].Cells[6].Value.ToString());


                    string sqlStr1 = "INSERT INTO [PurchaseOrderItems] ([itemID],[QuantityOrdered],[UnitPrice]) VALUES (@itemID,@QuantityOrdered,@UnitPrice)";
                    string sqlStr2 = "INSERT INTO [PurchaseOrders] ([SupplierID],[OrderDate],[Status]) VALUES (@SupplierID,@OrderDate,@Status)";
                    string sqlStr4 = "UPDATE ContractLine SET PromisedQty=@PromisedQty WHERE ItemID=@ItemID AND ContractID=@COntractID";
                    string sqlStr5 = "UPDATE ItemOrder SET Status=@Status WHERE ItemID=@ItemID";
                    OleDbConnection conn = new OleDbConnection(connStr);
                    OleDbCommand cmd2 = new OleDbCommand(sqlStr2, conn);
                    conn.Open();
                    cmd2.Parameters.AddWithValue("@SupplierID", supID);
                    cmd2.Parameters.AddWithValue("@OrderDate", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    cmd2.Parameters.AddWithValue("@Status", "delivery");
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    OleDbCommand cmd1 = new OleDbCommand(sqlStr1, conn);
                    conn.Open();
                    cmd1.Parameters.AddWithValue("@ItemID", itemID);
                    cmd1.Parameters.AddWithValue("@QuantityOrdered", (int)qty);
                    cmd1.Parameters.AddWithValue("@UnitPrice", (int)price);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("New Order is Created.");
                    conn.Close();

                    updateContractQty = promisedQty - orderContractQty;

                    OleDbCommand cmd4 = new OleDbCommand(sqlStr4, conn);
                    conn.Open();
                    cmd4.Parameters.AddWithValue("@PromisedQty", updateContractQty);
                    cmd4.Parameters.AddWithValue("@ItemID", itemID);
                    cmd4.Parameters.AddWithValue("@ContractID", contractID);
                    cmd4.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please input vaild Qty before click order.");
                }
            }

        }

        private void dgvCPA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 0)
            {
                try { 
                string supID = "",itemID="";
                int qty, price, orderqty;
                orderqty = int.Parse(dgvUnacceptItem.Rows[e.RowIndex].Cells[2].Value.ToString());
                supID = dgvCPA.Rows[e.RowIndex].Cells[5].Value.ToString();
                itemID = dgvCPA.Rows[e.RowIndex].Cells[4].Value.ToString();
                qty = int.Parse(dgvCPA.Rows[e.RowIndex].Cells[2].Value.ToString());
                price = int.Parse(dgvCPA.Rows[e.RowIndex].Cells[1].Value.ToString());
                string sqlStr1 = "INSERT INTO [PurchaseOrderItems] ([itemID],[QuantityOrdered],[UnitPrice]) VALUES (@itemID,@QuantityOrdered,@UnitPrice)";
                string sqlStr2 = "INSERT INTO [PurchaseOrders] ([SupplierID],[OrderDate],[Status]) VALUES (@SupplierID,@OrderDate,@Status)";
                OleDbConnection conn = new OleDbConnection(connStr);
                OleDbCommand cmd2 = new OleDbCommand(sqlStr2, conn);
                conn.Open();
                cmd2.Parameters.AddWithValue("@SupplierID", supID);
                cmd2.Parameters.AddWithValue("@OrderDate", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                cmd2.Parameters.AddWithValue("@Status","delivery");
                cmd2.ExecuteNonQuery();
                conn.Close();
                OleDbCommand cmd1 = new OleDbCommand(sqlStr1, conn);
                conn.Open();
                cmd1.Parameters.AddWithValue("@itemID", itemID);
                cmd1.Parameters.AddWithValue("@QuantityOrdered", (int)qty);
                cmd1.Parameters.AddWithValue("@UnitPrice", (int)price);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("New Order is Created.");
                conn.Close();

                update(connStr);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please input vaild Qty and price before click order.");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnStandOrd_Click(object sender, EventArgs e)
        {
            Purc_NewSOrd purc_NewS = new Purc_NewSOrd();
            purc_NewS.ShowDialog();
        }
    }
}

