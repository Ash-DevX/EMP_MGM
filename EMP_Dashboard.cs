using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EMP_MGM
{
    public partial class EMP_Dashboard : Dashboard
    {
        public EMP_Dashboard()
        {
            InitializeComponent();
        }

        public void Dashboard(object sender, EventArgs e)
        {
            // Hide both pages when the form starts
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        // Admin Button
        private void Admin_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            this.Hide();
            Dashboard D = new Dashboard();
            D.Show();
        }

        // Employee Button
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            this.Hide();
            EMP_Salary emp = new EMP_Salary();
            emp.Show();
        }

        // Back/Close Button
        public void btnBack_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void EMP_D_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EMP_Dele_btn_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {

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

        private void MIN_btn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MAX_btn_Click_1(object sender, EventArgs e)
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

        private void Exit_btn_Click_1(object sender, EventArgs e)
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

    }
}
