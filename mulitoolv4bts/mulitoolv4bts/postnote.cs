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
    public partial class postnote : Form
    {
        Point mouse1;
        bool move, toMove;
        public postnote(int ct)
        {
            InitializeComponent();
            move = true;
            toMove = false;
            postTitle.Text = "Post Note # " + ct; 
        }

        private void Moveandstop_Tick(object sender, EventArgs e)
        {
            mouse1 = Cursor.Position;
            this.Location = new System.Drawing.Point(mouse1.X - (this.Width / 2), mouse1.Y - (this.Height / 2));
        }

        private void Postnote_MouseClick(object sender, MouseEventArgs e)
        {
            if (toMove == false)
            {
                if (move == true)
                {
                    move = false;
                    moveandstop.Stop();
                    toMove = true;
                }
                else if (move == false)
                {
                    move = true;
                    moveandstop.Start();
                }
            }
        }

        private void Postnote_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.MouseClick += Postnote_MouseClick;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void MButton_Click(object sender, EventArgs e)
        {
            toMove = false;
            
        }
    }
}
