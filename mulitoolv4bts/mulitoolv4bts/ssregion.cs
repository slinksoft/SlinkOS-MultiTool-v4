using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace slinkosmtv4
{
    public partial class ssregion : Form
    {
        public bool part1;
        public bool part2;
        public ssregion()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (part1 == false && part2 == false)
            {
                this.Location = Cursor.Position;
            }
            else if (part1 == true && part2 == false)
            {
                this.Size = new System.Drawing.Size(Cursor.Position.X - this.Left, Cursor.Position.Y - this.Top);
            }

            if (Control.MouseButtons == MouseButtons.Left && part1 == false)
            {
                part1 = true;
                this.Focus();
            }
            else if (Control.MouseButtons == MouseButtons.Left && part2 == false)
            {
                part2 = true;
                progress.Stop();
                infoLabel.Visible = true;
                this.Activate();
                this.TopMost = true;
                if (this.Width < 80 || this.Height < 80)
                {
                    MessageBox.Show("Seems you have made your region small. Press C to capture the regioned "
                        + "screenshot. If not captured right away, click the region to gain focus and press C "
                        + "again to capture.", "Small Region Detection!");
                }
                
            }
        }

        private void delayClose_Tick(object sender, EventArgs e)
        {
            delayClose.Stop();
            this.Close();
        }

        private void delaySave_Tick(object sender, EventArgs e)
        {
            // intializes bitmap immage
            try
            {
                Bitmap shot = new Bitmap(Clipboard.GetImage());
                //saves screenshot and checks if current sceenshot name exists
                string time = DateTime.Now.ToString("hh-mm-ss tt");
                Rectangle cropped = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
                Bitmap croppedShot = new Bitmap(shot.Clone(cropped, shot.PixelFormat));
                string date = DateTime.Today.ToString("M-dd-yyyy"); ;
                string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + time + "_" + date + ".png";

                croppedShot.Save(filepath, ImageFormat.Png);
            }
            catch(NullReferenceException ex)
            {
                delaySave.Stop();
                MessageBox.Show("An error occurred! This likely happens due to the way Windows 10 handles the clipboard feature. Just try again and it SHOULD " +
                    "just work.", "Error");
            }
            delaySave.Stop();
            delayClose.Start();
        }

        private void ssregion_KeyDown(object sender, KeyEventArgs e)
        {
            if (part1 == true && part2 == true && e.KeyCode == Keys.C)
            {
                this.Opacity = 0;

                /* old screenshot code from ScreenSpy had to be scrapped due to bug/changes in windows 8 and later that does not
                allow 3rd party applications to capture the screenshot directly unless it is running as a service..
                more advanced code would be needed. There is no need to have SlinkOS run as a service over this issue... so 
                I am using PRTSC to manipulate the capture screenshot. A delay timer is necessary due to saving code being
                executed at the same time as the getImage method from Clipboard
                delaying the code execution thread... so when it captures the screenshot, the save
                method/function does not pick up the image right away... which is very strange.*/

                Clipboard.Clear();
                SendKeys.Send("{PRTSC}");
                delaySave.Start();
            }

            if (e.KeyCode == Keys.Space && part1 == false)
                part1 = true;
            else if (e.KeyCode == Keys.Space && part2 == false)
                {
                part2 = true;
                progress.Stop();
                infoLabel.Visible = true;
                this.Activate();
                this.TopMost = true;
                if (this.Width < 80 || this.Height < 80)
                {
                    MessageBox.Show("Seems you have made your region small. Press C to capture the regioned "
                        + "screenshot. If not captured right away, click the region to gain focus and press C "
                        + "again to capture.", "Small Region Detection!");
                } 
            }
        }
    }
}
