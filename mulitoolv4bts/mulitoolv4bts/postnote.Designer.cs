namespace slinkosmtv4
{
    partial class postnote
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
            this.noteBox = new System.Windows.Forms.TextBox();
            this.postTitle = new System.Windows.Forms.Label();
            this.rButton = new System.Windows.Forms.Button();
            this.moveandstop = new System.Windows.Forms.Timer(this.components);
            this.mButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noteBox
            // 
            this.noteBox.BackColor = System.Drawing.Color.Black;
            this.noteBox.ForeColor = System.Drawing.Color.Lime;
            this.noteBox.Location = new System.Drawing.Point(12, 25);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.noteBox.Size = new System.Drawing.Size(171, 179);
            this.noteBox.TabIndex = 0;
            // 
            // postTitle
            // 
            this.postTitle.AutoSize = true;
            this.postTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postTitle.ForeColor = System.Drawing.Color.Lime;
            this.postTitle.Location = new System.Drawing.Point(48, 8);
            this.postTitle.Name = "postTitle";
            this.postTitle.Size = new System.Drawing.Size(100, 13);
            this.postTitle.TabIndex = 1;
            this.postTitle.Text = "Post Note # 000";
            this.postTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rButton
            // 
            this.rButton.BackColor = System.Drawing.Color.Black;
            this.rButton.ForeColor = System.Drawing.Color.Lime;
            this.rButton.Location = new System.Drawing.Point(121, 206);
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(62, 23);
            this.rButton.TabIndex = 2;
            this.rButton.Text = "Remove";
            this.rButton.UseVisualStyleBackColor = false;
            this.rButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // moveandstop
            // 
            this.moveandstop.Enabled = true;
            this.moveandstop.Tick += new System.EventHandler(this.Moveandstop_Tick);
            // 
            // mButton
            // 
            this.mButton.BackColor = System.Drawing.Color.Black;
            this.mButton.ForeColor = System.Drawing.Color.Lime;
            this.mButton.Location = new System.Drawing.Point(12, 206);
            this.mButton.Name = "mButton";
            this.mButton.Size = new System.Drawing.Size(62, 23);
            this.mButton.TabIndex = 3;
            this.mButton.Text = "Move";
            this.mButton.UseVisualStyleBackColor = false;
            this.mButton.Click += new System.EventHandler(this.MButton_Click);
            // 
            // postnote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(197, 230);
            this.Controls.Add(this.mButton);
            this.Controls.Add(this.rButton);
            this.Controls.Add(this.postTitle);
            this.Controls.Add(this.noteBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "postnote";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Post Note";
            this.Load += new System.EventHandler(this.Postnote_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Postnote_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label postTitle;
        private System.Windows.Forms.Button rButton;
        private System.Windows.Forms.Timer moveandstop;
        private System.Windows.Forms.Button mButton;
    }
}