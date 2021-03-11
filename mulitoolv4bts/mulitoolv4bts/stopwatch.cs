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
    public partial class stopwatch : Form
    {
        int h, m, s, ms;
        bool start;
        public stopwatch()
        {
            InitializeComponent();
        }

        private void upTime_Tick(object sender, EventArgs e)
        {
            ms += 1;

            if (ms == 10)
            {
                s += 1;
                ms = 0;
            }

            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            if (m == 60)
            {
                m = 0;
                h += 1;
            }

            hD.Text = Convert.ToString(h);
            mD.Text = Convert.ToString(m);
            sD.Text = Convert.ToString(s);
            msD.Text = Convert.ToString(ms);
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                start = true;
                upTime.Start();
                sButton.Text = "STOP";
            }
            else if (start == true)
            {
                start = false;
                upTime.Stop();
                sButton.Text = "START";
            }
        }

        private void rButton_Click(object sender, EventArgs e)
        {
            h = 0;
            m = 0;
            s = 0;
            ms = 0;

            hD.Text = Convert.ToString(h);
            mD.Text = Convert.ToString(m);
            sD.Text = Convert.ToString(s);
            msD.Text = Convert.ToString(ms);
        }
    }
}
