namespace slinkosmtv4
{
    partial class clipboardcs
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clipboardcs));
			this.cbHistory = new System.Windows.Forms.TextBox();
			this.clearButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.fetchClipboard = new System.Windows.Forms.Timer(this.components);
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbHistory
			// 
			this.cbHistory.BackColor = System.Drawing.Color.Black;
			this.cbHistory.ForeColor = System.Drawing.Color.Lime;
			this.cbHistory.Location = new System.Drawing.Point(12, 26);
			this.cbHistory.MaxLength = 100000;
			this.cbHistory.Multiline = true;
			this.cbHistory.Name = "cbHistory";
			this.cbHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.cbHistory.Size = new System.Drawing.Size(260, 439);
			this.cbHistory.TabIndex = 0;
			// 
			// clearButton
			// 
			this.clearButton.BackColor = System.Drawing.Color.Black;
			this.clearButton.ForeColor = System.Drawing.Color.Lime;
			this.clearButton.Location = new System.Drawing.Point(32, 471);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(102, 29);
			this.clearButton.TabIndex = 1;
			this.clearButton.Text = "CLEAR BOARD";
			this.clearButton.UseVisualStyleBackColor = false;
			this.clearButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Lime;
			this.label1.Location = new System.Drawing.Point(95, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Clipboard History";
			// 
			// fetchClipboard
			// 
			this.fetchClipboard.Enabled = true;
			this.fetchClipboard.Tick += new System.EventHandler(this.fetchClipboard_Tick);
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.Black;
			this.closeButton.ForeColor = System.Drawing.Color.Lime;
			this.closeButton.Location = new System.Drawing.Point(140, 471);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(102, 29);
			this.closeButton.TabIndex = 5;
			this.closeButton.Text = "CLOSE";
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// clipboardcs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(284, 512);
			this.ControlBox = false;
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.cbHistory);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(300, 551);
			this.MinimumSize = new System.Drawing.Size(300, 551);
			this.Name = "clipboardcs";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clipboard History";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cbHistory;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer fetchClipboard;
        private System.Windows.Forms.Button closeButton;
    }
}