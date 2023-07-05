namespace WindowsFormsApp1
{
    partial class UC_DeliOrd
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvdeliitem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDeli = new System.Windows.Forms.Label();
            this.lblRestAdd = new System.Windows.Forms.Label();
            this.btnfinish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeliitem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdeliitem
            // 
            this.dgvdeliitem.AllowUserToAddRows = false;
            this.dgvdeliitem.AllowUserToDeleteRows = false;
            this.dgvdeliitem.AllowUserToResizeColumns = false;
            this.dgvdeliitem.AllowUserToResizeRows = false;
            this.dgvdeliitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdeliitem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvdeliitem.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdeliitem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdeliitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeliitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvdeliitem.Location = new System.Drawing.Point(16, 83);
            this.dgvdeliitem.Name = "dgvdeliitem";
            this.dgvdeliitem.RowHeadersVisible = false;
            this.dgvdeliitem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdeliitem.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdeliitem.RowTemplate.Height = 24;
            this.dgvdeliitem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvdeliitem.Size = new System.Drawing.Size(1034, 99);
            this.dgvdeliitem.TabIndex = 2;
            this.dgvdeliitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdeliitem_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // lblDeli
            // 
            this.lblDeli.AutoSize = true;
            this.lblDeli.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeli.Location = new System.Drawing.Point(127, 15);
            this.lblDeli.Name = "lblDeli";
            this.lblDeli.Size = new System.Drawing.Size(59, 17);
            this.lblDeli.TabIndex = 3;
            this.lblDeli.Text = "DO-0001";
            // 
            // lblRestAdd
            // 
            this.lblRestAdd.AutoSize = true;
            this.lblRestAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestAdd.Location = new System.Drawing.Point(86, 32);
            this.lblRestAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRestAdd.Name = "lblRestAdd";
            this.lblRestAdd.Size = new System.Drawing.Size(55, 17);
            this.lblRestAdd.TabIndex = 4;
            this.lblRestAdd.Text = "Address";
            // 
            // btnfinish
            // 
            this.btnfinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnfinish.FlatAppearance.BorderSize = 0;
            this.btnfinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfinish.Image = global::WindowsFormsApp1.Properties.Resources.checkbox;
            this.btnfinish.Location = new System.Drawing.Point(915, 0);
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.Size = new System.Drawing.Size(135, 40);
            this.btnfinish.TabIndex = 5;
            this.btnfinish.UseVisualStyleBackColor = false;
            this.btnfinish.Click += new System.EventHandler(this.btnfinish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delivery Order :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 182);
            this.label3.TabIndex = 8;
            // 
            // UC_DeliOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfinish);
            this.Controls.Add(this.lblRestAdd);
            this.Controls.Add(this.lblDeli);
            this.Controls.Add(this.dgvdeliitem);
            this.Name = "UC_DeliOrd";
            this.Size = new System.Drawing.Size(1050, 182);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeliitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblDeli;
        public System.Windows.Forms.DataGridView dgvdeliitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.Label lblRestAdd;
        public System.Windows.Forms.Button btnfinish;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
