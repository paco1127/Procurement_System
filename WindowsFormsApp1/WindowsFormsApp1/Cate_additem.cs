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
    public partial class Cate_additem : Form
    {
        int mov;
        int movX;
        int movY;
        public Cate_additem()
        {
            InitializeComponent();
        }
        string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string sqlStr = "insert into Item values(@ItemID,@ItemName,@Category,@ItemDesc,@AcceptUOM,@Picture," +
                "@supID,@UnitPrice,@QuantityAvailable,@Unit,@BrandID,@POO,@Storage,@ForRestaurantBrand)";
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbCommand command = new OleDbCommand(sqlStr, conn);
            conn.Open();
            string location = AppDomain.CurrentDomain.BaseDirectory + "\\Itempic";
            string path = Path.Combine(location, txtIID.Text + ".jpg");

            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            if(String.IsNullOrEmpty(txtIID.Text) || String.IsNullOrEmpty(txtIName.Text) || String.IsNullOrEmpty(cbICategory.Text) || String.IsNullOrEmpty(cbIUOM.Text) || String.IsNullOrEmpty(txtIUnitPrice.Text))
                {
                MessageBox.Show("* mark can't be empty");
            }
            else
            {
                try
                {
                    command.Parameters.AddWithValue("@ItemID", txtIID.Text);
                    command.Parameters.AddWithValue("@ItemName", txtIName.Text);
                    command.Parameters.AddWithValue("@Category", cbICategory.Text);
                    command.Parameters.AddWithValue("@ItemDesc", txtDesc.Text);
                    command.Parameters.AddWithValue("@AcceptUOM", cbIUOM.Text);
                    if (picbItemPic.Image != null)
                    {
                        command.Parameters.AddWithValue("Picture", path);
                        Image a = picbItemPic.Image;
                        a.Save(path);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Picture", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@supID", cbSupID.Text);
                    command.Parameters.AddWithValue("@UnitPrice", Int32.Parse(txtIUnitPrice.Text));
                    command.Parameters.AddWithValue("@QuantityAvailable", DBNull.Value);
                    command.Parameters.AddWithValue("@Unit", txtIUnit.Text);
                    command.Parameters.AddWithValue("@BrandID", cbBrandID.Text);
                    command.Parameters.AddWithValue("@POO", txtIPOO.Text);
                    command.Parameters.AddWithValue("@Storage", cbStorage.Text);
                    command.Parameters.AddWithValue("@ForRestaurantBrand", DBNull.Value);


                    command.ExecuteNonQuery();
                    MessageBox.Show("New item is added");
                    conn.Close();
                    this.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Unit Price must be digits");
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
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void Cate_additem_Load(object sender, EventArgs e)
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
