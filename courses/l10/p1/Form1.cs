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
        public Form2 newMDIChild;
        public int num = 0;
        public Color c = Color.White;
        public Form1()
        {
            InitializeComponent();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newMDIChild = new Form2();
            num++;
            newMDIChild.Text = "Форма " + num;
            newMDIChild.MdiParent = this;
            newMDIChild.f1 = this;
            newMDIChild.Show();
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem color = (ToolStripMenuItem) sender;
            switch(color.Text)
            {
                case "Красный":
                    c = Color.Red;
                    break;
                case "Оранжевый":
                    c = Color.Orange;
                    break;
                case "Жёлтый":
                    c = Color.Yellow;
                    break;
                case "Зелёный":
                    c = Color.GreenYellow;
                    break;
                case "Голубой":
                    c = Color.DeepSkyBlue;
                    break;
                case "Синий":
                    c = Color.RoyalBlue;
                    break;
                case "Фиолетовый":
                    c = Color.DarkViolet;
                    break;
                case "Чёрный":
                    c = Color.Black;
                    break;
            }
        }
    }
}
