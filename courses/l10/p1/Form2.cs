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
        public Graphics g;
        public Pen p1;
        public Form1 f1;
  
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            Color c = f1.c;
            Pen p1 = new Pen(c);
            g.DrawLine(p1, e.X - 5, e.Y - 5, e.X + 5, e.Y + 5);
            g.DrawLine(p1, e.X - 5, e.Y + 5, e.X + 5, e.Y - 5);
        }
    }
}
