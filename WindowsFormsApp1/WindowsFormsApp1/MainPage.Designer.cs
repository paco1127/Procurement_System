namespace WindowsFormsApp1
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnware = new System.Windows.Forms.Button();
            this.btnsys = new System.Windows.Forms.Button();
            this.btncat = new System.Windows.Forms.Button();
            this.btnrest = new System.Windows.Forms.Button();
            this.btnacc = new System.Windows.Forms.Button();
            this.btnpurch = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.pnlinfo = new System.Windows.Forms.Panel();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AvaUserIcon = new Sunny.UI.UIAvatar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbleff = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.btnclose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 40);
            this.panel2.TabIndex = 4;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = global::WindowsFormsApp1.Properties.Resources.cancel__1_;
            this.btnclose.Location = new System.Drawing.Point(1360, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 40);
            this.btnclose.TabIndex = 0;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnware
            // 
            this.btnware.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnware.FlatAppearance.BorderSize = 0;
            this.btnware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnware.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnware.ForeColor = System.Drawing.Color.LightGray;
            this.btnware.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnware.Location = new System.Drawing.Point(481, 1);
            this.btnware.Name = "btnware";
            this.btnware.Size = new System.Drawing.Size(120, 48);
            this.btnware.TabIndex = 5;
            this.btnware.Text = "Warehouse";
            this.btnware.UseVisualStyleBackColor = false;
            this.btnware.Click += new System.EventHandler(this.btnware_Click);
            // 
            // btnsys
            // 
            this.btnsys.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsys.FlatAppearance.BorderSize = 0;
            this.btnsys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsys.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsys.ForeColor = System.Drawing.Color.LightGray;
            this.btnsys.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsys.Location = new System.Drawing.Point(601, 1);
            this.btnsys.Name = "btnsys";
            this.btnsys.Size = new System.Drawing.Size(120, 48);
            this.btnsys.TabIndex = 4;
            this.btnsys.Text = "System";
            this.btnsys.UseVisualStyleBackColor = false;
            this.btnsys.Click += new System.EventHandler(this.btnsys_Click);
            // 
            // btncat
            // 
            this.btncat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncat.FlatAppearance.BorderSize = 0;
            this.btncat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncat.ForeColor = System.Drawing.Color.LightGray;
            this.btncat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncat.Location = new System.Drawing.Point(241, 1);
            this.btncat.Name = "btncat";
            this.btncat.Size = new System.Drawing.Size(120, 48);
            this.btncat.TabIndex = 3;
            this.btncat.Text = "Category";
            this.btncat.UseVisualStyleBackColor = false;
            this.btncat.Click += new System.EventHandler(this.btncat_Click);
            // 
            // btnrest
            // 
            this.btnrest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrest.FlatAppearance.BorderSize = 0;
            this.btnrest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrest.ForeColor = System.Drawing.Color.LightGray;
            this.btnrest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrest.Location = new System.Drawing.Point(1, 1);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(120, 48);
            this.btnrest.TabIndex = 2;
            this.btnrest.Text = "Restaurant";
            this.btnrest.UseVisualStyleBackColor = false;
            this.btnrest.Click += new System.EventHandler(this.btnrest_Click);
            // 
            // btnacc
            // 
            this.btnacc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnacc.FlatAppearance.BorderSize = 0;
            this.btnacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacc.ForeColor = System.Drawing.Color.LightGray;
            this.btnacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnacc.Location = new System.Drawing.Point(361, 1);
            this.btnacc.Name = "btnacc";
            this.btnacc.Size = new System.Drawing.Size(120, 48);
            this.btnacc.TabIndex = 1;
            this.btnacc.Text = "Accounting";
            this.btnacc.UseVisualStyleBackColor = false;
            this.btnacc.Click += new System.EventHandler(this.btnacc_Click);
            // 
            // btnpurch
            // 
            this.btnpurch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpurch.FlatAppearance.BorderSize = 0;
            this.btnpurch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpurch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpurch.ForeColor = System.Drawing.Color.LightGray;
            this.btnpurch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpurch.Location = new System.Drawing.Point(121, 1);
            this.btnpurch.Name = "btnpurch";
            this.btnpurch.Size = new System.Drawing.Size(120, 48);
            this.btnpurch.TabIndex = 0;
            this.btnpurch.Text = "Purchase";
            this.btnpurch.UseVisualStyleBackColor = false;
            this.btnpurch.Click += new System.EventHandler(this.btnpurch_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlmenu.Location = new System.Drawing.Point(0, 90);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(200, 710);
            this.pnlmenu.TabIndex = 6;
            this.pnlmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlmenu_Paint);
            // 
            // pnlinfo
            // 
            this.pnlinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.pnlinfo.Location = new System.Drawing.Point(200, 90);
            this.pnlinfo.Name = "pnlinfo";
            this.pnlinfo.Size = new System.Drawing.Size(1200, 710);
            this.pnlinfo.TabIndex = 7;
            this.pnlinfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlinfo_Paint);
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.asdToolStripMenuItem.Text = "asd";
            // 
            // AvaUserIcon
            // 
            this.AvaUserIcon.AvatarSize = 40;
            this.AvaUserIcon.FillColor = System.Drawing.Color.WhiteSmoke;
            this.AvaUserIcon.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AvaUserIcon.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            this.AvaUserIcon.Location = new System.Drawing.Point(12, 4);
            this.AvaUserIcon.MinimumSize = new System.Drawing.Size(1, 1);
            this.AvaUserIcon.Name = "AvaUserIcon";
            this.AvaUserIcon.Size = new System.Drawing.Size(42, 42);
            this.AvaUserIcon.Style = Sunny.UI.UIStyle.Custom;
            this.AvaUserIcon.TabIndex = 0;
            this.AvaUserIcon.Text = "uiAvatar1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.AvaUserIcon);
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 48);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hi, Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.lbleff);
            this.panel1.Controls.Add(this.btnware);
            this.panel1.Controls.Add(this.btnsys);
            this.panel1.Controls.Add(this.btncat);
            this.panel1.Controls.Add(this.btnrest);
            this.panel1.Controls.Add(this.btnacc);
            this.panel1.Controls.Add(this.btnpurch);
            this.panel1.Location = new System.Drawing.Point(200, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 48);
            this.panel1.TabIndex = 5;
            // 
            // lbleff
            // 
            this.lbleff.BackColor = System.Drawing.Color.Transparent;
            this.lbleff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbleff.Location = new System.Drawing.Point(1, 43);
            this.lbleff.Name = "lbleff";
            this.lbleff.Size = new System.Drawing.Size(120, 5);
            this.lbleff.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.Location = new System.Drawing.Point(1151, 5);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(45, 38);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlinfo);
            this.Controls.Add(this.pnlmenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnpurch;
        private System.Windows.Forms.Button btnsys;
        private System.Windows.Forms.Button btncat;
        private System.Windows.Forms.Button btnrest;
        private System.Windows.Forms.Button btnacc;
        private System.Windows.Forms.Button btnware;
        private Rest_Dashboard restDashboard1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Panel pnlinfo;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private Sunny.UI.UIAvatar AvaUserIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbleff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogout;
    }
}