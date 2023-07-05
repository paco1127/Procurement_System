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
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Data.Common;
using System.Data.SqlTypes;

namespace WindowsFormsApp1
{
    public partial class Rest_request : Form
    {
        private PictureBox pic = new PictureBox();
        double total = 0;
        private string Requestid = string.Empty;

        public Rest_request()
        {
            InitializeComponent();
        }
        public Rest_request(string rid)
        {
            Requestid = rid;
            InitializeComponent();
        }
        private void request_Load(object sender, EventArgs e)
        {
            if (Requestid == string.Empty)
            {
                GetData();
            }
            else
            {
                string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
                string sqlStr = "SELECT VItemID As ItemID, QTY FROM ReqItem WHERE RID = '"+Requestid+"'";
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();
                OleDbCommand myQuery = new OleDbCommand(sqlStr, conn);
                OleDbDataReader myReader = myQuery.ExecuteReader();
                dgvitemlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        dgvitemlist.Rows.Add(myReader.GetString(0), int.Parse(myReader.GetValue(1).ToString()));

                    }
                }
                GetData();
            }
            
        }
        private void GetData()
        {

            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "SELECT Item.Picture, VirtualItem.VirtualItemName As ItemName, VirtualItem.VirtualID As ItemID FROM VirtualItem, Item WHERE  VirtualItem.VirtualID = Item.VirtualID AND MID(ForRestaurantBrand, @brandid, 1) = '1'  ";
            string sqlStrgp = "Select Category from Item group by Category Order by Category ASC";

            OleDbConnection conn = new OleDbConnection(connStr);
            try
            {
                conn.Open();
                OleDbCommand myQuery = new OleDbCommand(sqlStr, conn); // assign the connection to the OleDbCommand
                myQuery.Parameters.AddWithValue("@brandid",Stat_Employee.BrID);
                OleDbDataReader myReader = myQuery.ExecuteReader();
                OleDbCommand myQuerygp = new OleDbCommand(sqlStrgp, conn);
                OleDbDataReader myReadergp = myQuerygp.ExecuteReader();
                Button btnall = new Button();
                FlowCate.Controls.Add(btnall);
                btnall.Text = "All";
                btnall.Height = 30;
                btnall.Width = 120;
                btnall.Font = new Font("Century Gothic", 12);
                btnall.BackColor = Color.White;
                btnall.FlatStyle = FlatStyle.Flat;
                btnall.Click += new EventHandler(OnClick1);
                while (myReadergp.Read())
                {
                    Button btncat = new Button();
                    btncat.Text = myReadergp["Category"].ToString();
                    btncat.Height = 30;
                    btncat.Width = 120;
                    btncat.Font = new Font("Century Gothic", 12);
                    btncat.BackColor = Color.White;
                    btncat.FlatStyle = FlatStyle.Flat;
                    btncat.FlatAppearance.BorderColor = Color.Red;
                    FlowCate.Controls.Add(btncat);
                    btncat.Click += new EventHandler(OnClick1);

                }
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
                    price.BackColor = Color.BlueViolet;
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
                    FlowPLPic.Controls.Add(pic);

                    pic.Click += new EventHandler(OnClick);

                }
                myReader.Close();
                myReadergp.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void OnClick(object sender, EventArgs e)
        {
            String tag = ((PictureBox)sender).Tag.ToString();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "Select * from VirtualItem Where VirtualID like '" + tag.ToString() + "'";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand myQuery = new OleDbCommand(sqlStr, conn);
            OleDbDataReader myReader = myQuery.ExecuteReader();
            bool contain = false;
            if (myReader.HasRows)
            {
                myReader.Read();
                dgvitemlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                
                
                    foreach (DataGridViewRow row in dgvitemlist.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(myReader["VirtualID"]))
                        {
                            int value = (int)row.Cells[1].Value;
                            row.Cells[1].Value = value + 1;
                            contain = true;
                        }
                    }
                if (contain == false)
                {
                    dgvitemlist.Rows.Add(myReader["VirtualID"], 1);
                }
                    
                

            }
            myReader.Close();
            conn.Close();
        }

        private void dgvitemlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int selectedCount = dgvitemlist.SelectedRows.Count;
                while (selectedCount > 0)
                {
                    if (!dgvitemlist.SelectedRows[0].IsNewRow)
                        dgvitemlist.Rows.RemoveAt(dgvitemlist.SelectedRows[0].Index);
                    selectedCount--;
                }
            }
        }

        public void OnClick1(object sender, EventArgs e)
        {


            FlowPLPic.Clear();
            string cattag = ((Button)sender).Text.ToString();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "SELECT Item.Picture, VirtualItem.VirtualItemName As ItemName, VirtualItem.VirtualID As ItemID FROM VirtualItem, Item WHERE  MID(ForRestaurantBrand, @brandid, 1) = '1' AND VirtualItem.VirtualID = Item.VirtualID AND Category like " + "'" + cattag.ToString() + "'";
            if (((Button)sender).Text.ToString() == "All")
            {
                sqlStr = "SELECT Item.Picture, VirtualItem.VirtualItemName As ItemName, VirtualItem.VirtualID As ItemID FROM VirtualItem, Item WHERE  VirtualItem.VirtualID = Item.VirtualID AND MID(ForRestaurantBrand, @brandid, 1) = '1'";
            }
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand myQuery = new OleDbCommand(sqlStr, conn);
            myQuery.Parameters.AddWithValue("@brandid", Stat_Employee.BrID);
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
                        path = Path.Combine(path + "\\" + "Itempic\null.jpg");
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
                    FlowPLPic.Controls.Add(pic);

                    pic.Click += new EventHandler(OnClick);

                }
                myReader.Close();
            }

        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if(Requestid != String.Empty)
            {
                string connStr1 = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
                string sqlStr = "Update RestReq Set [Status]=@Status WHERE RID=@RID";
                OleDbConnection conn1 = new OleDbConnection(connStr1);
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;

                cmd.Parameters.AddWithValue("@Status", "deleted");
                cmd.Parameters.AddWithValue("@RID", int.Parse(Requestid.Substring(2)));
                cmd.Connection = conn1;
                conn1.Open();
                cmd.ExecuteNonQuery();
            }


            if (dgvitemlist.Rows.Count == 0)
            {
                MessageBox.Show("No Item Requested, Please select something");
                return;
            }
            // insert a new RestReq
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string rid;
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            using (conn = new OleDbConnection(connStr))
            {
                //
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into RestReq([RestaurantID],[ReqDate],[Status]) VALUES (@RID,@Date,@status)";

                cmd.Parameters.AddWithValue("@RID",Stat_Employee.Restaurantid);

                cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                if (cbemerg.Checked)
                {
                    cmd.Parameters.AddWithValue("@status", "Emergency");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@status", "Processing");

                }
                
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            // get the RestReq RID value just created
            String sql = "Select COUNT(*) AS rowcount From RestReq";
            using (OleDbConnection conn1 = new OleDbConnection(connStr))
            {
                conn1.Open();
                
                using (OleDbCommand cmd = new OleDbCommand(sql, conn1))
                {
                    int rowCount = (int)cmd.ExecuteScalar();
                    rid = "R-" + rowCount.ToString("000");
                }
            }
            using (conn = new OleDbConnection(connStr))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                conn.Open();
                foreach (DataGridViewRow row in dgvitemlist.Rows)
                {
                    cmd.CommandText = "insert into ReqItem([RID],[VItemID],[QTY]) VALUES (@RID,@VItemID,@Quan)";
                    cmd.Parameters.AddWithValue("@RID", rid);
                    cmd.Parameters.AddWithValue("@VItemID", row.Cells["ItemID"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Quan", row.Cells["Qty"].Value);
                    
                    cmd.Connection = conn;
                    
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();             
                }
                MessageBox.Show("Your request has been successfully submitted!\nPlease wait purchase manager to confirm!");
            }
            this.Close();

        }

        private void dgvitemlist_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (dgvitemlist.IsCurrentCellDirty)
                {
                    if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal value))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Insert Numeric only.");
                    }
                }
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            FlowPLPic.Clear();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "SELECT Item.Picture As Picture, VirtualItem.VirtualItemName As ItemName, VirtualItem.VirtualID As ItemID FROM VirtualItem, Item WHERE VirtualItem.VirtualID = Item.VirtualID AND ItemName like " + "'%" + searchtxt.Text + "%'" + " GROUP BY VirtualItemName,VirtualItem.VirtualID,Item.Picture";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand myQuery = new OleDbCommand(sqlStr, conn);
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
                        path = Path.Combine(path + "\\" + "Itempic\null.jpg");
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
                    FlowPLPic.Controls.Add(pic);

                    pic.Click += new EventHandler(OnClick);

                }
                myReader.Close();
            }
        }

    }
}
