using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
         
            if (panel2.Width>=699)
            {
                timer1.Stop();
                admin f2 = new admin();
                this.Hide();
                f2.Show();
              
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
