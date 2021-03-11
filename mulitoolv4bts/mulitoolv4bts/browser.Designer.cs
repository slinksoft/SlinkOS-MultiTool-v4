namespace slinkosmtv4
{
    partial class browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(browser));
            this.cPanel = new System.Windows.Forms.Panel();
            this.specialThanksButtonLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.urlI = new System.Windows.Forms.TextBox();
            this.panelHide = new System.Windows.Forms.Button();
            this.chromeBrowser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.cPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cPanel
            // 
            this.cPanel.BackColor = System.Drawing.Color.Black;
            this.cPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cPanel.Controls.Add(this.specialThanksButtonLabel);
            this.cPanel.Controls.Add(this.refreshButton);
            this.cPanel.Controls.Add(this.goButton);
            this.cPanel.Controls.Add(this.forwardButton);
            this.cPanel.Controls.Add(this.backButton);
            this.cPanel.Controls.Add(this.label1);
            this.cPanel.Controls.Add(this.urlI);
            this.cPanel.Location = new System.Drawing.Point(12, 12);
            this.cPanel.Name = "cPanel";
            this.cPanel.Size = new System.Drawing.Size(601, 55);
            this.cPanel.TabIndex = 1;
            // 
            // specialThanksButtonLabel
            // 
            this.specialThanksButtonLabel.AutoSize = true;
            this.specialThanksButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialThanksButtonLabel.ForeColor = System.Drawing.Color.Lime;
            this.specialThanksButtonLabel.Location = new System.Drawing.Point(4, 34);
            this.specialThanksButtonLabel.Name = "specialThanksButtonLabel";
            this.specialThanksButtonLabel.Size = new System.Drawing.Size(228, 13);
            this.specialThanksButtonLabel.TabIndex = 6;
            this.specialThanksButtonLabel.Text = "(Click) Special Thanks To The CefSharp Team";
            this.specialThanksButtonLabel.Click += new System.EventHandler(this.specialThanksButtonLabel_Click);
            this.specialThanksButtonLabel.MouseEnter += new System.EventHandler(this.specialThanksButtonLabel_MouseEnter);
            this.specialThanksButtonLabel.MouseLeave += new System.EventHandler(this.specialThanksButtonLabel_MouseLeave);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Black;
            this.refreshButton.ForeColor = System.Drawing.Color.Lime;
            this.refreshButton.Location = new System.Drawing.Point(538, 6);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(56, 23);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.Black;
            this.goButton.ForeColor = System.Drawing.Color.Lime;
            this.goButton.Location = new System.Drawing.Point(409, 6);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(40, 23);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "GO!";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.Color.Black;
            this.forwardButton.ForeColor = System.Drawing.Color.Lime;
            this.forwardButton.Location = new System.Drawing.Point(497, 6);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(40, 23);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.Text = "->";
            this.forwardButton.UseVisualStyleBackColor = false;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.ForeColor = System.Drawing.Color.Lime;
            this.backButton.Location = new System.Drawing.Point(451, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(40, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "<-";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // urlI
            // 
            this.urlI.BackColor = System.Drawing.Color.Black;
            this.urlI.ForeColor = System.Drawing.Color.Lime;
            this.urlI.Location = new System.Drawing.Point(38, 8);
            this.urlI.Name = "urlI";
            this.urlI.Size = new System.Drawing.Size(367, 20);
            this.urlI.TabIndex = 0;
            this.urlI.Text = "https://realslinksoft.wixsite.com/slink-soft-portfolio";
            this.urlI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlI_KeyDown);
            // 
            // panelHide
            // 
            this.panelHide.BackColor = System.Drawing.Color.Black;
            this.panelHide.ForeColor = System.Drawing.Color.Lime;
            this.panelHide.Location = new System.Drawing.Point(12, 73);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(106, 24);
            this.panelHide.TabIndex = 5;
            this.panelHide.Text = "Show Panel";
            this.panelHide.UseVisualStyleBackColor = false;
            this.panelHide.Click += new System.EventHandler(this.panelHide_Click);
            // 
            // chromeBrowser
            // 
            this.chromeBrowser.Location = new System.Drawing.Point(318, 177);
            this.chromeBrowser.Name = "chromeBrowser";
            this.chromeBrowser.Size = new System.Drawing.Size(262, 110);
            this.chromeBrowser.TabIndex = 6;
            this.chromeBrowser.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.chromeBrowser_LoadingStateChanged);
            // 
            // browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 513);
            this.Controls.Add(this.chromeBrowser);
            this.Controls.Add(this.panelHide);
            this.Controls.Add(this.cPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Browser";
            this.cPanel.ResumeLayout(false);
            this.cPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel cPanel;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlI;
        private System.Windows.Forms.Button panelHide;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label specialThanksButtonLabel;
        private CefSharp.WinForms.ChromiumWebBrowser chromeBrowser;
    }
}