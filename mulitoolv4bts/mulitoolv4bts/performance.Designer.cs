namespace slinkosmtv4
{
    partial class performance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(performance));
            this.displayPerform = new System.Windows.Forms.Label();
            this.updateInfo = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayPerform
            // 
            this.displayPerform.AutoSize = true;
            this.displayPerform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPerform.ForeColor = System.Drawing.Color.Lime;
            this.displayPerform.Location = new System.Drawing.Point(12, 9);
            this.displayPerform.Name = "displayPerform";
            this.displayPerform.Size = new System.Drawing.Size(37, 20);
            this.displayPerform.TabIndex = 1;
            this.displayPerform.Text = "null";
            this.displayPerform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateInfo
            // 
            this.updateInfo.Enabled = true;
            this.updateInfo.Interval = 1000;
            this.updateInfo.Tick += new System.EventHandler(this.updateInfo_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(133, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Performance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(218, 40);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayPerform);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "performance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performace and Hardware Info.";
            this.Load += new System.EventHandler(this.performance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label displayPerform;
        private System.Windows.Forms.Timer updateInfo;
        private System.Windows.Forms.Label label1;
    }
}