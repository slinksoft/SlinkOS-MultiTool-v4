using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace slinkosmtv4
{
    public partial class equationCalc : Form
    {
        public equationCalc()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            calculateIt();
        }

        private void MessageFeatures_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trigonometry Functions (Case Sensitive, first letter must be capitalized):\n\nSin(n)\nCos(n)\nTan(n)\nFor csc: 1/Sin(n)\nFor sec: 1/Cos(n)\nFor cot: 1/Tan(n)\n\n" +
                "Operators: + - * /\n\nFor Pi (Capital P): Pi\n\nFor Pow (Capital P): Pow(x, n)\n\n" +
                "Parentheses are allowed.", "Features");
        }


        private void ResultOutput_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void ResultOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void EquationInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
            {
                calculateIt();
            }
        }

        private void calculateIt()
        {
            try
            {
                String nExpression = "";
                if (equationInput.Text.Contains("Pi"))
                    nExpression = equationInput.Text.Replace("Pi", "3.14159265359");
                else
                    nExpression = equationInput.Text;
                Expression ex = new Expression(nExpression);
                String result = ex.Evaluate().ToString();
                resultOutput.Text = result;
            }
            catch (Exception except)
            {
                MessageBox.Show("Error in expression! Check your expression for errors. Click \"Features\" to see available functions and features.", "Error");
            }
        }
    }
}
