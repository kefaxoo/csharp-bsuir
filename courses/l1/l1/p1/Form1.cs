using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + '\n' + textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = label1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Height = 100;
            this.Width = 100;
            this.Left = 0;
            this.Top = 0;
        }
    }
}
