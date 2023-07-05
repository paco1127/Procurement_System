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
    public partial class Ware_DeliOrd : UserControl
    {
        string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
        public Ware_DeliOrd()
        {
            InitializeComponent();

        }
        
        private void Ware_DeliOrd_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataReader delireader = GetDeliOrd(conn);
            while (delireader.Read())
            {
                UC_DeliOrd deliOrdUC = new UC_DeliOrd();
                string did = delireader.GetValue(0).ToString();
                deliOrdUC.lblDeli.Text = did;
                int restID = int.Parse(delireader.GetValue(2).ToString());
                string restAdd = GetRestAdd(restID, conn);
                deliOrdUC.lblRestAdd.Text = "Restaurant Address: "+restAdd;

                deliOrdUC.btnfinish.Click += new EventHandler(Onclick);
                OleDbDataReader delitemreader = GetDeliItem(did,conn);
                while(delitemreader.Read())
                {
                    string itemid = delitemreader.GetValue(1).ToString();
                    int qty=int.Parse(delitemreader.GetValue(2).ToString());
                    deliOrdUC.dgvdeliitem.Rows.Add(itemid,qty);
                }
                flpdeliord.Controls.Add(deliOrdUC);
            }
            conn.Close();
        }
        private string GetRestAdd(int restID, OleDbConnection conn)
        {
            string restAdd = "";
            string sqlreq = "SELECT * FROM [Restaurant] Where restID =" + restID;
            OleDbCommand ReqQuery = new OleDbCommand(sqlreq, conn);
            OleDbDataReader reader = ReqQuery.ExecuteReader();
            while (reader.Read())
            {
                restAdd = reader.GetValue(1).ToString();
            }
            return restAdd;
        }
        private OleDbDataReader GetDeliOrd(OleDbConnection conn)
        {
            string sqlreq = "SELECT * FROM [Delivery] WHERE Status ='Waiting to be released'";
            OleDbCommand ReqQuery = new OleDbCommand(sqlreq, conn);
            return ReqQuery.ExecuteReader();
        }
        private void UpdateDeliveryStatus(String DeliID, OleDbConnection conn)
        {
            string updatereq = "UPDATE [Delivery] SET Status ='In Transit' WHERE [DeliID]=@DID";
            OleDbCommand cmdupdatereq = new OleDbCommand(updatereq, conn);
            cmdupdatereq.Parameters.AddWithValue("@DID", DeliID);
            cmdupdatereq.ExecuteNonQuery();
        }
        private void Onclick(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            string DeliID = ((Button)sender).Parent.Controls["lblDeli"].Text;
            UpdateDeliveryStatus(DeliID, conn);
            
            flpdeliord.Controls.Clear();
            OleDbDataReader delireader = GetDeliOrd(conn);
            while (delireader.Read())
            {
                UC_DeliOrd deliOrdUC = new UC_DeliOrd();
                string did = delireader.GetValue(0).ToString();
                deliOrdUC.lblDeli.Text = did;
                int restID = int.Parse(delireader.GetValue(2).ToString());
                string restAdd = GetRestAdd(restID, conn);
                deliOrdUC.lblRestAdd.Text = "Restaurant Address: " + restAdd;

                deliOrdUC.btnfinish.Click += new EventHandler(Onclick);
                OleDbDataReader delitemreader = GetDeliItem(did, conn);
                while (delitemreader.Read())
                {
                    string itemid = delitemreader.GetValue(1).ToString();
                    int qty = int.Parse(delitemreader.GetValue(2).ToString());
                    deliOrdUC.dgvdeliitem.Rows.Add(itemid, qty);
                }
                flpdeliord.Controls.Add(deliOrdUC);
            }
            conn.Close();
        }
        private OleDbDataReader GetDeliItem(String DID,OleDbConnection conn)
        {
            
            string sqlreq = "SELECT * FROM [DeliveryItem] WHERE DID=@DID ";
            OleDbCommand ReqQuery = new OleDbCommand(sqlreq, conn);
            ReqQuery.Parameters.AddWithValue("@DID", DID);
            return ReqQuery.ExecuteReader();
        }

    }
}
