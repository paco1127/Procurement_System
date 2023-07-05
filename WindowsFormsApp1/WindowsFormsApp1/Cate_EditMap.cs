using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Cate_EditMap : Form
    {
        private PictureBox pic = new PictureBox();
        private String ForRestaurantBrand = "";
        Cate_EditMap_AddItem addItem = new Cate_EditMap_AddItem();
        private static string _VID = "";
        string Itemid = "";
        bool[] isBrand = new bool[10];
        int rowIndex = 0;
        bool[,] Check;
        int count = 0;


        public static string VID
        {
            get { return _VID; }
        }
        public Cate_EditMap()
        {
            InitializeComponent();
        }
        private void checkRest()
        {
            rowIndex = 0;
             // Create a 2D bool array to store the result
             // Initialize the index for the first row


            OleDbConnection conn = ConnDataBase();
            String cont = "Select COUNT(*)  From Item WHERE VirtualID = @Vid  ";
            
            using (OleDbCommand cmd = new OleDbCommand(cont, conn))
            {
                cmd.Parameters.AddWithValue("@Vid", lblVID.Text);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            String sql = "Select ForRestaurantBrand  From Item WHERE VirtualID = @Vid AND ItemID <> @itemid ";
            
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                
                cmd.Parameters.AddWithValue("@Vid", lblVID.Text);
                cmd.Parameters.AddWithValue("@itemid", Itemid);
                OleDbDataReader reader = cmd.ExecuteReader();
                
                Check = new bool[count, 10];
                while (reader.Read())
                {

                    if (reader.GetValue(0) != null)
                    {
                        String temp = reader.GetValue(0).ToString();

                        for (int i = 0; i < temp.Length && i < 10; i++)
                        {

                            if (temp[i] == '1')
                            {
                                Check[rowIndex, i] = true;
                            }
                        }

                        rowIndex++; // Move to the next row
                    }
                    
                }
            }
        }
        private void setNumber(bool[] IsChecked)
        {
            String ForRest = "";
            for (int i = 0; i < IsChecked.Count(); i++)
            {
                if (IsChecked[i])
                {
                    ForRest += "1";
                }
                else
                {
                    ForRest += "0";
                }
            }
            OleDbConnection conn = ConnDataBase();
            string sqlStr = "Update Item Set [ForRestaurantBrand] = @Number Where ItemID= @ItemID";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr;

            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@Number", ForRest);
            cmd.Parameters.AddWithValue("@ItemID", Itemid);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        private bool[] getCheck()
        {
            
            int checktrue = 0;
            bool[] IsChecked = new bool[10];
            for (int i = 0; i < 10; i++)
            {
               checktrue = 0;
                for (int j = 0; j < count; j++)  // Loop through rows in the current column
                {

                    if (Check[j, i] == true) // Check if the current row in the current column is true
                    {
                        checktrue++;
                        if (checktrue > 1)
                        {
                            return null;
                        }
                        
                    }
                }


                if (cbgRestaurant.GetItemCheckState(i) == true)
                {
                    IsChecked[i] = true;
                }
                else
                {
                    IsChecked[i] = false;
                }
            }

            return IsChecked; // Return true if no rows in any column have a value of true
        }
        private OleDbConnection ConnDataBase()
        {
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            return conn;
        }
        private void setCBG()
        {
            cbgRestaurant.Items.Clear();
            cbgRestaurant.UnSelectAll();
            OleDbConnection conn = ConnDataBase();
            String sql = "Select brName From Brand";


            using (OleDbCommand cmd1 = new OleDbCommand(sql, conn))
            {
                OleDbDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    cbgRestaurant.Items.Add(reader.GetValue(0).ToString());
                }
            }

        }
        private void getRItem()
        {
            pnlMappedItem.Clear();

            string sqlStr = "Select Picture,ItemName,ItemID from Item Where VirtualID = @Vid";
            OleDbConnection conn = ConnDataBase();


            OleDbCommand myQuery = new OleDbCommand(sqlStr, conn);
            myQuery.Parameters.AddWithValue("@Vid", lblVID.Text);
            _VID = lblVID.Text;
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
                    pnlMappedItem.Controls.Add(pic);

                    pic.Click += new EventHandler(OnClick);

                }
                myReader.Close();
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            Itemid = ((PictureBox)sender).Tag.ToString();
            checkRest();
            cbgRestaurant.UnSelectAll();
            String tag = ((PictureBox)sender).Tag.ToString();
            OleDbConnection conn = ConnDataBase();
            String sql = "Select ForRestaurantBrand From Item WHERE ItemID = @Iid";



            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Iid", tag);
            lblCurrItem.Text = "Current Selected Item:" + tag;
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(0) != DBNull.Value)
                {
                    ForRestaurantBrand = reader.GetValue(0).ToString();
                }
                else { ForRestaurantBrand = "0000000000"; }
                        
                        

            }
            for (int i = 0; i < ForRestaurantBrand.Length; i++)
            {
                if (ForRestaurantBrand[i] == '1')
                {
                    cbgRestaurant.SetItemCheckState(i, true);
                }

            }
            
            
        }

        private void Cate_EditMap_Load(object sender, EventArgs e)
        {
            lblCurrItem.Text = "Current Selected Item: None";
            getRItem();
            setCBG();

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            addItem.ShowDialog();
            getRItem();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Check[count - 1, i] = cbgRestaurant.GetItemCheckState(i);
            }
            bool[] place = getCheck();
            if (place != null)
            {
                setNumber(place);
            }
            else
            {
                MessageBox.Show("Same Item Map in One Restaurant! Please Double Check");
                setCBG();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = ConnDataBase();
            string sqlStr = "Update Item Set [ForRestaurantBrand] = @Number Where ItemID= @ItemID";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Number", 0);
            cmd.Parameters.AddWithValue("@ItemID", Itemid);
            cmd.ExecuteNonQuery();
            conn.Close();
            setCBG();
            checkRest();
            lblCurrItem.Text = "Current Selected Item: None";
        }


    }
}
