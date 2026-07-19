using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP_MGM
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login_UName_tb.Text.Trim() == "" || Login_Pass_tb.Text.Trim() == "")
                {
                    MessageBox.Show("Fill all Data's");
                }
                else if (Login_UName_tb.Text.Trim() == "Dashboard" && Login_Pass_tb.Text.Trim() == "Dashboard")
                {
                    MessageBox.Show("Welcome Back Admin");
                    Dashboard D = new Dashboard();
                    D.Show();
                    this.Hide();
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=MS;Initial Catalog=EMP_MGM1;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_login1", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@User_Name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = Login_UName_tb.Text.Trim();

                    SqlParameter p2 = new SqlParameter("@CPassword", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = Login_Pass_tb.Text.Trim();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    int a = Convert.ToInt32(ds.Tables[0].Rows.Count);
                    if (a > 0)
                    {
                        MessageBox.Show("Welcome Back "+ Login_UName_tb.Text);
                        Dashboard D = new Dashboard();
                        D.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User");
                    }
                    con.Close();
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_password FP = new Forgot_password();
            FP.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Login_Pass_tb.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes) {
                Register reg = new Register();
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
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MIN_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Pass_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

