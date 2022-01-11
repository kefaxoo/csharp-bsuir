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

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Введите имя";
            comboBox1.SelectedIndex = 0;
            richTextBox1.Text = "Введите описание";
            radioButton3.Checked = true;
            richTextBox2.Text = "Чтобы выбрать несколько элементов, используйте Shift и Ctrl";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = checkBox1.Checked;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown2.Enabled = checkBox2.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "СОЗДАН ЮНИТ\nИмя - " + textBox1.Text + "\nРаса - " + comboBox1.Text + "\nПол - ";
            if (radioButton1.Checked == true)
                str += radioButton1.Text;
            
            if (radioButton2.Checked == true)
                str += radioButton2.Text;
            
            if (radioButton3.Checked == true)
                str += radioButton3.Text;
            
            if (numericUpDown1.Enabled == true)
                str += "\nАтака - " + numericUpDown1.Text;
            else
                str += "\nНе умеет драться";

            if (numericUpDown2.Enabled == true)
                str += "\nЗащита - " + numericUpDown2.Text;
            else
                str += "\nНе может защищаться";

            str += "\nИнвентарь: ";
            for (int i = 0; i < listBox1.SelectedItems.Count; i++ )
            {
                str += listBox1.SelectedItems[i] + " ";
            }
            str += "\n" + richTextBox1.Text;
            MessageBox.Show(str);
        }
    }
}