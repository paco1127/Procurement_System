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
    public partial class UC_ManuOrd : UserControl
    {
        String DID = "";
        public UC_ManuOrd()
        {
            InitializeComponent();
        }

        private void btncrtdeliord_Click(object sender, EventArgs e)
        {
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            bool checkitemfordeli = false; 
            int count = 0;
            for(int  i = 0; i < dgvunitem.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvunitem.Rows[i].Cells["selectitem"].Value) && int.Parse(dgvunitem.Rows[i].Cells["reqty"].Value.ToString())< int.Parse(dgvunitem.Rows[i].Cells["Stockqty"].Value.ToString()))
                {
                    //Create Delivery Order
                    if (checkitemfordeli == false)
                    {
                        createDeliveryOrder(lblOrdID.Text, conn, lblrestid.Text);
                        checkitemfordeli =true;
                        getDeliveryID(lblOrdID.Text, conn);
                    }
                    insertDeliveryItem(DID, dgvunitem.Rows[i].Cells["Item"].Value.ToString(), int.Parse(dgvunitem.Rows[i].Cells["reqty"].Value.ToString()),conn);
                    updateorditemstat(lblOrdID.Text, dgvunitem.Rows[i].Cells["Item"].Value.ToString(), conn);
                    count++;
                    if (count== dgvunitem.RowCount)
                    {
                        //update order status
                        updateordstatus(lblOrdID.Text, conn);
                    }
                }
            }
        }

        private void dgvunitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void createDeliveryOrder(String Order, OleDbConnection conn, String RestID)
        {
            string ctDO = "INSERT INTO [Delivery] ([OrderID], [RestID],[Status],[Time]) VALUES (@OrderID,@RestID,@Status,@Time)";
            OleDbCommand ctDOCmd = new OleDbCommand(ctDO, conn);
            ctDOCmd.Parameters.AddWithValue("@OrderID", Order);
            ctDOCmd.Parameters.AddWithValue("@RestID", RestID);
            ctDOCmd.Parameters.AddWithValue("@Status", "Waiting to be released");
            ctDOCmd.Parameters.AddWithValue("@Time", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            ctDOCmd.ExecuteNonQuery();
        }
        private void insertDeliveryItem(String DID, String ItemID, int Qty, OleDbConnection conn)
        {
            string itDOI = "INSERT INTO [DeliveryItem] ([DID], [ItemID],[QTY]) VALUES (@DID,@ItemID,@QTY)";
            OleDbCommand itDOICmd = new OleDbCommand(itDOI, conn);
            itDOICmd.Parameters.AddWithValue("@DID", DID);
            itDOICmd.Parameters.AddWithValue("@ItemID", ItemID);
            itDOICmd.Parameters.AddWithValue("@QTY", Qty);
            itDOICmd.ExecuteNonQuery();
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
        private void updateorditemstat(String Ordid,String itemid, OleDbConnection conn)
        {
            string updatereq = "UPDATE [ItemOrder] SET Status ='accept' WHERE [OrderID]=@OID AND [ItemID]=@IID AND [Status]='unaccept'";
            OleDbCommand cmdupdatereq = new OleDbCommand(updatereq, conn);
            cmdupdatereq.Parameters.AddWithValue("@OID", Ordid);
            cmdupdatereq.Parameters.AddWithValue("@IID", itemid);
            cmdupdatereq.ExecuteNonQuery();
        }
        private void updateordstatus(String Ordid, OleDbConnection conn)
        {
            string updatereq = "UPDATE [Order] SET Status ='Processing' WHERE [OrdID]=@OID";
            OleDbCommand cmdupdatereq = new OleDbCommand(updatereq, conn);
            cmdupdatereq.Parameters.AddWithValue("@OID", Ordid);
            cmdupdatereq.ExecuteNonQuery();
        }
    }
}
