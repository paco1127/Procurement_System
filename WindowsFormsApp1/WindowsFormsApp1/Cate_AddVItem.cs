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
    public partial class Cate_AddVItem : Form
    {
        string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
        public Cate_AddVItem()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataReader MaxVItem = GetMaxVItem(conn);
            while (MaxVItem.Read())
            {
                int maxVI = int.Parse(MaxVItem.GetValue(0).ToString()) + 1;
                string FormatedmaxVI = "V-" + maxVI.ToString("D3");

                Insert(txtVItemName.Text, FormatedmaxVI, conn);
            }

        }
        private OleDbDataReader GetMaxVItem(OleDbConnection conn)
        {
            string sql = "SELECT COUNT(*) FROM VirtualItem";
            OleDbCommand maxcmd = new OleDbCommand(sql, conn);
            return maxcmd.ExecuteReader();
        }

        private void Insert(string name, string VID,  OleDbConnection conn)
        {
            name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
            if (CheckItem(name, conn) == false)
            {
                string sql = "INSERT INTO VirtualItem VALUES (@VID,@Name)";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@VID", VID);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful Adding Virtual Item");
                this.Close();
            }
            else
            {
                MessageBox.Show("Item " + name + " already inserted");
            }

        }
        private bool CheckItem(string name, OleDbConnection conn)
        {
            string sql = "SELECT * FROM VirtualItem WHERE VirtualItemName = @Name";
            OleDbCommand cmdname = new OleDbCommand(sql, conn);
            cmdname.Parameters.AddWithValue("@Name", name);
            OleDbDataReader MaxVItem = cmdname.ExecuteReader();
            
            if(MaxVItem.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
