namespace slinkosmtv4
{
    partial class stopwatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stopwatch));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sD = new System.Windows.Forms.Label();
            this.mD = new System.Windows.Forms.Label();
            this.hD = new System.Windows.Forms.Label();
            this.msD = new System.Windows.Forms.Label();
            this.sButton = new System.Windows.Forms.Button();
            this.upTime = new System.Windows.Forms.Timer(this.components);
            this.rButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(331, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 73);
            this.label5.TabIndex = 9;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(135, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 73);
            this.label4.TabIndex = 8;
            this.label4.Text = ":";
            // 
            // sD
            // 
            this.sD.AutoSize = true;
            this.sD.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sD.ForeColor = System.Drawing.Color.Lime;
            this.sD.Location = new System.Drawing.Point(388, 61);
            this.sD.Name = "sD";
            this.sD.Size = new System.Drawing.Size(69, 73);
            this.sD.TabIndex = 7;
            this.sD.Text = "0";
            // 
            // mD
            // 
            this.mD.AutoSize = true;
            this.mD.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mD.ForeColor = System.Drawing.Color.Lime;
            this.mD.Location = new System.Drawing.Point(229, 61);
            this.mD.Name = "mD";
            this.mD.Size = new System.Drawing.Size(69, 73);
            this.mD.TabIndex = 6;
            this.mD.Text = "0";
            // 
            // hD
            // 
            this.hD.AutoSize = true;
            this.hD.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hD.ForeColor = System.Drawing.Color.Lime;
            this.hD.Location = new System.Drawing.Point(60, 61);
            this.hD.Name = "hD";
            this.hD.Size = new System.Drawing.Size(69, 73);
            this.hD.TabIndex = 5;
            this.hD.Text = "0";
            // 
            // msD
            // 
            this.msD.AutoSize = true;
            this.msD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msD.ForeColor = System.Drawing.Color.Lime;
            this.msD.Location = new System.Drawing.Point(484, 127);
            this.msD.Name = "msD";
            this.msD.Size = new System.Drawing.Size(19, 20);
            this.msD.TabIndex = 10;
            this.msD.Text = "0";
            // 
            // sButton
            // 
            this.sButton.BackColor = System.Drawing.Color.Black;
            this.sButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton.ForeColor = System.Drawing.Color.Lime;
            this.sButton.Location = new System.Drawing.Point(188, 157);
            this.sButton.Name = "sButton";
            this.sButton.Size = new System.Drawing.Size(60, 36);
            this.sButton.TabIndex = 11;
            this.sButton.Text = "START";
            this.sButton.UseVisualStyleBackColor = false;
            this.sButton.Click += new System.EventHandler(this.sButton_Click);
            // 
            // upTime
            // 
            this.upTime.Tick += new System.EventHandler(this.upTime_Tick);
            // 
            // rButton
            // 
            this.rButton.BackColor = System.Drawing.Color.Black;
            this.rButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton.ForeColor = System.Drawing.Color.Lime;
            this.rButton.Location = new System.Drawing.Point(276, 157);
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(60, 36);
            this.rButton.TabIndex = 12;
            this.rButton.Text = "RESET";
            this.rButton.UseVisualStyleBackColor = false;
            this.rButton.Click += new System.EventHandler(this.rButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Stopwatch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(556, 205);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rButton);
            this.Controls.Add(this.sButton);
            this.Controls.Add(this.msD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sD);
            this.Controls.Add(this.mD);
            this.Controls.Add(this.hD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(572, 244);
            this.MinimumSize = new System.Drawing.Size(572, 244);
            this.Name = "stopwatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sD;
        private System.Windows.Forms.Label mD;
        private System.Windows.Forms.Label hD;
        private System.Windows.Forms.Label msD;
        private System.Windows.Forms.Button sButton;
        private System.Windows.Forms.Timer upTime;
        private System.Windows.Forms.Button rButton;
        private System.Windows.Forms.Label label1;
    }
}