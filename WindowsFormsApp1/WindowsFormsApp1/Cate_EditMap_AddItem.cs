using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cate_EditMap_AddItem : Form
    {
        private PictureBox pic = new PictureBox();
        
        string ItemIDSelected = "";
        public Cate_EditMap_AddItem()
        {
            InitializeComponent();
        }
        private OleDbConnection ConnDataBase()
        {
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            return conn;
        }
        private void Cate_EditMap_AddItem_Load(object sender, EventArgs e)
        {
            string sqlStr = "Select Picture,ItemName,ItemID from Item Where VirtualID <> @Vid";
            OleDbConnection conn = ConnDataBase();


            OleDbCommand myQuery = new OleDbCommand(sqlStr, conn);
            myQuery.Parameters.AddWithValue("@Vid", Cate_EditMap.VID);
            OleDbDataReader myReader = myQuery.ExecuteReader();
            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string imagePath = myReader.GetString(0);
                    pic = new PictureBox();
                    pic.Width = 180;
                    pic.Height = 180;
                    pic.BackgroundImageLayout = ImageLayout.Stretch;
                    pic.Tag = myReader["ItemID"].ToString();

                    if (myReader.GetValue(0) == DBNull.Value)
                    {
                        path = Path.Combine(path + "\\" + "Itempicnull.jpg");
                    }
                    else
                    {
                        path = Path.Combine(path + "\\" + myReader.GetValue(0).ToString());

                    }
                    Image image = Image.FromFile(path);
                    pic.BackgroundImage = image;



                    Label price = new Label();
                    price.Font = new Font("Century Gothic", 9);
                    price.Text = myReader.GetValue(2).ToString();
                    price.TextAlign = ContentAlignment.MiddleCenter;
                    price.BackColor = Color.Pink;
                    price.Tag = myReader["ItemID"].ToString();


                    Label itemname = new Label();
                    itemname.Font = new Font("Century Gothic", 9);
                    itemname.Text = myReader.GetValue(1).ToString();
                    itemname.Dock = DockStyle.Bottom;
                    itemname.BackColor = Color.Pink;
                    itemname.TextAlign = ContentAlignment.MiddleCenter;
                    itemname.Tag = myReader["ItemID"].ToString();

                    pic.Controls.Add(itemname);
                    pic.Controls.Add(price);
                    panItemList.Controls.Add(pic);

                    pic.Click += new EventHandler(OnClick);

                }
                myReader.Close();
            }
        }
        private void OnClick(object sender, EventArgs e)
        {
            ItemIDSelected = ((PictureBox)sender).Tag.ToString();
            lblID.Text = "Selected ItemID: " + ItemIDSelected;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = ConnDataBase();
            string sqlStr = "Update Item Set [VirtualID] = @Vid Where ItemID= @ItemID";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr;
           
                cmd.Connection = conn;
                
            cmd.Parameters.AddWithValue("@Vid", Cate_EditMap.VID);
            cmd.Parameters.AddWithValue("@ItemID", ItemIDSelected);


            cmd.ExecuteNonQuery();
                MessageBox.Show("Mapped complete");
                this.Close();
            }
        }
    }

