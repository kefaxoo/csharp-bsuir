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

        Graphics graphics;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            SolidBrush sb = new SolidBrush(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
            int width = this.ClientRectangle.Width, height = this.ClientRectangle.Height;
            int x0 = width - rand.Next(0, width), y0 = height - rand.Next(0, height);
            int x = width - rand.Next(x0, width), y = height - rand.Next(y0, height);

            graphics.FillEllipse(sb, x0, y0, x, y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
        }
    }
}
