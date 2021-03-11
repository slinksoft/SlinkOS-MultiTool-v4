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
    public partial class clipboardcs : Form
    {
        string pastcopy;
        string currentcopy;
        Image past;
        Image current;
        public clipboardcs()
        {
            InitializeComponent();
        }

        private void fetchClipboard_Tick(object sender, EventArgs e)
        {
            currentcopy = Clipboard.GetText();
            if (currentcopy != pastcopy)
            {
                pastcopy = currentcopy;
                string time = DateTime.Now.ToString("hh:mm:ss tt");
                string date = DateTime.Today.ToString("M-dd-yyyy"); ;
                cbHistory.Text += "[" + time + " " + date  + "]  " + pastcopy + System.Environment.NewLine;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Clipboard.Clear();
            cbHistory.Text = "";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
