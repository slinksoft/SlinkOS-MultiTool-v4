﻿namespace slinkosmtv4
{
    partial class slinkoscredits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(slinkoscredits));
            this.creditsText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creditsText
            // 
            this.creditsText.AutoSize = true;
            this.creditsText.ForeColor = System.Drawing.Color.Lime;
            this.creditsText.Location = new System.Drawing.Point(3, 33);
            this.creditsText.Name = "creditsText";
            this.creditsText.Size = new System.Drawing.Size(364, 286);
            this.creditsText.TabIndex = 0;
            this.creditsText.Text = resources.GetString("creditsText.Text");
            this.creditsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credits";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Black;
            this.closeButton.ForeColor = System.Drawing.Color.Lime;
            this.closeButton.Location = new System.Drawing.Point(138, 322);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(92, 28);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // slinkoscredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(369, 358);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creditsText);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 397);
            this.MinimumSize = new System.Drawing.Size(385, 397);
            this.Name = "slinkoscredits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SlinkOS Credits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creditsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
    }
}