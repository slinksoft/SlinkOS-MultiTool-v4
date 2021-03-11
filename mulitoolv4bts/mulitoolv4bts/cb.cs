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
    public partial class cb : Form
    {
        Point mouse1;
        bool move;
        public cb()
        {
            InitializeComponent();
            move = true;
        }

        private void moveandstop_Tick(object sender, EventArgs e)
        {
            mouse1 = Cursor.Position;
            this.Location = new System.Drawing.Point(mouse1.X - (this.Width/2), mouse1.Y - (this.Height/2));
        }

        private void cb_MouseClick(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                move = false;
                moveandstop.Stop();
            }
            else if (move == false)
            {
                move = true;
                moveandstop.Start();
            }
        }

        private void cb_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
