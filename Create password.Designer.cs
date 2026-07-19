namespace EMP_MGM
{
    partial class Create_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_password));
            this.C_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MIN_btn = new System.Windows.Forms.PictureBox();
            this.MAX_btn = new System.Windows.Forms.PictureBox();
            this.Exit_btn = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.UName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MIN_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAX_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // C_Password
            // 
            this.C_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.C_Password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Password.Location = new System.Drawing.Point(450, 390);
            this.C_Password.Name = "C_Password";
            this.C_Password.Size = new System.Drawing.Size(307, 27);
            this.C_Password.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Conform Password";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(450, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 33);
            this.button1.TabIndex = 31;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(450, 318);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(307, 27);
            this.Password.TabIndex = 30;
            this.Password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "Create New Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MIN_btn
            // 
            this.MIN_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MIN_btn.Image = ((System.Drawing.Image)(resources.GetObject("MIN_btn.Image")));
            this.MIN_btn.Location = new System.Drawing.Point(955, 12);
            this.MIN_btn.Name = "MIN_btn";
            this.MIN_btn.Size = new System.Drawing.Size(28, 30);
            this.MIN_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MIN_btn.TabIndex = 37;
            this.MIN_btn.TabStop = false;
            this.MIN_btn.Click += new System.EventHandler(this.MIN_btn_Click);
            // 
            // MAX_btn
            // 
            this.MAX_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MAX_btn.Image = ((System.Drawing.Image)(resources.GetObject("MAX_btn.Image")));
            this.MAX_btn.Location = new System.Drawing.Point(998, 12);
            this.MAX_btn.Name = "MAX_btn";
            this.MAX_btn.Size = new System.Drawing.Size(28, 30);
            this.MAX_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MAX_btn.TabIndex = 36;
            this.MAX_btn.TabStop = false;
            this.MAX_btn.Click += new System.EventHandler(this.MAX_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(1042, 12);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(28, 30);
            this.Exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit_btn.TabIndex = 35;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
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
            this.button2.TabIndex = 56;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UName
            // 
            this.UName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UName.Location = new System.Drawing.Point(450, 254);
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(307, 27);
            this.UName.TabIndex = 58;
            this.UName.TextChanged += new System.EventHandler(this.reg_UName_tb_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 57;
            this.label3.Text = "User Name";
            // 
            // Create_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 705);
            this.Controls.Add(this.UName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MIN_btn);
            this.Controls.Add(this.MAX_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.C_Password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Create_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Create_password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MIN_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAX_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox C_Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MIN_btn;
        private System.Windows.Forms.PictureBox MAX_btn;
        private System.Windows.Forms.PictureBox Exit_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox UName;
        private System.Windows.Forms.Label label3;
    }
}