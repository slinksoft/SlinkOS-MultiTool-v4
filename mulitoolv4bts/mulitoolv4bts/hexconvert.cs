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
    public partial class hexconvert : Form
    {
        public hexconvert()
        {
            InitializeComponent();
        }

        private void converttoB_Click(object sender, EventArgs e)
        {
            hexI.Text = tohexx(asciiI.Text);
        }

        private void converttoA_Click(object sender, EventArgs e)
        {
            string containhex = hexI.Text.Replace(" ", "");
            hexI.Text = containhex;
            asciiI.Text = tostringg(hexI.Text);
            
        }


        public string tohexx(string asciistring)
        {
            string hex = "";
            foreach (char c in asciistring)
            {
                int tmp = c;
                hex += string.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }

            return hex;
        }

        public string tostringg(string hexvalue)
        {
            string strvalue = "";
            while (hexvalue.Length > 0)
            {
                strvalue += System.Convert.ToChar(System.Convert.ToUInt32(hexvalue.Substring(0, 2), 16)).ToString();
                hexvalue = hexvalue.Substring(2, hexvalue.Length - 2);
            }

            return strvalue;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            asciiI.Text = "Hello World!";
            hexI.Text = "48656c6c6f20576f726c6421";
        }

        private void binconvert_Load(object sender, EventArgs e)
        {
            asciiI.Text = "Hello World!";
            hexI.Text = "48656c6c6f20576f726c6421";
        }

    }
}
