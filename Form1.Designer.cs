namespace EMP_MGM
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.login_txt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_UName_tb = new System.Windows.Forms.TextBox();
            this.Login_Pass_tb = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.C_Account_txt = new System.Windows.Forms.Label();
            this.reg_link = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.MIN_btn = new System.Windows.Forms.PictureBox();
            this.MAX_btn = new System.Windows.Forms.PictureBox();
            this.Exit_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MIN_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAX_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // login_txt
            // 
            this.login_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_txt.AutoSize = true;
            this.login_txt.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_txt.Location = new System.Drawing.Point(457, 136);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(175, 35);
            this.login_txt.TabIndex = 0;
            this.login_txt.Text = "Login page";
            this.login_txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Login_UName_tb
            // 
            this.Login_UName_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_UName_tb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_UName_tb.Location = new System.Drawing.Point(429, 251);
            this.Login_UName_tb.Name = "Login_UName_tb";
            this.Login_UName_tb.Size = new System.Drawing.Size(307, 27);
            this.Login_UName_tb.TabIndex = 4;
            this.Login_UName_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Login_Pass_tb
            // 
            this.Login_Pass_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_Pass_tb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Pass_tb.Location = new System.Drawing.Point(429, 310);
            this.Login_Pass_tb.Name = "Login_Pass_tb";
            this.Login_Pass_tb.PasswordChar = '*';
            this.Login_Pass_tb.Size = new System.Drawing.Size(307, 27);
            this.Login_Pass_tb.TabIndex = 6;
            this.Login_Pass_tb.TextChanged += new System.EventHandler(this.Login_Pass_tb_TextChanged);
            // 
            // login_btn
            // 
            this.login_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.login_btn.FlatAppearance.BorderSize = 2;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(429, 434);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(307, 33);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(426, 362);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 14);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot your password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // C_Account_txt
            // 
            this.C_Account_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.C_Account_txt.AutoSize = true;
            this.C_Account_txt.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Account_txt.Location = new System.Drawing.Point(425, 509);
            this.C_Account_txt.Name = "C_Account_txt";
            this.C_Account_txt.Size = new System.Drawing.Size(209, 23);
            this.C_Account_txt.TabIndex = 10;
            this.C_Account_txt.Text = "Don\'t have an Account?";
            // 
            // reg_link
            // 
            this.reg_link.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reg_link.AutoSize = true;
            this.reg_link.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.reg_link.LinkColor = System.Drawing.Color.Black;
            this.reg_link.Location = new System.Drawing.Point(640, 516);
            this.reg_link.Name = "reg_link";
            this.reg_link.Size = new System.Drawing.Size(72, 14);
            this.reg_link.TabIndex = 11;
            this.reg_link.TabStop = true;
            this.reg_link.Text = "Create Now";
            this.reg_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(634, 362);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // logout_btn
            // 
            this.logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logout_btn.BackColor = System.Drawing.Color.Crimson;
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.logout_btn.FlatAppearance.BorderSize = 2;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(839, 12);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(113, 40);
            this.logout_btn.TabIndex = 55;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // MIN_btn
            // 
            this.MIN_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MIN_btn.Image = ((System.Drawing.Image)(resources.GetObject("MIN_btn.Image")));
            this.MIN_btn.Location = new System.Drawing.Point(971, 12);
            this.MIN_btn.Name = "MIN_btn";
            this.MIN_btn.Size = new System.Drawing.Size(28, 30);
            this.MIN_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MIN_btn.TabIndex = 58;
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
            this.MAX_btn.TabIndex = 57;
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
            this.Exit_btn.TabIndex = 56;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 744);
            this.Controls.Add(this.MIN_btn);
            this.Controls.Add(this.MAX_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.reg_link);
            this.Controls.Add(this.C_Account_txt);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.Login_Pass_tb);
            this.Controls.Add(this.Login_UName_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_txt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MIN_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAX_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login_UName_tb;
        private System.Windows.Forms.TextBox Login_Pass_tb;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label C_Account_txt;
        private System.Windows.Forms.LinkLabel reg_link;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.PictureBox MIN_btn;
        private System.Windows.Forms.PictureBox MAX_btn;
        private System.Windows.Forms.PictureBox Exit_btn;
    }
}

