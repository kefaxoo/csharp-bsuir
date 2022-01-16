using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName.ToString();
                StreamReader reader = new StreamReader(filename);

                Graphics graphics;
                graphics = this.CreateGraphics();
                graphics.Clear(Color.Peru);

                SolidBrush sb;
                string temp;
                Random rand = new Random();
                Color color = Color.Peru;
                int size = 0; // true - big, false - small
                
                while((temp = reader.ReadLine()) != null) 
                {
                    if (temp.Length == 2)
                    {
                        switch (temp[0])
                        {
                            case 'R':
                            case 'G':
                            case 'D':
                            case 'E':
                            case 'S':
                                size = 10;
                                break;
                            case 'r':
                            case 'g':
                            case 'd':
                            case 'e':
                            case 's':
                                size = 5;
                                break;
                        }

                        switch (temp[0])
                        {
                            case 'R':
                            case 'r':
                                color = Color.Red;
                                break;
                            case 'G':
                            case 'g':
                                color = Color.Yellow;
                                break;
                            case 'D':
                            case 'd':
                                color = Color.White;
                                break;
                            case 'E':
                            case 'e':
                                color = Color.Green;
                                break;
                            case 'S':
                            case 's':
                                color = Color.Blue;
                                break;
                        }
                    }
                    
                    sb = new SolidBrush(color);
                    for (int i = 0; i < Convert.ToInt32(temp[1].ToString()); i++)
                    {
                        int x0 = rand.Next(0, this.ClientRectangle.Width - size);
                        int y0 = rand.Next(0, this.ClientRectangle.Height - size);
                        graphics.FillEllipse(sb, x0, y0, size, size);
                    }
                }
            }
        }
    }
}
