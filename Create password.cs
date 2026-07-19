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
using System.Xml.Linq;

namespace EMP_MGM
{
    public partial class Create_password : Form
    {
        public Create_password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void Create_password_Load(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                if (UName.Text.Trim() != "" && Password.Text.Trim() != "" && C_Password.Text.Trim() != "" )
                {
                    if (UName.Text.Trim() == "@reg_UName_tb.Text.Trim()")
                    {

                        if (Password.Text.Trim().Length >= 3)
                        {

                            if (Password.Text.Trim() == C_Password.Text.Trim())
                            {
                                con = new SqlConnection(@"Data Source=MS;Initial Catalog=EMP_MGM1;Integrated Security=True");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("sp_Create", con);
                                cmd.CommandType = CommandType.StoredProcedure;


                                SqlParameter p1 = new SqlParameter("@User_Name", SqlDbType.VarChar);
                                cmd.Parameters.Add(p1).Value = UName.Text.Trim();

                                SqlParameter p2 = new SqlParameter("@Password", SqlDbType.VarChar);
                                cmd.Parameters.Add(p2).Value = Password.Text.Trim();

                                SqlParameter p3 = new SqlParameter("@CPassword", SqlDbType.VarChar);
                                cmd.Parameters.Add(p3).Value = C_Password.Text.Trim();

                                int a = cmd.ExecuteNonQuery();

                                if (a > 0)
                                {
                                    MessageBox.Show("Password Created Successfully");
                                    {
                                        login l = new login();
                                        l.Show();
                                        this.Hide();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Password Creation Failed");
                                    UName.Text = string.Empty;
                                    Password.Text = string.Empty;
                                    C_Password.Text = string.Empty;

                                }
                            }
                            else
                            {
                                MessageBox.Show("Password and Confirm Password do not match.");
                                UName.Text = string.Empty;
                                Password.Text = string.Empty;
                                C_Password.Text = string.Empty;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must be at least 3 characters long.");
                            UName.Text = string.Empty;
                            Password.Text = string.Empty;
                            C_Password.Text = string.Empty;
                        }
                    }
                    else if (UName.Text.Trim() != "@reg_UName_tb.Text.Trim()")
                    {
                        MessageBox.Show("Please Enter Valid User Name.");
                        UName.Text = string.Empty;
                        Password.Text = string.Empty;
                        C_Password.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill Both Data's.");
                    UName.Text = string.Empty;
                    Password.Text = string.Empty;
                    C_Password.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                    UName.Text = string.Empty;
                    Password.Text = string.Empty;
                    C_Password.Text = string.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forgot_password fp = new Forgot_password();
            fp.Show();
            this.Hide();
        }

        private void reg_UName_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
