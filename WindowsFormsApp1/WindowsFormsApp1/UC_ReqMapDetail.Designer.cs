namespace WindowsFormsApp1
{
    partial class UC_ReqMapDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblrest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblrestaddress = new System.Windows.Forms.Label();
            this.lblOrdDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnldeli = new System.Windows.Forms.Panel();
            this.btndetail = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 369);
            this.label1.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(34, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 22);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "O-001";
            // 
            // lblrest
            // 
            this.lblrest.AutoSize = true;
            this.lblrest.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrest.Location = new System.Drawing.Point(175, 41);
            this.lblrest.Name = "lblrest";
            this.lblrest.Size = new System.Drawing.Size(95, 17);
            this.lblrest.TabIndex = 2;
            this.lblrest.Text = "AAA Restaurat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Restaurant Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Restaurant Address:";
            // 
            // lblrestaddress
            // 
            this.lblrestaddress.AllowDrop = true;
            this.lblrestaddress.AutoSize = true;
            this.lblrestaddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrestaddress.Location = new System.Drawing.Point(175, 67);
            this.lblrestaddress.Name = "lblrestaddress";
            this.lblrestaddress.Size = new System.Drawing.Size(220, 17);
            this.lblrestaddress.TabIndex = 20;
            this.lblrestaddress.Text = "123 Road 1231312313123123123123";
            // 
            // lblOrdDate
            // 
            this.lblOrdDate.AutoSize = true;
            this.lblOrdDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdDate.Location = new System.Drawing.Point(736, 41);
            this.lblOrdDate.Name = "lblOrdDate";
            this.lblOrdDate.Size = new System.Drawing.Size(15, 17);
            this.lblOrdDate.TabIndex = 12;
            this.lblOrdDate.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(649, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Order Date :";
            // 
            // pnldeli
            // 
            this.pnldeli.Location = new System.Drawing.Point(27, 101);
            this.pnldeli.Name = "pnldeli";
            this.pnldeli.Size = new System.Drawing.Size(1020, 265);
            this.pnldeli.TabIndex = 22;
            // 
            // btndetail
            // 
            this.btndetail.BackColor = System.Drawing.Color.Transparent;
            this.btndetail.FlatAppearance.BorderSize = 0;
            this.btndetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndetail.Image = global::WindowsFormsApp1.Properties.Resources.menu_dots_vertical;
            this.btndetail.Location = new System.Drawing.Point(1012, 3);
            this.btndetail.Name = "btndetail";
            this.btndetail.Size = new System.Drawing.Size(35, 40);
            this.btndetail.TabIndex = 23;
            this.btndetail.UseVisualStyleBackColor = false;
            this.btndetail.Click += new System.EventHandler(this.btndetail_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.lblstatus.Location = new System.Drawing.Point(826, 9);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(59, 21);
            this.lblstatus.TabIndex = 24;
            this.lblstatus.Text = "label3";
            // 
            // UC_ReqMapDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btndetail);
            this.Controls.Add(this.pnldeli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOrdDate);
            this.Controls.Add(this.lblrestaddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblrest);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Name = "UC_ReqMapDetail";
            this.Size = new System.Drawing.Size(1050, 369);
            this.Load += new System.EventHandler(this.ReqMapDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblrest;
        public System.Windows.Forms.Label lblrestaddress;
        public System.Windows.Forms.Label lblOrdDate;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel pnldeli;
        public System.Windows.Forms.Button btndetail;
        public System.Windows.Forms.Label lblstatus;
    }
}
