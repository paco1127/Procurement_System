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
    public partial class Sys_ac : UserControl
    {

        private void update()
        {
            DataSet ds = new DataSet();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "Select StaffID,FirstName,LastName,EmailAddress,Status from Account ";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            oleDbDataAdapter.Fill(ds);
            dgvuserac.DataSource = ds.Tables[0];
        }



        
        public Sys_ac()
        {
            InitializeComponent();
        }
        public int indexRow;
        Sys_editac ced = new Sys_editac();

        private void sysac_Load(object sender, EventArgs e)
        {
            update();
            dgvuserac.ReadOnly = true;
        }

        private void btnaccreate_Click(object sender, EventArgs e)
        {
            var cac = new Sys_CreateAc();
            cac.ShowDialog();
            update();
        }

        private void btnacedit_Click(object sender, EventArgs e)
        {
            ced.ShowDialog();
            update();
        }



        private void dgvuserac_SelectionChanged(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            if(dgvuserac.CurrentCell != null && dgvuserac.CurrentRow.Index < dgvuserac.Rows.Count - 1)
            {
                indexRow = dgvuserac.CurrentCell.RowIndex;
                DataGridViewRow row = dgvuserac.Rows[indexRow];
                string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
                string sqlStr = "Select * from Account where StaffID = @StaffID ";
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();
                OleDbCommand command = new OleDbCommand(sqlStr, conn);
                command.Parameters.AddWithValue("@StaffID", row.Cells[0].Value.ToString());
                OleDbDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    ced.txtSID.Text = rd.GetValue(0).ToString();
                    ced.txtFName.Text = rd.GetValue(1).ToString();
                    ced.txtLName.Text = rd.GetValue(2).ToString();
                    ced.txtNName.Text = rd.GetValue(3).ToString();
                    ced.cbxgender.Text = rd.GetValue(4).ToString();
                    ced.cbxpost.Text = rd.GetValue(5).ToString();
                    ced.cbxdept.Text = rd.GetValue(6).ToString();
                    ced.txtemail.Text = rd.GetValue(7).ToString();
                    if (rd.GetValue(11) == DBNull.Value)
                    {
                        path += "\\Userpic\\Default.png";
                    }
                    else
                    {
                        path = Path.Combine(path + "\\" + rd.GetValue(11).ToString());
                    }

                    ced.picbxuser.Image = Image.FromFile(path);
                }
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "Select StaffID,FirstName,LastName,EmailAddress,Status from Account Where " + cbList.Text + " Like @text";

            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();

            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            oleDbDataAdapter.SelectCommand.Parameters.Add("@text", OleDbType.VarChar).Value = "%" + txtSearch.Text + "%";


            oleDbDataAdapter.Fill(ds);
            dgvuserac.DataSource = ds.Tables[0];
            

                
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
