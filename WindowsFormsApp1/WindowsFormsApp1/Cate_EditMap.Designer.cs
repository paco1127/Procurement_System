namespace WindowsFormsApp1
{
    partial class Cate_EditMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cate_EditMap));
            this.lblVName = new System.Windows.Forms.Label();
            this.pnlMappedItem = new Sunny.UI.UIFlowLayoutPanel();
            this.cbgRestaurant = new Sunny.UI.UICheckBoxGroup();
            this.lblVID = new System.Windows.Forms.Label();
            this.lblforVname = new System.Windows.Forms.Label();
            this.lblForVID = new System.Windows.Forms.Label();
            this.lblCurrItem = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVName
            // 
            this.lblVName.AutoSize = true;
            this.lblVName.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVName.Location = new System.Drawing.Point(198, 32);
            this.lblVName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVName.Name = "lblVName";
            this.lblVName.Size = new System.Drawing.Size(82, 27);
            this.lblVName.TabIndex = 0;
            this.lblVName.Text = "Name";
            // 
            // pnlMappedItem
            // 
            this.pnlMappedItem.FillColor = System.Drawing.Color.MediumPurple;
            this.pnlMappedItem.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlMappedItem.FillDisableColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMappedItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.pnlMappedItem.Location = new System.Drawing.Point(16, 100);
            this.pnlMappedItem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnlMappedItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlMappedItem.Name = "pnlMappedItem";
            this.pnlMappedItem.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlMappedItem.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.pnlMappedItem.RectSize = 2;
            this.pnlMappedItem.ScrollBarColor = System.Drawing.Color.Silver;
            this.pnlMappedItem.ShowText = false;
            this.pnlMappedItem.Size = new System.Drawing.Size(787, 192);
            this.pnlMappedItem.Style = Sunny.UI.UIStyle.Custom;
            this.pnlMappedItem.TabIndex = 1;
            this.pnlMappedItem.Text = "uiFlowLayoutPanel1";
            this.pnlMappedItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbgRestaurant
            // 
            this.cbgRestaurant.ColumnCount = 4;
            this.cbgRestaurant.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbgRestaurant.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.cbgRestaurant.FillDisableColor = System.Drawing.Color.WhiteSmoke;
            this.cbgRestaurant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgRestaurant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.cbgRestaurant.Location = new System.Drawing.Point(17, 329);
            this.cbgRestaurant.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbgRestaurant.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbgRestaurant.Name = "cbgRestaurant";
            this.cbgRestaurant.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.cbgRestaurant.Radius = 1;
            this.cbgRestaurant.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.cbgRestaurant.RectDisableColor = System.Drawing.Color.WhiteSmoke;
            this.cbgRestaurant.RectSize = 2;
            this.cbgRestaurant.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("cbgRestaurant.SelectedIndexes")));
            this.cbgRestaurant.Size = new System.Drawing.Size(786, 139);
            this.cbgRestaurant.Style = Sunny.UI.UIStyle.Custom;
            this.cbgRestaurant.TabIndex = 2;
            this.cbgRestaurant.Text = "Choose Restaurant Brand";
            this.cbgRestaurant.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblVID
            // 
            this.lblVID.AutoSize = true;
            this.lblVID.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVID.Location = new System.Drawing.Point(198, 60);
            this.lblVID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVID.Name = "lblVID";
            this.lblVID.Size = new System.Drawing.Size(52, 27);
            this.lblVID.TabIndex = 6;
            this.lblVID.Text = "VID";
            // 
            // lblforVname
            // 
            this.lblforVname.AutoSize = true;
            this.lblforVname.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforVname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.lblforVname.Location = new System.Drawing.Point(11, 33);
            this.lblforVname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblforVname.Name = "lblforVname";
            this.lblforVname.Size = new System.Drawing.Size(168, 27);
            this.lblforVname.TabIndex = 7;
            this.lblforVname.Text = "V Item Name:";
            // 
            // lblForVID
            // 
            this.lblForVID.AutoSize = true;
            this.lblForVID.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForVID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.lblForVID.Location = new System.Drawing.Point(11, 60);
            this.lblForVID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForVID.Name = "lblForVID";
            this.lblForVID.Size = new System.Drawing.Size(121, 27);
            this.lblForVID.TabIndex = 8;
            this.lblForVID.Text = "V Item ID:";
            // 
            // lblCurrItem
            // 
            this.lblCurrItem.AutoSize = true;
            this.lblCurrItem.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrItem.Location = new System.Drawing.Point(19, 307);
            this.lblCurrItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrItem.Name = "lblCurrItem";
            this.lblCurrItem.Size = new System.Drawing.Size(84, 27);
            this.lblCurrItem.TabIndex = 10;
            this.lblCurrItem.Text = "label1";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Image = global::WindowsFormsApp1.Properties.Resources.folder_download;
            this.btnsave.Location = new System.Drawing.Point(709, 499);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 36);
            this.btnsave.TabIndex = 19;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.White;
            this.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Image = global::WindowsFormsApp1.Properties.Resources.broom;
            this.btnclear.Location = new System.Drawing.Point(667, 499);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(36, 36);
            this.btnclear.TabIndex = 18;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Image = global::WindowsFormsApp1.Properties.Resources.add_document;
            this.btnAddItem.Location = new System.Drawing.Point(773, 39);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(36, 36);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(-3, 485);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(825, 65);
            this.label15.TabIndex = 78;
            // 
            // Cate_EditMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(816, 547);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblCurrItem);
            this.Controls.Add(this.lblForVID);
            this.Controls.Add(this.lblforVname);
            this.Controls.Add(this.lblVID);
            this.Controls.Add(this.cbgRestaurant);
            this.Controls.Add(this.pnlMappedItem);
            this.Controls.Add(this.lblVName);
            this.Controls.Add(this.label15);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Cate_EditMap";
            this.Text = "Edit Mapping";
            this.Load += new System.EventHandler(this.Cate_EditMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UIFlowLayoutPanel pnlMappedItem;
        private Sunny.UI.UICheckBoxGroup cbgRestaurant;
        public System.Windows.Forms.Label lblVID;
        public System.Windows.Forms.Label lblVName;
        private System.Windows.Forms.Label lblforVname;
        private System.Windows.Forms.Label lblForVID;
        private System.Windows.Forms.Label lblCurrItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label15;
    }
}