using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Verify : Form
    {
        string verifyCode = "";
        public Verify()
        {
            InitializeComponent();
        }
        // EMAIL SENDING

        string to = Stat_Employee.Email;
        string sub = "Yummy Restaurant Group Limited Procurement System Login: Your Two-Factor Authentication (2FA) Code";
        string mess = "";
        public void Email()
        {
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
            MessageBox.Show("An Email Has Been Sent To Your Email Address\nPlease Check Your MailBox!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // MAIN CODE
        private void button1_Click(object sender, EventArgs e)
        {
            getVerCode();
            setMessage();
            Email();
        }
        private void setMessage()
        {
            mess = "<html><head><style>*{box-sizing:border-box;margin:0;padding:0}body{font-family:'Roboto',sans-serif;font-size:16px;line-height:1.5;color:#333;background-color:#171a21}p{color:#dbdbdb;margin-bottom:1rem;font-size:1.1rem}.container{max-width:600px;margin:0 auto;padding:1rem;background-color:#2c2f38;border-radius:1rem;box-shadow:0 4px 8px rgba(0,0,0,0.1);overflow:hidden;}.content{background-color:transparent;padding:1.5rem}.content p:last-child{margin-bottom:0}.code{display:block;margin:0 auto;padding:.5rem;background-color:#66c0f4;color:#171a21;font-size:2rem;font-weight:600;border-radius:.25rem;text-align:center;text-shadow:1px 1px 0 rgba(0,0,0,0.1)}.footer{background-color:transparent;padding:1rem;text-align:center;font-size:.6rem;color:#fff}.footer p{text-align: center;font-size:5px;margin: 0;}</style></head><body><div class='container'><main class='content'><p style='color:#77B9EE';>Dear " + Stat_Employee.Name + ",</p><p>A unique code has been generated for your login attempt:</p><span class='code'>"+ verifyCode +"</span><p>Please note that this code is valid for 5 minutes. Do not share this code with anyone, including colleagues or IT staff.</p><p>If you did not attempt to log in, please contact our IT department immediately at support@yummyrestaurantgroup.com.</p></main><footer class='footer'><p>&copy; 2023 Yummy Restaurant Group Limited. All rights reserved.</p></footer></div></body></html>";
        }
        private void getVerCode()
        {
            char[] chars = "!@#$%^&*?abcdefghijklmnopqrstuvwxyz!@#$%^&*?ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*?1234567890!@#$%^&*?".ToCharArray();
            byte[] data = new byte[6];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(6);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            verifyCode = result.ToString();
        }

        private void Verify_Load(object sender, EventArgs e)
        {
            getVerCode();
            setMessage();
            Email();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtChar.Text == verifyCode)
            {
                String sqlStr = "Update Account SET lastUpdate = @time Where StaffID = @staffID";
                String connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Database.accdb";
                
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.Parameters.AddWithValue("@staffID", Stat_Employee.Id);
                    cmd.Parameters.AddWithValue("@time", DateTime.Now);
                    cmd.CommandText = sqlStr;
                    cmd.ExecuteNonQuery();
                }


                Static_LogWriter logWriter = new Static_LogWriter(Stat_Employee.Id + " login successful!");
                MessageBox.Show("      Welcome!\n      Redirecting", "Correct");
                Thread.Sleep(100);
                this.Hide();
                var main = new MainPage();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("WRONG VERIFCATION CODE! \n PLEASE TRY AGAIN", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                var form1 = new Login();
                form1.ShowDialog();
            }
        }
    }
}
