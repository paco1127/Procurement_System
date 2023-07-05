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
    public partial class Purc_EditContractCPA : Form
    {
        public Purc_EditContractCPA()
        {
            InitializeComponent();
        }
        public int indexRow;

        private void update()
        {
            DataSet ds = new DataSet();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr4 = "Select ItemID, UOM from ContractLine WHERE ContractID = '" + txtContractID.Text+"'";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr4, conn);
            oleDbDataAdapter.Fill(ds);
            dgvSelectItem.DataSource = ds.Tables[0];
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "insert into ContractLine values(@ItemID,@ContractID,@PromisedQty,@Price,@UOM)";
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbCommand command = new OleDbCommand(sqlStr, conn);
            conn.Open();
            command.Parameters.AddWithValue("@ItemID", cbItemID.Text);
            command.Parameters.AddWithValue("@ContractID", txtContractID.Text);
            command.Parameters.AddWithValue("@PromisedQty", DBNull.Value);
            command.Parameters.AddWithValue("@Price", DBNull.Value);
            command.Parameters.AddWithValue("@UOM", cbUOM.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("New item is added");
            conn.Close();
            update();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
                string sqlStr = "UPDATE ContractLine SET ItemID=@ItemID,UOM=@UOM WHERE ContractID=@ContractID AND ItemID=@ItemID";
                OleDbConnection conn = new OleDbConnection(connStr);
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;

                cmd.Parameters.AddWithValue("@ItemID", cbItemID.Text);
                cmd.Parameters.AddWithValue("@UOM", cbUOM.Text);
                cmd.Parameters.AddWithValue("@ContractID", txtContractID.Text);
                cmd.Parameters.AddWithValue("@ItemID", cbItemID.Text);

                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Updated!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
            finally
            {
                update();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "UPDATE Contract SET StaffID=@StaffID, supID=@supID, SigningDate=@SigningDate, EffectiveDate=@EffectiveDate, ExpirationDate=@ExpirationDate WHERE ContractID=@ContractID";
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr;
            DateTime SigningDate = dtpSigningDate.Value;
            DateTime effectiveDate = dtpEffectiveDate.Value;
            DateTime expirationDate = dtpExpirationDate.Value;

            if (effectiveDate < SigningDate)
            {
                MessageBox.Show("Effective date cannot be earlier than Signing date.");
                return;
            }

            if (expirationDate < effectiveDate)
            {
                MessageBox.Show("Expiration date cannot be earlier than effective date.");
                return;
            }
            cmd.Parameters.AddWithValue("@StaffID", cbStaffID.Text);
            cmd.Parameters.AddWithValue("@supID", cbSupID.Text);
            cmd.Parameters.AddWithValue("@SigningDate", dtpSigningDate.Text);
            cmd.Parameters.AddWithValue("@EffectiveDate", dtpEffectiveDate.Text);
            cmd.Parameters.AddWithValue("@ExpirationDate", dtpExpirationDate.Text);
            cmd.Parameters.AddWithValue("@ContractID", txtContractID.Text);

            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated!");
            this.Close();
        }

        private void Purc_EditContractCPA_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr1 = "SELECT StaffID FROM Account";
            string sqlStr2 = "Select ItemID, UOM from ContractLine Where ContractID = '"+txtContractID.Text+"'";
            string sqlStr3 = "SELECT supID FROM Supplier";
            string sqlStr4 = "SELECT ItemID FROM Item";
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr1;
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbStaffID.Items.Add(reader["StaffID"].ToString());
            }
            conn.Close();

            conn = new OleDbConnection(connStr);
            cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr4;
            conn.Open();
            reader = cmd.ExecuteReader();

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
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr2, conn);

            oleDbDataAdapter.Fill(ds);
            dgvSelectItem.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSelectItem.CurrentCell != null && dgvSelectItem.CurrentRow.Index < dgvSelectItem.Rows.Count)
            {
                try
                {
                    indexRow = dgvSelectItem.CurrentCell.RowIndex;
                    DataGridViewRow row = dgvSelectItem.Rows[indexRow];
                    string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
                    string sqlStr = "Delete from ContractLine where ItemID = @ItemID ";
                    OleDbConnection conn = new OleDbConnection(connStr);
                    conn.Open();
                    OleDbCommand command = new OleDbCommand(sqlStr, conn);
                    command.Parameters.AddWithValue("@ItemID", row.Cells[0].Value.ToString());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Deleted. ");
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
    }
}
