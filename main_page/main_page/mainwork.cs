using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkingPage;

namespace main_page
{
    public partial class mainwork : Form
    {
        public mainwork()
        {
            InitializeComponent();
        }
        private void showchildformpanel(object Form)
        {
            if (this.panel3.Controls.Count>0)
            {
                this.panel3.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(form);
            form.Show();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            showchildformpanel(new menu());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            showchildformpanel(new loading());
            
            //loading l1 = new loading();
            //this.Hide();
            //l1.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"E:\Desktop\New folder (2)\SplashScreen\SplashScreen\bin\Debug\newrecord_of_truck.txt  ");
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            showchildformpanel(new aboutus());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
