namespace EMP_MGM
{
    partial class Forgot_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_password));
            this.label1 = new System.Windows.Forms.Label();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OTP_BOX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Verify_OTP = new System.Windows.Forms.Button();
            this.Send_OTP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MIN_btn = new System.Windows.Forms.PictureBox();
            this.MAX_btn = new System.Windows.Forms.PictureBox();
            this.Exit_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MIN_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAX_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email verification";
            // 
            // Email_Box
            // 
            this.Email_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email_Box.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Box.Location = new System.Drawing.Point(353, 312);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(343, 27);
            this.Email_Box.TabIndex = 50;
            this.Email_Box.TextChanged += new System.EventHandler(this.Email_Box_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 29);
            this.label7.TabIndex = 49;
            this.label7.Text = "Enter Registered Email";
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(353, 218);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(343, 27);
            this.name.TabIndex = 48;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "User Name";
            // 
            // OTP_BOX
            // 
            this.OTP_BOX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OTP_BOX.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTP_BOX.Location = new System.Drawing.Point(353, 478);
            this.OTP_BOX.Name = "OTP_BOX";
            this.OTP_BOX.Size = new System.Drawing.Size(343, 27);
            this.OTP_BOX.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 51;
            this.label4.Text = "Enter OTP";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Verify_OTP
            // 
            this.Verify_OTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Verify_OTP.BackColor = System.Drawing.Color.DodgerBlue;
            this.Verify_OTP.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Verify_OTP.FlatAppearance.BorderSize = 2;
            this.Verify_OTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Verify_OTP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verify_OTP.ForeColor = System.Drawing.Color.White;
            this.Verify_OTP.Location = new System.Drawing.Point(583, 533);
            this.Verify_OTP.Name = "Verify_OTP";
            this.Verify_OTP.Size = new System.Drawing.Size(113, 40);
            this.Verify_OTP.TabIndex = 53;
            this.Verify_OTP.Text = "VERIFY OTP";
            this.Verify_OTP.UseVisualStyleBackColor = false;
            this.Verify_OTP.Click += new System.EventHandler(this.Verify_OTP_Click);
            // 
            // Send_OTP
            // 
            this.Send_OTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Send_OTP.BackColor = System.Drawing.Color.DodgerBlue;
            this.Send_OTP.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Send_OTP.FlatAppearance.BorderSize = 2;
            this.Send_OTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_OTP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_OTP.ForeColor = System.Drawing.Color.White;
            this.Send_OTP.Location = new System.Drawing.Point(583, 363);
            this.Send_OTP.Name = "Send_OTP";
            this.Send_OTP.Size = new System.Drawing.Size(113, 40);
            this.Send_OTP.TabIndex = 54;
            this.Send_OTP.Text = "SEND OTP";
            this.Send_OTP.UseVisualStyleBackColor = false;
            this.Send_OTP.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 40);
            this.button2.TabIndex = 55;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MIN_btn
            // 
            this.MIN_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MIN_btn.Image = ((System.Drawing.Image)(resources.GetObject("MIN_btn.Image")));
            this.MIN_btn.Location = new System.Drawing.Point(971, 12);
            this.MIN_btn.Name = "MIN_btn";
            this.MIN_btn.Size = new System.Drawing.Size(28, 30);
            this.MIN_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MIN_btn.TabIndex = 61;
            this.MIN_btn.TabStop = false;
            this.MIN_btn.Click += new System.EventHandler(this.MIN_btn_Click);
            // 
            // MAX_btn
            // 
            this.MAX_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MAX_btn.Image = ((System.Drawing.Image)(resources.GetObject("MAX_btn.Image")));
            this.MAX_btn.Location = new System.Drawing.Point(1014, 12);
            this.MAX_btn.Name = "MAX_btn";
            this.MAX_btn.Size = new System.Drawing.Size(28, 30);
            this.MAX_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MAX_btn.TabIndex = 60;
            this.MAX_btn.TabStop = false;
            this.MAX_btn.Click += new System.EventHandler(this.MAX_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(1058, 12);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(28, 30);
            this.Exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit_btn.TabIndex = 59;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Forgot_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 744);
            this.Controls.Add(this.MIN_btn);
            this.Controls.Add(this.MAX_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Send_OTP);
            this.Controls.Add(this.Verify_OTP);
            this.Controls.Add(this.OTP_BOX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email_Box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forgot_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot_password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Forgot_password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MIN_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAX_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OTP_BOX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Verify_OTP;
        private System.Windows.Forms.Button Send_OTP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox MIN_btn;
        private System.Windows.Forms.PictureBox MAX_btn;
        private System.Windows.Forms.PictureBox Exit_btn;
    }
}