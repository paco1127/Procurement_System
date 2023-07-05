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
    public partial class Purc_EditSupplier : Form
    {
        public Purc_EditSupplier()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "UPDATE Supplier SET supName=@supName,supPhone=@supPhone,supAddress=@supAddress,supEmail=@supEmail,supState=@supState WHERE supID=@supID";
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbCommand cmd = new OleDbCommand();
            if (String.IsNullOrEmpty(txtsupID.Text) || String.IsNullOrEmpty(txtsupName.Text) || String.IsNullOrEmpty(txtsupPhone.Text) || String.IsNullOrEmpty(txtsupAddress.Text) || String.IsNullOrEmpty(txtsupEmail.Text))
            {
                MessageBox.Show("Please fill all text box.");
            }
            else
            {
                try
                {
                    if (int.Parse(txtsupPhone.Text) < 10000000 || int.Parse(txtsupPhone.Text) > 99999999)
                    {
                        MessageBox.Show("Phone must be 8 digits");
                    }
                    else if (!IsValidEmail(txtsupEmail.Text))
                    {
                        MessageBox.Show("Email is not in a valid format.");
                    }
                    else
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sqlStr;
                        cmd.Parameters.AddWithValue("@supName", txtsupName.Text);
                        cmd.Parameters.AddWithValue("@supPhone", txtsupPhone.Text);
                        cmd.Parameters.AddWithValue("@supAddress", txtsupAddress.Text);
                        cmd.Parameters.AddWithValue("@supEmail", txtsupEmail.Text);
                        cmd.Parameters.AddWithValue("@supState", cbsupState.Text);
                        cmd.Parameters.AddWithValue("@supID", txtsupID.Text);

                        cmd.Connection = conn;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated ");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Phone must be 8 digits");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
