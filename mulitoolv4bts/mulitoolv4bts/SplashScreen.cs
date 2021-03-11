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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void openMenu_Tick(object sender, EventArgs e)
        {
            menu openMenuu = new menu();
            openMenu.Stop();
            openMenu.Dispose();
            this.Dispose();
            menu start = new menu();
            start.ShowDialog();
        }
    }
}
