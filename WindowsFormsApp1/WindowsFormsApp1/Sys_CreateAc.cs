using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sys_CreateAc : Form
    {
        private string password;
        private string enpassword;
        private string mess = "";
        private void generatepassword()
        {
            char[] chars = "!@#$%^&*?abcdefghijklmnopqrstuvwxyz!@#$%^&*?ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*?1234567890!@#$%^&*?".ToCharArray();
            byte[] data = new byte[16];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(16);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            password = result.ToString();
            enpassword = Encrypt(password);
        }

        private string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        public void Email()
        {
            string to = txtNName.Text + txtLName.Text + "@yummyrg.com";
            string sub = "Your password for Yummy Restaurant Group's procurement system";
            setMessage();
            string username = "yummyrestaurantgroup.bot@gmail.com";
            string password = "jjdunmzpxlunxodr";
            ICredentialsByHost credentials = new NetworkCredential(username, password);

            SmtpClient smtpClient = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = credentials
            };

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(username);
            mail.IsBodyHtml = true;
            mail.To.Add(to);
            mail.Subject = sub;
            mail.Body = mess;

            smtpClient.Send(mail);
            MessageBox.Show("Account Generated Successfully, Email Sent to Employee's email", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void setMessage()
        {
            mess = "<html><head><style>*{box-sizing:border-box;margin:0;padding:0}body{font-family:'Roboto',sans-serif;font-size:16px;line-height:1.5;color:#333;background-color:#171a21}p{color:#dbdbdb;margin-bottom:1rem;font-size:1.1rem}.container{max-width:600px;margin:0 auto;padding:1rem;background-color:#2c2f38;border-radius:1rem;box-shadow:0 4px 8px rgba(0,0,0,0.1);overflow:hidden;}.content{background-color:transparent;padding:1.5rem}.content p:last-child{margin-bottom:0}.code{display:block;margin:0 auto;padding:.5rem;background-color:#66c0f4;color:#171a21;font-size:2rem;font-weight:600;border-radius:.25rem;text-align:center;text-shadow:1px 1px 0 rgba(0,0,0,0.1)}.footer{background-color:transparent;padding:1rem;text-align:center;font-size:.6rem;color:#fff}.footer p{text-align: center;font-size:5px;margin: 0;}</style></head><body><div class='container'><main class='content'><p style='color:#77B9EE';>Dear " + txtNName.Text + ",</p><p>We are excited to welcome you to Yummy Restaurant Group's procurement system. As a new user, we have generated a password for you to use when logging into the system for the first time.\r\n\r\nYour password is: </p><span class='code'>" + password + "</span><p>Please note that this password is case-sensitive and is only for use with the procurement system. We recommend that you do not share this password with anyone and that you change it periodically to ensure the security of our systems.\r\n\r\nTo access the procurement system, please follow the instructions provided to you by our IT support team. If you have any questions or concerns about your password or the system, please do not hesitate to contact our IT support team at support@yummyrestaurantgroup.com\r\n\r\nThank you for your cooperation.</p></main><footer class='footer'><p>&copy; 2023 Yummy Restaurant Group Limited. All rights reserved.</p></footer></div></body></html>";
        }

        public Sys_CreateAc()
        {
            InitializeComponent();
        }

        private void CreateAc_Load(object sender, EventArgs e)
        {


        }

        private void picbxuser_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "insert into Account values(@StaffID,@LastName,@FirstName,@NickName,@Gender,@Position,@DepartmentID,@EmailAddress,@encryptedPassword,@Status,@LastUpdate,@UserPic,@Contact)";
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbCommand command = new OleDbCommand(sqlStr, conn);
            conn.Open();
            string location = AppDomain.CurrentDomain.BaseDirectory + "\\Userpic";
            string path = Path.Combine(location, txtSID.Text + ".jpg");

            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }
            generatepassword();
            DateTime currentDate = DateTime.Now;
            if (txtLName.Text == null || txtFName.Text == null || txtNName.Text == null)
            {
                MessageBox.Show("Name can't be empty");
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
                command.Parameters.AddWithValue("@StaffID", txtSID.Text);
                command.Parameters.AddWithValue("@LastName", txtLName.Text);
                command.Parameters.AddWithValue("@FirstName", txtFName.Text);
                command.Parameters.AddWithValue("@NickName", txtNName.Text);
                command.Parameters.AddWithValue("@Gender", cbxgender.Text);
                command.Parameters.AddWithValue("@Position", cbxpost.Text);
                command.Parameters.AddWithValue("@DepartmentID", Convert.ToInt32(cbxdept.Text));
                command.Parameters.AddWithValue("@EmailAddress", txtNName.Text + txtLName.Text + "@yummyrg.com");
                command.Parameters.AddWithValue("@encryptedPassword", enpassword);
                command.Parameters.AddWithValue("@Status", "Active");
                command.Parameters.AddWithValue("@LastUpdate", currentDate.ToString("dd/MM/yyyy"));
                if (picbxuser.Image != null)
                {
                    command.Parameters.AddWithValue("@UserPic", path);
                    Image a = picbxuser.Image;
                    a.Save(path);
                }
                else
                {
                    command.Parameters.AddWithValue("@UserPic", DBNull.Value);
                }

                command.Parameters.AddWithValue("@Contact", int.Parse(txtcont.Text));

                command.ExecuteNonQuery();


                Email();

                this.Close();
            }
        }
    }
}
