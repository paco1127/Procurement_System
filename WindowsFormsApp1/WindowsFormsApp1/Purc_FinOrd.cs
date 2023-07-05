using Sunny.UI.Win32;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Purc_FinOrd : UserControl
    {
        string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
        public Purc_FinOrd()
        {
            InitializeComponent();
        }
        
        private void Purc_ReqMap_Load_1(object sender, EventArgs e)
        {
            
            {

                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();
                OleDbDataReader reader = CheckOrderStatus(conn);
                while (reader.Read())
                {

                    UC_ReqMapDetail reqMapDetail = new UC_ReqMapDetail();
                    string ordid = reader.GetValue(0).ToString();
                    reqMapDetail.lblID.Text = String.Format("O-{0}", reader.GetValue(0).ToString());
                    reqMapDetail.lblrestaddress.Text = reader.GetValue(1).ToString();
                    reqMapDetail.lblOrdDate.Text= reader.GetValue(2).ToString();
                    reqMapDetail.lblstatus.Text = reader.GetValue(3).ToString();
                    pnlreqmap.Controls.Add(reqMapDetail);
                    OleDbDataReader delireader = GetDeliID(ordid,conn);


                    while (delireader.Read())
                    {
                        String DID = delireader.GetValue(0).ToString();
                        OleDbDataReader deliitemreader = GetDeliItem(DID, conn);
                        UC_Deli deliUC = new UC_Deli();
                        while (deliitemreader.Read())
                        {

                            deliUC.lbldeliID.Text = String.Format("D-{0}", delireader.GetValue(0).ToString());
                            String ItemID = deliitemreader.GetValue(0).ToString();
                            String qty = deliitemreader.GetValue(1).ToString();
                            deliUC.dgvdeli.Rows.Add(ItemID, qty);

                        }
                        reqMapDetail.pnldeli.Controls.Add(deliUC);

                    }

                }
                conn.Close();
            }


        }
        private OleDbDataReader CheckOrderStatus(OleDbConnection conn)
        {
            string chkordsts = "SELECT OrdID AS FormattedOrdID, RestAddress,OrdDate,Order.Status FROM[Order], [Restaurant] WHERE[Status] = 'Delivered' AND FORMAT(Order.restID, 'R-000') = FORMAT(Restaurant.restID, 'R-000')";
            OleDbCommand cmdchkordsts = new OleDbCommand(chkordsts, conn);
            return cmdchkordsts.ExecuteReader();
        }
        private OleDbDataReader GetDeliID(String OID,OleDbConnection conn)
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



    }
}
