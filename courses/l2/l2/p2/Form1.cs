using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2
{
    public partial class Form1 : Form
    {
        float temp;
        int symbol;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            temp = Convert.ToInt32(textBox1.Text);
            symbol = 1;
            textBox1.Text = "";
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            temp = Convert.ToSingle(textBox1.Text);
            symbol = 2;
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            temp = Convert.ToSingle(textBox1.Text);
            symbol = 3;
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            temp = Convert.ToSingle(textBox1.Text);
            symbol = 4;
            textBox1.Text = "";
        }

        private void buttonclean_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (symbol)
            {
                case 1:
                    {
                        textBox1.Text = Convert.ToString(temp + Int32.Parse(textBox1.Text));
                        break;
                    }
                case 2:
                    {
                        textBox1.Text = Convert.ToString(temp - Int32.Parse(textBox1.Text));
                        break;
                    }
                case 3:
                    {
                        textBox1.Text = Convert.ToString(temp * Int32.Parse(textBox1.Text));
                        break;
                    }
                case 4:
                    {
                        if (Int32.Parse(textBox1.Text) == 0)
                            textBox1.Text = "На ноль делить нельзя! (пустое множество)";
                        else
                            textBox1.Text = Convert.ToString(temp / float.Parse(textBox1.Text));
                        break;
                    }
            }
        }
    }
}
