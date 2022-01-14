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

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Твоё имя: " + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Твоё имя: " + textBox1.Text + "\nТвоя фамилия: " + textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text);
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            this.Height = 100;
            MessageBox.Show("Изменение ширины формы на 100 пкс.");
            this.Width = 100;
            MessageBox.Show("Изменение длины формы на 100 пкс.");
            this.Left = 0;
            MessageBox.Show("Форма перенесена в левую сторону на положение 0");
            this.Top = 0;
            MessageBox.Show("Форма перенесена вверх на положение 0");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Выводится текст из поля Имя" + "\n2. Выводится текст из двух полей" + "\n3. Выводится текст из надписи" + "\n4. Выводится текст 4-ой кнопки" + "\n5. Перенос текста из текст. поля в надпись" + "\n6. Перенос текста их надписи на себя" + "\n7. Кнопка переносит текст из текст. поля на заголовок формы" + "\nКлик по пустому месту формы меняет её размер и положение");
        }
    }
}
