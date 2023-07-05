using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp1
{
    public partial class Sys_log : UserControl
    {
        string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\log.txt";
        public Sys_log()
        {
            InitializeComponent();
        }

        private void syslg_Load(object sender, EventArgs e)
        {
            
            rtxtlog.Text = File.ReadAllText(path);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string message = "Do you want clear the log?";
            string title = "Clear Log";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write("");
                }
                rtxtlog.Text = File.ReadAllText(path);
            }



            
        }
    }
 }
