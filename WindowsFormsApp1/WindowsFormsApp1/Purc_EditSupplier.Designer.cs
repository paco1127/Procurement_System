namespace WindowsFormsApp1
{
    partial class Purc_EditSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purc_EditSupplier));
            this.txtsupAddress = new System.Windows.Forms.TextBox();
            this.txtsupEmail = new System.Windows.Forms.TextBox();
            this.txtsupPhone = new System.Windows.Forms.TextBox();
            this.txtsupName = new System.Windows.Forms.TextBox();
            this.txtsupID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbsupState = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsupAddress
            // 
            this.txtsupAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtsupAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupAddress.Location = new System.Drawing.Point(14, 250);
            this.txtsupAddress.Multiline = true;
            this.txtsupAddress.Name = "txtsupAddress";
            this.txtsupAddress.Size = new System.Drawing.Size(268, 94);
            this.txtsupAddress.TabIndex = 23;
            // 
            // txtsupEmail
            // 
            this.txtsupEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtsupEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupEmail.Location = new System.Drawing.Point(16, 160);
            this.txtsupEmail.Name = "txtsupEmail";
            this.txtsupEmail.Size = new System.Drawing.Size(266, 22);
            this.txtsupEmail.TabIndex = 22;
            // 
            // txtsupPhone
            // 
            this.txtsupPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtsupPhone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupPhone.Location = new System.Drawing.Point(16, 116);
            this.txtsupPhone.Name = "txtsupPhone";
            this.txtsupPhone.Size = new System.Drawing.Size(266, 22);
            this.txtsupPhone.TabIndex = 21;
            // 
            // txtsupName
            // 
            this.txtsupName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtsupName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupName.Location = new System.Drawing.Point(16, 72);
            this.txtsupName.Name = "txtsupName";
            this.txtsupName.Size = new System.Drawing.Size(266, 22);
            this.txtsupName.TabIndex = 20;
            // 
            // txtsupID
            // 
            this.txtsupID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtsupID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupID.Location = new System.Drawing.Point(16, 28);
            this.txtsupID.Name = "txtsupID";
            this.txtsupID.ReadOnly = true;
            this.txtsupID.Size = new System.Drawing.Size(266, 22);
            this.txtsupID.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Supplier Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Supplier E-mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Supplier Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Supplier Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Supplier ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "States :";
            // 
            // cbsupState
            // 
            this.cbsupState.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbsupState.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsupState.FormattingEnabled = true;
            this.cbsupState.Items.AddRange(new object[] {
            "available",
            "unavailable"});
            this.cbsupState.Location = new System.Drawing.Point(16, 204);
            this.cbsupState.Name = "cbsupState";
            this.cbsupState.Size = new System.Drawing.Size(266, 24);
            this.cbsupState.TabIndex = 25;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Image = global::WindowsFormsApp1.Properties.Resources.folder_download;
            this.btnsave.Location = new System.Drawing.Point(182, 352);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 36);
            this.btnsave.TabIndex = 82;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Purc_EditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(289, 400);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cbsupState);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsupAddress);
            this.Controls.Add(this.txtsupEmail);
            this.Controls.Add(this.txtsupPhone);
            this.Controls.Add(this.txtsupName);
            this.Controls.Add(this.txtsupID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Purc_EditSupplier";
            this.Text = "Purc_EditSupplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtsupAddress;
        public System.Windows.Forms.TextBox txtsupEmail;
        public System.Windows.Forms.TextBox txtsupPhone;
        public System.Windows.Forms.TextBox txtsupName;
        public System.Windows.Forms.TextBox txtsupID;
        public System.Windows.Forms.ComboBox cbsupState;
        private System.Windows.Forms.Button btnsave;
    }
}