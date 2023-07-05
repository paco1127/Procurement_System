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
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Purc_NewContract : Form
    {
        public Purc_NewContract()
        {
            InitializeComponent();
        }
        public int indexRow;
        private void update()
        {
            try
            {
                DataSet ds = new DataSet();
                string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
                string sqlStr4 = "Select ItemID, PromisedQty, Price, UOM from ContractLine WHERE ContractID LIKE " + txtContractID.Text;
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr4, conn);
                oleDbDataAdapter.Fill(ds);
                dgvSelectItem.DataSource = ds.Tables[0];
            }catch(Exception ex)
            {
                
            }
        }
        private void Purc_NewContract_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr1 = "SELECT StaffID FROM Account";
            string sqlStr2 = "SELECT ItemID FROM Item";
            string sqlStr3 = "SELECT supID FROM Supplier";
            string sqlStr4 = "Select ItemID, PromisedQty, Price, UOM from ContractLine WHERE ContractID is null";


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
            cmd.CommandText = sqlStr2;
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
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr4, conn);
            oleDbDataAdapter.Fill(ds);
            dgvSelectItem.DataSource = ds.Tables[0];
            conn.Close();
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr1 = "insert into Contract values(@ContractID,@supID,@SigningDate,@StaffID,@EffectiveDate,@ExpirationDate,@Type,@Reference)";
            
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbCommand cmd1 = new OleDbCommand(sqlStr1, conn);
            if (String.IsNullOrEmpty(txtContractID.Text))
            {
                MessageBox.Show("ContractID can't be Empty.");
            }
            else
            {
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
                try
                {
                    conn.Open();
                    cmd1.Parameters.AddWithValue("@ContractID", txtContractID.Text);
                    cmd1.Parameters.AddWithValue("supID", cbStaffID.Text);
                    cmd1.Parameters.AddWithValue("@SigningDate", dtpSigningDate);
                    cmd1.Parameters.AddWithValue("@StaffID", cbSupID.Text);
                    cmd1.Parameters.AddWithValue("@EffectiveDate", dtpEffectiveDate);
                    cmd1.Parameters.AddWithValue("@ExpirationDate", dtpExpirationDate);
                    cmd1.Parameters.AddWithValue("@Type", "BPA");
                    cmd1.Parameters.AddWithValue("@Reference", "a");

                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("New Contract is added");
                    conn.Close();
                    this.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Contract ID must be digits.");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

      
        private void btnUploadPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
 
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtContractID is null)
            {
                MessageBox.Show("Please input Contract ID first.");
            }
            else
            {
                try
                {
                    string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
                    string sqlStr = "insert into ContractLine values(@ItemID,@ContractID,@PromisedQty,@Price,@UOM)";
                    OleDbConnection conn = new OleDbConnection(connStr);
                    OleDbCommand command = new OleDbCommand(sqlStr, conn);
                    conn.Open();
                    command.Parameters.AddWithValue("@ItemID", cbItemID.Text);
                    command.Parameters.AddWithValue("@ContractID", txtContractID.Text);
                    command.Parameters.AddWithValue("@PromisedQty", Int32.Parse(txtPQty.Text));
                    command.Parameters.AddWithValue("@Price", Int32.Parse(txtPrice.Text));
                    command.Parameters.AddWithValue("@UOM", cbUOM.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("New item is added");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please input ContractID first.");
                }
                finally
                {
                    update();
                }
            }
        }


        private void pbUploadPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
                string sqlStr = "UPDATE ContractLine SET ItemID=@ItemID,PromisedQty=@PromisedQty,Price=@Price,UOM=@UOM WHERE ContractID=@ContractID AND ItemID=@ItemID";
                OleDbConnection conn = new OleDbConnection(connStr);
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;

                cmd.Parameters.AddWithValue("@ItemID", cbItemID.Text);
                cmd.Parameters.AddWithValue("@PromisedQty", Int32.Parse(txtPQty.Text));
                cmd.Parameters.AddWithValue("@Price", Int32.Parse(txtPrice.Text));
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
                MessageBox.Show("Please input ContractID first.");
            }
            finally
            {
                update();
            }
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
