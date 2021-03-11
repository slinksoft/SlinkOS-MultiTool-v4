namespace slinkosmtv4
{
    partial class timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timer));
            this.hD = new System.Windows.Forms.Label();
            this.mD = new System.Windows.Forms.Label();
            this.sD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sButton = new System.Windows.Forms.Button();
            this.hI = new System.Windows.Forms.TextBox();
            this.mI = new System.Windows.Forms.TextBox();
            this.sI = new System.Windows.Forms.TextBox();
            this.timerz = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hD
            // 
            this.hD.AutoSize = true;
            this.hD.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hD.Location = new System.Drawing.Point(37, 66);
            this.hD.Name = "hD";
            this.hD.Size = new System.Drawing.Size(69, 73);
            this.hD.TabIndex = 0;
            this.hD.Text = "0";
            // 
            // mD
            // 
            this.mD.AutoSize = true;
            this.mD.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mD.Location = new System.Drawing.Point(226, 66);
            this.mD.Name = "mD";
            this.mD.Size = new System.Drawing.Size(69, 73);
            this.mD.TabIndex = 1;
            this.mD.Text = "0";
            // 
            // sD
            // 
            this.sD.AutoSize = true;
            this.sD.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sD.Location = new System.Drawing.Point(422, 66);
            this.sD.Name = "sD";
            this.sD.Size = new System.Drawing.Size(69, 73);
            this.sD.TabIndex = 2;
            this.sD.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 73);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 73);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // sButton
            // 
            this.sButton.BackColor = System.Drawing.Color.Black;
            this.sButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton.Location = new System.Drawing.Point(227, 162);
            this.sButton.Name = "sButton";
            this.sButton.Size = new System.Drawing.Size(60, 36);
            this.sButton.TabIndex = 5;
            this.sButton.Text = "START";
            this.sButton.UseVisualStyleBackColor = false;
            this.sButton.Click += new System.EventHandler(this.sButton_Click);
            // 
            // hI
            // 
            this.hI.BackColor = System.Drawing.Color.Black;
            this.hI.ForeColor = System.Drawing.Color.Lime;
            this.hI.Location = new System.Drawing.Point(188, 43);
            this.hI.Name = "hI";
            this.hI.Size = new System.Drawing.Size(42, 20);
            this.hI.TabIndex = 6;
            // 
            // mI
            // 
            this.mI.BackColor = System.Drawing.Color.Black;
            this.mI.ForeColor = System.Drawing.Color.Lime;
            this.mI.Location = new System.Drawing.Point(236, 44);
            this.mI.Name = "mI";
            this.mI.Size = new System.Drawing.Size(42, 20);
            this.mI.TabIndex = 7;
            // 
            // sI
            // 
            this.sI.BackColor = System.Drawing.Color.Black;
            this.sI.ForeColor = System.Drawing.Color.Lime;
            this.sI.Location = new System.Drawing.Point(284, 43);
            this.sI.Name = "sI";
            this.sI.Size = new System.Drawing.Size(42, 20);
            this.sI.TabIndex = 8;
            // 
            // timerz
            // 
            this.timerz.Interval = 1000;
            this.timerz.Tick += new System.EventHandler(this.timerz_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Minute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Second";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(242, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Timer";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(536, 205);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sI);
            this.Controls.Add(this.mI);
            this.Controls.Add(this.hI);
            this.Controls.Add(this.sButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sD);
            this.Controls.Add(this.mD);
            this.Controls.Add(this.hD);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(552, 244);
            this.MinimumSize = new System.Drawing.Size(552, 244);
            this.Name = "timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hD;
        private System.Windows.Forms.Label mD;
        private System.Windows.Forms.Label sD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sButton;
        private System.Windows.Forms.TextBox hI;
        private System.Windows.Forms.TextBox mI;
        private System.Windows.Forms.TextBox sI;
        private System.Windows.Forms.Timer timerz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}