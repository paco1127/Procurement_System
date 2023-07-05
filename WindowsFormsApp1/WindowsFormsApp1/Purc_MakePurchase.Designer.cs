namespace WindowsFormsApp1
{
    partial class Purc_MakePurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purc_MakePurchase));
            this.dgvUnacceptItem = new System.Windows.Forms.DataGridView();
            this.btnMapping = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvBPA = new System.Windows.Forms.DataGridView();
            this.btnOrderBPA = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCPA = new System.Windows.Forms.DataGridView();
            this.btnOrderCPA = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStandOrd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnacceptItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUnacceptItem
            // 
            this.dgvUnacceptItem.AllowUserToAddRows = false;
            this.dgvUnacceptItem.AllowUserToDeleteRows = false;
            this.dgvUnacceptItem.AllowUserToOrderColumns = true;
            this.dgvUnacceptItem.AllowUserToResizeColumns = false;
            this.dgvUnacceptItem.AllowUserToResizeRows = false;
            this.dgvUnacceptItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnacceptItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnacceptItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnacceptItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnacceptItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnacceptItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnacceptItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnacceptItem.ColumnHeadersHeight = 50;
            this.dgvUnacceptItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnMapping});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnacceptItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnacceptItem.EnableHeadersVisualStyles = false;
            this.dgvUnacceptItem.Location = new System.Drawing.Point(73, 90);
            this.dgvUnacceptItem.Name = "dgvUnacceptItem";
            this.dgvUnacceptItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnacceptItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUnacceptItem.RowHeadersVisible = false;
            this.dgvUnacceptItem.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUnacceptItem.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUnacceptItem.RowTemplate.Height = 60;
            this.dgvUnacceptItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUnacceptItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnacceptItem.Size = new System.Drawing.Size(776, 238);
            this.dgvUnacceptItem.TabIndex = 11;
            this.dgvUnacceptItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnacceptItem_CellContentClick);
            // 
            // btnMapping
            // 
            this.btnMapping.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnMapping.HeaderText = "Mapping";
            this.btnMapping.Image = global::WindowsFormsApp1.Properties.Resources.document;
            this.btnMapping.MinimumWidth = 6;
            this.btnMapping.Name = "btnMapping";
            this.btnMapping.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnMapping.Width = 197;
            // 
            // dgvBPA
            // 
            this.dgvBPA.AllowUserToAddRows = false;
            this.dgvBPA.AllowUserToDeleteRows = false;
            this.dgvBPA.AllowUserToOrderColumns = true;
            this.dgvBPA.AllowUserToResizeColumns = false;
            this.dgvBPA.AllowUserToResizeRows = false;
            this.dgvBPA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBPA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBPA.BackgroundColor = System.Drawing.Color.White;
            this.dgvBPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBPA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBPA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBPA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBPA.ColumnHeadersHeight = 50;
            this.dgvBPA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnOrderBPA,
            this.txtBQty});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBPA.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBPA.EnableHeadersVisualStyles = false;
            this.dgvBPA.Location = new System.Drawing.Point(73, 386);
            this.dgvBPA.Name = "dgvBPA";
            this.dgvBPA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBPA.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBPA.RowHeadersVisible = false;
            this.dgvBPA.RowHeadersWidth = 50;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBPA.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBPA.RowTemplate.Height = 60;
            this.dgvBPA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBPA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBPA.Size = new System.Drawing.Size(776, 95);
            this.dgvBPA.TabIndex = 14;
            this.dgvBPA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBPA_CellContentClick);
            // 
            // btnOrderBPA
            // 
            this.btnOrderBPA.HeaderText = "Order";
            this.btnOrderBPA.Image = global::WindowsFormsApp1.Properties.Resources.cart_shopping_fast;
            this.btnOrderBPA.MinimumWidth = 6;
            this.btnOrderBPA.Name = "btnOrderBPA";
            this.btnOrderBPA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtBQty
            // 
            this.txtBQty.HeaderText = "Qty";
            this.txtBQty.MinimumWidth = 6;
            this.txtBQty.Name = "txtBQty";
            // 
            // dgvCPA
            // 
            this.dgvCPA.AllowUserToAddRows = false;
            this.dgvCPA.AllowUserToDeleteRows = false;
            this.dgvCPA.AllowUserToOrderColumns = true;
            this.dgvCPA.AllowUserToResizeColumns = false;
            this.dgvCPA.AllowUserToResizeRows = false;
            this.dgvCPA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCPA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCPA.BackgroundColor = System.Drawing.Color.White;
            this.dgvCPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCPA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCPA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCPA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCPA.ColumnHeadersHeight = 50;
            this.dgvCPA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnOrderCPA,
            this.txtPrice,
            this.txtQty});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCPA.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCPA.EnableHeadersVisualStyles = false;
            this.dgvCPA.Location = new System.Drawing.Point(73, 542);
            this.dgvCPA.Name = "dgvCPA";
            this.dgvCPA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCPA.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCPA.RowHeadersVisible = false;
            this.dgvCPA.RowHeadersWidth = 50;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCPA.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCPA.RowTemplate.Height = 60;
            this.dgvCPA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCPA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCPA.Size = new System.Drawing.Size(776, 95);
            this.dgvCPA.TabIndex = 15;
            this.dgvCPA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCPA_CellContentClick);
            // 
            // btnOrderCPA
            // 
            this.btnOrderCPA.HeaderText = "Order";
            this.btnOrderCPA.Image = global::WindowsFormsApp1.Properties.Resources.cart_shopping_fast;
            this.btnOrderCPA.MinimumWidth = 6;
            this.btnOrderCPA.Name = "btnOrderCPA";
            this.btnOrderCPA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtPrice
            // 
            this.txtPrice.HeaderText = "Price";
            this.txtPrice.MinimumWidth = 6;
            this.txtPrice.Name = "txtPrice";
            // 
            // txtQty
            // 
            this.txtQty.HeaderText = "Qty";
            this.txtQty.MinimumWidth = 6;
            this.txtQty.Name = "txtQty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "BPA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "CPA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnStandOrd
            // 
            this.btnStandOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnStandOrd.FlatAppearance.BorderSize = 0;
            this.btnStandOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStandOrd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandOrd.ForeColor = System.Drawing.Color.White;
            this.btnStandOrd.Location = new System.Drawing.Point(681, 36);
            this.btnStandOrd.Name = "btnStandOrd";
            this.btnStandOrd.Size = new System.Drawing.Size(168, 39);
            this.btnStandOrd.TabIndex = 25;
            this.btnStandOrd.Text = "Create Standard Order";
            this.btnStandOrd.UseVisualStyleBackColor = false;
            this.btnStandOrd.Click += new System.EventHandler(this.btnStandOrd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Request Item";
            // 
            // Purc_MakePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(926, 730);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStandOrd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCPA);
            this.Controls.Add(this.dgvBPA);
            this.Controls.Add(this.dgvUnacceptItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Purc_MakePurchase";
            this.Load += new System.EventHandler(this.Purc_MakePurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnacceptItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvUnacceptItem;
        public System.Windows.Forms.DataGridView dgvBPA;
        public System.Windows.Forms.DataGridView dgvCPA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn btnMapping;
        private System.Windows.Forms.DataGridViewImageColumn btnOrderBPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBQty;
        private System.Windows.Forms.DataGridViewImageColumn btnOrderCPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQty;
        private System.Windows.Forms.Button btnStandOrd;
        private System.Windows.Forms.Label label3;
    }
}
