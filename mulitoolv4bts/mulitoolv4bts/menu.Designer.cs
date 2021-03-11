namespace slinkosmtv4
{
    partial class menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.label1 = new System.Windows.Forms.Label();
            this.menuUp = new System.Windows.Forms.Timer(this.components);
            this.menuDown = new System.Windows.Forms.Timer(this.components);
            this.datetimeDisplay = new System.Windows.Forms.Label();
            this.timeUpdate = new System.Windows.Forms.Timer(this.components);
            this.versionDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTiper = new System.Windows.Forms.ToolTip(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.sysinfoButton = new System.Windows.Forms.Button();
            this.hibernateCPU = new System.Windows.Forms.Button();
            this.sleepCPU = new System.Windows.Forms.Button();
            this.realignMenu = new System.Windows.Forms.Button();
            this.openPerformance = new System.Windows.Forms.Button();
            this.openTerminal = new System.Windows.Forms.Button();
            this.shutdownCPU = new System.Windows.Forms.Button();
            this.restartComputer = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.openClipboard = new System.Windows.Forms.Button();
            this.snapDesktop = new System.Windows.Forms.Button();
            this.openScreen = new System.Windows.Forms.Button();
            this.openSpammer = new System.Windows.Forms.Button();
            this.openBrowser = new System.Windows.Forms.Button();
            this.openCensor = new System.Windows.Forms.Button();
            this.openStop = new System.Windows.Forms.Button();
            this.openTimer = new System.Windows.Forms.Button();
            this.openCalc = new System.Windows.Forms.Button();
            this.openHEX = new System.Windows.Forms.Button();
            this.openBinary = new System.Windows.Forms.Button();
            this.unDisplay = new System.Windows.Forms.Label();
            this.latestUpdateCheck = new System.Windows.Forms.Label();
            this.updateButtonControls = new System.Windows.Forms.Timer(this.components);
            this.delaySave = new System.Windows.Forms.Timer(this.components);
            this.hkInfoLabel = new System.Windows.Forms.Label();
            this.updaterv2 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.checkUpdateV2 = new System.Windows.Forms.Timer(this.components);
            this.postNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = ". . .";
            // 
            // menuUp
            // 
            this.menuUp.Interval = 30;
            this.menuUp.Tick += new System.EventHandler(this.menuUp_Tick);
            // 
            // menuDown
            // 
            this.menuDown.Interval = 30;
            this.menuDown.Tick += new System.EventHandler(this.menuDown_Tick);
            // 
            // datetimeDisplay
            // 
            this.datetimeDisplay.AutoSize = true;
            this.datetimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeDisplay.Location = new System.Drawing.Point(12, 132);
            this.datetimeDisplay.Name = "datetimeDisplay";
            this.datetimeDisplay.Size = new System.Drawing.Size(147, 13);
            this.datetimeDisplay.TabIndex = 10;
            this.datetimeDisplay.Text = "00:00:00 00 00/00/0000";
            // 
            // timeUpdate
            // 
            this.timeUpdate.Interval = 1000;
            this.timeUpdate.Tick += new System.EventHandler(this.timeUpdate_Tick);
            // 
            // versionDisplay
            // 
            this.versionDisplay.AutoSize = true;
            this.versionDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionDisplay.Location = new System.Drawing.Point(246, 132);
            this.versionDisplay.Name = "versionDisplay";
            this.versionDisplay.Size = new System.Drawing.Size(169, 13);
            this.versionDisplay.TabIndex = 11;
            this.versionDisplay.Text = "§linkOS MultiTool - 0.00-000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Menu";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Black;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(395, 11);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 23);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "X";
            this.toolTiper.SetToolTip(this.closeButton, "Terminate SlinkOS");
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // sysinfoButton
            // 
            this.sysinfoButton.BackColor = System.Drawing.Color.Black;
            this.sysinfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sysinfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysinfoButton.Location = new System.Drawing.Point(366, 11);
            this.sysinfoButton.Name = "sysinfoButton";
            this.sysinfoButton.Size = new System.Drawing.Size(25, 23);
            this.sysinfoButton.TabIndex = 19;
            this.sysinfoButton.Text = "i";
            this.toolTiper.SetToolTip(this.sysinfoButton, "Network/System Info");
            this.sysinfoButton.UseVisualStyleBackColor = false;
            this.sysinfoButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // hibernateCPU
            // 
            this.hibernateCPU.BackColor = System.Drawing.Color.Black;
            this.hibernateCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hibernateCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hibernateCPU.Location = new System.Drawing.Point(5, 36);
            this.hibernateCPU.Name = "hibernateCPU";
            this.hibernateCPU.Size = new System.Drawing.Size(25, 23);
            this.hibernateCPU.TabIndex = 20;
            this.hibernateCPU.Text = "H";
            this.toolTiper.SetToolTip(this.hibernateCPU, "Put your computer into a hibernate state\r\nUseful if you do not want to shutdown c" +
        "ompletely");
            this.hibernateCPU.UseVisualStyleBackColor = false;
            this.hibernateCPU.Click += new System.EventHandler(this.hibernateCPU_Click);
            // 
            // sleepCPU
            // 
            this.sleepCPU.BackColor = System.Drawing.Color.Black;
            this.sleepCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sleepCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleepCPU.Location = new System.Drawing.Point(395, 36);
            this.sleepCPU.Name = "sleepCPU";
            this.sleepCPU.Size = new System.Drawing.Size(25, 23);
            this.sleepCPU.TabIndex = 24;
            this.sleepCPU.Text = "S";
            this.toolTiper.SetToolTip(this.sleepCPU, "Put your computer to sleep \r\n(NOTE: Not the same as hibernation)");
            this.sleepCPU.UseVisualStyleBackColor = false;
            this.sleepCPU.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // realignMenu
            // 
            this.realignMenu.BackColor = System.Drawing.Color.Black;
            this.realignMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.realignMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realignMenu.Location = new System.Drawing.Point(297, 11);
            this.realignMenu.Name = "realignMenu";
            this.realignMenu.Size = new System.Drawing.Size(32, 23);
            this.realignMenu.TabIndex = 26;
            this.realignMenu.Text = "Re";
            this.toolTiper.SetToolTip(this.realignMenu, "Realign Menu if somehow it goes out of place");
            this.realignMenu.UseVisualStyleBackColor = false;
            this.realignMenu.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // openPerformance
            // 
            this.openPerformance.BackColor = System.Drawing.Color.Black;
            this.openPerformance.BackgroundImage = global::slinkosmtv4.Properties.Resources.battery;
            this.openPerformance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openPerformance.Location = new System.Drawing.Point(98, 11);
            this.openPerformance.Name = "openPerformance";
            this.openPerformance.Size = new System.Drawing.Size(25, 23);
            this.openPerformance.TabIndex = 28;
            this.toolTiper.SetToolTip(this.openPerformance, "Battery and Performance");
            this.openPerformance.UseVisualStyleBackColor = false;
            this.openPerformance.Click += new System.EventHandler(this.openPerformance_Click);
            // 
            // openTerminal
            // 
            this.openTerminal.BackColor = System.Drawing.Color.Black;
            this.openTerminal.BackgroundImage = global::slinkosmtv4.Properties.Resources.terminalicon;
            this.openTerminal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openTerminal.Enabled = false;
            this.openTerminal.Location = new System.Drawing.Point(381, 77);
            this.openTerminal.Name = "openTerminal";
            this.openTerminal.Size = new System.Drawing.Size(40, 38);
            this.openTerminal.TabIndex = 25;
            this.toolTiper.SetToolTip(this.openTerminal, "Open SlinkOS Terminal");
            this.openTerminal.UseVisualStyleBackColor = false;
            this.openTerminal.Visible = false;
            this.openTerminal.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // shutdownCPU
            // 
            this.shutdownCPU.BackColor = System.Drawing.Color.Black;
            this.shutdownCPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shutdownCPU.BackgroundImage")));
            this.shutdownCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shutdownCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownCPU.Location = new System.Drawing.Point(335, 11);
            this.shutdownCPU.Name = "shutdownCPU";
            this.shutdownCPU.Size = new System.Drawing.Size(25, 23);
            this.shutdownCPU.TabIndex = 22;
            this.toolTiper.SetToolTip(this.shutdownCPU, "Shutdown your computer");
            this.shutdownCPU.UseVisualStyleBackColor = false;
            this.shutdownCPU.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // restartComputer
            // 
            this.restartComputer.BackColor = System.Drawing.Color.Black;
            this.restartComputer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restartComputer.BackgroundImage")));
            this.restartComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restartComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartComputer.Location = new System.Drawing.Point(67, 11);
            this.restartComputer.Name = "restartComputer";
            this.restartComputer.Size = new System.Drawing.Size(25, 23);
            this.restartComputer.TabIndex = 21;
            this.toolTiper.SetToolTip(this.restartComputer, "Restart your computer");
            this.restartComputer.UseVisualStyleBackColor = false;
            this.restartComputer.Click += new System.EventHandler(this.restartComputer_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Black;
            this.settingsButton.BackgroundImage = global::slinkosmtv4.Properties.Resources.settings;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.Location = new System.Drawing.Point(366, 36);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(25, 23);
            this.settingsButton.TabIndex = 15;
            this.toolTiper.SetToolTip(this.settingsButton, "Settings");
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.MouseEnter += new System.EventHandler(this.settingsButton_MouseEnter);
            // 
            // openClipboard
            // 
            this.openClipboard.BackColor = System.Drawing.Color.Black;
            this.openClipboard.BackgroundImage = global::slinkosmtv4.Properties.Resources.clipboard;
            this.openClipboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openClipboard.Location = new System.Drawing.Point(5, 11);
            this.openClipboard.Name = "openClipboard";
            this.openClipboard.Size = new System.Drawing.Size(25, 23);
            this.openClipboard.TabIndex = 14;
            this.toolTiper.SetToolTip(this.openClipboard, "Clipboard History");
            this.openClipboard.UseVisualStyleBackColor = false;
            this.openClipboard.Click += new System.EventHandler(this.openClipboard_Click);
            // 
            // snapDesktop
            // 
            this.snapDesktop.BackColor = System.Drawing.Color.Black;
            this.snapDesktop.BackgroundImage = global::slinkosmtv4.Properties.Resources.snapshot;
            this.snapDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snapDesktop.Location = new System.Drawing.Point(36, 11);
            this.snapDesktop.Name = "snapDesktop";
            this.snapDesktop.Size = new System.Drawing.Size(25, 23);
            this.snapDesktop.TabIndex = 13;
            this.toolTiper.SetToolTip(this.snapDesktop, "Snap Desktop");
            this.snapDesktop.UseVisualStyleBackColor = false;
            this.snapDesktop.Click += new System.EventHandler(this.snapDesktop_Click);
            // 
            // openScreen
            // 
            this.openScreen.BackColor = System.Drawing.Color.Black;
            this.openScreen.BackgroundImage = global::slinkosmtv4.Properties.Resources.snapshot;
            this.openScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openScreen.Location = new System.Drawing.Point(192, 80);
            this.openScreen.Name = "openScreen";
            this.openScreen.Size = new System.Drawing.Size(40, 38);
            this.openScreen.TabIndex = 8;
            this.toolTiper.SetToolTip(this.openScreen, "Screenshot Tool");
            this.openScreen.UseVisualStyleBackColor = false;
            this.openScreen.Click += new System.EventHandler(this.button9_Click);
            // 
            // openSpammer
            // 
            this.openSpammer.BackColor = System.Drawing.Color.Black;
            this.openSpammer.BackgroundImage = global::slinkosmtv4.Properties.Resources.spam;
            this.openSpammer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openSpammer.Location = new System.Drawing.Point(146, 80);
            this.openSpammer.Name = "openSpammer";
            this.openSpammer.Size = new System.Drawing.Size(40, 38);
            this.openSpammer.TabIndex = 7;
            this.toolTiper.SetToolTip(this.openSpammer, "Text Spammer");
            this.openSpammer.UseVisualStyleBackColor = false;
            this.openSpammer.Click += new System.EventHandler(this.button8_Click);
            // 
            // openBrowser
            // 
            this.openBrowser.BackColor = System.Drawing.Color.Black;
            this.openBrowser.BackgroundImage = global::slinkosmtv4.Properties.Resources.slinkbrowser;
            this.openBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openBrowser.Location = new System.Drawing.Point(306, 36);
            this.openBrowser.Name = "openBrowser";
            this.openBrowser.Size = new System.Drawing.Size(40, 38);
            this.openBrowser.TabIndex = 6;
            this.toolTiper.SetToolTip(this.openBrowser, "Web Browser");
            this.openBrowser.UseVisualStyleBackColor = false;
            this.openBrowser.Click += new System.EventHandler(this.button7_Click);
            // 
            // openCensor
            // 
            this.openCensor.BackColor = System.Drawing.Color.Black;
            this.openCensor.BackgroundImage = global::slinkosmtv4.Properties.Resources.censoricon;
            this.openCensor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openCensor.Location = new System.Drawing.Point(260, 36);
            this.openCensor.Name = "openCensor";
            this.openCensor.Size = new System.Drawing.Size(40, 38);
            this.openCensor.TabIndex = 5;
            this.toolTiper.SetToolTip(this.openCensor, "Censorbar");
            this.openCensor.UseVisualStyleBackColor = false;
            this.openCensor.Click += new System.EventHandler(this.button6_Click);
            // 
            // openStop
            // 
            this.openStop.BackColor = System.Drawing.Color.Black;
            this.openStop.BackgroundImage = global::slinkosmtv4.Properties.Resources.timeicon;
            this.openStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openStop.Location = new System.Drawing.Point(214, 36);
            this.openStop.Name = "openStop";
            this.openStop.Size = new System.Drawing.Size(40, 38);
            this.openStop.TabIndex = 4;
            this.toolTiper.SetToolTip(this.openStop, "Stopwatch");
            this.openStop.UseVisualStyleBackColor = false;
            this.openStop.Click += new System.EventHandler(this.button5_Click);
            // 
            // openTimer
            // 
            this.openTimer.BackColor = System.Drawing.Color.Black;
            this.openTimer.BackgroundImage = global::slinkosmtv4.Properties.Resources.timericon;
            this.openTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openTimer.Location = new System.Drawing.Point(168, 36);
            this.openTimer.Name = "openTimer";
            this.openTimer.Size = new System.Drawing.Size(40, 38);
            this.openTimer.TabIndex = 3;
            this.toolTiper.SetToolTip(this.openTimer, "Timer");
            this.openTimer.UseVisualStyleBackColor = false;
            this.openTimer.Click += new System.EventHandler(this.button4_Click);
            // 
            // openCalc
            // 
            this.openCalc.BackColor = System.Drawing.Color.Black;
            this.openCalc.BackgroundImage = global::slinkosmtv4.Properties.Resources.calculatoricon;
            this.openCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openCalc.Location = new System.Drawing.Point(122, 36);
            this.openCalc.Name = "openCalc";
            this.openCalc.Size = new System.Drawing.Size(40, 38);
            this.openCalc.TabIndex = 2;
            this.toolTiper.SetToolTip(this.openCalc, "Calculator");
            this.openCalc.UseVisualStyleBackColor = false;
            this.openCalc.Click += new System.EventHandler(this.button3_Click);
            // 
            // openHEX
            // 
            this.openHEX.BackColor = System.Drawing.Color.Black;
            this.openHEX.BackgroundImage = global::slinkosmtv4.Properties.Resources.hexicon;
            this.openHEX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openHEX.Enabled = false;
            this.openHEX.Location = new System.Drawing.Point(5000, 5000);
            this.openHEX.Name = "openHEX";
            this.openHEX.Size = new System.Drawing.Size(40, 38);
            this.openHEX.TabIndex = 1;
            this.toolTiper.SetToolTip(this.openHEX, "HEX Converter");
            this.openHEX.UseVisualStyleBackColor = false;
            this.openHEX.Visible = false;
            this.openHEX.Click += new System.EventHandler(this.button2_Click);
            // 
            // openBinary
            // 
            this.openBinary.BackColor = System.Drawing.Color.Black;
            this.openBinary.BackgroundImage = global::slinkosmtv4.Properties.Resources.binaryicon;
            this.openBinary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openBinary.Location = new System.Drawing.Point(76, 36);
            this.openBinary.Name = "openBinary";
            this.openBinary.Size = new System.Drawing.Size(40, 38);
            this.openBinary.TabIndex = 0;
            this.toolTiper.SetToolTip(this.openBinary, "Data Conversions");
            this.openBinary.UseVisualStyleBackColor = false;
            this.openBinary.Click += new System.EventHandler(this.button1_Click);
            // 
            // unDisplay
            // 
            this.unDisplay.AutoSize = true;
            this.unDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unDisplay.Location = new System.Drawing.Point(288, 116);
            this.unDisplay.Name = "unDisplay";
            this.unDisplay.Size = new System.Drawing.Size(94, 13);
            this.unDisplay.TabIndex = 16;
            this.unDisplay.Text = "Welcome: §link";
            // 
            // latestUpdateCheck
            // 
            this.latestUpdateCheck.AutoSize = true;
            this.latestUpdateCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latestUpdateCheck.Location = new System.Drawing.Point(411, 132);
            this.latestUpdateCheck.Name = "latestUpdateCheck";
            this.latestUpdateCheck.Size = new System.Drawing.Size(14, 13);
            this.latestUpdateCheck.TabIndex = 23;
            this.latestUpdateCheck.Text = "√";
            this.latestUpdateCheck.Visible = false;
            // 
            // updateButtonControls
            // 
            this.updateButtonControls.Enabled = true;
            this.updateButtonControls.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // delaySave
            // 
            this.delaySave.Interval = 500;
            this.delaySave.Tick += new System.EventHandler(this.delaySave_Tick);
            // 
            // hkInfoLabel
            // 
            this.hkInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.hkInfoLabel.Location = new System.Drawing.Point(22, 89);
            this.hkInfoLabel.Name = "hkInfoLabel";
            this.hkInfoLabel.Size = new System.Drawing.Size(114, 47);
            this.hkInfoLabel.TabIndex = 27;
            this.hkInfoLabel.Text = "Press Alt+S to show menu on top.";
            this.hkInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updaterv2
            // 
            this.updaterv2.Location = new System.Drawing.Point(3000, 3000);
            this.updaterv2.Name = "updaterv2";
            this.updaterv2.Size = new System.Drawing.Size(261, 52);
            this.updaterv2.TabIndex = 29;
            this.updaterv2.Visible = false;
            this.updaterv2.FrameLoadEnd += new System.EventHandler<CefSharp.FrameLoadEndEventArgs>(this.Updaterv2_FrameLoadEnd);
            // 
            // checkUpdateV2
            // 
            this.checkUpdateV2.Interval = 2000;
            this.checkUpdateV2.Tick += new System.EventHandler(this.CheckUpdateV2_Tick);
            // 
            // postNote
            // 
            this.postNote.BackColor = System.Drawing.Color.Black;
            this.postNote.BackgroundImage = global::slinkosmtv4.Properties.Resources.postnoteicon;
            this.postNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.postNote.Location = new System.Drawing.Point(238, 80);
            this.postNote.Name = "postNote";
            this.postNote.Size = new System.Drawing.Size(40, 38);
            this.postNote.TabIndex = 30;
            this.toolTiper.SetToolTip(this.postNote, "Open New Postnote");
            this.postNote.UseVisualStyleBackColor = false;
            this.postNote.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(425, 150);
            this.Controls.Add(this.postNote);
            this.Controls.Add(this.updaterv2);
            this.Controls.Add(this.openPerformance);
            this.Controls.Add(this.realignMenu);
            this.Controls.Add(this.openTerminal);
            this.Controls.Add(this.sleepCPU);
            this.Controls.Add(this.latestUpdateCheck);
            this.Controls.Add(this.shutdownCPU);
            this.Controls.Add(this.restartComputer);
            this.Controls.Add(this.hibernateCPU);
            this.Controls.Add(this.sysinfoButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.unDisplay);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.openClipboard);
            this.Controls.Add(this.snapDesktop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.versionDisplay);
            this.Controls.Add(this.datetimeDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openScreen);
            this.Controls.Add(this.openSpammer);
            this.Controls.Add(this.openBrowser);
            this.Controls.Add(this.openCensor);
            this.Controls.Add(this.openStop);
            this.Controls.Add(this.openTimer);
            this.Controls.Add(this.openCalc);
            this.Controls.Add(this.openHEX);
            this.Controls.Add(this.openBinary);
            this.Controls.Add(this.hkInfoLabel);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(425, 150);
            this.MinimumSize = new System.Drawing.Size(425, 150);
            this.Name = "menu";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.Text = "§linkOS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menu_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openBinary;
        private System.Windows.Forms.Button openHEX;
        private System.Windows.Forms.Button openCalc;
        private System.Windows.Forms.Button openTimer;
        private System.Windows.Forms.Button openStop;
        private System.Windows.Forms.Button openCensor;
        private System.Windows.Forms.Button openBrowser;
        private System.Windows.Forms.Button openSpammer;
        private System.Windows.Forms.Button openScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer menuUp;
        private System.Windows.Forms.Timer menuDown;
        private System.Windows.Forms.Label datetimeDisplay;
        private System.Windows.Forms.Timer timeUpdate;
        private System.Windows.Forms.Label versionDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button snapDesktop;
        private System.Windows.Forms.ToolTip toolTiper;
        private System.Windows.Forms.Button openClipboard;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label unDisplay;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button sysinfoButton;
        private System.Windows.Forms.Button hibernateCPU;
        private System.Windows.Forms.Button restartComputer;
        private System.Windows.Forms.Button shutdownCPU;
        private System.Windows.Forms.Label latestUpdateCheck;
        private System.Windows.Forms.Button sleepCPU;
        private System.Windows.Forms.Timer updateButtonControls;
        private System.Windows.Forms.Button openTerminal;
        private System.Windows.Forms.Button realignMenu;
        private System.Windows.Forms.Timer delaySave;
        private System.Windows.Forms.Label hkInfoLabel;
        private System.Windows.Forms.Button openPerformance;
        private CefSharp.WinForms.ChromiumWebBrowser updaterv2;
        private System.Windows.Forms.Timer checkUpdateV2;
        private System.Windows.Forms.Button postNote;
    }
}

