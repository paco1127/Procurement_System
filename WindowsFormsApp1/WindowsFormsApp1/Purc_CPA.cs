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

namespace WindowsFormsApp1
{
    public partial class Purc_CPA : UserControl
    {
        public Purc_CPA()
        {
            InitializeComponent();
        }

        public int indexRow;
        Purc_EditContractCPA eCon = new Purc_EditContractCPA();

        private void update()
        {
            DataSet ds = new DataSet();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "Select ContractID, StaffID, SigningDate, supID, EffectiveDate, ExpirationDate from Contract WHERE Type = 'CPA' ";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            oleDbDataAdapter.Fill(ds);
            dgvContractCPA.DataSource = ds.Tables[0];
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "Select ContractID, StaffID, SigningDate, supID, EffectiveDate, ExpirationDate from Contract Where " + cbSearch.Text + " Like @text";

            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();

            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            oleDbDataAdapter.SelectCommand.Parameters.Add("@text", OleDbType.VarChar).Value = "%" + txtKeyword.Text + "%";


            oleDbDataAdapter.Fill(ds);
            dgvContractCPA.DataSource = ds.Tables[0];
        }

        private void Purc_CPA_Load(object sender, EventArgs e)
        {
            dgvContractCPA.ReadOnly = true;
            update();
        }

        private void btnEditContract_Click(object sender, EventArgs e)
        {
            eCon.ShowDialog();
            update();
        }


        private void btnNewContract_Click(object sender, EventArgs e)
        {
            Purc_NewContractCPA newC = new Purc_NewContractCPA();
            newC.ShowDialog();
            update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContractCPA.CurrentCell != null && dgvContractCPA.CurrentRow.Index < dgvContractCPA.Rows.Count)
            {
                try
                {
                    indexRow = dgvContractCPA.CurrentCell.RowIndex;
                    DataGridViewRow row = dgvContractCPA.Rows[indexRow];
                    string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
                    string sqlStr1 = "Delete from Contract where ContractID = @ContractID ";
                    string sqlStr2 = "Delete from ContractLine where ContractID = @ContractID ";
                    OleDbConnection conn = new OleDbConnection(connStr);
                    conn.Open();
                    OleDbCommand command = new OleDbCommand(sqlStr2, conn);
                    command.Parameters.AddWithValue("@ContractID", row.Cells[0].Value.ToString());
                    command.ExecuteNonQuery();
                    OleDbCommand cmd2 = new OleDbCommand(sqlStr1, conn);
                    cmd2.Parameters.AddWithValue("@ContractID", row.Cells[0].Value.ToString());
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Contract Deleted. ");
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

        private void dgvContractCPA_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContractCPA.CurrentCell != null && dgvContractCPA.CurrentRow.Index < dgvContractCPA.Rows.Count)
            {
                indexRow = dgvContractCPA.CurrentCell.RowIndex;
                DataGridViewRow row = dgvContractCPA.Rows[indexRow];
                string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
                string sqlStr = "Select * from Contract where ContractID = @ContractID ";
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();
                OleDbCommand command = new OleDbCommand(sqlStr, conn);
                command.Parameters.AddWithValue("@ContractID", row.Cells[0].Value.ToString());
                OleDbDataReader drd = command.ExecuteReader();
                while (drd.Read())
                {
                    eCon.txtContractID.Text = drd["ContractID"].ToString();
                    eCon.cbStaffID.Text = drd["StaffID"].ToString();
                    eCon.dtpSigningDate.Text = drd["SigningDate"].ToString();
                    eCon.cbSupID.Text = drd["supID"].ToString();
                    eCon.dtpEffectiveDate.Text = drd["EffectiveDate"].ToString();
                    eCon.dtpExpirationDate.Text = drd["ExpirationDate"].ToString();

                }
            }
        }
    }
}
