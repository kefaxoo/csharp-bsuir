using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace p3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sex = -1, age = -1, count = 0;

            if (radioButton1.Checked)
                age = 1;
                else if (radioButton2.Checked)
                    age = 2;
                    else if (radioButton3.Checked)
                        age = 3;
                        else if (radioButton4.Checked)
                            age = 4;
                            else
                                MessageBox.Show("Выберите ваш возраст!");

            if (radioButton5.Checked)
                sex = 1;
                else if (radioButton6.Checked)
                    sex = 0;
                    else
                        MessageBox.Show("Выберите ваш пол!");

            if (textBox1.Text == "")
                MessageBox.Show("Введите ваше имя!");

            if (checkBox1.Checked)
                count++;

            if (checkBox2.Checked)
                count++;

            if (checkBox3.Checked)
                count++;

            if (sex != -1 && age != -1) 
            {
                string result = "Ваше имя: " + textBox1.Text + '\n';

                if (age == 2)
                    result += "Вы подросток" + '\n';
                else
                {
                    if (sex == 1)
                        switch (age)
                        {
                            case 1:
                                result += "Вы мальчик" + '\n';
                                break;
                            case 3:
                                result += "Вы парень" + '\n';
                                break;
                            case 4:
                                result += "Вы джентельмен" + '\n';
                                break;
                        }
                    else
                        switch (age)
                        {
                            case 1:
                                result += "Вы девочка" + '\n';
                                break;
                            case 3:
                                result += "Вы девушка" + '\n';
                                break;
                            case 4:
                                result += "Вы леди" + '\n';
                                break;
                        }
                }

                switch (count)
                {
                    case 0:
                        result += "Вы ничего не любите";
                        break;
                    case 1:
                        {
                            result += "Вы любите ";
                            if (checkBox1.Checked)
                                result += checkBox1.Text.ToLower();

                            if (checkBox2.Checked)
                                result += checkBox2.Text.ToLower();

                            if (checkBox3.Checked)
                                result += checkBox3.Text.ToLower();
                        }
                        break;
                    case 2:
                        {
                            result += "Вы любите ";
                            if (checkBox1.Checked && checkBox2.Checked)
                                result += checkBox1.Text.ToLower() + " и " + checkBox2.Text.ToLower();

                            if (checkBox1.Checked && checkBox3.Checked)
                                result += checkBox1.Text.ToLower() + " и " + checkBox3.Text.ToLower();

                            if (checkBox2.Checked && checkBox3.Checked)
                                result += checkBox2.Text.ToLower() + " и " + checkBox3.Text.ToLower();
                        }
                        break;
                    case 3:
                        result += "Вы любите " + checkBox1.Text.ToLower() + ", " + checkBox2.Text.ToLower() + " и " + checkBox3.Text.ToLower();
                        break;
                }

                MessageBox.Show(result);
            }
        }
    }
}
