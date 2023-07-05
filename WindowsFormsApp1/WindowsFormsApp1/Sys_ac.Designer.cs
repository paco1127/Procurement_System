namespace WindowsFormsApp1
{
    partial class Sys_ac
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.databaseDataSet1 = new WindowsFormsApp1.DatabaseDataSet1();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new WindowsFormsApp1.DatabaseDataSet1TableAdapters.EmployeeTableAdapter();
            this.cbList = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaccreate = new System.Windows.Forms.Button();
            this.btnacedit = new System.Windows.Forms.Button();
            this.dgvuserac = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserac)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.databaseDataSet1;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // cbList
            // 
            this.cbList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbList.FormattingEnabled = true;
            this.cbList.Items.AddRange(new object[] {
            "StaffID",
            "FirstName",
            "LastName",
            "EmailAddress",
            "Status"});
            this.cbList.Location = new System.Drawing.Point(50, 93);
            this.cbList.Margin = new System.Windows.Forms.Padding(2);
            this.cbList.Name = "cbList";
            this.cbList.Size = new System.Drawing.Size(100, 25);
            this.cbList.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(154, 96);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(140, 22);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(298, 89);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 36);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::WindowsFormsApp1.Properties.Resources.users;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // btnaccreate
            // 
            this.btnaccreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnaccreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnaccreate.FlatAppearance.BorderSize = 0;
            this.btnaccreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaccreate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnaccreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaccreate.Image = global::WindowsFormsApp1.Properties.Resources.add_document__1_;
            this.btnaccreate.Location = new System.Drawing.Point(985, 86);
            this.btnaccreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnaccreate.Name = "btnaccreate";
            this.btnaccreate.Size = new System.Drawing.Size(125, 36);
            this.btnaccreate.TabIndex = 2;
            this.btnaccreate.UseVisualStyleBackColor = false;
            this.btnaccreate.Click += new System.EventHandler(this.btnaccreate_Click);
            // 
            // btnacedit
            // 
            this.btnacedit.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.file_edit;
            this.btnacedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnacedit.FlatAppearance.BorderSize = 0;
            this.btnacedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacedit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnacedit.Location = new System.Drawing.Point(1114, 86);
            this.btnacedit.Margin = new System.Windows.Forms.Padding(2);
            this.btnacedit.Name = "btnacedit";
            this.btnacedit.Size = new System.Drawing.Size(36, 36);
            this.btnacedit.TabIndex = 1;
            this.btnacedit.UseVisualStyleBackColor = true;
            this.btnacedit.Click += new System.EventHandler(this.btnacedit_Click);
            // 
            // dgvuserac
            // 
            this.dgvuserac.AllowUserToAddRows = false;
            this.dgvuserac.AllowUserToDeleteRows = false;
            this.dgvuserac.AllowUserToOrderColumns = true;
            this.dgvuserac.AllowUserToResizeColumns = false;
            this.dgvuserac.AllowUserToResizeRows = false;
            this.dgvuserac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvuserac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvuserac.BackgroundColor = System.Drawing.Color.White;
            this.dgvuserac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvuserac.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvuserac.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvuserac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvuserac.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvuserac.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvuserac.EnableHeadersVisualStyles = false;
            this.dgvuserac.Location = new System.Drawing.Point(50, 130);
            this.dgvuserac.Name = "dgvuserac";
            this.dgvuserac.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvuserac.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvuserac.RowHeadersVisible = false;
            this.dgvuserac.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvuserac.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvuserac.RowTemplate.Height = 60;
            this.dgvuserac.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvuserac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvuserac.Size = new System.Drawing.Size(1100, 550);
            this.dgvuserac.TabIndex = 12;
            this.dgvuserac.SelectionChanged += new System.EventHandler(this.dgvuserac_SelectionChanged);
            // 
            // Sys_ac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.dgvuserac);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaccreate);
            this.Controls.Add(this.btnacedit);
            this.Name = "Sys_ac";
            this.Size = new System.Drawing.Size(1200, 710);
            this.Load += new System.EventHandler(this.sysac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DatabaseDataSet1 databaseDataSet1;
        private DatabaseDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button btnacedit;
        private System.Windows.Forms.Button btnaccreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.DataGridView dgvuserac;
    }
}
