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
    public partial class Purc_SupplierMana : UserControl
    {
        public Purc_SupplierMana()
        {
            InitializeComponent();
        }
        public int indexRow;
        Purc_EditSupplier eSup = new Purc_EditSupplier();

        private void update()
        {
            DataSet ds = new DataSet();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "Select * from Supplier ";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            oleDbDataAdapter.Fill(ds);
            dgvsupList.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "Select * from Supplier Where " + cbSearch.Text + " Like @text";

            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();

            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            oleDbDataAdapter.SelectCommand.Parameters.Add("@text", OleDbType.VarChar).Value = "%" + tbKeyword.Text + "%";


            oleDbDataAdapter.Fill(ds);
            dgvsupList.DataSource = ds.Tables[0];
        }

        private void Purc_SupplierMana_Load(object sender, EventArgs e)
        {
            dgvsupList.ReadOnly = true;
            update();
        }

        private void dgvsupList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvsupList.CurrentCell != null && dgvsupList.CurrentRow.Index < dgvsupList.Rows.Count)
            {
                indexRow = dgvsupList.CurrentCell.RowIndex;
                DataGridViewRow row = dgvsupList.Rows[indexRow];
                string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
                string sqlStr = "Select * from Supplier where supID = @supID ";
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();
                OleDbCommand command = new OleDbCommand(sqlStr, conn);
                command.Parameters.AddWithValue("@supID", row.Cells[0].Value.ToString());
                OleDbDataReader drd = command.ExecuteReader();
                while (drd.Read())
                {
                    eSup.txtsupID.Text = drd["supID"].ToString();
                    eSup.txtsupName.Text = drd["supName"].ToString();
                    eSup.txtsupPhone.Text = drd["supPhone"].ToString();
                    eSup.txtsupAddress.Text = drd["supAddress"].ToString();
                    eSup.txtsupEmail.Text = drd["supEmail"].ToString();
                    eSup.cbsupState.Text = drd["supState"].ToString();
                }
            }
        }

        private void btnNewSup_Click(object sender, EventArgs e)
        {
            Purc_NewSupplier nSup = new Purc_NewSupplier();
            nSup.ShowDialog();
            update();
        }

        private void btnEditSup_Click(object sender, EventArgs e)
        {
            eSup.ShowDialog();
            update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvsupList.CurrentCell != null && dgvsupList.CurrentRow.Index < dgvsupList.Rows.Count)
            {
                try
                {
                    indexRow = dgvsupList.CurrentCell.RowIndex;
                    DataGridViewRow row = dgvsupList.Rows[indexRow];
                    string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
                    string sqlStr = "Delete from Supplier where supID = @supID ";
                    OleDbConnection conn = new OleDbConnection(connStr);
                    conn.Open();
                    OleDbCommand command = new OleDbCommand(sqlStr, conn);
                    command.Parameters.AddWithValue("@supID", row.Cells[0].Value.ToString());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted. ");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message);
                }
                finally
                {
                    update();
                }
            }
        }
    }
}
