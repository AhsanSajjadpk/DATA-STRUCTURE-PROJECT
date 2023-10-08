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
namespace WorkingPage
{
    public partial class Form1 : Form
    {
        string x="PROFIT", y="PROFIT";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != ""&& textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "")
            {
                int item = 5;
                double c =Convert.ToDouble( textBox16.Text);
                double ratio;
                double[,] knap = new double[item, 4];

                knap[0, 0] = 1;
                knap[1, 0] = 2;
                knap[2, 0] = 3;
                knap[3, 0] = 4;
                knap[4, 0] = 5;


                knap[0, 1] = Convert.ToDouble(textBox2.Text);
                knap[0, 2] = Convert.ToDouble(textBox3.Text);

                knap[1, 1] = Convert.ToDouble(textBox5.Text);
                knap[1, 2] = Convert.ToDouble(textBox6.Text);

                knap[2, 1] = Convert.ToDouble(textBox8.Text);
                knap[2, 2] = Convert.ToDouble(textBox9.Text);

                knap[3, 1] = Convert.ToDouble(textBox11.Text);
                knap[3, 2] = Convert.ToDouble(textBox12.Text);

                knap[4, 1] = Convert.ToDouble(textBox14.Text);
                knap[4, 2] = Convert.ToDouble(textBox15.Text);

                for (int i = 0; i < item; i++)
                {
                    ratio = knap[i, 2] / knap[i, 1];
                    knap[i, 3] = ratio;
                }
              
                // Sorting the ratio in Ascending order
                int k;
                for (int m = item; m >= 0; m--)
                {
                    for (int i = 0; i < item - 1; i++)
                    {
                        k = i + 1;
                        if (knap[i, 3] > knap[k, 3])
                        {
                            double temp;
                            temp = knap[i, 3];
                            knap[i, 3] = knap[k, 3];
                            knap[k, 3] = temp;

                            temp = knap[i, 2];
                            knap[i, 2] = knap[k, 2];
                            knap[k, 2] = temp;

                            temp = knap[i, 1];
                            knap[i, 1] = knap[k, 1];
                            knap[k, 1] = temp;

                        }
                    }
                }
              

             

                double weight = 0, value = 0,count=0;
                int a = item - 1;
                while (true)
                {

                    weight += knap[a, 1];
                    double temp = weight - knap[a, 1];
                    temp = c - temp;
                    if (weight > c)
                    {

                        double last = (temp / knap[a, 1]) * knap[a, 2];
                        value += last;
                        label21.Text = label21.Text +": "+ value.ToString();
                        break;
                    }

                    if (weight == c)
                    {
                        label21.Text =label21.Text+ ": " + value.ToString();
                        break;
                        
                    }
                    value += knap[a, 2];
                    a--;
                    count++;
                    if (item==count)
                    {
                        label21.Text = label21.Text + ": " + value.ToString();
                        break;
                    }
                }
              


            }
            else 
            {
                MessageBox.Show(
                     "Please Fill all fields !!",
                     "Follow Instructions.",
                     MessageBoxButtons.OKCancel,
                     MessageBoxIcon.Warning
                     );
                textBox1.Focus();
            }



           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox16.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.gatevidyalay.com/fractional-knapsack-problem-using-greedy-approach/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";

            label21.Text = "COST";
        }
    }
}
