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

        Color color;
        Graphics graphics;
        Pen pen; // линии
        SolidBrush sb; // области

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                color = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!color.IsEmpty)
            {
                graphics.Clear(Color.White);
                pen = new Pen(color);
                for (int i = 0; i < this.ClientRectangle.Width; i += 10)
                    graphics.DrawLine(pen, i, 0, i, this.ClientRectangle.Height);
                for (int i = 0; i < this.ClientRectangle.Height; i += 10)
                    graphics.DrawLine(pen, 0, i, this.ClientRectangle.Width, i);
            }
            else
                MessageBox.Show("Выберите цвет");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            Random rand = new Random();
            color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            sb = new SolidBrush(color);
            pen = new Pen(color);
            for (int i = 0; i < this.ClientRectangle.Width; i += 50)
                for (int j = 0; j < this.ClientRectangle.Height; j += 50)
                {
                    graphics.FillEllipse(sb, i, j, 10, 10);
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            Random rand = new Random();
            for (int r = 0; r < this.ClientRectangle.Width; r += 10)
            {
                pen = new Pen(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)), 5);
                graphics.DrawEllipse(pen, this.ClientRectangle.Width / 2 - r, this.ClientRectangle.Height / 2 - r, r * 2, r * 2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            sb = new SolidBrush(Color.DarkRed);
            Point[] points = new Point[4];
            points[0].X = 200;
            points[0].Y = 200;
            points[1].X = 350;
            points[1].Y = 150;
            points[2].X = 500;
            points[2].Y = 200;
            points[3] = points[0];
            graphics.FillPolygon(sb, points);
            
            sb = new SolidBrush(Color.Beige);
            graphics.FillRectangle(sb, 210, 200, 280, 150);

            pen = new Pen(Color.DarkGray, 5);
            graphics.DrawLine(pen, 250, 230, 450, 230);
            graphics.DrawLine(pen, 250, 300, 450, 300);
            graphics.DrawLine(pen, 252, 230, 252, 300);
            graphics.DrawLine(pen, 447, 230, 447, 300);

            sb = new SolidBrush(Color.LightGray);
            graphics.FillRectangle(sb, 255, 233, 190, 65);

            graphics.DrawLine(pen, 250, 265, 450, 265);

            pen = new Pen(Color.Brown, 3);
            for (int i = 150; i < 550; i += 10)
                graphics.DrawLine(pen, i, 320, i, 370);
        }
    }
}
