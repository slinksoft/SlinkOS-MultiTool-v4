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
    public partial class censorbar : Form
    {
        int namenumber;
        Point mouse1;

        public censorbar()
        {
            InitializeComponent();
            namenumber = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wI.Text == "")
            {
                wI.Text = "200";
            }
            if (hI.Text == "")
            {
                hI.Text = "50";
            }

            cb cbo = new cb();
            cbo.Show();
            cbo.Name = "cbar" + Convert.ToString(namenumber);
            cbo.numberofbar.Text = "CB#: " +Convert.ToString(namenumber) + " - SlinkOS";
            cbo.Size = new System.Drawing.Size(Convert.ToInt32(wI.Text), Convert.ToInt32(hI.Text));

            namenumber += 1;
        }

        private void dButton_Click(object sender, EventArgs e)
        {
            foreach (Form c in Application.OpenForms)
            {
                if (c.Name == "cbar" + dI.Text)
                {
                    c.Close();
                    break;
                }
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Input desired width and height of the censor bar; then hit 'Add Bar'. Once the bar appears, move around your mouse, then left click to set its place. To delete a bar, look for a number on each individual censor bar, input it into the field, and press 'Delete Bar'. Censors bars can stay even when closing the options window.", "Tutorial");
        }



    }
}
