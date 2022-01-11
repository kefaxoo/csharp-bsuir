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
    public partial class Form2 : Form
    {
        public string[] name;
        public int[] price;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
            comboBox3.Items.AddRange(name);
            comboBox4.Items.AddRange(name);
            comboBox5.Items.AddRange(name);
            comboBox6.Items.AddRange(name);
            numericUpDown1.Minimum = 1;
            numericUpDown2.Minimum = 1;
            numericUpDown3.Minimum = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            int i;
            double result, temp, pricetemp;
            str = "Вы предлагаете: " + "\n 1) " + comboBox1.Text + ", за: ";
            i = comboBox1.SelectedIndex;
            pricetemp = price[i] * (int)numericUpDown1.Value;
            result = pricetemp;
            str += pricetemp + " денег;\n 2) " + comboBox2.Text + ", за: ";
            i = comboBox2.SelectedIndex;
            pricetemp = price[i] * (int)numericUpDown2.Value;
            result += pricetemp;
            str += pricetemp + "денег;\n 3) " + comboBox3.Text + ", за: ";
            i = comboBox3.SelectedIndex;
            pricetemp = price[i] * (int)numericUpDown3.Value;
            result += pricetemp;
            str += pricetemp + "денег.\n Взамен вы получите: \n 1) " + comboBox4.Text + ", количеством: ";
            i = comboBox4.SelectedIndex;
            temp = (result*0.9) / 3;
            pricetemp = temp / price[i];
            str += pricetemp;
            if (comboBox4.SelectedIndex == 4)
                str += " л;\n";
            else
                str += "шт;\n";
            str += " 2) " + comboBox5.Text + ", количеством: ";
            i = comboBox5.SelectedIndex;
            pricetemp = temp / price[i];
            str += pricetemp;
            if (comboBox5.SelectedIndex == 4)
                str += " л;\n";
            else
                str += "шт;\n";
            str += " 3) " + comboBox6.Text + ", количеством: ";
            i = comboBox6.SelectedIndex;
            pricetemp = temp / price[i];
            str += pricetemp;
            if (comboBox6.SelectedIndex == 4)
                str += " л.";
            else
                str += " шт.";
            MessageBox.Show(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 one = new Form1();
            one.Visible = true;
            Form2 three = new Form2();
            three.Visible = false;
        }
    }
}
