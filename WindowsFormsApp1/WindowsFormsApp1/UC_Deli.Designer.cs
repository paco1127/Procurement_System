namespace WindowsFormsApp1
{
    partial class UC_Deli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbldeliID = new System.Windows.Forms.Label();
            this.dgvdeli = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeli)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldeliID
            // 
            this.lbldeliID.AutoSize = true;
            this.lbldeliID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeliID.Location = new System.Drawing.Point(120, 13);
            this.lbldeliID.Name = "lbldeliID";
            this.lbldeliID.Size = new System.Drawing.Size(45, 17);
            this.lbldeliID.TabIndex = 0;
            this.lbldeliID.Text = "label1";
            // 
            // dgvdeli
            // 
            this.dgvdeli.AllowUserToAddRows = false;
            this.dgvdeli.AllowUserToDeleteRows = false;
            this.dgvdeli.AllowUserToResizeColumns = false;
            this.dgvdeli.AllowUserToResizeRows = false;
            this.dgvdeli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdeli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdeli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdeli.ColumnHeadersHeight = 29;
            this.dgvdeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvdeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Qty});
            this.dgvdeli.GridColor = System.Drawing.Color.MediumPurple;
            this.dgvdeli.Location = new System.Drawing.Point(17, 42);
            this.dgvdeli.Name = "dgvdeli";
            this.dgvdeli.RowHeadersVisible = false;
            this.dgvdeli.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdeli.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdeli.RowTemplate.Height = 24;
            this.dgvdeli.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvdeli.Size = new System.Drawing.Size(1297, 152);
            this.dgvdeli.TabIndex = 1;
            // 
            // Item
            // 
            this.Item.HeaderText = "ItemID";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Delivery Order :";
            // 
            // UC_Deli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdeli);
            this.Controls.Add(this.lbldeliID);
            this.Name = "UC_Deli";
            this.Size = new System.Drawing.Size(1321, 549);
            this.Load += new System.EventHandler(this.DeliUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvdeli;
        public System.Windows.Forms.Label lbldeliID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        public System.Windows.Forms.Label label1;
    }
}
