using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private float first;
        private float second;
        private float result;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            first = Convert.ToSingle(textBox1.Text);
            second = Convert.ToSingle(textBox2.Text);
            result = first + second;
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            first = Convert.ToSingle(textBox1.Text);
            second = Convert.ToSingle(textBox2.Text);
            result = first - second;
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            first = Convert.ToSingle(textBox1.Text);
            second = Convert.ToSingle(textBox2.Text);
            result = first * second;
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            first = Convert.ToSingle(textBox1.Text);
            second = Convert.ToSingle(textBox2.Text);
            if (second == 0)
            {
                textBox3.Text = "На ноль делить нельзя! (пустое множество)";
            }
            else
            {
                result = first / second;
                textBox3.Text = result.ToString();
            }
        }
    }
}
