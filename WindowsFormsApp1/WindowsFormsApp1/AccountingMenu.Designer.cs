namespace WindowsFormsApp1
{
    partial class AccountingMenu
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
            this.btnlog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlog
            // 
            this.btnlog.FlatAppearance.BorderSize = 0;
            this.btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlog.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlog.Location = new System.Drawing.Point(0, 40);
            this.btnlog.Margin = new System.Windows.Forms.Padding(2);
            this.btnlog.Name = "btnlog";
            this.btnlog.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnlog.Size = new System.Drawing.Size(200, 40);
            this.btnlog.TabIndex = 5;
            this.btnlog.Text = "Log";
            this.btnlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlog.UseVisualStyleBackColor = true;
            // 
            // AccountingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnlog);
            this.Name = "AccountingMenu";
            this.Size = new System.Drawing.Size(200, 710);
            this.Load += new System.EventHandler(this.AccountingMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnlog;
    }
}