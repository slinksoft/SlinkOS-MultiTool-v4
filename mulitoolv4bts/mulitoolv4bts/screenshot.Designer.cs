namespace slinkosmtv4
{
    partial class screenshot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(screenshot));
            this.coordD = new System.Windows.Forms.Label();
            this.coordUpdate = new System.Windows.Forms.Timer(this.components);
            this.snapWhole = new System.Windows.Forms.Button();
            this.snapRegion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.delaySave = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // coordD
            // 
            this.coordD.AutoSize = true;
            this.coordD.ForeColor = System.Drawing.Color.Lime;
            this.coordD.Location = new System.Drawing.Point(95, 142);
            this.coordD.Name = "coordD";
            this.coordD.Size = new System.Drawing.Size(100, 13);
            this.coordD.TabIndex = 0;
            this.coordD.Text = "Current Coordinates";
            this.coordD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coordUpdate
            // 
            this.coordUpdate.Enabled = true;
            this.coordUpdate.Tick += new System.EventHandler(this.coordUpdate_Tick);
            // 
            // snapWhole
            // 
            this.snapWhole.BackColor = System.Drawing.Color.Black;
            this.snapWhole.ForeColor = System.Drawing.Color.Lime;
            this.snapWhole.Location = new System.Drawing.Point(106, 43);
            this.snapWhole.Name = "snapWhole";
            this.snapWhole.Size = new System.Drawing.Size(75, 37);
            this.snapWhole.TabIndex = 1;
            this.snapWhole.Text = "Snap Desktop";
            this.snapWhole.UseVisualStyleBackColor = false;
            this.snapWhole.Click += new System.EventHandler(this.button1_Click);
            // 
            // snapRegion
            // 
            this.snapRegion.BackColor = System.Drawing.Color.Black;
            this.snapRegion.ForeColor = System.Drawing.Color.Lime;
            this.snapRegion.Location = new System.Drawing.Point(106, 86);
            this.snapRegion.Name = "snapRegion";
            this.snapRegion.Size = new System.Drawing.Size(75, 37);
            this.snapRegion.TabIndex = 2;
            this.snapRegion.Text = "Snap Region";
            this.snapRegion.UseVisualStyleBackColor = false;
            this.snapRegion.Click += new System.EventHandler(this.snapRegion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(101, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Screenshot Tool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(198, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tutorial";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Screenshots saved to the Desktop.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delaySave
            // 
            this.delaySave.Interval = 500;
            this.delaySave.Tick += new System.EventHandler(this.delaySave_Tick);
            // 
            // screenshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(299, 178);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.snapRegion);
            this.Controls.Add(this.snapWhole);
            this.Controls.Add(this.coordD);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(315, 217);
            this.MinimumSize = new System.Drawing.Size(315, 217);
            this.Name = "screenshot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screenshot Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coordD;
        private System.Windows.Forms.Timer coordUpdate;
        public System.Windows.Forms.Button snapWhole;
        public System.Windows.Forms.Button snapRegion;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer delaySave;
    }
}