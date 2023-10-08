﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace WorkingPage
{
    public partial class loading : Form
    {
       // string x="PROFIT", y="PROFIT";

        public loading()
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

                //  names of item store in this array 
                string[] names = new string[item];


                knap[0, 0] = 1;
                knap[1, 0] = 2;
                knap[2, 0] = 3;
                knap[3, 0] = 4;
                knap[4, 0] = 5;


                knap[0, 1] = Convert.ToDouble(textBox2.Text);
                knap[0, 2] = Convert.ToDouble(textBox3.Text);
                //  name of item1 
                names[0] = textBox1.Text;

                knap[1, 1] = Convert.ToDouble(textBox5.Text);
                knap[1, 2] = Convert.ToDouble(textBox6.Text);
                //  name of item2
                names[1] = textBox4.Text;
                knap[2, 1] = Convert.ToDouble(textBox8.Text);
                knap[2, 2] = Convert.ToDouble(textBox9.Text);
                //  name of item3
                names[2] = textBox7.Text;
                knap[3, 1] = Convert.ToDouble(textBox11.Text);
                knap[3, 2] = Convert.ToDouble(textBox12.Text);
                //  name of item4
                names[3] = textBox10.Text;
                knap[4, 1] = Convert.ToDouble(textBox14.Text);
                knap[4, 2] = Convert.ToDouble(textBox15.Text);
                //  name of item5
                names[4] = textBox13.Text;
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
                           
                            // names sort with respect to ratios
                            string temps = names[i];
                            names[i] = names[k];
                            names[k] = temps;

                        }
                    }
                }
                double weight = 0, value = 0,count=0;
                int a = item - 1;
                
                // Open text file

                StreamWriter sw = new StreamWriter("record_of_truck.txt");
                sw.WriteLine("\n\n----------------------------------------------------");
                sw.WriteLine("\t\t<<<<: RECORD OF TRUCK :>>>>");
                sw.WriteLine("----------------------------------------------------");
                sw.WriteLine("<<: Capacity OF TRUCK :>>>> : "+c+"KG");
                sw.WriteLine("----------------------------------------------------");

                ////////////////////
                while (true)
                {
                    weight += knap[a, 1];
                    double temp = weight - knap[a, 1];
                    temp = c - temp;
                    
                    if (weight > c)
                    {

                        double last = (temp / knap[a, 1]) * knap[a, 2];
                        value += last;
                        sw.WriteLine(names[a] + " :\t" + temp + "KG");
                        ////  print name in text file
                        label21.Text = label21.Text +": "+ value.ToString();

                        // TotAl
                        sw.WriteLine("----------------------------------------------------");
                        sw.WriteLine("TOTAL : " + textBox16.Text + "KG");
                        sw.WriteLine("----------------------------------------------------");
                        break;
                    }

                    ////  print name in text file
                        sw.WriteLine(names[a] + " :\t" + knap[a, 1] + "KG");
                    if (weight == c)
                    {
                        label21.Text =label21.Text+ ": " + value.ToString();
                        // TotAl
                        sw.WriteLine("----------------------------------------------------");
                        sw.WriteLine("TOTAL : " + weight + "KG");
                        sw.WriteLine("----------------------------------------------------");
                       break; 
                    }
                    value += knap[a, 2];
                    a--;
                    count++;
                    if (item==count)
                    {
                        label21.Text = label21.Text + ": " + value.ToString();
                        // TotAl
                        sw.WriteLine("----------------------------------------------------");
                        sw.WriteLine("TOTAL : " + weight + "KG");
                        sw.WriteLine("----------------------------------------------------");
                        break;
                    }
                }
                // close text file
                sw.Close();
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"C:\Users\HP\source\repos\WorkingPage\WorkingPage\bin\Debug\record_of_truck.txt  ");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loading_Load(object sender, EventArgs e)
        {

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
