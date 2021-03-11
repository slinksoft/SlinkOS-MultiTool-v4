namespace slinkosmtv4
{
    partial class ssregion
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
            this.progress = new System.Windows.Forms.Timer(this.components);
            this.delayClose = new System.Windows.Forms.Timer(this.components);
            this.delaySave = new System.Windows.Forms.Timer(this.components);
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Enabled = true;
            this.progress.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // delayClose
            // 
            this.delayClose.Interval = 1000;
            this.delayClose.Tick += new System.EventHandler(this.delayClose_Tick);
            // 
            // delaySave
            // 
            this.delaySave.Interval = 500;
            this.delaySave.Tick += new System.EventHandler(this.delaySave_Tick);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Lime;
            this.infoLabel.Location = new System.Drawing.Point(0, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(182, 52);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Press The C key to capture\r\n(If not captured right away,\r\nclick region to focus a" +
    "nd press\r\nC again)";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoLabel.Visible = false;
            // 
            // ssregion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::slinkosmtv4.Properties.Resources.slinkoscb;
            this.ClientSize = new System.Drawing.Size(173, 117);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ssregion";
            this.Opacity = 0.65D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ssregion";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ssregion_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer progress;
        private System.Windows.Forms.Timer delayClose;
        private System.Windows.Forms.Timer delaySave;
        private System.Windows.Forms.Label infoLabel;
    }
}