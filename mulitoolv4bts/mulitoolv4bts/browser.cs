using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace slinkosmtv4
{
    public partial class browser : Form
    {
        bool panelhidden;
        public browser()
        {
            InitializeComponent();
            initializeChromiumBrowser();
        }

        private void initializeChromiumBrowser()
        {
            chromeBrowser.Load("https://realslinksoft.wixsite.com/slink-soft-portfolio");
            chromeBrowser.Dock = DockStyle.Fill; // fill the whole canvas/gui with browser control/object
            chromeBrowser.SendToBack(); // send browser to back so navigation controls are visible to user/ontop of it

        }

        private void urlI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chromeBrowser.Load(urlI.Text);
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load(urlI.Text);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Back();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Forward();
        }

        private void panelHide_Click(object sender, EventArgs e)
        {
            if (panelhidden == false && cPanel.Visible == true)
            {
                panelhidden = true;
                cPanel.Visible = false;
                panelHide.Text = "Hide Panel";
            }
            else if (panelhidden == true && cPanel.Visible == false)
            {
                panelhidden = false;
                cPanel.Visible = true;
                panelHide.Text = "Show Panel";
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Reload();
        }

        private void specialThanksButtonLabel_MouseEnter(object sender, EventArgs e)
        {
            this.specialThanksButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void specialThanksButtonLabel_MouseLeave(object sender, EventArgs e)
        {
            this.specialThanksButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void specialThanksButtonLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Special Thanks to the CefSharp team and their hard work on developing " +
                "a chrome-based browser for WinForm GUI controls, which made the SlinkOS Browser possible." +
                "\nPlease visit their github at https://github.com/cefsharp/CefSharp!", "Thank You CefSharp Team");
            chromeBrowser.Load("https://cefsharp.github.io/");
        }

        private void chromeBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            // once finished loading, update url naviation bar to the newest/accurate current url.
            if (e.IsLoading == false)
            {
                String newUrl = chromeBrowser.Address;
                /* NOTE: The following Invoke method on UrlI is necessary to avoid a cross-thread execution
                 exception (chromium browser is being executed on a different thread). This will enable 
                 cross-thread execution to allow changes a property value on another control (in this 
                 case, control UrlI textbox, property Text).*/
                urlI.Invoke((Action)delegate
                {
                    urlI.Text = newUrl; // set url box text data to new url
                }); 
            }
        }
    }
}
