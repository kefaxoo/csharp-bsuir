using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckListBox
{
    public partial class Form1 : Form
    {
        public string[] m1 = new string[] {"вода", "огонь", "земля", "воздух"};
        public string[] m2 = new string[] { "львы", "олени", "куропатки", "ласточки" };
        public string[] newm;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // копирование помеченнных в другой список
            CheckedListBox clb1, clb2;
            if ((sender as Button).Name == "button1")
            {
                clb1 = checkedListBox1;
                clb2 = checkedListBox2;
            }
            else
            {
                clb1 = checkedListBox2;
                clb2 = checkedListBox1;
            }
            foreach (string str in clb1.CheckedItems)
                clb2.Items.Add(str);
         }

        private void button2_Click(object sender, EventArgs e)
        {
            // копирование выделенного в другой список
            CheckedListBox clb1, clb2;
            if ((sender as Button).Name == "button2")
            {
                clb1 = checkedListBox1;
                clb2 = checkedListBox2;
            }
            else
            {
                clb1 = checkedListBox2;
                clb2 = checkedListBox1;
            }
            clb2.Items.Add(clb1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // добавляем из текстового поля
            CheckedListBox clb;
            TextBox tb;
            if ((sender as Button).Name == "button3")
            {
                clb = checkedListBox1;
                tb = textBox1;
            }
            else
            {
                clb = checkedListBox2;
                tb = textBox2;
            }
            if (tb.Text != "")
                clb.Items.Add(tb.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // удаляем отмеченнные
            CheckedListBox clb;
            if ((sender as Button).Name == "button4")
                clb = checkedListBox1;
            else
                clb = checkedListBox2;
            for (int i = clb.Items.Count - 1; i > 0; i--)
                if (clb.GetItemChecked(i))
                    clb.Items.RemoveAt(i);
        }
    

        private void button5_Click(object sender, EventArgs e)
        {
            // Очищение списка (обработчик для двух checkedListBox)
            CheckedListBox clb;
            if ((sender as Button).Name == "button5") 
                clb = checkedListBox1;
            else 
                clb = checkedListBox2;
            clb.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Заполнение списка из массивов
            CheckedListBox clb;
            string[] m;
            if ((sender as Button).Name == "button6")
            {
                clb = checkedListBox1;
                m = m1;
            }
            else
            {
                clb = checkedListBox2;
                m = m2;
            }
            clb.Items.AddRange(m);
        }

        
        private void button7_Click(object sender, EventArgs e)
        {
             // в массив
            CheckedListBox clb;
            String[] s;
            if ((sender as Button).Name == "button7")
            {
                clb = checkedListBox1;
                s = m1;
            }
            else
            {
                clb = checkedListBox2;
                s = m2;
            }
            s = new string[clb.Items.Count];
            for (int i = 0; i < clb.Items.Count; i++)
                s[i] = clb.Items[i].ToString();
            if ((sender as Button).Name == "button7")
                m1 = s;
            else
                m2 = s;
        }

        private void button8_Click(object sender, EventArgs e)
        {   
            // снять выделение
            CheckedListBox clb;
            if ((sender as Button).Name == "button8")
                clb = checkedListBox1;
            else
                clb = checkedListBox2;
            clb.ClearSelected();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // убрать check со всех
            CheckedListBox clb;
            if ((sender as Button).Name == "button9")
                clb = checkedListBox1;
            else
                clb = checkedListBox2;
            for (int i = 0; i < clb.Items.Count; i++)
                clb.SetItemChecked(i, false);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // добавить check на все
            CheckedListBox clb;
            if ((sender as Button).Name == "button10")
                clb = checkedListBox1;
            else
                clb = checkedListBox2;
            for (int i = 0; i < clb.Items.Count; i++)
                clb.SetItemChecked(i, true);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // убрать дубликаты
            CheckedListBox clb;
            if ((sender as Button).Name == "button11")
                clb = checkedListBox1;
            else
                clb = checkedListBox2;
            for(int i=clb.Items.Count-2;i>=0;i--)
                if(String.Compare(clb.Items[i].ToString(),clb.Items[i+1].ToString())==0)
                    clb.Items.RemoveAt(i);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            // перенос направо 1
            CheckedListBox clb1, clb2;
            if ((sender as Button).Name == "button21")
            {
                clb1 = checkedListBox1;
                clb2 = checkedListBox2;
            }
            else
            {
                clb1 = checkedListBox2;
                clb2 = checkedListBox1;
            }
            clb2.Items.Add(clb1.SelectedItem);
            clb1.Items.Remove(clb1.SelectedItem);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            // перенос направо помеченнных
            CheckedListBox clb1, clb2;
            if ((sender as Button).Name == "button22")
            {
                clb1 = checkedListBox1;
                clb2 = checkedListBox2;
            }
            else
            {
                clb1 = checkedListBox2;
                clb2 = checkedListBox1;
            }
            foreach (string str in clb1.CheckedItems)
                clb2.Items.Add(str);
            for (int i = clb1.Items.Count - 1; i > 0; i--)
                if (clb1.GetItemChecked(i))
                    clb1.Items.RemoveAt(i);
        }
    }
}
