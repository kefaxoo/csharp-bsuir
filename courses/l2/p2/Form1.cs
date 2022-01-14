using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace p2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Я " + textBox1.Text + ".";
            if (radioButton5.Checked == true)
            {
                if (radioButton1.Checked == true)
                    str += " Я мальчик. ";
                if (radioButton2.Checked == true)
                    str += " Я подросток. ";
                if (radioButton3.Checked == true)
                    str += " Я парень. ";
                if (radioButton4.Checked == true)
                    str += " Я джентельмен. ";
            }
            if (radioButton6.Checked == true)
            {
                if (radioButton1.Checked == true)
                    str += " Я девочка. ";
                if (radioButton2.Checked == true)
                    str += " Я подросток. ";
                if (radioButton3.Checked == true)
                    str += " Я девушка. ";
                if (radioButton4.Checked == true)
                    str += " Я дама/леди/мадмуазель. ";
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
                str += "Из этого списка, я ничем не увлекаюсь";
            else
                str += "Я люблю ";
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false)
                str += "программировать.";
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false)
                str += "программировать и фотографировать.";
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
                str += "программировать, фотографировать и слушать музыку";
            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
                str += "фотографировать.";
            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true)
                str += "фотографировать и слушать музыку.";
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
                str += "слушать музыку.";
            MessageBox.Show(str);
        }
    }
}
