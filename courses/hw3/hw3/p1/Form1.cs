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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                label1.BackColor = colorDialog1.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                label1.BackColor = Color.White;
            else if (radioButton2.Checked)
                label1.BackColor = Color.Yellow;
                else if (radioButton3.Checked)
                    label1.BackColor = Color.LightBlue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                label1.ForeColor = Color.Black;
            else if (radioButton5.Checked)
                label1.ForeColor = Color.Red;
                else if (radioButton6.Checked)
                    label1.ForeColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                label1.ForeColor = colorDialog1.Color;
        }
    }
}
