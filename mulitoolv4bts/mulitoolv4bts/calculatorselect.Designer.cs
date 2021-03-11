namespace slinkosmtv4
{
    partial class calcSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calcSelector));
            this.old = new System.Windows.Forms.Button();
            this.neww = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // old
            // 
            this.old.BackColor = System.Drawing.Color.Black;
            this.old.ForeColor = System.Drawing.Color.Lime;
            this.old.Location = new System.Drawing.Point(55, 25);
            this.old.Name = "old";
            this.old.Size = new System.Drawing.Size(114, 44);
            this.old.TabIndex = 0;
            this.old.Text = "Old Four Function Calculator";
            this.old.UseVisualStyleBackColor = false;
            this.old.Click += new System.EventHandler(this.Old_Click);
            // 
            // neww
            // 
            this.neww.BackColor = System.Drawing.Color.Black;
            this.neww.ForeColor = System.Drawing.Color.Lime;
            this.neww.Location = new System.Drawing.Point(54, 73);
            this.neww.Name = "neww";
            this.neww.Size = new System.Drawing.Size(114, 44);
            this.neww.TabIndex = 1;
            this.neww.Text = "New Four Function Calculator";
            this.neww.UseVisualStyleBackColor = false;
            this.neww.Click += new System.EventHandler(this.Neww_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(54, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Equation Calculator";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // calcSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(227, 194);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.neww);
            this.Controls.Add(this.old);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(243, 233);
            this.MinimumSize = new System.Drawing.Size(243, 233);
            this.Name = "calcSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator Selector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button old;
        private System.Windows.Forms.Button neww;
        private System.Windows.Forms.Button button1;
    }
}