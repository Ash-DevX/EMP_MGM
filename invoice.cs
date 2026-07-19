using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP_MGM
{
    public partial class invoice : Form
    {
        public string Date,Name,Department,Salary,Bonus,Total,Gender;
        public Image img = null;
        public invoice()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(B, (pagearea.Width / 2) - (this.guna2Panel3.Width / 2), this.guna2Panel3.Location.Y);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Print(this.guna2Panel3);
        }

        private void Print(Guna.UI2.WinForms.Guna2Panel a)
        {
            PrinterSettings p = new PrinterSettings();
            guna2Panel3 = a;
            B = new Bitmap(a.Width, a.Height);
            a.DrawToBitmap(B, new Rectangle(0, 0, a.Width, a.Height));
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap B;

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

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void invoice_Load(object sender, EventArgs e)
        {
            Label1.Text = Date;
            PictureBox1.Image = img;
            lbl_Name.Text = Name;
            lbl_Dept.Text = Department;
            lbl_Salary.Text = Salary;
            lbl_Bonus.Text = Bonus;
            lbl_Total.Text = Total;
            lbl_Gender.Text = Gender;
        }
    }
}
