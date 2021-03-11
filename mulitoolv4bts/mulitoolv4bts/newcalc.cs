using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slinkosmtv4
{
    public partial class newcalc : Form
    {
        double a, b, c;
        bool aSet, bSet, cSet;
        int currOP;

      


        public newcalc()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (aSet == true && bSet == true)
            {
                inoutBox.Clear();
                aSet = false;
                bSet = false;
                currOP = -1;
            }
            inoutBox.Text += "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (aSet == true && bSet == true)
            {
                inoutBox.Clear();
                aSet = false;
                bSet = false;
                currOP = -1;
            }
            inoutBox.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (aSet == true && bSet == true)
            {
                inoutBox.Clear();
                aSet = false;
                bSet = false;
                currOP = -1;
            }
            inoutBox.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (aSet == true && bSet == true)
            {
                inoutBox.Clear();
                aSet = false;
                bSet = false;
                currOP = -1;
            }
            inoutBox.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (aSet == true && bSet == true)
            {
                inoutBox.Clear();
                aSet = false;
                bSet = false;
                currOP = -1;
            }
            inoutBox.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (aSet == true && bSet == true)
            {
                inoutBox.Clear();
                aSet = false;
                bSet = false;
                currOP = -1;
            }
            inoutBox.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (aSet == true && bSet == true)
            {
                inoutBox.Clear();
                aSet = false;
                bSet = false;
                currOP = -1;
            }
            inoutBox.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (aSet == true && bSet == true)
            {
                inoutBox.Clear();
                aSet = false;
                bSet = false;
                currOP = -1;
            }
            inoutBox.Text += "7";
        }

        private void equals()
        {
            // 1 = +; 2 = -; 3 = *; 4 = /
            if (inoutBox.Text != "")
            {
                if (aSet == true && bSet == false)
                {
                    try
                    {
                        b = Convert.ToDouble(inoutBox.Text);
                        if (currOP == 1)
                        {
                            c = a + b;
                        }
                        else if (currOP == 2)
                        {
                            c = a - b;
                        }
                        else if (currOP == 3)
                        {
                            c = a * b;
                        }
                        else if (currOP == 4)
                        {
                            c = a / b;
                        }
                        inoutBox.Text = Convert.ToString(c);
                        bSet = true;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Error. Check your input format. Place \"-\" and \".\" in proper places and make sure there are no duplicates.", "Format Error");
                        aSet = false;
                        bSet = false;
                        inoutBox.Clear();
                        currOP = -1;
                    }

                }
            }
        }

        private void doMath()
        {
            if (inoutBox.Text != "")
            {
                if (aSet == true && bSet == true)
                {
                    aSet = false;
                }

                if (aSet == false)
                {

                    try
                    {
                        if (bSet == true)
                        {
                            a = c;
                            b = 0;
                            bSet = false;
                        }
                        else
                        {
                            a = Convert.ToDouble(inoutBox.Text);
                        }
                        inoutBox.Clear();
                        aSet = true;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Error. Check your input format. Place \"-\" and \".\" in proper places and make sure there are no duplicates.", "Format Error");
                        aSet = false;
                        bSet = false;
                        inoutBox.Clear();
                        currOP = -1;

                    }

                }
                else if (bSet == false)
                {
                    try
                    {
                        b = Convert.ToDouble(inoutBox.Text);
                        if (currOP == 1)
                        {
                            c = a + b;
                        }
                        else if (currOP == 2)
                        {
                            c = a - b;
                        }
                        else if (currOP == 3)
                        {
                            c = a * b;
                        }
                        else if (currOP == 4)
                        {
                            c = a / b;
                        }
                        inoutBox.Text = Convert.ToString(c);
                        bSet = true;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Error. Check your input format. Place \"-\" and \".\" in proper places and make sure there are no duplicates.", "Format Error");
                        aSet = false;
                        bSet = false;
                        inoutBox.Clear();
                        currOP = -1;
                    }
                }
            }
        }

       

        private void Buttonequals_Click(object sender, EventArgs e)
        {
            equals();
        }
        

        private void Buttonminus_Click(object sender, EventArgs e)
        {
            currOP = 2;
            doMath();
        }


        private void Buttonplus_Click(object sender, EventArgs e)
        {
            currOP = 1;
            doMath();
        }

        private void Buttonmult_Click(object sender, EventArgs e)
        {
            currOP = 3;
            doMath();
        }

        private void Buttondivide_Click(object sender, EventArgs e)
        {
            currOP = 4;
            doMath();
        }

        private void ButtonclearAll_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            inoutBox.Clear();
            aSet = false;
            bSet = false;
            currOP = -1;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (aSet == false)
                inoutBox.Clear();
            else if (bSet == false)
                inoutBox.Clear();
        }

        private void Newcalc_KeyDown(object sender, KeyEventArgs e)
        {
         
           

            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                if (aSet == true && bSet == true)
                {
                    clearAll();
                }
                inoutBox.Text += "0";
            }
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                if (aSet == true && bSet == true)
                {
                    clearAll();
                }
                inoutBox.Text += "1";
            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                if (aSet == true && bSet == true)
                {
                    clearAll();
                }
                inoutBox.Text += "2";
            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                if (aSet == true && bSet == true)
                {
                    clearAll();
                }
                inoutBox.Text += "3";
            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                if (aSet == true && bSet == true)
                {
                    clearAll();
                }
                inoutBox.Text += "4";
            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                if (aSet == true && bSet == true)
                {
                    clearAll();
                }
                inoutBox.Text += "5";
            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                if (aSet == true && bSet == true)
                {
                    clearAll();
                }
                inoutBox.Text += "6";
            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                if (aSet == true && bSet == true)
                {
                    clearAll();
                }
                inoutBox.Text += "7";
            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                if (aSet == true && bSet == true)
                {
                    clearAll();
                }
                inoutBox.Text += "8";
            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                if (aSet == true && bSet == true)
                {
                    clearAll();
                }
                inoutBox.Text += "9";
            }
            if (e.KeyCode == Keys.Add)
            {
                currOP = 1;
                doMath();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                currOP = 2;
                doMath();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                currOP = 3;
                doMath();
            }
            if (e.KeyCode == Keys.Divide)
            {
                currOP = 4;
                doMath();
            }
            if (e.KeyCode == Keys.OemMinus)
            {
                inoutBox.Text += "-";
            }
            if (e.KeyCode == Keys.R)
            {
                clearAll();
            }
            if (e.KeyCode == Keys.E)
            {
                if (aSet == false)
                    inoutBox.Clear();
                else if (bSet == false)
                    inoutBox.Clear();
            }
            if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                inoutBox.Text += ".";
            }
            if (e.KeyCode == Keys.C)
            {
                equals();
            }

        }

        private void InoutBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void InoutBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Buttons work like a normal calculator. Use the keyboard's 0-9 (including NumPad) to input numbers. \nUse R" +
                " to reset the calulator.\nUse E to clear the current value. \nUse C to compute.\nFor operations on the keyboard, " +
                "you must have a NumPad on your keyboard (most keyboards do). \nPlus is plus, minus is minus, visa versa. Period or decimal " +
                "adds a decimal point, and dash adds a negative sign.\nNOTE: If you input a value after doing a complete compute" +
                " (computing two values), the calculator will automatically reset.", "Tutorial");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (aSet == true && bSet == true)
            {
                inoutBox.Clear();
                aSet = false;
                bSet = false;
                currOP = -1;
            }
            inoutBox.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (aSet == true && bSet == true)
            {
                inoutBox.Clear();
                aSet = false;
                bSet = false;
                currOP = -1;
            }
            inoutBox.Text += "9";
        }

        

        private void Buttonnegative_Click(object sender, EventArgs e)
        {
            if (aSet == true && bSet == true)
            {
                inoutBox.Clear();
                aSet = false;
                bSet = false;
                currOP = -1;
            }
            inoutBox.Text += "-";
        }

        private void Buttondecimal_Click(object sender, EventArgs e)
        {
            if (aSet == true && bSet == true)
            {
                inoutBox.Clear();
                aSet = false;
                bSet = false;
            }
            inoutBox.Text += ".";
        }

    }
}
