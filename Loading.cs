using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP_MGM
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {                
                if (progressBar1.Value < 100)
                {
                    progressBar1.Value += 1;
                    guna2HtmlLabel1.Text = progressBar1.Value.ToString() + "%"; 
                }
                else
                {
                    timer1.Stop(); 
                    MessageBox.Show("Loading Complete!"); 
                    this.Hide(); 
                    login l = new login(); 
                    l.Show(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
