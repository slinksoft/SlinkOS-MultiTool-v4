using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace slinkosmtv4
{

   
    public partial class spammer : Form
    {
        bool enabled;
        string texttospam;
        public spammer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (enabled == false)
            {
                if (intervalI.Text == "")
                {
                    intervalI.Text = "1000";
                }
                if (textI.Text == "")
                {
                    textI.Text = "spamm3rz";
                }
                enabled = true;
                texttospam = textI.Text;
                button1.Text = "STOP";
                spamtick.Interval = Convert.ToInt32(intervalI.Text);
                spamtick.Start();
              
            }
            else if (enabled == true)
            {
                enabled = false;
                button1.Text = "START";
                spamtick.Stop();
            }
        }

        private void spamtick_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(texttospam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In case the spammer/macro tool goes crazy and won't stop via \"STOP\" button, " +
                "simply press the red 'X' (close button) of the tool. It's that simple.", "Tip!");
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter desired text to spam. The interval is measured in milliseconds (ms); so 1000 ms " +
                "is equivalent to 1 second. Press start. Choose desired field on your desktop or program to spam text. " +
                "Press stop to stop the spammer. Press the red 'X' on the tool GUI window to close the spammer window  "+
                "if the spammer won't stop properly.\n\nNEW: While having the tool GUI in focus, enter the desired " +
                "interval to trigger the spammer/macro, and press the Ctrl+E key to start the process, then click " +
                "the desired text field to send the text being spammed/macro. To stop the tool, press any empty " +
                "space in the spammer/macro tool GUI (a blank space, not a control), and press the Ctrl+E key again " +
                "(pressing the STOP button still works, just not as well as this new implementation with the " +
                "Ctrl+E keys. NOTE: You may have to hold Ctrl+E for a second or two).", "Tutorial");
        }

        private void spammer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E && e.Modifiers == Keys.Control)
            {   
                    if (enabled == false)
                    {
                        if (intervalI.Text == "")
                        {
                            intervalI.Text = "1000";
                        }
                        if (textI.Text == "")
                        {
                            textI.Text = "spamm3rz";
                        }
                        enabled = true;
                        texttospam = textI.Text;
                        button1.Text = "STOP";
                        spamtick.Interval = Convert.ToInt32(intervalI.Text);
                        spamtick.Start();
                   

                }
                    else if (enabled == true)
                    {
                        enabled = false;
                        button1.Text = "START";
                        spamtick.Stop();
                    }
            }

        }

        private void intervalI_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 48; i < 58; i++)
            {
                if (e.KeyChar == i || e.KeyChar == 8)
                {
                    if (spamtick.Enabled == false)
                    {
                        e.Handled = false;
                        break;
                    }
                }
                else
                    e.Handled = true;
            }
        }

        private void spam()
        {
            
        }
    }
}
