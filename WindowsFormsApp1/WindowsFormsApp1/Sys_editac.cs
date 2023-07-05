using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sys_editac : Form
    {
        public Sys_editac()
        {
            InitializeComponent();
        }

        private void editac_Load(object sender, EventArgs e)
        {   
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "Update Account Set [LastName]=@Lastname, [FirstName]=@Firstname, [NickName]=@NickName, [Gender]=@Gender, [Position]=@Position, [DepartmentID]=@DepartmentID, [EmailAddress]=@email, [Contact]=@Contact WHERE StaffID=@StaffID";
            string location = AppDomain.CurrentDomain.BaseDirectory + "\\Userpic";
            string path = Path.Combine(location, txtSID.Text + ".jpg");
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr;
            if (txtLName.Text == null || txtFName.Text == null || txtNName.Text == null || txtemail.Text == null)
            {
                MessageBox.Show("Email or Name can't be empty");
            }
            else if (String.IsNullOrEmpty(txtcont.Text))
            {
                MessageBox.Show("Phone not be Empty!");
            }
            else if (int.Parse(txtcont.Text) < 10000000 || int.Parse(txtcont.Text) > 99999999)
            {
                MessageBox.Show("Phone must be 8 digits");
            }
            else
            {
                cmd.Parameters.AddWithValue("@Lastname", txtLName.Text);
                cmd.Parameters.AddWithValue("@Firstname", txtFName.Text);
                cmd.Parameters.AddWithValue("@NickName", txtNName.Text);
                cmd.Parameters.AddWithValue("@Gender", cbxgender.Text);
                cmd.Parameters.AddWithValue("@Position", cbxpost.Text);
                cmd.Parameters.AddWithValue("@DepartmentID", int.Parse(cbxdept.Text));
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@Contact", int.Parse(txtcont.Text));
                cmd.Parameters.AddWithValue("@StaffID", txtSID.Text);
                if (picbxuser.Image != null)
                {
                    cmd.Parameters.AddWithValue("@UserPic", path);
                    Image a = picbxuser.Image;
                    a.Save(path);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@UserPic", DBNull.Value);
                }
                cmd.Connection = conn;
                conn.Open();


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated, Press Close to Close");
                this.Close();
            }
        }
    }
}
