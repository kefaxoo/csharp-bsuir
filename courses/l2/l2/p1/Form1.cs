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

        public bool CheckTextBoxes()
        {
            if (textBox1.Text == "")
                MessageBox.Show("textBox1 пустой");
            else if (textBox2.Text == "")
                MessageBox.Show("textBox2 пустой");
            else
                return true;

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
                textBox3.Text = (Convert.ToDouble(textBox1.Text.Replace('.', ',')) + Convert.ToDouble(textBox2.Text.Replace('.', ','))).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
                textBox3.Text = (Convert.ToDouble(textBox1.Text.Replace('.', ',')) - Convert.ToDouble(textBox2.Text.Replace('.', ','))).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
                textBox3.Text = (Convert.ToDouble(textBox1.Text.Replace('.', ',')) * Convert.ToDouble(textBox2.Text.Replace('.', ','))).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
                textBox3.Text = (Convert.ToDouble(textBox1.Text.Replace('.', ',')) / Convert.ToDouble(textBox2.Text.Replace('.', ','))).ToString();
        }
    }
}
