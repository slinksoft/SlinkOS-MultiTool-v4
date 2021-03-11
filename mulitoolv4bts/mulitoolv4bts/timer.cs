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
    public partial class timer : Form
    {
        bool started;
        int h, m, s;
        System.Media.SoundPlayer chim = new System.Media.SoundPlayer(Properties.Resources.chim);
        public timer()
        {
            InitializeComponent();
            started = false;
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            if (started == false)
            {

                if (hI.Text == "")
                {
                    hI.Text = "0";
                }
                if (mI.Text == "")
                {
                    mI.Text = "0";

                }
                if (sI.Text == "")
                {
                    sI.Text = "0";
                }
                h = Convert.ToInt32(hI.Text);
                m = Convert.ToInt32(mI.Text);
                s = Convert.ToInt32(sI.Text);
                hD.Text = Convert.ToString(h);
                mD.Text = Convert.ToString(m);
                sD.Text = Convert.ToString(s);

                started = true;
                sButton.Text = "STOP";
                timerz.Start();
            }
            else if (started == true)
            {
                started = false;
                sButton.Text = "START";
                timerz.Stop();
            }
        }

        private void timerz_Tick(object sender, EventArgs e)
        {
            s -= 1;
            if (s == -1)
            {
                m -= 1;
                s = 59;
            }

            if (m == -1)
            {
                h -= 1;
                m = 59;
            }

            hD.Text = Convert.ToString(h);
            mD.Text = Convert.ToString(m);
            sD.Text = Convert.ToString(s);

            if (h == 0 && m == 0 && s <= 0)
            {
                timerz.Stop();
                chim.PlayLooping();
                MessageBox.Show("TIME!", "TIME!");
                chim.Stop();
                started = false;
                sButton.Text = "START";
            }
            else if (h == -1 && m == 59 && s == 59)
            {
                timerz.Stop();
                MessageBox.Show("Invalid Time! Input Values And Try Again.", "Error");
                started = false;
                sButton.Text = "START";
            }

        }
    }
}
