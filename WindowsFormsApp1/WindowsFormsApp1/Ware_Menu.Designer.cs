namespace WindowsFormsApp1
{
    partial class Ware_Menu
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
            this.btnordhis = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.btnsysdash = new System.Windows.Forms.Button();
            this.btndeliord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnordhis
            // 
            this.btnordhis.AutoSize = true;
            this.btnordhis.BackColor = System.Drawing.Color.Transparent;
            this.btnordhis.FlatAppearance.BorderSize = 0;
            this.btnordhis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnordhis.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnordhis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnordhis.Location = new System.Drawing.Point(0, 140);
            this.btnordhis.Name = "btnordhis";
            this.btnordhis.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnordhis.Size = new System.Drawing.Size(200, 40);
            this.btnordhis.TabIndex = 2;
            this.btnordhis.Text = "PO Sign";
            this.btnordhis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnordhis.UseVisualStyleBackColor = false;
            this.btnordhis.Click += new System.EventHandler(this.btnordhis_Click);
            // 
            // btnInv
            // 
            this.btnInv.AutoSize = true;
            this.btnInv.BackColor = System.Drawing.Color.Transparent;
            this.btnInv.FlatAppearance.BorderSize = 0;
            this.btnInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInv.Location = new System.Drawing.Point(0, 90);
            this.btnInv.Name = "btnInv";
            this.btnInv.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnInv.Size = new System.Drawing.Size(200, 40);
            this.btnInv.TabIndex = 2;
            this.btnInv.Text = "Inventory";
            this.btnInv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInv.UseVisualStyleBackColor = false;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // btnsysdash
            // 
            this.btnsysdash.BackColor = System.Drawing.Color.Transparent;
            this.btnsysdash.FlatAppearance.BorderSize = 0;
            this.btnsysdash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsysdash.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsysdash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsysdash.Location = new System.Drawing.Point(0, 40);
            this.btnsysdash.Margin = new System.Windows.Forms.Padding(2);
            this.btnsysdash.Name = "btnsysdash";
            this.btnsysdash.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnsysdash.Size = new System.Drawing.Size(200, 40);
            this.btnsysdash.TabIndex = 10;
            this.btnsysdash.Text = "Dashboard";
            this.btnsysdash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsysdash.UseVisualStyleBackColor = false;
            // 
            // btndeliord
            // 
            this.btndeliord.AutoSize = true;
            this.btndeliord.BackColor = System.Drawing.Color.Transparent;
            this.btndeliord.FlatAppearance.BorderSize = 0;
            this.btndeliord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeliord.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeliord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndeliord.Location = new System.Drawing.Point(0, 190);
            this.btndeliord.Name = "btndeliord";
            this.btndeliord.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btndeliord.Size = new System.Drawing.Size(200, 40);
            this.btndeliord.TabIndex = 11;
            this.btndeliord.Text = "Delivery Order";
            this.btndeliord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeliord.UseVisualStyleBackColor = false;
            this.btndeliord.Click += new System.EventHandler(this.btndeliord_Click);
            // 
            // Ware_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btndeliord);
            this.Controls.Add(this.btnsysdash);
            this.Controls.Add(this.btnordhis);
            this.Controls.Add(this.btnInv);
            this.Name = "Ware_Menu";
            this.Size = new System.Drawing.Size(200, 710);
            this.Load += new System.EventHandler(this.WarehouseMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnordhis;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Button btnsysdash;
        private System.Windows.Forms.Button btndeliord;
    }
}