using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Threading;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private static String staffID = "";
        Static_LogWriter logWriter;
        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        public static String getStaffID()
        {
            return staffID;
        }
        bool CorrectPassword()
        {
            String sqlStr = "Select * From Account Where StaffID = @staffID and encryptedPassword = @password";
            String connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Database.accdb";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(sqlStr, conn))
                    {
                        cmd.Parameters.AddWithValue("@staffID", textBox1.Text);
                        cmd.Parameters.AddWithValue("@password", Encrypt(textBox2.Text));
                        using (OleDbDataReader r = cmd.ExecuteReader())
                        {
                            if (r.HasRows)
                            {
                                return true;
                            }
                            else { return false; }
                        }
                    }
                }
            }
        }
        void setEmployee()
        {
            String sqlStr = "Select * From Account Where StaffID = @staffID";
            String connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Database.accdb";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@staffID", staffID);
                    OleDbDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        
                        if (int.Parse(r.GetValue(6).ToString()) == 5)
                        {
                            String sql = "Select restID,brID From Restaurant Where managerID = @staffID";
                            using (OleDbConnection conn1 = new OleDbConnection(connStr))
                            {
                                
                                using (OleDbCommand cmd1 = new OleDbCommand(sql, conn))
                                {
                                    cmd1.Parameters.AddWithValue("@staffID", staffID);
                                    OleDbDataReader re = cmd1.ExecuteReader();
                                    while (re.Read())
                                    {
                                        Stat_Employee.Restaurantid = re.GetValue(0).ToString();
                                        Stat_Employee.BrID = int.Parse(re.GetValue(1).ToString());
                                    }
                                }
                            }
                           
                        }
                        Stat_Employee.Id = staffID;
                        Stat_Employee.Name = r.GetValue(1).ToString() + " " + r.GetValue(2).ToString();
                        Stat_Employee.Email = r.GetValue(7).ToString();
                        Stat_Employee.DeptID = r.GetValue(6).ToString();
                        if (r.GetValue(11) == DBNull.Value)
                        {
                            Stat_Employee.Userpic = null;
                        }
                        else
                        {
                            Stat_Employee.Userpic = r.GetValue(11).ToString();
                           
                        }
                    }
                }
            }
        }
        public Login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {     

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (CorrectPassword())
            {
                staffID = textBox1.Text;
                setEmployee();
                //MessageBox.Show("Password Correct! \nVerify Yourself", "Correct", MessageBoxButtons.OK);
                MessageBox.Show("Password Correct!", "Correct", MessageBoxButtons.OK);
                this.Hide();
                var verify = new MainPage();
                verify.Show();
            }
            else
            {
                logWriter = new Static_LogWriter(textBox1.Text + " login fail!");
                MessageBox.Show("StaffID or Password Wrong", "WRONG!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnfill_Click(object sender, EventArgs e)
        {
            textBox1.Text = "S-002";
            textBox2.Text = "M3KcP0Z%GRayq30A";
        }

        private void btnfillCate_Click(object sender, EventArgs e)
        {
            textBox1.Text = "S-008";
            textBox2.Text = "uM&ow#wtsMve&*nw";
        }

        private void btnfillRest_Click(object sender, EventArgs e)
        {
            textBox1.Text = "S-001";
            textBox2.Text = "W$UBre?#nFb@g?Sw";
        }

        private void btnfillWare_Click(object sender, EventArgs e)
        {
            textBox1.Text = "S-006";
            textBox2.Text = "1*jkCVTNvl#sfuS5";
        }

        private void btnfillAcc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "S-004";
            textBox2.Text = "ZOM0#D5E1t4cMKf^";
        }

        private void btnPurc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "S-012";
            textBox2.Text = "9m6sGnQd?c5cUfZ?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact IT Manager at YRGLITSupport@YRGL.com");
        }
    }
}
