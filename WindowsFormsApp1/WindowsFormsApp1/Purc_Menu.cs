using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Purc_Menu : UserControl
    {

        public int CPA = 0;
        public int BPA = 0;
        public int FinOrd = 0;
        public int NFinOrd = 0;
        public int Sup = 0;
        public int inv = 0;
        public int standardOrd = 0;
        string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
        string RID="";
        string BrID = "";
        string RestID = "";

        string OrdStatus = "Processing";
        string DID = "";
        
        public Purc_Menu()
        {
            InitializeComponent();
        }

        private void PurchaseMenu_Load(object sender, EventArgs e)
        {
            timer1.Interval = 600;
            timer1.Tick += new EventHandler(OnTimerElapsed);
            timer1.Start();
            // Assign the event handlers to all Button controls in the form
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.MouseEnter += new EventHandler(AllButtons_MouseEnter);
                    button.MouseLeave += new EventHandler(AllButtons_MouseLeave);
                }
            }
        }
        
        private void OnTimerElapsed(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataReader myReader = CheckRequest("Emergency", conn);
            while (myReader.Read())
            {
                RID = myReader.GetValue(0).ToString();
                BrID = myReader.GetValue(1).ToString();
                RestID = myReader.GetValue(2).ToString();
                UpdateReq(conn);
                CreateOrder(conn);
                String OrdID = getOrderID(conn);
                OleDbDataReader checkqtyrder = Checkqty(conn);
                bool IsCreated = true;
                while (checkqtyrder.Read())
                {
                    string itemID = checkqtyrder.GetValue(0).ToString();
                    int reqqty = int.Parse(checkqtyrder.GetValue(1).ToString());
                    int stockqty = int.Parse(checkqtyrder.GetValue(2).ToString());
                    string itemstat = "";
                    if (reqqty <= stockqty)
                    {
                        int updatestock = stockqty - reqqty;
                        itemstat = "accept";
                        string sqlupdatestock = "UPDATE stock SET QTY = @updatestock WHERE itemID = @itemID AND Place = 'Warehouse'";
                        OleDbCommand UpStkCmd = new OleDbCommand(sqlupdatestock, conn);
                        UpStkCmd.Parameters.AddWithValue("@updatestock", updatestock);
                        UpStkCmd.Parameters.AddWithValue("@itemID", itemID);
                        UpStkCmd.ExecuteNonQuery();

                        if (IsCreated)
                        {
                            createDeliveryOrder(OrdID, conn, RestID);
                            IsCreated = false;
                        }
                        getDeliveryID(OrdID, conn);

                        insertDeliveryItem(DID, itemID, reqqty, conn);
                    }
                    else
                    {
                        itemstat = "unaccept";
                        OrdStatus = "Pending";
                    }
                    string sqlorderitem = "INSERT INTO [ItemOrder] ([OrderID], [ItemID], [Quantity],[Status]) VALUES (@OrderID,@ItemID,@Quantity,@Status)";
                    OleDbCommand OrderitemCmd = new OleDbCommand(sqlorderitem, conn);
                    OrderitemCmd.Parameters.AddWithValue("@OrderID", OrdID);
                    OrderitemCmd.Parameters.AddWithValue("@ItemID", itemID);
                    OrderitemCmd.Parameters.AddWithValue("@Quantity", reqqty);
                    OrderitemCmd.Parameters.AddWithValue("@Status", itemstat);
                    OrderitemCmd.ExecuteNonQuery();
                    OleDbDataReader checkordsts = CheckOrderStatus(conn);
                    if (checkordsts.Read())
                    {
                        UpdateOrdStatus(OrdID, OrdStatus, conn);
                    }
                }
            }
            conn.Close(); 
            DateTime now = DateTime.Now;
            if ((now.Hour == 9 || now.Hour == 13 || now.Hour == 17) && now.Minute == 0 && now.Second == 0)
            {
                
                conn.Open();
                OleDbDataReader myReader1 = CheckRequest("Processing", conn);

                while (myReader.Read())
                {
                    RID = myReader1.GetValue(0).ToString();
                    BrID = myReader1.GetValue(1).ToString();
                    RestID = myReader1.GetValue(2).ToString();
                    UpdateReq(conn);
                    CreateOrder(conn);
                    String OrdID = getOrderID(conn);
                    OleDbDataReader checkqtyrder = Checkqty(conn);
                    bool IsCreated = true;

                    while (checkqtyrder.Read())
                    {

                        
                        string itemID = checkqtyrder.GetValue(0).ToString();
                        int reqqty = int.Parse(checkqtyrder.GetValue(1).ToString());
                        int stockqty = int.Parse(checkqtyrder.GetValue(2).ToString());
                        string itemstat = "";

                        if (reqqty <= stockqty)
                        {
                            int updatestock = stockqty - reqqty;
                            itemstat = "accept";
                            string sqlupdatestock = "UPDATE stock SET QTY = @updatestock WHERE itemID = @itemID AND Place = 'Warehouse'";
                            OleDbCommand UpStkCmd = new OleDbCommand(sqlupdatestock, conn);
                            UpStkCmd.Parameters.AddWithValue("@updatestock", updatestock);
                            UpStkCmd.Parameters.AddWithValue("@itemID", itemID);
                            UpStkCmd.ExecuteNonQuery();
                            if (IsCreated)
                            {
                                createDeliveryOrder(OrdID, conn, RestID);
                                IsCreated = false;
                            }

                            getDeliveryID(OrdID, conn);

                            insertDeliveryItem(DID, itemID, reqqty, conn);
                        }
                        else
                        {
                            itemstat = "unaccept";
                            OrdStatus = "Pending";
                        }
                        string sqlorderitem = "INSERT INTO [ItemOrder] ([OrderID], [ItemID], [Quantity],[Status]) VALUES (@OrderID,@ItemID,@Quantity,@Status)";
                        OleDbCommand OrderitemCmd = new OleDbCommand(sqlorderitem, conn);
                        OrderitemCmd.Parameters.AddWithValue("@OrderID", OrdID);
                        OrderitemCmd.Parameters.AddWithValue("@ItemID", itemID);
                        OrderitemCmd.Parameters.AddWithValue("@Quantity", reqqty);
                        OrderitemCmd.Parameters.AddWithValue("@Status", itemstat);
                        OrderitemCmd.ExecuteNonQuery();
                        OleDbDataReader checkordsts = CheckOrderStatus(conn);
                        if (checkordsts.Read())
                        {
                            UpdateOrdStatus(OrdID, OrdStatus, conn);
                        }
                    }
                }
                conn.Close();
            }

        }
        private void UpdateOrdStatus(String Order,String status,OleDbConnection conn)
        {
            string upordsta = "UPDATE [Order] SET Status =@Status WHERE [OrdID]=@OID";
            OleDbCommand cmdupordsta = new OleDbCommand(upordsta, conn);
            cmdupordsta.Parameters.AddWithValue("@Status", status);
            cmdupordsta.Parameters.AddWithValue("@OID", Order);
            cmdupordsta.ExecuteNonQuery();
        }
        private OleDbDataReader CheckOrderStatus(OleDbConnection conn)
        {
            string chkordsts = "SELECT ItemID FROM ItemOrder WHERE Status = 'unaccept' ";
            OleDbCommand cmdchkordsts = new OleDbCommand(chkordsts, conn);
            return cmdchkordsts.ExecuteReader();
        }
        private void UpdateReq(OleDbConnection conn)
        {
            string updatereq = "UPDATE RestReq SET Status ='Submitted' WHERE [RID]=@RID";
            OleDbCommand cmdupdatereq = new OleDbCommand(updatereq, conn);
            cmdupdatereq.Parameters.AddWithValue("@RID", RID);
            cmdupdatereq.ExecuteNonQuery();
        }
        private OleDbDataReader CheckRequest(String Status, OleDbConnection conn)
        {
            string sqlreq = "SELECT RestReq.RID, Restaurant.brID, RestReq.RestaurantID " +
                            "FROM RestReq, Restaurant " +
                            "WHERE RestReq.RestaurantID = FORMAT(Restaurant.restID) " +
                            "AND RestReq.Status = @Status";
            
            OleDbCommand ReqQuery = new OleDbCommand(sqlreq, conn);
            ReqQuery.Parameters.AddWithValue("@Status", Status);
            return ReqQuery.ExecuteReader();
        }
        private void AllButtons_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.BlueViolet;
            }
        }

        private void AllButtons_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.Transparent;
            }
        }
        private void getDeliveryID(String Order, OleDbConnection conn)
        {
            string sqlordid = "SELECT DeliID From [Delivery] WHERE OrderID = @OrderID";
            OleDbCommand OrdQuery = new OleDbCommand(sqlordid, conn);
            OrdQuery.Parameters.AddWithValue("@OrderID", Order);
            OleDbDataReader cmdgetOrdid = OrdQuery.ExecuteReader();
            if (cmdgetOrdid.Read())
            {
                 DID = cmdgetOrdid.GetValue(0).ToString();
            }
        }
        private string getOrderID(OleDbConnection conn)
        {
            string sqlordid = "SELECT OrdID From [Order] WHERE RefReqID = @RefReqID";
            OleDbCommand OrdQuery = new OleDbCommand(sqlordid, conn);
            OrdQuery.Parameters.AddWithValue("@RefReqID", RID);
            OleDbDataReader cmdgetOrdid = OrdQuery.ExecuteReader();
            if (cmdgetOrdid.Read())
            {
                string OrdID = cmdgetOrdid.GetValue(0).ToString();
                return OrdID;
            }
            return null;
        }
        private void CreateOrder(OleDbConnection conn)
        {
            string sqlorder = "INSERT INTO [Order] ([RestID],[Status],[OrdDate],[RefReqID]) VALUES (@RestID,@Status,@OrdDate,@RefReqID)";
            OleDbCommand OrderCmd = new OleDbCommand(sqlorder, conn);
            OrderCmd.Parameters.AddWithValue("@RestID", RestID);
            OrderCmd.Parameters.AddWithValue("@Status", "Processing");
            OrderCmd.Parameters.AddWithValue("@OrdDate", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            OrderCmd.Parameters.AddWithValue("@RefReqID", RID);
            OrderCmd.ExecuteNonQuery();
        }
        private void createDeliveryOrder(String Order, OleDbConnection conn,String RestID)
        {
            string ctDO = "INSERT INTO [Delivery] ([OrderID], [RestID],[Status],[Time]) VALUES (@OrderID,@RestID,@Status,@Time)";
            OleDbCommand ctDOCmd = new OleDbCommand(ctDO, conn);
            ctDOCmd.Parameters.AddWithValue("@OrderID", Order);
            ctDOCmd.Parameters.AddWithValue("@RestID", RestID);
            ctDOCmd.Parameters.AddWithValue("@Status", "Waiting to be released");
            ctDOCmd.Parameters.AddWithValue("@Time", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            ctDOCmd.ExecuteNonQuery();
        }
        private void insertDeliveryItem(String DID,String ItemID,int Qty, OleDbConnection conn)
        {
            string itDOI = "INSERT INTO [DeliveryItem] ([DID], [ItemID],[QTY]) VALUES (@DID,@ItemID,@QTY)";
            OleDbCommand itDOICmd = new OleDbCommand(itDOI, conn);
            itDOICmd.Parameters.AddWithValue("@DID", DID);
            itDOICmd.Parameters.AddWithValue("@ItemID", ItemID);
            itDOICmd.Parameters.AddWithValue("@QTY", Qty);
            itDOICmd.ExecuteNonQuery();
        }
        private OleDbDataReader Checkqty(OleDbConnection conn)
        {
            string sqlemer = "SELECT Item.ItemID, ReqItem.QTY, Stock.QTY FROM Item, ReqItem, Stock WHERE Item.ItemID = Stock.ItemID AND Item.VirtualID = ReqItem.VItemID AND MID(Item.ForRestaurantBrand, @brid, 1) = '1' AND ReqItem.RID = FORMAT(@RID, 'R-000') AND Stock.Place = 'Warehouse'";
            OleDbCommand Checkqty = new OleDbCommand(sqlemer, conn);
            Checkqty.Parameters.AddWithValue("@brid", BrID);
            Checkqty.Parameters.AddWithValue("@RID", RID);
            return Checkqty.ExecuteReader();
        }

        private void btnBPA_Click(object sender, EventArgs e)
        {
            BPA++;
        }

        private void btnCPA_Click(object sender, EventArgs e)
        {
            CPA++;
        }

        private void btnfinord_Click(object sender, EventArgs e)
        {
            FinOrd++;
        }

        private void btnNfinord_Click(object sender, EventArgs e)
        {
           NFinOrd++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnSupMana_Click(object sender, EventArgs e)
        {
            Sup++;
        }

        private void btninv_Click(object sender, EventArgs e)
        {
            inv++;
        }

        private void btnStandardOrder_Click(object sender, EventArgs e)
        {
            standardOrd++;
        }
    }
}
