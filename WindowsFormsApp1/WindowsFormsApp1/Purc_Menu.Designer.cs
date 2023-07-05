namespace WindowsFormsApp1
{
    partial class Purc_Menu
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
            this.btnsysdash = new System.Windows.Forms.Button();
            this.btninv = new System.Windows.Forms.Button();
            this.btnfinord = new System.Windows.Forms.Button();
            this.btnNfinord = new System.Windows.Forms.Button();
            this.btnBPA = new System.Windows.Forms.Button();
            this.btnCPA = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSupMana = new System.Windows.Forms.Button();
            this.btnStandardOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsysdash
            // 
            this.btnsysdash.BackColor = System.Drawing.Color.Transparent;
            this.btnsysdash.FlatAppearance.BorderSize = 0;
            this.btnsysdash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsysdash.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsysdash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsysdash.Location = new System.Drawing.Point(0, 34);
            this.btnsysdash.Margin = new System.Windows.Forms.Padding(2);
            this.btnsysdash.Name = "btnsysdash";
            this.btnsysdash.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnsysdash.Size = new System.Drawing.Size(200, 40);
            this.btnsysdash.TabIndex = 15;
            this.btnsysdash.Text = "Dashboard";
            this.btnsysdash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsysdash.UseVisualStyleBackColor = false;
            // 
            // btninv
            // 
            this.btninv.AutoSize = true;
            this.btninv.BackColor = System.Drawing.Color.Transparent;
            this.btninv.FlatAppearance.BorderSize = 0;
            this.btninv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btninv.Location = new System.Drawing.Point(-3, 217);
            this.btninv.Name = "btninv";
            this.btninv.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btninv.Size = new System.Drawing.Size(200, 40);
            this.btninv.TabIndex = 14;
            this.btninv.Text = "Inventory";
            this.btninv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninv.UseVisualStyleBackColor = false;
            this.btninv.Click += new System.EventHandler(this.btninv_Click);
            // 
            // btnfinord
            // 
            this.btnfinord.AutoSize = true;
            this.btnfinord.BackColor = System.Drawing.Color.Transparent;
            this.btnfinord.FlatAppearance.BorderSize = 0;
            this.btnfinord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfinord.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfinord.Location = new System.Drawing.Point(-3, 125);
            this.btnfinord.Name = "btnfinord";
            this.btnfinord.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnfinord.Size = new System.Drawing.Size(200, 40);
            this.btnfinord.TabIndex = 11;
            this.btnfinord.Text = "Finish Order";
            this.btnfinord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfinord.UseVisualStyleBackColor = false;
            this.btnfinord.Click += new System.EventHandler(this.btnfinord_Click);
            // 
            // btnNfinord
            // 
            this.btnNfinord.AutoSize = true;
            this.btnNfinord.BackColor = System.Drawing.Color.Transparent;
            this.btnNfinord.FlatAppearance.BorderSize = 0;
            this.btnNfinord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNfinord.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNfinord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNfinord.Location = new System.Drawing.Point(-3, 171);
            this.btnNfinord.Name = "btnNfinord";
            this.btnNfinord.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnNfinord.Size = new System.Drawing.Size(200, 40);
            this.btnNfinord.TabIndex = 13;
            this.btnNfinord.Text = "Not Finish Order";
            this.btnNfinord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNfinord.UseVisualStyleBackColor = false;
            this.btnNfinord.Click += new System.EventHandler(this.btnNfinord_Click);
            // 
            // btnBPA
            // 
            this.btnBPA.AutoSize = true;
            this.btnBPA.BackColor = System.Drawing.Color.Transparent;
            this.btnBPA.FlatAppearance.BorderSize = 0;
            this.btnBPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBPA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBPA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBPA.Location = new System.Drawing.Point(0, 263);
            this.btnBPA.Name = "btnBPA";
            this.btnBPA.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnBPA.Size = new System.Drawing.Size(227, 40);
            this.btnBPA.TabIndex = 16;
            this.btnBPA.Text = "BPA";
            this.btnBPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBPA.UseVisualStyleBackColor = false;
            this.btnBPA.Click += new System.EventHandler(this.btnBPA_Click);
            // 
            // btnCPA
            // 
            this.btnCPA.AutoSize = true;
            this.btnCPA.BackColor = System.Drawing.Color.Transparent;
            this.btnCPA.FlatAppearance.BorderSize = 0;
            this.btnCPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCPA.Location = new System.Drawing.Point(0, 309);
            this.btnCPA.Name = "btnCPA";
            this.btnCPA.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnCPA.Size = new System.Drawing.Size(200, 40);
            this.btnCPA.TabIndex = 17;
            this.btnCPA.Text = "CPA";
            this.btnCPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPA.UseVisualStyleBackColor = false;
            this.btnCPA.Click += new System.EventHandler(this.btnCPA_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSupMana
            // 
            this.btnSupMana.AutoSize = true;
            this.btnSupMana.BackColor = System.Drawing.Color.Transparent;
            this.btnSupMana.FlatAppearance.BorderSize = 0;
            this.btnSupMana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupMana.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupMana.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupMana.Location = new System.Drawing.Point(0, 355);
            this.btnSupMana.Name = "btnSupMana";
            this.btnSupMana.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSupMana.Size = new System.Drawing.Size(200, 40);
            this.btnSupMana.TabIndex = 18;
            this.btnSupMana.Text = "Supplier";
            this.btnSupMana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupMana.UseVisualStyleBackColor = false;
            this.btnSupMana.Click += new System.EventHandler(this.btnSupMana_Click);
            // 
            // btnStandardOrder
            // 
            this.btnStandardOrder.AutoSize = true;
            this.btnStandardOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnStandardOrder.FlatAppearance.BorderSize = 0;
            this.btnStandardOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStandardOrder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandardOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStandardOrder.Location = new System.Drawing.Point(-3, 79);
            this.btnStandardOrder.Name = "btnStandardOrder";
            this.btnStandardOrder.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnStandardOrder.Size = new System.Drawing.Size(200, 40);
            this.btnStandardOrder.TabIndex = 19;
            this.btnStandardOrder.Text = "Standard Purchase";
            this.btnStandardOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStandardOrder.UseVisualStyleBackColor = false;
            this.btnStandardOrder.Click += new System.EventHandler(this.btnStandardOrder_Click);
            // 
            // Purc_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnStandardOrder);
            this.Controls.Add(this.btnSupMana);
            this.Controls.Add(this.btnCPA);
            this.Controls.Add(this.btnBPA);
            this.Controls.Add(this.btnsysdash);
            this.Controls.Add(this.btninv);
            this.Controls.Add(this.btnfinord);
            this.Controls.Add(this.btnNfinord);
            this.Name = "Purc_Menu";
            this.Size = new System.Drawing.Size(200, 710);
            this.Load += new System.EventHandler(this.PurchaseMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsysdash;
        private System.Windows.Forms.Button btninv;
        private System.Windows.Forms.Button btnfinord;
        private System.Windows.Forms.Button btnNfinord;
        private System.Windows.Forms.Button btnBPA;
        private System.Windows.Forms.Button btnCPA;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSupMana;
        private System.Windows.Forms.Button btnStandardOrder;
    }
}
