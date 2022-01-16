using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace p1
{
    public partial class Form1 : Form
    {
        private int dx, dy;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dx = 1;
            dy = 1;
            ovalShape1.FillStyle = FillStyle.Solid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Старт")
            {
                button1.Text = "Стоп";
                timer1.Enabled = !timer1.Enabled;
            }
            else
            {
                button1.Text = "Старт";
                timer1.Enabled = !timer1.Enabled;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ovalShape1.Left += dx;
            ovalShape1.Top += dy;
            if (ovalShape1.Top + ovalShape1.Height > this.ClientRectangle.Height || ovalShape1.Top < 0)
                dy = -dy;
            if (ovalShape1.Left + ovalShape1.Width > this.ClientRectangle.Width || ovalShape1.Left < 0)
                dx = -dx;
            toolStripStatusLabel1.Text = "X = " + Convert.ToString(ovalShape1.Left);
            toolStripStatusLabel2.Text = "Y = " + Convert.ToString(ovalShape1.Top);
        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: fzzksiniy.\nВерсия программы: beta0.1.\nГод разработки: 2018.");
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            ovalShape1.BackColor = colorDialog1.Color;
            toolStripStatusLabel3.Text = Convert.ToString(ovalShape1.BackColor);
        }

        private void цветЛинийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            ovalShape1.FillColor = colorDialog1.Color;
        }

        private void цветКонтураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            ovalShape1.BorderColor = colorDialog1.Color;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ovalShape1.BorderWidth = Convert.ToInt32(toolStripComboBox1.SelectedItem);
        }

        private void даToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Vertical;
        }

        private void нетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox2.SelectedIndex)
            {
                case 0:
                    ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Horizontal;
                    break;
                case 1:
                    ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Vertical;
                    break;
                case 2:
                    ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Cross;
                    break;
                case 3:
                    ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.ForwardDiagonal;
                    break;
                case 4:
                    ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.BackwardDiagonal;
                    break;
                case 5:
                    ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.DiagonalCross;
                    break;
            }    
        }

        private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(toolStripComboBox3.SelectedItem);
        }

        private void toolStripComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            dx = Convert.ToInt16(toolStripComboBox4.SelectedItem);
        }

        private void toolStripComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            dy = Convert.ToInt16(toolStripComboBox5.SelectedItem);
        }
    }
}