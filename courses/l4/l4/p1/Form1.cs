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

        public string[] items = new string[10];
        public int[] prices = { 5, 1, 4, 500, 1500, 7, 20, 40, 300, 200 };

        private void Form1_Load(object sender, EventArgs e)
        {
            items[0] = "Камень";
            items[1] = "Дерево";
            items[2] = "Руда";
            items[3] = "Золото";
            items[4] = "Алмазы";
            items[5] = "Гранит";
            items[6] = "Нефть";
            items[7] = "Железо";
            items[8] = "Сапфир";
            items[9] = "Жемчуг";
            for (int i = 0; i < 10; i++)
            {
                comboBox1.Items.Add(items[i]);
                comboBox2.Items.Add(items[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("За " + comboBox1.Items[comboBox1.SelectedIndex].ToString().ToLower() + " в количестве " + numericUpDown1.Value + " шт" + '\n' + "Вы получитеs " + comboBox2.Items[comboBox2.SelectedIndex].ToString().ToLower() + " в количестве " + ((prices[comboBox1.SelectedIndex] * (double)numericUpDown1.Value) / prices[comboBox2.SelectedIndex]) * 0.9 + " шт");
        }
    }
}
