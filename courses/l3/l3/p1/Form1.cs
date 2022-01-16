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
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.ReadOnly = !numericUpDown1.ReadOnly;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown2.ReadOnly = !numericUpDown2.ReadOnly;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (richTextBox1.Text != "Введите описание")
                {
                    string result = "СОЗДАН ЮНИТ" + '\n' + "по имени " + textBox1.Text + '\n' + "Пол - ";
                    if (radioButton1.Checked)
                        result += radioButton1.Text.ToLower() + '\n';
                    else if (radioButton2.Checked)
                        result += radioButton2.Text.ToLower() + '\n';
                        else
                            result += radioButton3.Text.ToLower() + '\n';

                    if (!numericUpDown1.ReadOnly)
                        result += "Атака - " + numericUpDown1.Value + '\n';

                    if (!numericUpDown2.ReadOnly)
                        result += "Защита - " + numericUpDown2.Value + '\n';
                        
                    if (listBox1.SelectedItems.Count != 0)
                    {
                        result += "Инвентарь: " + '\n';
                        for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                            result += "- " + listBox1.SelectedItems[i].ToString() + '\n';
                    }

                    MessageBox.Show(result + "Описание: " + '\n' + richTextBox1.Text);
                }
                else
                    MessageBox.Show("Введите описание");
            }
            else
                MessageBox.Show("Введите имя");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
