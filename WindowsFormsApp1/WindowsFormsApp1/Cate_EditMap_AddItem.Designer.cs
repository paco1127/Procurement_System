namespace WindowsFormsApp1
{
    partial class Cate_EditMap_AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cate_EditMap_AddItem));
            this.lblID = new System.Windows.Forms.Label();
            this.panItemList = new Sunny.UI.UIFlowLayoutPanel();
            this.btnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(13, 13);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(76, 26);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "label1";
            // 
            // panItemList
            // 
            this.panItemList.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panItemList.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.panItemList.FillDisableColor = System.Drawing.Color.WhiteSmoke;
            this.panItemList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panItemList.Location = new System.Drawing.Point(14, 55);
            this.panItemList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panItemList.MinimumSize = new System.Drawing.Size(1, 1);
            this.panItemList.Name = "panItemList";
            this.panItemList.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panItemList.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.panItemList.RectSize = 2;
            this.panItemList.ScrollBarBackColor = System.Drawing.Color.WhiteSmoke;
            this.panItemList.ScrollBarColor = System.Drawing.Color.Gray;
            this.panItemList.ShowText = false;
            this.panItemList.Size = new System.Drawing.Size(677, 279);
            this.panItemList.Style = Sunny.UI.UIStyle.Custom;
            this.panItemList.TabIndex = 3;
            this.panItemList.Text = "uiFlowLayoutPanel1";
            this.panItemList.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Image = global::WindowsFormsApp1.Properties.Resources.add_document__1_;
            this.btnadd.Location = new System.Drawing.Point(574, 344);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(117, 51);
            this.btnadd.TabIndex = 19;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // Cate_EditMap_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 412);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panItemList);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Cate_EditMap_AddItem";
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.Cate_EditMap_AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblID;
        private Sunny.UI.UIFlowLayoutPanel panItemList;
        private System.Windows.Forms.Button btnadd;
    }
}