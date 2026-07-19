using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP_MGM
{
    public partial class EMP_Salary : Form
    {
        public string Gender = "";
        public EMP_Salary()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2RadioButton1.Checked)
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            invoice inv = new invoice();
            inv.img = guna2CirclePictureBox1.Image;
            inv.Name = guna2TextBox1.Text;
            if (guna2ComboBox1.SelectedIndex == -1)
            {
                inv.Department = "";
            }
            else
            {
                inv.Department = guna2ComboBox1.SelectedItem.ToString();
            }
            inv.Salary = guna2TextBox2.Text;
            inv.Bonus = guna2TextBox3.Text;
            inv.Total = guna2TextBox4.Text;
            inv.Gender = Gender;
            inv.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif) | *.jpg;*.jpeg;*.png;*.bmp;*.gif | All Files (*.*) | *.*";
            openFileDialog.Title = "Select an Image File";  

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                guna2CirclePictureBox1.Image = Image.FromFile(filePath);
                MessageBox.Show("Selected file: " + filePath);
            }
        }

       private void guna2TextBox3_TextChanged(object sender, EventArgs e)
       {
        // treat empty as zero or bail out depending on desired UX
        var sText = guna2TextBox2.Text?.Trim();
        var bText = guna2TextBox3.Text?.Trim();

        // try integer first, then decimal if you expect fractions
        if (int.TryParse(sText, NumberStyles.Integer, CultureInfo.InvariantCulture, out int salary)
            && int.TryParse(bText, NumberStyles.Integer, CultureInfo.InvariantCulture, out int bonus))
        {
            guna2TextBox4.Text = (salary + bonus).ToString(CultureInfo.InvariantCulture);
            return;
        }

        // fallback: try decimal (handles "100.50" or culture-specific formats)
        if (decimal.TryParse(sText, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal dSalary)
            && decimal.TryParse(bText, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal dBonus))
        {
            guna2TextBox4.Text = (dSalary + dBonus).ToString(CultureInfo.CurrentCulture);
            return;
        }

        // invalid input: clear result or show message as appropriate
        guna2TextBox4.Text = string.Empty;
       }

        private void EMP_Salary_Load(object sender, EventArgs e)
        {

        }
    }
}
