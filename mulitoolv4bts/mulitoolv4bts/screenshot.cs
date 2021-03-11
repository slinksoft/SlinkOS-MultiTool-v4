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
    public partial class screenshot : Form
    {
        bool createrd;
        bool part1;
        bool part2;
        bool process;
        public screenshot()
        {
            InitializeComponent();
        }

        private void coordUpdate_Tick(object sender, EventArgs e)
        {
            Point mousecoords = Cursor.Position;
            coordD.Text = "Current Coordinates:" + System.Environment.NewLine + Convert.ToString(mousecoords);



        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void snapRegion_Click(object sender, EventArgs e)
        {
            ssregion open = new ssregion();
            open.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("When the semi-transparent black box comes up, choose the initial coordinates " +
                "(where you want to start the screenshot) by dragging and left clicking your mouse." 
                + System.Environment.NewLine + "Then, drag out the box (expanding its dimensions) and left click again." +
                " Finally, press C to capture. All screenshots will be saved to the desktop with a time stamp as the file name."
                + "\n\nNEW: You can now press the space bar to create the desired region you want to capture. Move your" +
                " mouse to choose the initial coordinates. Press the space bar, then drag out your mouse to expand" +
                " the capture region's dimensions and press the space bar again. Continue with capturing the region" +
                " with the C key.", "Tutorial");
        }

        private void delaySave_Tick(object sender, EventArgs e)
        {
            try
            {
                // intializes bitmap immage
                Bitmap shot = new Bitmap(Clipboard.GetImage());
                //saves screenshot and checks if current sceenshot name exists
                string time = DateTime.Now.ToString("hh-mm-ss tt");
                string date = DateTime.Today.ToString("M-dd-yyyy"); ;
                string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + time + "_" + date + ".png";

                shot.Save(filepath, ImageFormat.Png);
            }
            catch (NullReferenceException ex)
            {
                delaySave.Stop();
                MessageBox.Show("An error occurred! This likely happens due to the way Windows 10 handles the clipboard feature. Just try again and it SHOULD " +
                    "just work.", "Error");
            }
            delaySave.Stop();
        }

       
    }
}
