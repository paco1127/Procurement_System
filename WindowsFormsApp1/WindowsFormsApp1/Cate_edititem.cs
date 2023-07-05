using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cate_edititem : Form
    {
        public Cate_edititem()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string location = AppDomain.CurrentDomain.BaseDirectory + "\\Itempic";
            string path = Path.Combine(location, txtIID.Text + ".jpg");
            

            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "UPDATE Item SET AcceptUOM=@AcceptUOM,Category=@Category, ItemName=@ItemName, Unit=@Unit ,UnitPrice=@UnitPrice, supID=@supID, BrandID=@BrandID, Storage=@Storage, POO=@POO, ItemDesc=@ItemDesc, Picture=@Picture WHERE ItemID=@ItemID";
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr;

            if (String.IsNullOrEmpty(txtIID.Text) || String.IsNullOrEmpty(txtIName.Text) || String.IsNullOrEmpty(cbICategory.Text) || String.IsNullOrEmpty(cbIUOM.Text) || String.IsNullOrEmpty(txtIUnitPrice.Text))
            {
                MessageBox.Show("* mark can't be empty");
            }
            else
            {
                try
                {
                    cmd.Parameters.AddWithValue("@AcceptUOM", cbIUOM.Text);
                    cmd.Parameters.AddWithValue("@Category", cbICategory.Text);
                    cmd.Parameters.AddWithValue("@ItemName", txtIName.Text);
                    cmd.Parameters.AddWithValue("@Unit", txtIUnit.Text);
                    cmd.Parameters.AddWithValue("@UnitPrice", txtIUnitPrice.Text);
                    cmd.Parameters.AddWithValue("@supID", cbSupID.Text);
                    cmd.Parameters.AddWithValue("@BrandID", cbBrandID.Text);
                    cmd.Parameters.AddWithValue("@Storage", cbStorage.Text);
                    cmd.Parameters.AddWithValue("@POO", txtIPOO.Text);
                    cmd.Parameters.AddWithValue("@ItemDesc", txtDesc.Text);

                    if (picbItemPic.Image != null)
                    {
                        cmd.Parameters.AddWithValue("@Picture", path);
                        Image a = picbItemPic.Image;
                        a.Save(path.ToString());
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Picture", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@ItemID", txtIID.Text);



                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated ");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unit Price must be digits");
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

        private void picbItemPic_Click(object sender, EventArgs e)
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

        private void txtVID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cate_edititem_Load(object sender, EventArgs e)
        {
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr1 = "SELECT brID FROM Brand";
            string sqlStr2 = "SELECT supID FROM Supplier";
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbCommand cmd = new OleDbCommand();
            
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr1;        
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbBrandID.Items.Add(reader["brID"].ToString());
/*                cbSupID.Items.Add(reader["supID"].ToString());*/
            }
            conn.Close();
            cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr2;
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbSupID.Items.Add(reader["supID"].ToString());
            }


        }
    }
}