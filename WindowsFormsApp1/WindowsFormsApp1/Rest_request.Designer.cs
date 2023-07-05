namespace WindowsFormsApp1
{
    partial class Rest_request
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rest_request));
            this.FlowCate = new Sunny.UI.UIFlowLayoutPanel();
            this.FlowPLPic = new Sunny.UI.UIFlowLayoutPanel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnSearch = new Sunny.UI.UIButton();
            this.searchtxt = new Sunny.UI.UITextBox();
            this.dgvitemlist = new Sunny.UI.UIDataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndel = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnsubmit = new Sunny.UI.UIButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cbemerg = new System.Windows.Forms.CheckBox();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitemlist)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowCate
            // 
            this.FlowCate.FillColor = System.Drawing.Color.White;
            this.FlowCate.FillColor2 = System.Drawing.Color.White;
            this.FlowCate.FillDisableColor = System.Drawing.Color.White;
            this.FlowCate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.FlowCate.Location = new System.Drawing.Point(13, 12);
            this.FlowCate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FlowCate.MinimumSize = new System.Drawing.Size(1, 1);
            this.FlowCate.Name = "FlowCate";
            this.FlowCate.Padding = new System.Windows.Forms.Padding(2);
            this.FlowCate.RectColor = System.Drawing.Color.White;
            this.FlowCate.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.FlowCate.ScrollBarColor = System.Drawing.Color.Silver;
            this.FlowCate.ShowText = false;
            this.FlowCate.Size = new System.Drawing.Size(173, 535);
            this.FlowCate.Style = Sunny.UI.UIStyle.Custom;
            this.FlowCate.TabIndex = 0;
            this.FlowCate.Text = "uiFlowLayoutPanel1";
            this.FlowCate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlowPLPic
            // 
            this.FlowPLPic.BackColor = System.Drawing.Color.White;
            this.FlowPLPic.FillColor = System.Drawing.Color.White;
            this.FlowPLPic.FillColor2 = System.Drawing.Color.Silver;
            this.FlowPLPic.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.FlowPLPic.Location = new System.Drawing.Point(207, 69);
            this.FlowPLPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FlowPLPic.MinimumSize = new System.Drawing.Size(1, 1);
            this.FlowPLPic.Name = "FlowPLPic";
            this.FlowPLPic.Padding = new System.Windows.Forms.Padding(2);
            this.FlowPLPic.Radius = 10;
            this.FlowPLPic.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.FlowPLPic.RectSize = 2;
            this.FlowPLPic.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.FlowPLPic.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.FlowPLPic.ShowText = false;
            this.FlowPLPic.Size = new System.Drawing.Size(791, 480);
            this.FlowPLPic.Style = Sunny.UI.UIStyle.Custom;
            this.FlowPLPic.TabIndex = 2;
            this.FlowPLPic.Text = "uiFlowLayoutPanel3";
            this.FlowPLPic.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Controls.Add(this.btnSearch);
            this.uiPanel1.Controls.Add(this.searchtxt);
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.uiPanel1.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(194, 12);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.RectDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(974, 45);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 3;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSearch.Location = new System.Drawing.Point(374, 9);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RectColor = System.Drawing.Color.White;
            this.btnSearch.Size = new System.Drawing.Size(100, 29);
            this.btnSearch.Style = Sunny.UI.UIStyle.Custom;
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtxt.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchtxt.Location = new System.Drawing.Point(13, 9);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchtxt.MinimumSize = new System.Drawing.Size(1, 16);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Padding = new System.Windows.Forms.Padding(5);
            this.searchtxt.Radius = 10;
            this.searchtxt.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.searchtxt.RectSize = 2;
            this.searchtxt.ShowText = false;
            this.searchtxt.Size = new System.Drawing.Size(354, 29);
            this.searchtxt.Style = Sunny.UI.UIStyle.Custom;
            this.searchtxt.TabIndex = 0;
            this.searchtxt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchtxt.Watermark = "Search Item Name";
            // 
            // dgvitemlist
            // 
            this.dgvitemlist.AllowUserToAddRows = false;
            this.dgvitemlist.AllowUserToDeleteRows = false;
            this.dgvitemlist.AllowUserToResizeColumns = false;
            this.dgvitemlist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvitemlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvitemlist.BackgroundColor = System.Drawing.Color.White;
            this.dgvitemlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvitemlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvitemlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvitemlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvitemlist.ColumnHeadersHeight = 32;
            this.dgvitemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvitemlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.Qty,
            this.btndel});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvitemlist.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvitemlist.EnableHeadersVisualStyles = false;
            this.dgvitemlist.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dgvitemlist.GridColor = System.Drawing.Color.White;
            this.dgvitemlist.Location = new System.Drawing.Point(1020, 69);
            this.dgvitemlist.Name = "dgvitemlist";
            this.dgvitemlist.RectColor = System.Drawing.Color.White;
            this.dgvitemlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvitemlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvitemlist.RowHeadersVisible = false;
            this.dgvitemlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gray;
            this.dgvitemlist.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvitemlist.RowTemplate.Height = 24;
            this.dgvitemlist.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvitemlist.ScrollBarRectColor = System.Drawing.Color.Silver;
            this.dgvitemlist.SelectedIndex = -1;
            this.dgvitemlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitemlist.Size = new System.Drawing.Size(161, 402);
            this.dgvitemlist.StripeOddColor = System.Drawing.Color.White;
            this.dgvitemlist.Style = Sunny.UI.UIStyle.Custom;
            this.dgvitemlist.TabIndex = 4;
            this.dgvitemlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitemlist_CellClick);
            this.dgvitemlist.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvitemlist_CellValidating);
            // 
            // ItemID
            // 
            this.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Width = 74;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Qty.DefaultCellStyle = dataGridViewCellStyle3;
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 54;
            // 
            // btndel
            // 
            this.btndel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.btndel.HeaderText = "";
            this.btndel.Image = global::WindowsFormsApp1.Properties.Resources.trash__1_;
            this.btndel.MinimumWidth = 6;
            this.btndel.Name = "btndel";
            this.btndel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btndel.Width = 6;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnsubmit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnsubmit.FillHoverColor = System.Drawing.Color.DarkOrchid;
            this.btnsubmit.FillPressColor = System.Drawing.Color.DarkOrchid;
            this.btnsubmit.FillSelectedColor = System.Drawing.Color.DarkOrchid;
            this.btnsubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(1024, 514);
            this.btnsubmit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Radius = 10;
            this.btnsubmit.RectColor = System.Drawing.Color.White;
            this.btnsubmit.RectHoverColor = System.Drawing.Color.White;
            this.btnsubmit.RectPressColor = System.Drawing.Color.White;
            this.btnsubmit.RectSelectedColor = System.Drawing.Color.White;
            this.btnsubmit.Size = new System.Drawing.Size(148, 35);
            this.btnsubmit.Style = Sunny.UI.UIStyle.Custom;
            this.btnsubmit.TabIndex = 5;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::WindowsFormsApp1.Properties.Resources.trash__1_;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cbemerg
            // 
            this.cbemerg.AutoSize = true;
            this.cbemerg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbemerg.Location = new System.Drawing.Point(1024, 477);
            this.cbemerg.Name = "cbemerg";
            this.cbemerg.Size = new System.Drawing.Size(93, 21);
            this.cbemerg.TabIndex = 6;
            this.cbemerg.Text = "Emergency";
            this.cbemerg.UseVisualStyleBackColor = true;
            // 
            // Rest_request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1190, 561);
            this.Controls.Add(this.cbemerg);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.dgvitemlist);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.FlowPLPic);
            this.Controls.Add(this.FlowCate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rest_request";
            this.Text = "request";
            this.Load += new System.EventHandler(this.request_Load);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvitemlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIFlowLayoutPanel FlowCate;
        private Sunny.UI.UIFlowLayoutPanel FlowPLPic;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox searchtxt;
        private Sunny.UI.UIButton btnsubmit;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewImageColumn btndel;
        private Sunny.UI.UIDataGridView dgvitemlist;
        private Sunny.UI.UIButton btnSearch;
        private System.Windows.Forms.CheckBox cbemerg;
    }
}