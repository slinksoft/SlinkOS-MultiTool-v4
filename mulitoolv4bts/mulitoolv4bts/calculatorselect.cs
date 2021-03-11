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
    public partial class calcSelector : Form
    {
        public calcSelector()
        {
            InitializeComponent();
        }

        private void Old_Click(object sender, EventArgs e)
        {
            calculator showme = new calculator();
            showme.Show();
            this.Close();
        }

        private void Neww_Click(object sender, EventArgs e)
        {
            newcalc showme = new newcalc();
            showme.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            equationCalc showme = new equationCalc();
            showme.Show();
            this.Close();
        }
    }
}
