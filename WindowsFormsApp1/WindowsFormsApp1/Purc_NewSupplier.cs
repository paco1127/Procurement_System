using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Purc_NewSupplier : Form
    {
        public Purc_NewSupplier()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "insert into Supplier values(@supID,@supName,@supPhone,@supAddress,@supEmail,@supState)";
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbCommand command = new OleDbCommand(sqlStr, conn);
            conn.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            if (String.IsNullOrEmpty(txtsupID.Text) || String.IsNullOrEmpty(txtsupName.Text) || String.IsNullOrEmpty(txtsupPhone.Text) || String.IsNullOrEmpty(txtsupAddress.Text) || String.IsNullOrEmpty(txtsupEmail.Text))
            {
                MessageBox.Show("Please fill all text box.");
            } else {
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
                        command.Parameters.AddWithValue("@supID", txtsupID.Text);
                        command.Parameters.AddWithValue("@supName", txtsupName.Text);
                        command.Parameters.AddWithValue("@supPhone", int.Parse(txtsupPhone.Text));
                        command.Parameters.AddWithValue("@supAddress", txtsupAddress.Text);
                        command.Parameters.AddWithValue("@supEmail", txtsupEmail.Text);
                        command.Parameters.AddWithValue("@supState", "available");
                        command.ExecuteNonQuery();
                        MessageBox.Show("New supplier information is added");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Phone must be 8 digits");
                }
            }

        } 

    }
}


