using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using main_page;

namespace SplashScreen
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""||textBox2.Text=="")
            {
                MessageBox.Show(
                    "Please enter both fields !!",
                    "Follow Instructions.",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                    );
                textBox1.Focus();
            }
           else if (textBox1.Text != "admin".ToLower() || textBox2.Text != "000")
            {
                MessageBox.Show(
                    "Wrong Password or Username !!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                textBox1.Focus();
                textBox1.Text = null;
                    textBox2.Text = null;
            }
            else
            {
                MessageBox.Show(
                   "LOGIN SUCCESSFULL !!",
                   "Login",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Asterisk
                   );
               
                mainwork mw = new mainwork();
                this.Hide();
                mw.Show();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.twitter.com/");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
