using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using CefSharp;
using CefSharp.WinForms;
using System.Threading.Tasks;

namespace slinkosmtv4
{
    public partial class menu : Form
    {
        //menu vars
        int menupulllimit, version, revision, build;
        string completevnumber;
        bool refreshpage;
        //settings vars
        string uname;
        bool paintopen, ifversioncheck, ifStartup;
        int postNoteCt;
        // instance for hotkey
        Hotkey hk = new Hotkey();

        clipboardcs open = new clipboardcs();

        string source = "";


        //create one and only one instance of terminal
        terminal openme = new terminal();
        public menu() 
        {

            InitializeComponent();
            initializeChromiumBrowser();

            //set version number.
            version = 4;
            revision = 90;
            build = 20;
            versionDisplay.Text = "§linkOS MultiTool - " + version + "." + revision + "-" + build;
            completevnumber = Convert.ToString(version) + "." + Convert.ToString(revision) + "-" + Convert.ToString(build);

        }


        private void initializeChromiumBrowser()
        {
            updaterv2.Load("https://realslinksoft.wixsite.com/slink-soft-portfolio/project-releases");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //adds events for every control on menu
            foreach (Control c in this.Controls)
            {
                c.MouseEnter += settingsButton_MouseEnter; // only the menu, or form mouse enter event will control activation and focus. all other controls just control the menu tray drag
                c.MouseLeave += Form1_MouseLeave;
            }

            // opens and hides clipboard so instance can be controlled in SlinkOS Terminal
            open.Show();
            open.Hide();

            //sets location for menu and starts date time Timer.
            timeUpdate.Start();
            Rectangle location = Screen.PrimaryScreen.Bounds;
            this.Location = new System.Drawing.Point(location.Width - this.Width, -130);


            //used for installation of SlinkOS. Used to display username (for terminal tool later on in future updates). Also will check slinksoft for updates for SlinkOS when enabled by user in settings.
            using (RegistryKey Key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\")) // finds if registry keys exists already so it will not overwrite incorrect value.
            {
                string findkey = (string)Key.GetValue("SlinkOS");
                if (findkey == null)
                {
                    unDisplay.Visible = false;
                    if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SlinkOS") == true)
                    {
                        Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SlinkOS", true);
                    }
                }
                else
                {

                    StreamReader read = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SlinkOS\\settings.slinkOS");
                    uname = read.ReadLine();
                    paintopen = Convert.ToBoolean(read.ReadLine());
                    ifversioncheck = Convert.ToBoolean(read.ReadLine());
                    ifStartup = Convert.ToBoolean(read.ReadLine());
                    unDisplay.Text = "Welcome: " + uname;
                    read.Close();
                    openTerminal.Enabled = true;
                    openTerminal.Visible = true;

                    if (ifversioncheck == true)
                    {
                        updaterv2.Visible = true;
                        initializeChromiumBrowser();

                    }
                    else
                    {
                        updaterv2.Dispose();
                    }
                }
            }

            // register hotkey code
            hk.KeyCode = Keys.S;
            hk.Alt = true;
            hk.Register(this);
            hk.Pressed += delegate
            {
                if (this.TopMost == false)
                {
                    this.TopMost = true;
                    hkInfoLabel.ForeColor = Color.Lime;
                    hkInfoLabel.Text = "Press Alt+S to send back menu.";
                }
                else
                {
                    this.TopMost = false;
                    this.SendToBack();
                    hkInfoLabel.ForeColor = Color.Red;
                    hkInfoLabel.Text = "Press Alt+S to show menu on top.";
                }
            };

            postNoteCt = 1;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            //controls menu tray drag
            menuDown.Start();
            menuUp.Stop();

            this.Activate();


        }



        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            menuUp.Start();
            menuDown.Stop();

        }

        private void menuDown_Tick(object sender, EventArgs e)
        {
            if (menupulllimit < 26)
            {
                menupulllimit += 1;
                this.Top += 5;
            }
        }

        private void menuUp_Tick(object sender, EventArgs e)
        {
            if (menupulllimit > 0)
            {
                menupulllimit -= 1;
                this.Top -= 5;
            }
        }

        private void timeUpdate_Tick(object sender, EventArgs e)
        {
            string date;
            string time;

            date = DateTime.Today.ToString("M/dd/yyyy");
            time = DateTime.Now.ToString("hh:mm:ss tt");

            datetimeDisplay.Text = time + " - " + date;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer open = new timer();
            open.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stopwatch open = new stopwatch();
            open.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calcSelector open = new calcSelector();
            open.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            censorbar open = new censorbar();
            open.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataConversion open = new dataConversion();
            open.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hexconvert open = new hexconvert();
            open.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            spammer open = new spammer();
            open.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            screenshot open = new screenshot();
            open.Show();
        }

        private void snapDesktop_Click(object sender, EventArgs e)
        {
            /* old screenshot code from ScreenSpy had to be scrapped due to bug/changes in windows 8 and later that does not
               allow 3rd party applications to capture the screenshot directly unless it is running as a service..
               more advanced code would be needed. There is no need to have SlinkOS run as a service over this issue... so 
               I am using PRTSC to manipulate the capture screenshot. A delay timer is necessary due to saving code being
               executed at the same time as the getImage method from Clipboard
               delaying the code execution thread... so when it captures the screenshot, the save
               method/function does not pick up the image right away... which is very strange.*/

            Clipboard.Clear();
            SendKeys.Send("+{PRTSC}");
            delaySave.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            browser open = new browser();
            open.Show();
        }

        private void openClipboard_Click(object sender, EventArgs e)
        {
            open.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settings open = new settings();
            open.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using MultiTool v4/SlinkOS!", "Thank You!");
            Environment.Exit(0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string localip = "";
            string time = DateTime.Now.ToString("hh:mm:ss tt");
            string date = DateTime.Today.ToString("M-dd-yyyy @ ");
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            localip += "- " + ni.Name + ": " + ip.Address.ToString() + System.Environment.NewLine;
                        }
                    }
                }
            }
            MessageBox.Show("Report Printed On: " + date + time + System.Environment.NewLine + "----------------------------------------------------------" + System.Environment.NewLine + "External IP: " + getExternalIp() + System.Environment.NewLine + "Local IP: " + System.Environment.NewLine + localip + System.Environment.NewLine + "OS Name: " + System.Environment.OSVersion + System.Environment.NewLine + "Version: " + System.Environment.Version + System.Environment.NewLine + "Username: " + System.Environment.UserName + System.Environment.NewLine + "Domain Name: " + System.Environment.UserDomainName + System.Environment.NewLine + "Machine Name: " + System.Environment.MachineName + System.Environment.NewLine + "Is 64 bit: " + System.Environment.Is64BitOperatingSystem + System.Environment.NewLine + "# Of Processors: " + System.Environment.ProcessorCount + System.Environment.NewLine + "SlinkOS Version: " + completevnumber, "System Info");
        }

        private string getExternalIp()
        {
            try
            {
                string externalIP;
                externalIP = (new WebClient()).DownloadString("http://checkip.dyndns.org/");
                externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}"))
                             .Matches(externalIP)[0].ToString();
                return externalIP;
            }
            catch { return null; }
        }

        private void hibernateCPU_Click(object sender, EventArgs e)
        {
            // realigns the menu if screen size changes abruptly during suspension or sleep (happens when laptop lids close while suspending or sleeping
            menupulllimit = 0;
            Rectangle location = Screen.PrimaryScreen.Bounds;
            this.Location = new System.Drawing.Point(location.Width - this.Width, -130);
            Application.SetSuspendState(PowerState.Hibernate, true, true);


        }

        private void restartComputer_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r -t 0");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-s -t 0");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // realigns the menu if screen size changes abruptly during suspension or sleep (happens when laptop lids close while suspending or sleeping
            menupulllimit = 0;
            Rectangle location = Screen.PrimaryScreen.Bounds;
            this.Location = new System.Drawing.Point(location.Width - this.Width, -130);
            Application.SetSuspendState(PowerState.Suspend, true, true);
        }

        private void settingsButton_MouseEnter(object sender, EventArgs e)
        {
            //Will be applied on all buttons and controls besides the form itself. See Form Load event.

            //controls menu tray drag
            menuDown.Start();
            menuUp.Stop();

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            openme.executeTerminal();
      
        }

        private void openPerformance_Click(object sender, EventArgs e)
        {
            performance showme = new performance();
            showme.Show();
        }

      
        //When the Chromium browser finishes loading, we will get the entire page's source code and store it into string source to check for the latest version of SlinkOS.
        private void Updaterv2_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Frame.IsMain)
            {
                updaterv2.GetSourceAsync().ContinueWith(taskHtml =>
                {
                    source = taskHtml.Result;
                });
                checkUpdateV2.Start();
            }

        }

        private void CheckUpdateV2_Tick(object sender, EventArgs e)
        {
            if (source.Contains(completevnumber))
            {
                latestUpdateCheck.Invoke((Action)delegate
                {
                    latestUpdateCheck.Visible = true;
                    updaterv2.Dispose();
                    MessageBox.Show("This is the final version of SlinkOS. Development has stopped as Slink is moving on to other projects of interest and moving forward with his career.\n\n" +
                        "For more information, visit: https://realslinksoft.wixsite.com/slink-soft-portfolio \n\nThank You!", "NOTICE");
                });
            }
            else if (source == "<html><head></head><body></body></html>") // cefsharp chromium processes a blank webpage with the basic tags: html,head, and body with no content within them.
            {
                latestUpdateCheck.Invoke((Action)delegate
                {
                    MessageBox.Show("Error: Failed to fetch version from SlinkSoft! Either you have no Internet connection or the website (Wix servers) are down! Please try again later.", "ERROR!");
                    updaterv2.Dispose();
                });
            }
            else
            {
                latestUpdateCheck.Invoke((Action)delegate
                {
                    MessageBox.Show("There is an update for MultiTool v4/SlinkOS! Go to https://realslinksoft.wixsite.com/slink-soft-portfolio/project-releases and download it. Before installing the new update, uninstall the current build from the settings window. Thank you for using SlinkOS!", "Update Available!");
                    updaterv2.Dispose();
                });
            }
            checkUpdateV2.Stop();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            postnote newPost = new postnote(postNoteCt);
            newPost.Show();
            postNoteCt++;
        }

        /* timer to control the enabled property for button objects/controls. This is necessary to prevent the user from accidentally
           hibernating, shuting down, restarting, or sleeping the computer when on the desktop and hitting the enter key. This bug 
           is a rare occurance, but this will fix it.
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form.ActiveForm != this || this.Location.Y <= -10)
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                    datetimeDisplay.Enabled = true;
                    label1.Enabled = true;
                    versionDisplay.Enabled = true;
                    unDisplay.Enabled = true;
                    latestUpdateCheck.Enabled = true;
                    label2.Enabled = true;
                    hkInfoLabel.Enabled = true;
                }
            }
            else
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = true;
                }
            }
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            // realigns the menu if screen size changes abruptly during suspension or sleep (happens when laptop lids close while suspending or sleeping
            menupulllimit = 0;
            Rectangle location = Screen.PrimaryScreen.Bounds;
            this.Location = new System.Drawing.Point(location.Width - this.Width, -130);
        }

        private void delaySave_Tick(object sender, EventArgs e)
        {
            // intializes bitmap immage
            string paintfilepath = "";
            try
            {
                Bitmap shot = new Bitmap(Clipboard.GetImage());
                //saves screenshot and checks if current sceenshot name exists
                string time = DateTime.Now.ToString("hh-mm-ss tt");
                string date = DateTime.Today.ToString("M-dd-yyyy"); ;
                string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + time + "_" + date + ".png";
                paintfilepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + time + "_" + date + ".png";
                shot.Save(filepath, ImageFormat.Png);
            }
            catch (NullReferenceException ex)
            {
                delaySave.Stop();
                MessageBox.Show("An error occurred! This likely happens due to the way Windows 10 handles the clipboard feature. Just try again and it SHOULD " +
                    "just work.", "Error");
            }

            if (paintopen == false)
            {
            }
            else if (paintopen == true)
            {
                Process paint = new Process();
                paint.StartInfo.FileName = "mspaint.exe";
                paint.StartInfo.Arguments = string.Format("\"{0}\"", paintfilepath);
                paint.Start();
            }
            delaySave.Stop();
        }

        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (hk.Registered)
                hk.Unregister();
        }
        

    }
}