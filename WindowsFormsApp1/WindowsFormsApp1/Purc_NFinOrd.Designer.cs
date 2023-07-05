namespace WindowsFormsApp1
{
    partial class Purc_NFinOrd
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
            this.pnlreqmap = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpurcitem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlreqmap
            // 
            this.pnlreqmap.AutoScroll = true;
            this.pnlreqmap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlreqmap.Location = new System.Drawing.Point(50, 130);
            this.pnlreqmap.Name = "pnlreqmap";
            this.pnlreqmap.Size = new System.Drawing.Size(1100, 550);
            this.pnlreqmap.TabIndex = 0;
            this.pnlreqmap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlreqmap_Paint);
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
            this.label1.TabIndex = 19;
            this.label1.Text = "Not Finish Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // btnpurcitem
            // 
            this.btnpurcitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnpurcitem.FlatAppearance.BorderSize = 0;
            this.btnpurcitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpurcitem.Image = global::WindowsFormsApp1.Properties.Resources.shopping_cart_add;
            this.btnpurcitem.Location = new System.Drawing.Point(1000, 85);
            this.btnpurcitem.Name = "btnpurcitem";
            this.btnpurcitem.Size = new System.Drawing.Size(150, 36);
            this.btnpurcitem.TabIndex = 1;
            this.btnpurcitem.UseVisualStyleBackColor = false;
            this.btnpurcitem.Click += new System.EventHandler(this.btnpurcitem_Click);
            // 
            // Purc_NFinOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpurcitem);
            this.Controls.Add(this.pnlreqmap);
            this.Name = "Purc_NFinOrd";
            this.Size = new System.Drawing.Size(1200, 710);
            this.Load += new System.EventHandler(this.Purc_NFinOrd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlreqmap;
        private System.Windows.Forms.Button btnpurcitem;
        private System.Windows.Forms.Label label1;
    }
}
