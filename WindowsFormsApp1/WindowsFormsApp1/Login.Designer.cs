namespace WindowsFormsApp1
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnfillIT = new System.Windows.Forms.Button();
            this.btnfillCate = new System.Windows.Forms.Button();
            this.btnfillRest = new System.Windows.Forms.Button();
            this.btnfillWare = new System.Windows.Forms.Button();
            this.btnfillAcc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPurc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login1
            // 
            this.Login1.AutoSize = true;
            this.Login1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login1.Location = new System.Drawing.Point(493, 36);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(533, 32);
            this.Login1.TabIndex = 0;
            this.Login1.Text = "Yummy Restaurant Procurement System";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(736, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 26);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(736, 244);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(221, 26);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(805, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Forget Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(664, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "KIONG_Clay_Pot_Rices_is_a_chef_using_chopstickcute_yummy_restau_89e6c19a-9dd3-4c7" +
        "3-9684-af005bbd87a1.png");
            this.imageList1.Images.SetKeyName(1, "user.png");
            this.imageList1.Images.SetKeyName(2, "key.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(617, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "StaffID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(617, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(0, -1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 596);
            this.label3.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.BlueViolet;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.IMAGE;
            this.pictureBox1.Location = new System.Drawing.Point(37, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnfillIT
            // 
            this.btnfillIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnfillIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfillIT.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfillIT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfillIT.Location = new System.Drawing.Point(501, 535);
            this.btnfillIT.Name = "btnfillIT";
            this.btnfillIT.Size = new System.Drawing.Size(171, 35);
            this.btnfillIT.TabIndex = 11;
            this.btnfillIT.Text = "IT";
            this.btnfillIT.UseVisualStyleBackColor = false;
            this.btnfillIT.Click += new System.EventHandler(this.btnfill_Click);
            // 
            // btnfillCate
            // 
            this.btnfillCate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnfillCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfillCate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfillCate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfillCate.Location = new System.Drawing.Point(855, 535);
            this.btnfillCate.Name = "btnfillCate";
            this.btnfillCate.Size = new System.Drawing.Size(172, 35);
            this.btnfillCate.TabIndex = 12;
            this.btnfillCate.Text = "Category";
            this.btnfillCate.UseVisualStyleBackColor = false;
            this.btnfillCate.Click += new System.EventHandler(this.btnfillCate_Click);
            // 
            // btnfillRest
            // 
            this.btnfillRest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnfillRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfillRest.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfillRest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfillRest.Location = new System.Drawing.Point(855, 495);
            this.btnfillRest.Name = "btnfillRest";
            this.btnfillRest.Size = new System.Drawing.Size(172, 35);
            this.btnfillRest.TabIndex = 13;
            this.btnfillRest.Text = "Restaurant";
            this.btnfillRest.UseVisualStyleBackColor = false;
            this.btnfillRest.Click += new System.EventHandler(this.btnfillRest_Click);
            // 
            // btnfillWare
            // 
            this.btnfillWare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnfillWare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfillWare.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfillWare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfillWare.Location = new System.Drawing.Point(677, 535);
            this.btnfillWare.Name = "btnfillWare";
            this.btnfillWare.Size = new System.Drawing.Size(172, 35);
            this.btnfillWare.TabIndex = 13;
            this.btnfillWare.Text = "Warehourse";
            this.btnfillWare.UseVisualStyleBackColor = false;
            this.btnfillWare.Click += new System.EventHandler(this.btnfillWare_Click);
            // 
            // btnfillAcc
            // 
            this.btnfillAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnfillAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfillAcc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfillAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfillAcc.Location = new System.Drawing.Point(677, 495);
            this.btnfillAcc.Name = "btnfillAcc";
            this.btnfillAcc.Size = new System.Drawing.Size(172, 35);
            this.btnfillAcc.TabIndex = 13;
            this.btnfillAcc.Text = "Accounting";
            this.btnfillAcc.UseVisualStyleBackColor = false;
            this.btnfillAcc.Click += new System.EventHandler(this.btnfillAcc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(493, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quick Login";
            // 
            // btnPurc
            // 
            this.btnPurc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(255)))));
            this.btnPurc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPurc.Location = new System.Drawing.Point(500, 495);
            this.btnPurc.Name = "btnPurc";
            this.btnPurc.Size = new System.Drawing.Size(172, 35);
            this.btnPurc.TabIndex = 15;
            this.btnPurc.Text = "Purchase";
            this.btnPurc.UseVisualStyleBackColor = false;
            this.btnPurc.Click += new System.EventHandler(this.btnPurc_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1048, 593);
            this.Controls.Add(this.btnPurc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnfillAcc);
            this.Controls.Add(this.btnfillWare);
            this.Controls.Add(this.btnfillRest);
            this.Controls.Add(this.btnfillCate);
            this.Controls.Add(this.btnfillIT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Login1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnfillIT;
        private System.Windows.Forms.Button btnfillCate;
        private System.Windows.Forms.Button btnfillRest;
        private System.Windows.Forms.Button btnfillWare;
        private System.Windows.Forms.Button btnfillAcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPurc;
    }
}

