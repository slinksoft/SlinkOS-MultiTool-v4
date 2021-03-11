namespace slinkosmtv4
{
    partial class cb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cb));
            this.numberofbar = new System.Windows.Forms.Label();
            this.moveandstop = new System.Windows.Forms.Timer(this.components);
            this.checkifclosed = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // numberofbar
            // 
            this.numberofbar.AutoSize = true;
            this.numberofbar.ForeColor = System.Drawing.Color.Lime;
            this.numberofbar.Location = new System.Drawing.Point(0, 0);
            this.numberofbar.Name = "numberofbar";
            this.numberofbar.Size = new System.Drawing.Size(13, 13);
            this.numberofbar.TabIndex = 0;
            this.numberofbar.Text = "0";
            // 
            // moveandstop
            // 
            this.moveandstop.Enabled = true;
            this.moveandstop.Tick += new System.EventHandler(this.moveandstop_Tick);
            // 
            // checkifclosed
            // 
            this.checkifclosed.Enabled = true;
            // 
            // cb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(155, 55);
            this.ControlBox = false;
            this.Controls.Add(this.numberofbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cb";
            this.ShowIcon = false;
            this.Text = "cb";
            this.Load += new System.EventHandler(this.cb_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label numberofbar;
        private System.Windows.Forms.Timer moveandstop;
        private System.Windows.Forms.Timer checkifclosed;
    }
}