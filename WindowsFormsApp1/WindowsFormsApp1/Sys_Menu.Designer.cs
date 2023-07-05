namespace WindowsFormsApp1
{
    partial class Sys_Menu
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
            this.btnsysdash = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.btnsysac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsysdash
            // 
            this.btnsysdash.BackColor = System.Drawing.Color.Transparent;
            this.btnsysdash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsysdash.FlatAppearance.BorderSize = 0;
            this.btnsysdash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsysdash.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsysdash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsysdash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsysdash.Location = new System.Drawing.Point(0, 40);
            this.btnsysdash.Margin = new System.Windows.Forms.Padding(2);
            this.btnsysdash.Name = "btnsysdash";
            this.btnsysdash.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnsysdash.Size = new System.Drawing.Size(200, 40);
            this.btnsysdash.TabIndex = 0;
            this.btnsysdash.Text = "Dashboard";
            this.btnsysdash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsysdash.UseVisualStyleBackColor = false;
            // 
            // btnlog
            // 
            this.btnlog.FlatAppearance.BorderSize = 0;
            this.btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlog.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlog.Location = new System.Drawing.Point(0, 140);
            this.btnlog.Margin = new System.Windows.Forms.Padding(2);
            this.btnlog.Name = "btnlog";
            this.btnlog.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnlog.Size = new System.Drawing.Size(200, 40);
            this.btnlog.TabIndex = 2;
            this.btnlog.Text = "Log";
            this.btnlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // btnsysac
            // 
            this.btnsysac.FlatAppearance.BorderSize = 0;
            this.btnsysac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsysac.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsysac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsysac.Location = new System.Drawing.Point(0, 90);
            this.btnsysac.Margin = new System.Windows.Forms.Padding(2);
            this.btnsysac.Name = "btnsysac";
            this.btnsysac.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnsysac.Size = new System.Drawing.Size(200, 40);
            this.btnsysac.TabIndex = 4;
            this.btnsysac.Text = "Account";
            this.btnsysac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsysac.UseVisualStyleBackColor = true;
            this.btnsysac.Click += new System.EventHandler(this.btnsysac_Click_1);
            // 
            // SystemMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnsysac);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.btnsysdash);
            this.Name = "SystemMenu";
            this.Size = new System.Drawing.Size(200, 710);
            this.Load += new System.EventHandler(this.SystemMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsysdash;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btnsysac;
    }
}
