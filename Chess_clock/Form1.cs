using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_clock
{
    public partial class Form1 : Form
    {
        int h1, h2, m1, m2, s1, s2, temp;
        public Form1()
        {
            InitializeComponent();
            h1 = 0;
            h2 = 0;
            m1 = 0;
            m2 = 0;
            s1 = 0;
            s2 = 0;
            temp = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "00";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "00";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "00";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = "00";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = "00";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (s2 < 59)
            {
                s2++;
                if (s2 < 10)
                    label9.Text = "0" + s2.ToString();
                else
                    label9.Text = s2.ToString();
            }
            else
            {
                if(m2 < 59)
                {
                    m2++;
                    if (m2 < 10)
                        label6.Text = "0" + m2.ToString();
                    else
                        label6.Text = m2.ToString();
                    s2 = 0;
                    label9.Text = "00";
                }
                
                else{
                    if(h2 < 10)
                    {
                        h2++;
                        label4.Text = "0" + h2.ToString();
                    }
                    else
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                    }
                    s2 = 0;
                    m2 = 0;
                    label9.Text = "00";
                    label6.Text = "00";
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            h1 = 0;
            h2 = 0;
            m1 = 0;
            m2 = 0;
            s1 = 0;
            s2 = 0;
            timer1.Enabled = false;
            timer2.Enabled = false;
            label1.Text = "00";
            label2.Text = "00";
            label4.Text = "00";
            label6.Text = "00";
            label7.Text = "00";
            label9.Text = "00";
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer1.Enabled = true;
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = "00";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s1 < 59)
            {
                s1++;
                if (s1 < 10)
                    label7.Text = "0" + s1.ToString();
                else
                    label7.Text = s1.ToString();
            }
            else
            {
                if (m1 < 59)
                {
                    m1++;
                    if (m1 < 10)
                        label2.Text = "0" + m1.ToString();
                    else
                        label2.Text = m1.ToString();
                    s1 = 0;
                    label7.Text = "00";
                }
                else
                {
                    if (h1 < 10)
                    {
                        h1++;
                        label1.Text = "0" + h1.ToString();
                    }
                    else
                    {
                        timer1.Enabled = false;
                        timer1.Enabled = false;
                    }
                    s1 = 0;
                    m1 = 0;
                    label2.Text = "00";
                    label7.Text = "00";
                }
            }
        }
    }
}
