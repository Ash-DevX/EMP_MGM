using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP_MGM
{
    public partial class Salary_Bonus : Form
    {
        public string Total_Salary;
        public Salary_Bonus()
        {
            InitializeComponent();
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

        private void MIN_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void Managers_radio_CheckedChanged(object sender, EventArgs e)
        {
            Managers_radio.ForeColor = Color.Green;
            Employees_radio.ForeColor = Color.Red;


            comboBox1.Items.Clear();

            comboBox1.Items.Add("Jeevitha");
            comboBox1.Items.Add("Kowshika");

        }

        private void Employees_radio_CheckedChanged(object sender, EventArgs e)
        {
            Managers_radio.ForeColor = Color.Red;
            Employees_radio.ForeColor = Color.Green;

            comboBox1.Items.Clear();

            comboBox1.Items.Add("Lokesh");
            comboBox1.Items.Add("Ashwin");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Jeevitha")
                    textBox1.Text = "50000";
                else if (comboBox1.Text == "Kowshika")
                    textBox1.Text = "45000";
                else if (comboBox1.Text == "Lokesh")
                    textBox1.Text = "30000";
                else if (comboBox1.Text == "Ashwin")
                    textBox1.Text = "25000";
                else
                {
                    textBox1.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            {
                // treat empty as zero or bail out depending on desired UX
                var sText = textBox1.Text?.Trim();
                var bText = textBox2.Text?.Trim();

                // try integer first, then decimal if you expect fractions
                if (int.TryParse(sText, NumberStyles.Integer, CultureInfo.InvariantCulture, out int salary)
                    && int.TryParse(bText, NumberStyles.Integer, CultureInfo.InvariantCulture, out int bonus))
                {
                    textBox3.Text = (salary + bonus).ToString(CultureInfo.InvariantCulture);
                    return;
                }

                // fallback: try decimal (handles "100.50" or culture-specific formats)
                if (decimal.TryParse(sText, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal dSalary)
                    && decimal.TryParse(bText, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal dBonus))
                {
                    textBox3.Text = (dSalary + dBonus).ToString(CultureInfo.CurrentCulture);
                    return;
                }

                // invalid input: clear result or show message as appropriate
                textBox3.Text = string.Empty;
            }
        }

        //public void textBox2_TextChanged(object sender, EventArgs e, string value)
        //{
        //    try
        //    {
        //        if (comboBox1.SelectedItem != null)
        //        {
        //            // Fix: Compare textBox4.Text (as number) with value (as number)
        //            if (decimal.TryParse(textBox4.Text, out decimal Value) && decimal.TryParse(value, out decimal minValue))
        //            {
        //                if (Value < 35)
        //                {
        //                    MessageBox.Show("Day should be greater than or equal to " + value);
        //                    textBox2.Clear();
        //                    return;
        //                }
        //            }
        //            string selectedEmployee = comboBox1.SelectedItem.ToString();
        //            decimal salary = 0;
        //            switch (selectedEmployee)
        //            {
        //                case "Jeevitha":
        //                    salary = 50000;
        //                    break;
        //                case "Kowshika":
        //                    salary = 45000;
        //                    break;
        //                case "Lokesh":
        //                    salary = 30000;
        //                    break;
        //                case "Ashwin":
        //                    salary = 25000;
        //                    break;
        //            }
        //            if (float.TryParse(textBox2.Text, out float bonus))
        //            {
        //                decimal finalSalary = salary + (decimal)bonus;
        //                textBox3.Text = "Rs. " + finalSalary.ToString();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message);
        //    }
        //}

        public void textBox1_TextChanged(object sender, EventArgs e)
        { 
        }

        private void EMP_ADD_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    if (!float.TryParse(textBox4.Text, out float Value))
                    {
                        MessageBox.Show("Please enter a correct date.");
                        textBox4.Clear();
                        return;
                    }
                    if (Value < 35)
                    {
                        MessageBox.Show("Bonus should be greater than or equal to 35.");
                        textBox4.Clear();
                        return;
                    }
                    if (comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Select Employee");
                        return;
                    }

                    float salary;
                    float bonus;
                    float totalSalary;

                    if (!float.TryParse(textBox1.Text.Trim(), out salary))
                    {
                        MessageBox.Show("Invalid Salary");
                        return;
                    }

                    if (!float.TryParse(textBox2.Text.Trim(), out bonus))
                    {
                        MessageBox.Show("Invalid Bonus");
                        return;
                    }

                    if (float.TryParse(textBox3.Text.Trim(), out totalSalary))
                    {
                        MessageBox.Show("Invalid Total Salary");
                        return;
                    }

                    string cs = @"Data Source=MS;
                      Initial Catalog=EMP_MGM1;
                      Integrated Security=True;
                      TrustServerCertificate=True";

                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("sp_Salary", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = comboBox1.Text;
                        cmd.Parameters.Add("@Salary", SqlDbType.Float).Value = salary;
                        cmd.Parameters.Add("@Bonus", SqlDbType.Float).Value = bonus;
                        cmd.Parameters.Add("@Total_Salary", SqlDbType.Float).Value = totalSalary;

                        int i = cmd.ExecuteNonQuery();

                        if (i > 0)
                        {
                            MessageBox.Show("Salary Added Successfully");

                            comboBox1.SelectedIndex = -1;
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                
        

        private void EMP_Fetch_btn_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("sp_Salary_Fetch", Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter SD = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    SD.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void TextBox3_TextChanged(object sender, EventArgs e, string value)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    // Fix: Compare textBox4.Text (as number) with value (as number)
                    if (decimal.TryParse(textBox4.Text, out decimal Value) && decimal.TryParse(value, out decimal minValue))
                    {
                        if (Value < 35)
                        {
                            MessageBox.Show("Day should be greater than or equal to " + value);
                            textBox2.Clear();
                            return;
                        }
                    }
                    string selectedEmployee = comboBox1.SelectedItem.ToString();
                    decimal salary = 0;
                    switch (selectedEmployee)
                    {
                        case "Jeevitha":
                            salary = 50000;
                            break;
                        case "Kowshika":
                            salary = 45000;
                            break;
                        case "Lokesh":
                            salary = 30000;
                            break;
                        case "Ashwin":
                            salary = 25000;
                            break;
                    }
                    if (float.TryParse(textBox2.Text, out float bonus))
                    {
                        decimal finalSalary = salary + (decimal)bonus;
                        textBox3.Text = "Rs. " + finalSalary.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        

        private void textBox3_TextChanged(object sender, EventArgs e, string value)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    // Fix: Compare textBox4.Text (as number) with value (as number)
                    if (decimal.TryParse(textBox4.Text, out decimal Value) && decimal.TryParse(value, out decimal minValue))
                    {
                        if (Value < 35)
                        {
                            MessageBox.Show("Day should be greater than or equal to " + value);
                            textBox2.Clear();
                            return;
                        }
                    }
                    string selectedEmployee = comboBox1.SelectedItem.ToString();
                    decimal salary = 0;
                    switch (selectedEmployee)
                    {
                        case "Jeevitha":
                            salary = 50000;
                            break;
                        case "Kowshika":
                            salary = 45000;
                            break;
                        case "Lokesh":
                            salary = 30000;
                            break;
                        case "Ashwin":
                            salary = 25000;
                            break;
                    }
                    if (float.TryParse(textBox2.Text, out float bonus))
                    {
                        decimal finalSalary = salary + (decimal)bonus;
                        textBox3.Text = "Rs. " + finalSalary.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void EMP_ADD_btn_MouseHover(object sender, EventArgs e)
        {
            ADD_btn.BackColor = Color.DodgerBlue;
        }

        private void ADD_btn_MouseLeave(object sender, EventArgs e)
        {
            ADD_btn.BackColor = Color.White;
        }

        private void EMP_Fetch_btn_MouseHover(object sender, EventArgs e)
        {
            EMP_Fetch_btn.BackColor = Color.DodgerBlue;
        }

        private void EMP_Fetch_btn_MouseLeave(object sender, EventArgs e)
        {
            EMP_Fetch_btn.BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif) | *.jpg;*.jpeg;*.png;*.bmp;*.gif | All Files (*.*) | *.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
                else
                {
                    MessageBox.Show("No file selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting the image: " + ex.Message);
            }
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.DodgerBlue;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EMP_Salary 
        }
    }
}
