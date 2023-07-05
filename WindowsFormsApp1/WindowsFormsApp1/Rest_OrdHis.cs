using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Rest_OrdHis : UserControl
    {
        string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
        public Rest_OrdHis()
        {
            InitializeComponent();
        }

        private void Rest_OrdHis_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataReader NFinreader = CheckOrderStatus("Pending", conn);
            while (NFinreader.Read())
            {
                UC_ManuOrd manuOrdUC = new UC_ManuOrd();

                manuOrdUC.btncrtdeliord.Visible = false;
                manuOrdUC.dgvunitem.Columns["selectitem"].Visible = false;
                manuOrdUC.dgvunitem.Columns["Stockqty"].Visible = false;
                manuOrdUC.lblRestName.Text = NFinreader.GetValue(2).ToString();
                manuOrdUC.lblstatus.Text=NFinreader.GetValue(4).ToString();
                string OID = NFinreader.GetValue(0).ToString();
                OleDbDataReader UnaccItem = CheckUnacceptItem(OID, conn);
                flpordhis.Controls.Add(manuOrdUC);
                while (UnaccItem.Read())
                {
                    string ItemID = UnaccItem.GetValue(0).ToString();
                    string Quantity = UnaccItem.GetValue(1).ToString();
                    OleDbDataReader stock = CheckStock(ItemID, conn);
                    while (stock.Read())
                    {
                        manuOrdUC.dgvunitem.Rows.Add(ItemID, Quantity, stock.GetValue(0).ToString());
                    }
                }
                OleDbDataReader delireader = GetDeliID(OID, conn);


                while (delireader.Read())
                {
                    String DID = delireader.GetValue(0).ToString();
                    OleDbDataReader deliitemreader = GetDeliItem(DID, conn);
                    UC_Deli deliUC = new UC_Deli();
                    while (deliitemreader.Read())
                    {

                        deliUC.lbldeliID.Text = String.Format("D-{0}", delireader.GetValue(0).ToString());
                        String ItemID = deliitemreader.GetValue(1).ToString();
                        String qty = deliitemreader.GetValue(2).ToString();
                        deliUC.dgvdeli.Rows.Add(ItemID, qty);
                        deliUC.addHeight();


                    }
                    manuOrdUC.flpdord.Controls.Add(deliUC);

                }

            }
            OleDbDataReader reader = CheckOrderStatus("Processing", conn);
            while (reader.Read())
            {

                UC_ReqMapDetail reqMapDetail = new UC_ReqMapDetail();
                string ordid = reader.GetValue(0).ToString();
                reqMapDetail.lblID.Text = String.Format("O-{0}", reader.GetValue(0).ToString());
                reqMapDetail.lblrestaddress.Text = reader.GetValue(1).ToString();
                reqMapDetail.lblrest.Text = reader.GetValue(2).ToString();
                reqMapDetail.lblOrdDate.Text = reader.GetValue(3).ToString();
                reqMapDetail.lblstatus.Text = reader.GetValue(4).ToString();
                flpordhis.Controls.Add(reqMapDetail);
                OleDbDataReader delireader = GetDeliID(ordid, conn);


                while (delireader.Read())
                {
                    String DID = delireader.GetValue(0).ToString();
                    OleDbDataReader deliitemreader = GetDeliItem(DID, conn);
                    UC_Deli deliUC = new UC_Deli();
                    while (deliitemreader.Read())
                    {

                        deliUC.lbldeliID.Text = String.Format("D-{0}", delireader.GetValue(0).ToString());
                        String ItemID = deliitemreader.GetValue(1).ToString();
                        String qty = deliitemreader.GetValue(2).ToString();
                        deliUC.dgvdeli.Rows.Add(ItemID, qty);
                        deliUC.addHeight();


                    }
                    reqMapDetail.pnldeli.Controls.Add(deliUC);

                }

            }
            OleDbDataReader reader1 = CheckOrderStatus("Delivered", conn);
            while (reader1.Read())
            {

                UC_ReqMapDetail reqMapDetail = new UC_ReqMapDetail();
                string ordid = reader1.GetValue(0).ToString();
                reqMapDetail.lblID.Text = String.Format("O-{0}", reader1.GetValue(0).ToString());
                reqMapDetail.lblrestaddress.Text = reader1.GetValue(1).ToString();
                reqMapDetail.lblrest.Text = reader1.GetValue(2).ToString();
                reqMapDetail.lblOrdDate.Text = reader1.GetValue(3).ToString();
                reqMapDetail.lblstatus.Text = reader1.GetValue(4).ToString();
                flpordhis.Controls.Add(reqMapDetail);
                OleDbDataReader delireader1 = GetDeliID(ordid, conn);


                while (delireader1.Read())
                {
                    String DID = delireader1.GetValue(0).ToString();
                    OleDbDataReader deliitemreader = GetDeliItem(DID, conn);
                    UC_Deli deliUC1 = new UC_Deli();
                    while (deliitemreader.Read())
                    {

                        deliUC1.lbldeliID.Text = String.Format("D-{0}", delireader1.GetValue(0).ToString());
                        String ItemID = deliitemreader.GetValue(1).ToString();
                        String qty = deliitemreader.GetValue(2).ToString();
                        deliUC1.dgvdeli.Rows.Add(ItemID, qty);
                        deliUC1.addHeight();


                    }
                    reqMapDetail.pnldeli.Controls.Add(deliUC1);

                }

            }
            conn.Close();
        }
        private OleDbDataReader CheckStock(String Iid, OleDbConnection conn)
        {
            string chkordsts = "SELECT Qty FROM Stock WHERE ItemID = @Iid ";
            OleDbCommand cmdchkordsts = new OleDbCommand(chkordsts, conn);
            cmdchkordsts.Parameters.AddWithValue("@Iid", Iid);
            return cmdchkordsts.ExecuteReader();
        }
        private OleDbDataReader CheckUnacceptItem(String OID, OleDbConnection conn)
        {
            string chkordsts = "SELECT ItemID,Quantity FROM ItemOrder WHERE Status = 'unaccept' AND OrderID = @Oid ";
            OleDbCommand cmdchkordsts = new OleDbCommand(chkordsts, conn);
            cmdchkordsts.Parameters.AddWithValue("@Oid", OID);
            return cmdchkordsts.ExecuteReader();
        }
        private OleDbDataReader CheckOrderStatus(String status, OleDbConnection conn)
        {
            string chkordsts = "SELECT OrdID AS FormattedOrdID, RestAddress,RestName,OrdDate,Order.Status FROM[Order], [Restaurant] WHERE[Status] = @status AND FORMAT(Order.restID, 'R-000') = FORMAT(Restaurant.restID, 'R-000') AND Restaurant.restID=@RID";
            OleDbCommand cmdchkordsts = new OleDbCommand(chkordsts, conn);
            cmdchkordsts.Parameters.AddWithValue("@status", status);
            cmdchkordsts.Parameters.AddWithValue("@RID", Stat_Employee.Restaurantid);
            return cmdchkordsts.ExecuteReader();
        }
        private OleDbDataReader GetDeliID(String OID, OleDbConnection conn)
        {
            string getdeliid = "SELECT DeliID, 'D-000'  FROM [Delivery],[Order] WHERE Delivery.OrderID = @OID";
            OleDbCommand cmdgetdeliid = new OleDbCommand(getdeliid, conn);
            cmdgetdeliid.Parameters.AddWithValue("@OID", OID);
            return cmdgetdeliid.ExecuteReader();
        }
        private OleDbDataReader GetDeliItem(String DID, OleDbConnection conn)
        {
            string getdeliid = "SELECT *  FROM [DeliveryItem] WHERE DeliveryItem.DID = @DID";
            OleDbCommand cmdgetdeliid = new OleDbCommand(getdeliid, conn);
            cmdgetdeliid.Parameters.AddWithValue("@OID", DID);
            return cmdgetdeliid.ExecuteReader();
        }

        private void btnpurcitem_Click(object sender, EventArgs e)
        {
            Purc_MakePurchase make = new Purc_MakePurchase();
            make.ShowDialog();
        }

        private void pnlreqmap_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
