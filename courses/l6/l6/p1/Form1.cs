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

        public string[] array1 = new string[9];
        public string[] array2 = new string[9];

        private void Form1_Load(object sender, EventArgs e)
        {
            array1[0] = "Алмазы";
            array1[1] = "Алюминий";
            array1[2] = "Железо";
            array1[3] = "Жемчуг";
            array1[4] = "Золото";
            array1[5] = "Медь";
            array1[6] = "Мрамор";
            array1[7] = "Рубины";
            array1[8] = "Серебро";

            array2[0] = "Газ";
            array2[1] = "Древесина";
            array2[2] = "Камень";
            array2[3] = "Кварц";
            array2[4] = "Кость";
            array2[5] = "Латунь";
            array2[6] = "Нефть";
            array2[7] = "Свинец";
            array2[8] = "Стекло";

            for (int i = 0; i < array1.Length; i++)
                checkedListBox1.Items.Add(array1[i]);
            
            for (int i = 0; i < array2.Length; i++)
                checkedListBox2.Items.Add(array2[i]);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            // добавление элемента из текстового поля
            if (textBox1.Text != "")
                checkedListBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox1.Items.Count - 1; i > -1; i--)
                if (checkedListBox1.GetItemChecked(i))
                    checkedListBox1.Items.RemoveAt(i);
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            // удаление всех элементов из списка
            for (int i = checkedListBox1.Items.Count - 1; i > -1; i--)
                checkedListBox1.Items.RemoveAt(i);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // удаление дубликатов
            int count = checkedListBox1.Items.Count;
            for (int i = 0; i < count - 1; i++)
                for (int j = i + 1; j < count; j++)
                    if (checkedListBox1.Items[i].ToString() == checkedListBox1.Items[j].ToString())
                    {
                        checkedListBox1.Items.RemoveAt(j);
                        count--;
                    }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // снять выделение
            checkedListBox1.ClearSelected();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // добавление элементов из массива
            for (int i = 0; i < array1.Length; i++)
                checkedListBox1.Items.Add(array1[i]);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // добавление элементов в массив
            array1 = new string[checkedListBox1.Items.Count];
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                array1[i] = checkedListBox1.Items[i].ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // перемещение выделенного элемента
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                if (checkedListBox1.GetSelected(i))
                {
                    checkedListBox2.Items.Add(checkedListBox1.Items[i]);
                    checkedListBox1.Items.RemoveAt(i);
                }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // перемещение помеченых элементов
            int count = checkedListBox1.Items.Count;
            for (int i = 0; i < count; i++)
                if (checkedListBox1.GetItemChecked(i))
                {
                    checkedListBox2.Items.Add(checkedListBox1.Items[i]);
                    checkedListBox1.Items.RemoveAt(i);
                    count--;
                }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // копирование выделенного элемента
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                if (checkedListBox1.GetSelected(i))
                    checkedListBox2.Items.Add(checkedListBox1.Items[i]);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // копирование помеченых элементов
            int count = checkedListBox1.Items.Count;
            for (int i = 0; i < count; i++)
                if (checkedListBox1.GetItemChecked(i))
                    checkedListBox2.Items.Add(checkedListBox1.Items[i]);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // перемещение выделенного элемента
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
                if (checkedListBox2.GetSelected(i))
                {
                    checkedListBox1.Items.Add(checkedListBox2.Items[i]);
                    checkedListBox2.Items.RemoveAt(i);
                }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // перемещение помеченых элементов
            int count = checkedListBox1.Items.Count;
            for (int i = 0; i < count; i++)
                if (checkedListBox1.GetItemChecked(i))
                {
                    checkedListBox2.Items.Add(checkedListBox1.Items[i]);
                    checkedListBox1.Items.RemoveAt(i);
                    count--;
                }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // копирование выделенного элемента
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
                if (checkedListBox2.GetSelected(i))
                    checkedListBox1.Items.Add(checkedListBox2.Items[i]);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // копирование помеченых элементов
            int count = checkedListBox2.Items.Count;
            for (int i = 0; i < count; i++)
                if (checkedListBox2.GetItemChecked(i))
                    checkedListBox1.Items.Add(checkedListBox2.Items[i]);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // добавление элементов в массив
            array2 = new string[checkedListBox2.Items.Count];
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
                array2[i] = checkedListBox2.Items[i].ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // добавление элементов из массива
            for (int i = 0; i < array1.Length; i++)
                checkedListBox2.Items.Add(array2[i]);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
                checkedListBox2.SetItemChecked(i, true);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
                checkedListBox2.SetItemChecked(i, false);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            // снять выделение
            checkedListBox2.ClearSelected();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            // удаление дубликатов
            int count = checkedListBox2.Items.Count;
            for (int i = 0; i < count - 1; i++)
                for (int j = i + 1; j < count; j++)
                    if (checkedListBox2.Items[i].ToString() == checkedListBox2.Items[j].ToString())
                    {
                        checkedListBox2.Items.RemoveAt(j);
                        count--;
                    }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            // удаление всех элементов из списка
            for (int i = checkedListBox2.Items.Count - 1; i > -1; i--)
                checkedListBox2.Items.RemoveAt(i);
        }
        
        private void button25_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox2.Items.Count - 1; i > -1; i--)
                if (checkedListBox2.GetItemChecked(i))
                    checkedListBox2.Items.RemoveAt(i);
        }
 
        private void button26_Click(object sender, EventArgs e)
        {
            // добавление элемента из текстового поля
            if (textBox2.Text != "")
                checkedListBox2.Items.Add(textBox2.Text);
            textBox2.Text = "";
        }
    }
}
