using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;





namespace WindowsFormsApp1
{
    public partial class MainPage : Form
    {
        int mov;
        int movX;
        int movY;
        Rest_menu resmenu = new Rest_menu();
        Purc_Menu purchasemenu = new Purc_Menu();
        Sys_Menu SystemMenu = new Sys_Menu();
        Rest_Dashboard RestDashboard = new Rest_Dashboard();
        AccountingMenu accmenu = new AccountingMenu();
        Ware_Menu waremenu = new Ware_Menu();
        Cate_Menu catmenu = new Cate_Menu();
        RestOrd restOrd = new RestOrd();
        Sys_ac sysac = new Sys_ac();
        Sys_log syslg = new Sys_log();
        Cate_ItemMana ItemMana = new Cate_ItemMana();
        Purc_BPA BPA = new Purc_BPA();
        Purc_CPA CPA = new Purc_CPA();
        Cate_Map  Cate_Map = new Cate_Map();    
        Purc_FinOrd Purc_FinOrd = new Purc_FinOrd();
        Purc_NFinOrd Purc_NFinOrd=new Purc_NFinOrd();
        Purc_SupplierMana Purc_Supp = new Purc_SupplierMana();
        Ware_DeliOrd Ware_deliord = new Ware_DeliOrd();
        Ware_Inventory Ware_Inv = new Ware_Inventory();
        Ware_POSign Ware_PO = new Ware_POSign();
        Rest_OrdHis rest_OrdHis = new Rest_OrdHis();
        Rest_OrdSign Rest_OrdSign = new Rest_OrdSign();
        Rest_Inventory Rest_Inventory = new Rest_Inventory();
        Purc_viewInv purc_inv = new Purc_viewInv();
        Purc_standardOrd purc_standOrd = new Purc_standardOrd();

        int x = 0;
        
        
        public MainPage()
        {
            InitializeComponent();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnrest_Click(object sender, EventArgs e)
        {
            btneffect((Button)sender);
            pnlmenu.Controls.Clear();
            pnlmenu.Controls.Add(resmenu);
            pnlinfo.Controls.Clear();
            pnlinfo.Controls.Add(RestDashboard);
        }

        private void btnpurch_Click(object sender, EventArgs e)
        {
            pnlmenu.Controls.Clear();
            pnlmenu.Controls.Add(purchasemenu);
            pnlinfo.Controls.Clear();
            btneffect((Button)sender);
        }

        private void btnacc_Click(object sender, EventArgs e)
        {
            pnlmenu.Controls.Clear();
            pnlmenu.Controls.Add(accmenu);
            pnlinfo.Controls.Clear();
            btneffect((Button)sender);
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            pnlmenu.Controls.Clear();
            pnlmenu.Controls.Add(catmenu);
            pnlinfo.Controls.Clear();
            btneffect((Button)sender);
        }

        private void btnware_Click(object sender, EventArgs e)
        {
            pnlmenu.Controls.Clear();
            pnlmenu.Controls.Add(waremenu);
            pnlinfo.Controls.Clear();
            btneffect((Button)sender);
        }

        private void btnsys_Click(object sender, EventArgs e)
        {
            pnlmenu.Controls.Clear();
            pnlmenu.Controls.Add(SystemMenu);
            pnlinfo.Controls.Clear();
            btneffect((Button)sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (resmenu.restdash == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(RestDashboard);
                resmenu.restdash = 0;
            }
            if (resmenu.restreq == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(restOrd);
                resmenu.restreq = 0;
            }
            if (SystemMenu.ac == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(sysac);
                SystemMenu.ac = 0;
            }
            if (SystemMenu.lg == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(syslg);
                SystemMenu.lg = 0;
            }
            if (catmenu.editItem == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(ItemMana);
                catmenu.editItem = 0;
            }
            if (purchasemenu.BPA == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(BPA);
                purchasemenu.BPA = 0;
            }
            if (purchasemenu.CPA == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(CPA);
                purchasemenu.CPA = 0;
            }
            if (catmenu.map == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(Cate_Map);
                catmenu.map = 0;
            }
            if(purchasemenu.FinOrd == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(Purc_FinOrd);
                purchasemenu.FinOrd = 0;
            }
            if (purchasemenu.NFinOrd == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(Purc_NFinOrd);
                purchasemenu.NFinOrd = 0;
            }
            if (purchasemenu.Sup == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(Purc_Supp);
                purchasemenu.Sup = 0;
            }
            if(waremenu.deli == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(Ware_deliord);
                waremenu.deli = 0;
            }
            if(waremenu.inv == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(Ware_Inv);
                waremenu.inv = 0;
            }
            if(waremenu.po == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(Ware_PO);
                waremenu.po = 0;
            }
            if (resmenu.restord == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(rest_OrdHis);
                resmenu.restord = 0;
            }
            if (resmenu.restordsign == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(Rest_OrdSign);
                resmenu.restordsign = 0;
            }
            if (resmenu.restinv == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(Rest_Inventory);
                resmenu.restinv = 0;
            }
            if (purchasemenu.inv == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(purc_inv);
                purchasemenu.inv = 0;
            }
            if (purchasemenu.standardOrd == 1)
            {
                pnlinfo.Controls.Clear();
                pnlinfo.Controls.Add(purc_standOrd);
                purchasemenu.standardOrd = 0;
            }
            
        }

        private void pnlmenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnlinfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            label1.Text = Stat_Employee.Name;
            
            if(Stat_Employee.Userpic == null)
            {
                path += "\\Userpic\\Default.png";
            }
            else
            {
                path = Path.Combine(path + "\\" + Stat_Employee.Userpic);
            }

            AvaUserIcon.Image = Image.FromFile(path);
        
            if (Screen.AllScreens.Length > 1)
            {

                this.Location = Screen.AllScreens[1].WorkingArea.Location;
            }
            else
            {
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }
            switch(Stat_Employee.DeptID)
            {
                case "2":
                    btnrest.Enabled = false;
                    btnpurch.Enabled = false;
                    btnsys.Enabled = false;
                    btncat.Enabled = false;
                    btnware.Enabled = false;
                    break;
                case "3":
                    btnrest.Enabled = false;
                    btnpurch.Enabled = false;
                    btnsys.Enabled = false;
                    btncat.Enabled = false;
                    btnacc.Enabled = false;
                    break;
                case "4":
                    btnrest.Enabled = false;
                    btnpurch.Enabled = false;
                    btnsys.Enabled = false;
                    btnware.Enabled = false;
                    btnacc.Enabled = false;
                    break;
                case "5":
                    btnacc.Enabled = false;
                    btnpurch.Enabled = false;
                    btnsys.Enabled = false;
                    btnware.Enabled = false;
                    btncat.Enabled = false;
                    break;
                case "6":
                    btnacc.Enabled = false;
                    btnrest.Enabled = false;
                    btnsys.Enabled = false;
                    btnware.Enabled = false;
                    btncat.Enabled = false;
                    break;
                case "1":
                    btnacc.Enabled = false;
                    btnrest.Enabled = false;
                    btnpurch.Enabled = false;
                    btnware.Enabled = false;
                    btncat.Enabled = false;
                    break;

            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X-movX, MousePosition.Y-movY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX=e.X;
            movY=e.Y;
        }

        private void btneffect(Button btneff)
        {
            foreach (Control control in btneff.Parent.Controls)
            {
                if (control is Button button && button != btneff)
                {
                    button.ForeColor = Color.Gray;
                }
            }
            btneff.ForeColor = Color.BlueViolet;
            lbleff.BackColor = Color.BlueViolet;
            lbleff.Location = new Point(btneff.Location.X,43);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {

            var login = new Login();
            this.Close();
            login.ShowDialog();
        }
    }
}
