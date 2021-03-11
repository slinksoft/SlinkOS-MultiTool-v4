using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace slinkosmtv4
{
    public partial class calculator : Form
    {
        Double a, b, c;
        public calculator()
        {
            InitializeComponent();
        }

        private void exeButton_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculator_Load(object sender, EventArgs e)
        {
            functionBox.SelectedIndex = 0;
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            aI.Text = cI.Text;
            bI.Text = "";
            cI.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            aI.Text = "";
            bI.Text = "";
            cI.Text = "";
        }

        private void calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
                functionBox.SelectedIndex = 0;
            if (e.KeyCode == Keys.Subtract)
                functionBox.SelectedIndex = 1;
            if (e.KeyCode == Keys.Multiply)
                functionBox.SelectedIndex = 2;
            if (e.KeyCode == Keys.Divide)
                functionBox.SelectedIndex = 3;
            if (e.KeyCode == Keys.C)
                calculate();
            if (e.KeyCode == Keys.R)
            {
                aI.Text = cI.Text;
                bI.Text = "";
                cI.Text = "";
            }
            if (e.KeyCode == Keys.E)
            {
                aI.Text = "";
                bI.Text = "";
                cI.Text = "";
            }

        }

        private void calculate()
        {
            if (aI.Text == "")
            {
                aI.Text = "0";
            }
            if (bI.Text == "")
            {
                bI.Text = "0";
            }

            if (aI.Text.Contains("-"))
            {
                if ('-' == aI.Text[0])
                {
                    aI.Text = aI.Text.Replace("-", "");
                    aI.Text = "-" + aI.Text;
                }
                else
                    aI.Text = aI.Text.Replace("-", "");
            }

            if (bI.Text.Contains("-"))
            {
                if ('-' == bI.Text[0])
                {
                    bI.Text = bI.Text.Replace("-", "");
                    bI.Text = "-" + bI.Text;
                }
                else
                    bI.Text = bI.Text.Replace("-", "");
            }
            try
            {
                a = Convert.ToDouble(aI.Text);
                b = Convert.ToDouble(bI.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please check A and B textboxes to ensure missing restricted characters are not included, a negative sign is not " 
                                +"out of place, a decimal point is not out of place, or unneccessary decimal points or negative signs are not included, " 
                                +"then try calculating again.", "Format Exception!");
            }

            if (functionBox.SelectedIndex == 0)
            {
                c = a + b;
                cI.Text = Convert.ToString(c);
            }
            else if (functionBox.SelectedIndex == 1)
            {
                c = a - b;
                cI.Text = Convert.ToString(c);
            }
            else if (functionBox.SelectedIndex == 2)
            {
                c = a * b;
                cI.Text = Convert.ToString(c);
            }
            else if (functionBox.SelectedIndex == 3)
            {
                c = a / b;
                cI.Text = Convert.ToString(c);
            }
        }

        private void aI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 126)
            {
                e.Handled = true;
            }

            if (e.KeyChar >= 33 && e.KeyChar <= 44)
            {
                e.Handled = true;
            }

            if (e.KeyChar >= 58 && e.KeyChar <= 64)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 47)
            {
                e.Handled = true;
            }
        }

        private void bI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 126)
            {
                e.Handled = true;
            }

            if (e.KeyChar >= 33 && e.KeyChar <= 44)
            {
                e.Handled = true;
            }

            if (e.KeyChar >= 58 && e.KeyChar <= 64)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 47)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOTE: ONLY SUPPORTED WITH KEYBOARDS THAT HAVE NUMPADS (More than likely, your keyboard has one): Press C to calculate. Press any of the four operators (+-*/) to change its operators. Press R to resume calculation, "
            + "setting C to A and leaving B blank for a new value. Use the TAB key to switch between A and B fields. Press E to clear all fields.", "Keyboard Shortcuts Help");
        }

    }


}
