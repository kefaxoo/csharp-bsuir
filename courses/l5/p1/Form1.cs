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

        private void splitContainer2_Panel1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                (sender as SplitterPanel).BackColor = colorDialog1.Color;
        }

        private void splitContainer2_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                    (sender as SplitterPanel).Font = fontDialog1.Font;
        }

        private void splitContainer2_Panel1_SizeChanged(object sender, EventArgs e)
        {
            label1.Left = (splitContainer2.Panel1.Width - label1.Width) / 2;
            label1.Top = (splitContainer2.Panel1.Height - label1.Height) / 2;
        }

        private void splitContainer3_Panel1_SizeChanged(object sender, EventArgs e)
        {
            label2.Left = (splitContainer3.Panel1.Width - label2.Width) / 2;
            label2.Top = (splitContainer3.Panel1.Height - label2.Height) / 2;
        }
    }
}
