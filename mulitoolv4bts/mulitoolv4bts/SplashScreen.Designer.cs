namespace slinkosmtv4
{
    partial class SplashScreen
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
            this.splashImage = new System.Windows.Forms.PictureBox();
            this.openMenu = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splashImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splashImage
            // 
            this.splashImage.BackColor = System.Drawing.Color.Transparent;
            this.splashImage.Image = global::slinkosmtv4.Properties.Resources.slinkoswatermark;
            this.splashImage.Location = new System.Drawing.Point(0, 0);
            this.splashImage.Name = "splashImage";
            this.splashImage.Size = new System.Drawing.Size(504, 253);
            this.splashImage.TabIndex = 0;
            this.splashImage.TabStop = false;
            // 
            // openMenu
            // 
            this.openMenu.Enabled = true;
            this.openMenu.Interval = 5000;
            this.openMenu.Tick += new System.EventHandler(this.openMenu_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(509, 261);
            this.Controls.Add(this.splashImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            ((System.ComponentModel.ISupportInitialize)(this.splashImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox splashImage;
        private System.Windows.Forms.Timer openMenu;
    }
}