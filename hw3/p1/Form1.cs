using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                label1.Visible = false;
            else
                label1.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightSkyBlue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void checkBoxpravo_CheckedChanged(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleRight;
            if (checkBoxlevo.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxlevo.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.MiddleCenter;
            }
            if (checkBoxup.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxup.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.TopRight;
            }
            if (checkBoxdown.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.BottomRight;
            }
            if (checkBoxlevo.Checked == true && checkBoxup.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxlevo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxup.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.TopCenter;
            }
            if (checkBoxlevo.Checked == true && checkBoxdown.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxlevo.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.BottomCenter;
            }
            if (checkBoxup.Checked == true && checkBoxdown.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxup.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.MiddleRight;
            }
            if (checkBoxlevo.Checked == true && checkBoxup.Checked == true && checkBoxdown.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxlevo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxup.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void checkBoxlevo_CheckedChanged(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleLeft;
            if (checkBoxpravo.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxlevo.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.MiddleCenter;
            }
            if (checkBoxup.Checked == true)
            {
                checkBoxlevo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxup.CheckState = CheckState.Indeterminate;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.TopLeft;
            }
            if (checkBoxdown.Checked == true)
            {
                checkBoxlevo.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.BottomLeft;
            }
            if (checkBoxpravo.Checked == true && checkBoxup.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxlevo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxup.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.TopCenter;
            }
            if (checkBoxpravo.Checked == true && checkBoxdown.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxlevo.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.BottomCenter;
            }
            if (checkBoxup.Checked == true && checkBoxdown.Checked == true)
            {
                checkBoxlevo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxup.CheckState = CheckState.Indeterminate;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.TopLeft;
            }
            if (checkBoxpravo.Checked == true && checkBoxup.Checked == true && checkBoxdown.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxlevo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxup.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void checkBoxup_CheckedChanged(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.TopCenter;
            if (checkBoxdown.Checked == true)
            {
                checkBoxup.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxup.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.MiddleCenter;
            }
            if (checkBoxlevo.Checked == true)
            {
                checkBoxlevo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxup.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.TopCenter;
            }
            if (checkBoxpravo.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxup.CheckState = CheckState.Indeterminate;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.TopRight;
            }
            if (checkBoxlevo.Checked == true && checkBoxpravo.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxlevo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxup.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.TopCenter;
            }
            if (checkBoxpravo.Checked == true && checkBoxdown.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxup.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.MiddleRight;
            }
            if (checkBoxlevo.Checked == true && checkBoxdown.Checked)
            {
                checkBoxlevo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxup.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.MiddleLeft;
            }
            if (checkBoxpravo.Checked == true && checkBoxlevo.Checked == true && checkBoxdown.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxlevo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxup.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
        private void checkBoxdown_CheckedChanged(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.BottomCenter;
            if (checkBoxlevo.Checked == true)
            {
                checkBoxlevo.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.BottomLeft;
            }
            if (checkBoxpravo.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.BottomRight;
            }
            if (checkBoxup.Checked == true)
            {
                checkBoxup.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxup.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.MiddleCenter;
            }
            if (checkBoxlevo.Checked == true && checkBoxpravo.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxlevo.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.BottomCenter;
            }
            if (checkBoxlevo.Checked == true && checkBoxup.Checked == true)
            {
                checkBoxup.ThreeState = true;
                checkBoxlevo.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                checkBoxup.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.MiddleLeft;
            }
            if (checkBoxpravo.Checked == true && checkBoxup.Checked == true)
            {
                checkBoxdown.ThreeState = true;
                checkBoxpravo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                checkBoxup.CheckState = CheckState.Indeterminate;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.MiddleRight;
            }
            if (checkBoxpravo.Checked == true && checkBoxlevo.Checked == true && checkBoxup.Checked == true)
            {
                checkBoxpravo.ThreeState = true;
                checkBoxlevo.ThreeState = true;
                checkBoxup.ThreeState = true;
                checkBoxdown.ThreeState = true;
                checkBoxpravo.CheckState = CheckState.Indeterminate;
                checkBoxlevo.CheckState = CheckState.Indeterminate;
                checkBoxup.CheckState = CheckState.Indeterminate;
                checkBoxdown.CheckState = CheckState.Indeterminate;
                label1.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
