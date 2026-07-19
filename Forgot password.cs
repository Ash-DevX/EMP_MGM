using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;   
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EMP_MGM
{
    public partial class Forgot_password : Form
    {
        private string randomcode;
        private SqlConnection Con; // Add this field

        public Forgot_password()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null; // Declare cmd at the start of the method
            try
            {

                if (name.Text.Trim() != "" && Email_Box.Text != "")
                {

                    if (name.Text.Trim() == "@reg_UName_tb.Text.Trim()" || Email_Box.Text == "@reg_Email_tb.Text.Trim()")
                    {
                        Con = new SqlConnection(@"Data Source=MS;Initial Catalog=EMP_MGM1;Integrated Security=True");
                        Con.Open();
                        cmd = new SqlCommand("sp_forgot", Con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter p1 = new SqlParameter("@User_Name", SqlDbType.VarChar);
                        cmd.Parameters.Add(p1).Value = name.Text.Trim();

                        Random random = new Random();
                        randomcode = random.Next(1000, 9999).ToString();
                        String to, from, pass, messagebody;
                        MailMessage Message = new MailMessage();
                        to = (Email_Box.Text).ToString();
                        from = "ashwinelums@gmail.com";
                        //app password for the email account used to send the email (important: do not delete password)
                        pass = "zsvr dakr gqsz dcwi";
                        messagebody = "Your password reset code is " + randomcode;
                        Message.To.Add(to);
                        Message.From = new MailAddress(from);
                        Message.Body = messagebody;
                        Message.Subject = "Employee Management Verification";

                        //network credentials for sending the email
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(from, pass);
                        smtp.Send(Message);
                        MessageBox.Show("OTP Sended Successfully");
                        Con.Close();
                    }

                    else if (name.Text.Trim() != "@reg_UName_tb.Text.Trim()" || Email_Box.Text != "@reg_Email_tb.Text.Trim()")
                    {
                        MessageBox.Show("Invalid User Name or Email");
                        return;
                    }

                }

                    else
                    {
                        MessageBox.Show("Please enter a data's");
                        return;
                    }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (Con != null && Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void Forgot_password_Load(object sender, EventArgs e)
        {

        }

        private void Verify_OTP_Click(object sender, EventArgs e)
        {
            if (randomcode == (OTP_BOX.Text).ToString())
            {
                MessageBox.Show("OTP Verified Successfully");
                Create_password cp = new Create_password();
                cp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.");
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Email_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
