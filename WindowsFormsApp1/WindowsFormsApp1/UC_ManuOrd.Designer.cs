namespace WindowsFormsApp1
{
    partial class UC_ManuOrd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRestName = new System.Windows.Forms.Label();
            this.flpdord = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvunitem = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stockqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectitem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btncrtdeliord = new System.Windows.Forms.Button();
            this.lblrestid = new System.Windows.Forms.Label();
            this.lblOrdID = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvunitem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 498);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restaurant Name :";
            // 
            // lblRestName
            // 
            this.lblRestName.AutoSize = true;
            this.lblRestName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestName.Location = new System.Drawing.Point(172, 71);
            this.lblRestName.Name = "lblRestName";
            this.lblRestName.Size = new System.Drawing.Size(102, 17);
            this.lblRestName.TabIndex = 2;
            this.lblRestName.Text = "AAA Restaurant";
            // 
            // flpdord
            // 
            this.flpdord.Location = new System.Drawing.Point(52, 325);
            this.flpdord.Name = "flpdord";
            this.flpdord.Size = new System.Drawing.Size(973, 159);
            this.flpdord.TabIndex = 3;
            // 
            // dgvunitem
            // 
            this.dgvunitem.AllowUserToAddRows = false;
            this.dgvunitem.AllowUserToDeleteRows = false;
            this.dgvunitem.AllowUserToResizeColumns = false;
            this.dgvunitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvunitem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvunitem.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvunitem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvunitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvunitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.reqty,
            this.Stockqty,
            this.selectitem});
            this.dgvunitem.Location = new System.Drawing.Point(52, 111);
            this.dgvunitem.Name = "dgvunitem";
            this.dgvunitem.RowHeadersVisible = false;
            this.dgvunitem.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvunitem.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvunitem.RowTemplate.Height = 24;
            this.dgvunitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvunitem.Size = new System.Drawing.Size(973, 169);
            this.dgvunitem.StandardTab = true;
            this.dgvunitem.TabIndex = 4;
            this.dgvunitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvunitem_CellContentClick);
            // 
            // Item
            // 
            this.Item.HeaderText = "ItemID";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // reqty
            // 
            this.reqty.HeaderText = "Request Qty";
            this.reqty.MinimumWidth = 6;
            this.reqty.Name = "reqty";
            this.reqty.ReadOnly = true;
            // 
            // Stockqty
            // 
            this.Stockqty.HeaderText = "Stock Qty";
            this.Stockqty.MinimumWidth = 6;
            this.Stockqty.Name = "Stockqty";
            this.Stockqty.ReadOnly = true;
            // 
            // selectitem
            // 
            this.selectitem.HeaderText = "Select";
            this.selectitem.MinimumWidth = 6;
            this.selectitem.Name = "selectitem";
            // 
            // btncrtdeliord
            // 
            this.btncrtdeliord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btncrtdeliord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrtdeliord.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrtdeliord.ForeColor = System.Drawing.Color.White;
            this.btncrtdeliord.Location = new System.Drawing.Point(878, 286);
            this.btncrtdeliord.Name = "btncrtdeliord";
            this.btncrtdeliord.Size = new System.Drawing.Size(147, 33);
            this.btncrtdeliord.TabIndex = 5;
            this.btncrtdeliord.Text = "Create Delivery Order";
            this.btncrtdeliord.UseVisualStyleBackColor = false;
            this.btncrtdeliord.Click += new System.EventHandler(this.btncrtdeliord_Click);
            // 
            // lblrestid
            // 
            this.lblrestid.AutoSize = true;
            this.lblrestid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrestid.Location = new System.Drawing.Point(148, 39);
            this.lblrestid.Name = "lblrestid";
            this.lblrestid.Size = new System.Drawing.Size(45, 17);
            this.lblrestid.TabIndex = 6;
            this.lblrestid.Text = "RestID";
            // 
            // lblOrdID
            // 
            this.lblOrdID.AutoSize = true;
            this.lblOrdID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdID.Location = new System.Drawing.Point(94, 13);
            this.lblOrdID.Name = "lblOrdID";
            this.lblOrdID.Size = new System.Drawing.Size(39, 17);
            this.lblOrdID.TabIndex = 7;
            this.lblOrdID.Text = "ordid";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.lblstatus.Location = new System.Drawing.Point(826, 9);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(59, 21);
            this.lblstatus.TabIndex = 8;
            this.lblstatus.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Order :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Restaurant ID :";
            // 
            // UC_ManuOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblOrdID);
            this.Controls.Add(this.lblrestid);
            this.Controls.Add(this.btncrtdeliord);
            this.Controls.Add(this.dgvunitem);
            this.Controls.Add(this.flpdord);
            this.Controls.Add(this.lblRestName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_ManuOrd";
            this.Size = new System.Drawing.Size(1050, 498);
            ((System.ComponentModel.ISupportInitialize)(this.dgvunitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblRestName;
        public System.Windows.Forms.DataGridView dgvunitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stockqty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectitem;
        public System.Windows.Forms.Button btncrtdeliord;
        public System.Windows.Forms.FlowLayoutPanel flpdord;
        public System.Windows.Forms.Label lblrestid;
        public System.Windows.Forms.Label lblOrdID;
        public System.Windows.Forms.Label lblstatus;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
    }
}
