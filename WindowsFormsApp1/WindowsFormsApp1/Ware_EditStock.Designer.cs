namespace WindowsFormsApp1
{
    partial class Ware_EditStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ware_EditStock));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIID = new System.Windows.Forms.TextBox();
            this.txtIName = new System.Windows.Forms.TextBox();
            this.txtIStock = new System.Windows.Forms.TextBox();
            this.picBoxItemImage = new System.Windows.Forms.PictureBox();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Name :";
            // 
            // txtIID
            // 
            this.txtIID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIID.Location = new System.Drawing.Point(286, 45);
            this.txtIID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIID.Name = "txtIID";
            this.txtIID.ReadOnly = true;
            this.txtIID.Size = new System.Drawing.Size(193, 22);
            this.txtIID.TabIndex = 8;
            // 
            // txtIName
            // 
            this.txtIName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIName.Location = new System.Drawing.Point(286, 105);
            this.txtIName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIName.Name = "txtIName";
            this.txtIName.ReadOnly = true;
            this.txtIName.Size = new System.Drawing.Size(193, 22);
            this.txtIName.TabIndex = 9;
            // 
            // txtIStock
            // 
            this.txtIStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIStock.Location = new System.Drawing.Point(286, 165);
            this.txtIStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIStock.Name = "txtIStock";
            this.txtIStock.Size = new System.Drawing.Size(193, 22);
            this.txtIStock.TabIndex = 10;
            // 
            // picBoxItemImage
            // 
            this.picBoxItemImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxItemImage.Location = new System.Drawing.Point(15, 18);
            this.picBoxItemImage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.picBoxItemImage.Name = "picBoxItemImage";
            this.picBoxItemImage.Size = new System.Drawing.Size(250, 250);
            this.picBoxItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxItemImage.TabIndex = 17;
            this.picBoxItemImage.TabStop = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Image = global::WindowsFormsApp1.Properties.Resources.folder_download;
            this.btnsave.Location = new System.Drawing.Point(341, 237);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(138, 31);
            this.btnsave.TabIndex = 81;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Ware_EditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(492, 286);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.picBoxItemImage);
            this.Controls.Add(this.txtIStock);
            this.Controls.Add(this.txtIName);
            this.Controls.Add(this.txtIID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ware_EditStock";
            this.Text = "Ware_EditStock";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtIID;
        public System.Windows.Forms.TextBox txtIName;
        public System.Windows.Forms.TextBox txtIStock;
        public System.Windows.Forms.PictureBox picBoxItemImage;
        private System.Windows.Forms.Button btnsave;
    }
}