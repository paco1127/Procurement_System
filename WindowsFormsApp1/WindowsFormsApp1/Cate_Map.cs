using Sunny.UI;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Cate_Map : UserControl
    {
        public Cate_Map()
        {
            InitializeComponent();
        }
        Cate_EditMap editMap = new Cate_EditMap();
        public string VID;

        private void update()
        {
            DataSet ds = new DataSet();
            string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source=Database.accdb";
            string sqlStr = "Select VirtualID,VirtualItemName from VirtualItem";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, conn);
            oleDbDataAdapter.Fill(ds);
            dgvVItem.DataSource = ds.Tables[0];
        }
        private void Cate_Map_Load(object sender, EventArgs e)
        {
            update();
            dgvVItem.ReadOnly = true;
            DataGridViewColumn column = dgvVItem.Columns[1];
            column.Width = 250;
        }

        private void btnAddMap_Click(object sender, EventArgs e)
        {
            editMap.ShowDialog();
        }

        private void dgvVItem_SelectionChanged(object sender, EventArgs e)
        {
            editMap.lblVID.Text = dgvVItem.Rows[dgvVItem.CurrentCell.RowIndex].Cells[0].Value.ToString();
            editMap.lblVName.Text = dgvVItem.Rows[dgvVItem.CurrentCell.RowIndex].Cells[1].Value.ToString();
        }

        private void btnAddVItem_Click(object sender, EventArgs e)
        {
            Cate_AddVItem cate_AddV = new Cate_AddVItem();
            cate_AddV.ShowDialog();
            update();
        }
    }
}
