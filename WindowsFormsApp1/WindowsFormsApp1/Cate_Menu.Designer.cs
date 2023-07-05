namespace WindowsFormsApp1
{
    partial class Cate_Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnsysdash = new System.Windows.Forms.Button();
            this.btnmap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Item management";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsysdash
            // 
            this.btnsysdash.BackColor = System.Drawing.Color.Transparent;
            this.btnsysdash.FlatAppearance.BorderSize = 0;
            this.btnsysdash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsysdash.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsysdash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsysdash.Location = new System.Drawing.Point(0, 40);
            this.btnsysdash.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsysdash.Name = "btnsysdash";
            this.btnsysdash.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnsysdash.Size = new System.Drawing.Size(200, 40);
            this.btnsysdash.TabIndex = 4;
            this.btnsysdash.Text = "Dashboard";
            this.btnsysdash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsysdash.UseVisualStyleBackColor = false;
            // 
            // btnmap
            // 
            this.btnmap.AutoSize = true;
            this.btnmap.BackColor = System.Drawing.Color.Transparent;
            this.btnmap.FlatAppearance.BorderSize = 0;
            this.btnmap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmap.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmap.Location = new System.Drawing.Point(0, 140);
            this.btnmap.Margin = new System.Windows.Forms.Padding(4);
            this.btnmap.Name = "btnmap";
            this.btnmap.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnmap.Size = new System.Drawing.Size(200, 40);
            this.btnmap.TabIndex = 5;
            this.btnmap.Text = "Item mapping";
            this.btnmap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmap.UseVisualStyleBackColor = false;
            this.btnmap.Click += new System.EventHandler(this.btnmap_Click);
            // 
            // Cate_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnmap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsysdash);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cate_Menu";
            this.Size = new System.Drawing.Size(200, 710);
            this.Load += new System.EventHandler(this.CategoryMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsysdash;
        private System.Windows.Forms.Button btnmap;
    }
}