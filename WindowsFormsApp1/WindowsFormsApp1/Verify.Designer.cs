namespace WindowsFormsApp1
{
    partial class Verify
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
            this.txtChar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_vfysubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(236, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "resend verify code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtChar
            // 
            this.txtChar.Location = new System.Drawing.Point(54, 206);
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(162, 22);
            this.txtChar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "The verification code is typically a 6-digit number \r\nthat is sent to you via ema" +
    "il.";
            // 
            // btn_vfysubmit
            // 
            this.btn_vfysubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_vfysubmit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vfysubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_vfysubmit.Location = new System.Drawing.Point(150, 278);
            this.btn_vfysubmit.Name = "btn_vfysubmit";
            this.btn_vfysubmit.Size = new System.Drawing.Size(112, 43);
            this.btn_vfysubmit.TabIndex = 3;
            this.btn_vfysubmit.Text = "Submit";
            this.btn_vfysubmit.UseVisualStyleBackColor = false;
            this.btn_vfysubmit.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(163, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 377);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_vfysubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChar);
            this.Controls.Add(this.button1);
            this.Name = "Verify";
            this.Text = "Verify";
            this.Load += new System.EventHandler(this.Verify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_vfysubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}