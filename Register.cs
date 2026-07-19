using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP_MGM
{
    public partial class Register : Form
    {
        private string EmailAddress;

        public Register()
        {
            InitializeComponent();
        }
        public bool IsEmailValid(string email)
            {
            string Pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            Regex r = new Regex(Pattern);
            return r.IsMatch(email);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = null; // Declare at the beginning of the method for broader scope
            try
            { 
                 if (reg_UName_tb.Text.Trim() != "" && reg_Pass_tb.Text.Trim() != "" && reg_CPass_tb.Text.Trim() != "" && reg_Email_tb.Text.Trim() != "" && reg_mobilenum_tb.Text.Trim() != "")
                 {  
                    string email = reg_Email_tb.Text.Trim();
                    bool isValid = IsEmailValid(email); // Use the correct variable here
                    if (isValid)
                    {
                        if (reg_Pass_tb.Text.Trim().Length >= 3)
                        {
                            if (reg_mobilenum_tb.Text.Trim().Length == 10)
                            {
                                if (reg_Pass_tb.Text.Trim() == reg_CPass_tb.Text.Trim())
                                {
                                    con = new SqlConnection(@"Data Source=MS;Initial Catalog=EMP_MGM1;Integrated Security=True");
                                    con.Open();
                                    SqlCommand cmd = new SqlCommand("sp_register1", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    SqlParameter p1 = new SqlParameter("@User_Name", SqlDbType.VarChar);
                                    cmd.Parameters.Add(p1).Value = reg_UName_tb.Text.Trim();

                                    SqlParameter p2 = new SqlParameter("@Password", SqlDbType.VarChar);
                                    cmd.Parameters.Add(p2).Value = reg_Pass_tb.Text.Trim();

                                    SqlParameter p3 = new SqlParameter("@CPassword", SqlDbType.VarChar);
                                    cmd.Parameters.Add(p3).Value = reg_CPass_tb.Text.Trim();

                                    SqlParameter p4 = new SqlParameter("@Email", SqlDbType.VarChar);
                                    cmd.Parameters.Add(p4).Value = reg_Email_tb.Text.Trim();

                                    SqlParameter p5 = new SqlParameter("@Mobile_Num", SqlDbType.VarChar);
                                    cmd.Parameters.Add(p5).Value = reg_mobilenum_tb.Text.Trim();

                                    int a = cmd.ExecuteNonQuery();

                                    if (a > 0)
                                    {
                                        MessageBox.Show("Registered Successfully");
                                            {
                                            MessageBox.Show(text: "Welcome "+reg_UName_tb.Text);
                                            login l = new login();
                                            l.Show();
                                            this.Hide();
                                            }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Registration Failed");
                                    }
                                    NewMethod();
                                }
                                else
                                {
                                    MessageBox.Show("Password and Confirm Password do not match.");
                                }                           
                            }
                            else
                            {
                                MessageBox.Show("Mobile number must be exactly 10 digits long.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must be at least 3 characters long.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid email address.");
                        return;
                    }
                 }
                 else
                 {
                    MessageBox.Show("Please fill all the Data's.");
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
                }
            }

            void NewMethod()
            {
                // No need to close connection here, handled in finally block
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void reg_login_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            reg_UName_tbclear();
            reg_Pass_tbclear();
            reg_CPass_tbclear();
            reg_Email_tbclear();
            reg_mobilenum_tbclear();
        }

        private void reg_UName_tbclear()
        {
            reg_UName_tb.Text = string.Empty;
        }

        private void reg_Pass_tbclear()
        {
            reg_Pass_tb.Text = string.Empty;
        }

        private void reg_CPass_tbclear()
        {
            reg_CPass_tb.Text = string.Empty;
        }

        private void reg_Email_tbclear()
        {
            reg_Email_tb.Text = string.Empty;
        }

        private void reg_mobilenum_tbclear()
        {
            reg_mobilenum_tb.Text = string.Empty;
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
            if(this.WindowState == FormWindowState.Normal)
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

        private void reg_UName_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_Pass_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_Email_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_CPass_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
