using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP_MGM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboardcs_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private PictureBox MIN_btn;
        private PictureBox MAX_btn;
        private PictureBox Exit_btn;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.MIN_btn = new System.Windows.Forms.PictureBox();
            this.MAX_btn = new System.Windows.Forms.PictureBox();
            this.Exit_btn = new System.Windows.Forms.PictureBox();
            this.EMP_Salary_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EMP_Name_box = new System.Windows.Forms.TextBox();
            this.EMP_ID_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EMP_Dept_combobox = new System.Windows.Forms.ComboBox();
            this.EMP_Role_combobox = new System.Windows.Forms.ComboBox();
            this.EMP_ADD_btn = new System.Windows.Forms.Button();
            this.EMP_Print_btn = new System.Windows.Forms.Button();
            this.EMP_Search_btn = new System.Windows.Forms.Button();
            this.Search_EMP_box = new System.Windows.Forms.TextBox();
            this.EMP_SearchEmp = new System.Windows.Forms.Label();
            this.EMP_Delete_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EMP_Fetch_btn = new System.Windows.Forms.Button();
            this.EMP_Update_btn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MIN_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAX_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MIN_btn
            // 
            this.MIN_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MIN_btn.Image = ((System.Drawing.Image)(resources.GetObject("MIN_btn.Image")));
            this.MIN_btn.Location = new System.Drawing.Point(954, 12);
            this.MIN_btn.Name = "MIN_btn";
            this.MIN_btn.Size = new System.Drawing.Size(28, 30);
            this.MIN_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MIN_btn.TabIndex = 40;
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
            this.MAX_btn.TabIndex = 39;
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
            this.Exit_btn.TabIndex = 38;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // EMP_Salary_box
            // 
            this.EMP_Salary_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMP_Salary_box.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_Salary_box.Location = new System.Drawing.Point(46, 329);
            this.EMP_Salary_box.Name = "EMP_Salary_box";
            this.EMP_Salary_box.Size = new System.Drawing.Size(307, 27);
            this.EMP_Salary_box.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 49;
            this.label1.Text = "EMP_Salary";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 29);
            this.label5.TabIndex = 46;
            this.label5.Text = "EMP_Roles";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "EMP_Depatement";
            // 
            // EMP_Name_box
            // 
            this.EMP_Name_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMP_Name_box.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_Name_box.Location = new System.Drawing.Point(46, 229);
            this.EMP_Name_box.Name = "EMP_Name_box";
            this.EMP_Name_box.Size = new System.Drawing.Size(307, 27);
            this.EMP_Name_box.TabIndex = 44;
            // 
            // EMP_ID_box
            // 
            this.EMP_ID_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMP_ID_box.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_ID_box.Location = new System.Drawing.Point(46, 131);
            this.EMP_ID_box.Name = "EMP_ID_box";
            this.EMP_ID_box.Size = new System.Drawing.Size(307, 27);
            this.EMP_ID_box.TabIndex = 43;
            this.EMP_ID_box.TextChanged += new System.EventHandler(this.EMP_ID_box_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "EMP_Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 41;
            this.label3.Text = "EMP_ID";
            // 
            // EMP_Dept_combobox
            // 
            this.EMP_Dept_combobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMP_Dept_combobox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_Dept_combobox.FormattingEnabled = true;
            this.EMP_Dept_combobox.Items.AddRange(new object[] {
            "Development",
            "HR",
            "Managing Directors"});
            this.EMP_Dept_combobox.Location = new System.Drawing.Point(46, 441);
            this.EMP_Dept_combobox.Name = "EMP_Dept_combobox";
            this.EMP_Dept_combobox.Size = new System.Drawing.Size(307, 27);
            this.EMP_Dept_combobox.TabIndex = 51;
            // 
            // EMP_Role_combobox
            // 
            this.EMP_Role_combobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMP_Role_combobox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_Role_combobox.FormattingEnabled = true;
            this.EMP_Role_combobox.Items.AddRange(new object[] {
            "Senior Level",
            "Junior Level"});
            this.EMP_Role_combobox.Location = new System.Drawing.Point(46, 554);
            this.EMP_Role_combobox.Name = "EMP_Role_combobox";
            this.EMP_Role_combobox.Size = new System.Drawing.Size(307, 27);
            this.EMP_Role_combobox.TabIndex = 52;
            // 
            // EMP_ADD_btn
            // 
            this.EMP_ADD_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMP_ADD_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.EMP_ADD_btn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.EMP_ADD_btn.FlatAppearance.BorderSize = 2;
            this.EMP_ADD_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EMP_ADD_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_ADD_btn.ForeColor = System.Drawing.Color.White;
            this.EMP_ADD_btn.Location = new System.Drawing.Point(118, 621);
            this.EMP_ADD_btn.Name = "EMP_ADD_btn";
            this.EMP_ADD_btn.Size = new System.Drawing.Size(122, 33);
            this.EMP_ADD_btn.TabIndex = 53;
            this.EMP_ADD_btn.Text = "ADD";
            this.EMP_ADD_btn.UseVisualStyleBackColor = false;
            this.EMP_ADD_btn.Click += new System.EventHandler(this.EMP_ADD_btn_Click);
            // 
            // EMP_Print_btn
            // 
            this.EMP_Print_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMP_Print_btn.BackColor = System.Drawing.Color.White;
            this.EMP_Print_btn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.EMP_Print_btn.FlatAppearance.BorderSize = 2;
            this.EMP_Print_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EMP_Print_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_Print_btn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EMP_Print_btn.Location = new System.Drawing.Point(740, 621);
            this.EMP_Print_btn.Name = "EMP_Print_btn";
            this.EMP_Print_btn.Size = new System.Drawing.Size(122, 33);
            this.EMP_Print_btn.TabIndex = 56;
            this.EMP_Print_btn.Text = "PRINT";
            this.EMP_Print_btn.UseVisualStyleBackColor = false;
            this.EMP_Print_btn.Click += new System.EventHandler(this.EMP_Print_btn_Click);
            // 
            // EMP_Search_btn
            // 
            this.EMP_Search_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMP_Search_btn.BackColor = System.Drawing.Color.White;
            this.EMP_Search_btn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.EMP_Search_btn.FlatAppearance.BorderSize = 2;
            this.EMP_Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EMP_Search_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_Search_btn.ForeColor = System.Drawing.Color.Green;
            this.EMP_Search_btn.Location = new System.Drawing.Point(740, 127);
            this.EMP_Search_btn.Name = "EMP_Search_btn";
            this.EMP_Search_btn.Size = new System.Drawing.Size(122, 33);
            this.EMP_Search_btn.TabIndex = 57;
            this.EMP_Search_btn.Text = "SEARCH";
            this.EMP_Search_btn.UseVisualStyleBackColor = false;
            this.EMP_Search_btn.Click += new System.EventHandler(this.EMP_Search_btn_Click);
            // 
            // Search_EMP_box
            // 
            this.Search_EMP_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search_EMP_box.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_EMP_box.Location = new System.Drawing.Point(427, 131);
            this.Search_EMP_box.Name = "Search_EMP_box";
            this.Search_EMP_box.Size = new System.Drawing.Size(290, 27);
            this.Search_EMP_box.TabIndex = 58;
            this.Search_EMP_box.TextChanged += new System.EventHandler(this.Search_EMP_box_TextChanged);
            // 
            // EMP_SearchEmp
            // 
            this.EMP_SearchEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMP_SearchEmp.AutoSize = true;
            this.EMP_SearchEmp.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_SearchEmp.Location = new System.Drawing.Point(422, 88);
            this.EMP_SearchEmp.Name = "EMP_SearchEmp";
            this.EMP_SearchEmp.Size = new System.Drawing.Size(295, 29);
            this.EMP_SearchEmp.TabIndex = 59;
            this.EMP_SearchEmp.Text = "Search Employee Name";
            this.EMP_SearchEmp.Click += new System.EventHandler(this.EMP_SearchEmp_Click);
            // 
            // EMP_Delete_btn
            // 
            this.EMP_Delete_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMP_Delete_btn.BackColor = System.Drawing.Color.White;
            this.EMP_Delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.EMP_Delete_btn.FlatAppearance.BorderSize = 2;
            this.EMP_Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EMP_Delete_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_Delete_btn.ForeColor = System.Drawing.Color.Red;
            this.EMP_Delete_btn.Location = new System.Drawing.Point(894, 125);
            this.EMP_Delete_btn.Name = "EMP_Delete_btn";
            this.EMP_Delete_btn.Size = new System.Drawing.Size(122, 33);
            this.EMP_Delete_btn.TabIndex = 60;
            this.EMP_Delete_btn.Text = "DELETE";
            this.EMP_Delete_btn.UseVisualStyleBackColor = false;
            this.EMP_Delete_btn.Click += new System.EventHandler(this.EMP_Delete_btn_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(407, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 411);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Exit_btn);
            this.panel1.Controls.Add(this.MAX_btn);
            this.panel1.Controls.Add(this.MIN_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 62);
            this.panel1.TabIndex = 62;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.logout_btn.Location = new System.Drawing.Point(806, 10);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(113, 40);
            this.logout_btn.TabIndex = 64;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(422, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 29);
            this.label7.TabIndex = 63;
            this.label7.Text = "EMPLOYEES DETIALS";
            // 
            // EMP_Fetch_btn
            // 
            this.EMP_Fetch_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMP_Fetch_btn.BackColor = System.Drawing.Color.White;
            this.EMP_Fetch_btn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.EMP_Fetch_btn.FlatAppearance.BorderSize = 2;
            this.EMP_Fetch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EMP_Fetch_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_Fetch_btn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EMP_Fetch_btn.Location = new System.Drawing.Point(441, 621);
            this.EMP_Fetch_btn.Name = "EMP_Fetch_btn";
            this.EMP_Fetch_btn.Size = new System.Drawing.Size(122, 33);
            this.EMP_Fetch_btn.TabIndex = 63;
            this.EMP_Fetch_btn.Text = "FETCH";
            this.EMP_Fetch_btn.UseVisualStyleBackColor = false;
            this.EMP_Fetch_btn.Click += new System.EventHandler(this.EMP_Fetch_btn_Click_1);
            // 
            // EMP_Update_btn
            // 
            this.EMP_Update_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMP_Update_btn.BackColor = System.Drawing.Color.White;
            this.EMP_Update_btn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.EMP_Update_btn.FlatAppearance.BorderSize = 2;
            this.EMP_Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EMP_Update_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_Update_btn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EMP_Update_btn.Location = new System.Drawing.Point(595, 621);
            this.EMP_Update_btn.Name = "EMP_Update_btn";
            this.EMP_Update_btn.Size = new System.Drawing.Size(122, 33);
            this.EMP_Update_btn.TabIndex = 64;
            this.EMP_Update_btn.Text = "UPDATE";
            this.EMP_Update_btn.UseVisualStyleBackColor = false;
            this.EMP_Update_btn.Click += new System.EventHandler(this.EMP_Update_btn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(894, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 33);
            this.button1.TabIndex = 65;
            this.button1.Text = "Bonus";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 705);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EMP_Update_btn);
            this.Controls.Add(this.EMP_Fetch_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EMP_Delete_btn);
            this.Controls.Add(this.EMP_SearchEmp);
            this.Controls.Add(this.Search_EMP_box);
            this.Controls.Add(this.EMP_Search_btn);
            this.Controls.Add(this.EMP_Print_btn);
            this.Controls.Add(this.EMP_ADD_btn);
            this.Controls.Add(this.EMP_Role_combobox);
            this.Controls.Add(this.EMP_Dept_combobox);
            this.Controls.Add(this.EMP_Salary_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EMP_Name_box);
            this.Controls.Add(this.EMP_ID_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1082, 705);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MIN_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAX_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox EMP_Salary_box;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox EMP_Name_box;
        private TextBox EMP_ID_box;
        private Label label2;
        private Label label3;
        private ComboBox EMP_Dept_combobox;

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private ComboBox EMP_Role_combobox;
        private Button EMP_ADD_btn;
        private Button EMP_Print_btn;
        private Button EMP_Search_btn;
        private TextBox Search_EMP_box;
        private Label EMP_SearchEmp;
        private Button EMP_Delete_btn;
        private DataGridView dataGridView1;

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Panel panel1;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private Label label7;
        private Button logout_btn;
        private Button EMP_Fetch_btn;
        private Button EMP_Update_btn;
        private string sp_Search;

        private void EMP_ID_box_TextChanged(object sender, EventArgs e)
        {
        }

        private void EMP_SearchEmp_Click(object sender, EventArgs e)
        {

        }

        private void Search_EMP_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void EMP_ADD_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString =
                @"Data Source=MS;
                Initial Catalog=EMP_MGM1;
                Integrated Security=True;
                TrustServerCertificate=True";
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("sp_EMP_register1", Con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@EMP_ID", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = EMP_ID_box.Text.Trim();

                    SqlParameter p2 = new SqlParameter("@EMP_Name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = EMP_Name_box.Text.Trim();

                    SqlParameter p3 = new SqlParameter("@EMP_Salary", SqlDbType.VarChar);
                    cmd.Parameters.Add(p3).Value = EMP_Salary_box.Text.Trim();

                    SqlParameter p4 = new SqlParameter("@EMP_Dept", SqlDbType.VarChar);
                    cmd.Parameters.Add(p4).Value = EMP_Dept_combobox.SelectedItem.ToString();

                    SqlParameter p5 = new SqlParameter("@EMP_Role", SqlDbType.VarChar);
                    cmd.Parameters.Add(p5).Value = EMP_Role_combobox.SelectedItem.ToString();

                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                    {
                        MessageBox.Show("You have been Added.", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EMP_ID_box.Clear();
                        EMP_Name_box.Clear();
                        EMP_Salary_box.Clear();
                        EMP_Dept_combobox.SelectedIndex = -1;
                        EMP_Role_combobox.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EMP_Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Search1", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@Searchdata", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = Search_EMP_box.Text;
                    SqlDataAdapter SD = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    SD.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EMP_Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=MS;Initial Catalog=EMP_MGM1;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_Update", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@EMP_ID", SqlDbType.Int).Value = Convert.ToInt32(EMP_ID_box.Text);
                    cmd.Parameters.Add("@EMP_Name", SqlDbType.VarChar).Value = EMP_Name_box.Text;
                    cmd.Parameters.Add("@EMP_Salary", SqlDbType.VarChar).Value = EMP_Salary_box.Text;
                    cmd.Parameters.Add("@EMP_Dept", SqlDbType.VarChar).Value = EMP_Dept_combobox.Text;
                    cmd.Parameters.Add("@EMP_Role", SqlDbType.VarChar).Value = EMP_Role_combobox.Text;

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Employee Updated Successfully");
                    else
                        MessageBox.Show("Employee ID not found.");

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EMP_Fetch_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Fetch1", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter SD = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    SD.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Register reg = new Register(); if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                }
                reg.Show();
                this.Hide();
            }
            else
            {
                // Do nothing, user canceled the logout
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do nothing, user canceled the exit
            }
        }

        private void MAX_btn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MIN_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void EMP_Print_btn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void EMP_Delete_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=MS;Initial Catalog=EMP_MGM1;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_Delete", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@EMP_ID", SqlDbType.Int).Value =
                        Convert.ToInt32(Search_EMP_box.Text);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Employee Deleted Successfully");
                    else
                        MessageBox.Show("Employee ID not found.");

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
             Bitmap B = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(B, new Rectangle(0,0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(B, 120, 120);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                EMP_ID_box.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                EMP_Name_box.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                EMP_Salary_box.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                EMP_Dept_combobox.SelectedItem = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                EMP_Role_combobox.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Add this field to the Dashboard class to fix CS0103
        private readonly string connectionString = @"Data Source=MS;Initial Catalog=EMP_MGM1;Integrated Security=True;TrustServerCertificate=True";
        private Button button1;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Salary_Bonus b= new Salary_Bonus();
            b.Show();
        }
    }
}
