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
        public string[] name;
        public int[] price;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            name = new string[10];
            price = new int[10];
            name[0] = "Дерево";
            price[0] = 1;
            name[1] = "Руда";
            price[1] = 4;
            name[2] = "Камень";
            price[2] = 5;
            name[3] = "Гранит";
            price[3] = 7;
            name[4] = "Нефть";
            price[4] = 20;
            name[5] = "Железо";
            price[5] = 40;
            name[6] = "Жемчуг";
            price[6] = 200;
            name[7] = "Сапфиры";
            price[7] = 300;
            name[8] = "Золото";
            price[8] = 500;
            name[9] = "Алмазы";
            price[9] = 1500;
            comboBox1.Items.AddRange(name);
            comboBox2.Items.AddRange(name);
            numericUpDown1.Minimum = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            int price1, temp, i;
            double price2;
            i = comboBox1.SelectedIndex;
            price1 = price[i] * (int)numericUpDown1.Value;
            str = "Вы предлагаете: " + comboBox1.Text + ",\nЗа: " + price1 + " денег. \nВзамен вы хотите получить: " + comboBox2.Text + ",\nКоличеством: ";
            i = comboBox2.SelectedIndex;
            temp = price1 / price[i];
            price2 = temp*0.9;
            if (comboBox2.SelectedIndex == 4)
                str += price2 + " л.";
            else
                str += price2 + "шт.";
            MessageBox.Show(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 three = new Form2();
            three.Show();
            Form1 one = new Form1();
            one.Visible = false;
        }
    }
}
