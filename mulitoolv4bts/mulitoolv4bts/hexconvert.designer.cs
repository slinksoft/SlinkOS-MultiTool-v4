namespace slinkosmtv4
{
    partial class hexconvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hexconvert));
            this.asciiI = new System.Windows.Forms.TextBox();
            this.hexI = new System.Windows.Forms.TextBox();
            this.converttoB = new System.Windows.Forms.Button();
            this.converttoA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // asciiI
            // 
            this.asciiI.BackColor = System.Drawing.Color.Black;
            this.asciiI.ForeColor = System.Drawing.Color.Lime;
            this.asciiI.Location = new System.Drawing.Point(12, 51);
            this.asciiI.Multiline = true;
            this.asciiI.Name = "asciiI";
            this.asciiI.Size = new System.Drawing.Size(134, 156);
            this.asciiI.TabIndex = 0;
            // 
            // hexI
            // 
            this.hexI.BackColor = System.Drawing.Color.Black;
            this.hexI.ForeColor = System.Drawing.Color.Lime;
            this.hexI.Location = new System.Drawing.Point(187, 51);
            this.hexI.Multiline = true;
            this.hexI.Name = "hexI";
            this.hexI.Size = new System.Drawing.Size(134, 156);
            this.hexI.TabIndex = 1;
            // 
            // converttoB
            // 
            this.converttoB.BackColor = System.Drawing.Color.Black;
            this.converttoB.ForeColor = System.Drawing.Color.Lime;
            this.converttoB.Location = new System.Drawing.Point(150, 67);
            this.converttoB.Name = "converttoB";
            this.converttoB.Size = new System.Drawing.Size(31, 31);
            this.converttoB.TabIndex = 2;
            this.converttoB.Text = "->";
            this.converttoB.UseVisualStyleBackColor = false;
            this.converttoB.Click += new System.EventHandler(this.converttoB_Click);
            // 
            // converttoA
            // 
            this.converttoA.BackColor = System.Drawing.Color.Black;
            this.converttoA.ForeColor = System.Drawing.Color.Lime;
            this.converttoA.Location = new System.Drawing.Point(150, 104);
            this.converttoA.Name = "converttoA";
            this.converttoA.Size = new System.Drawing.Size(31, 31);
            this.converttoA.TabIndex = 3;
            this.converttoA.Text = "<-";
            this.converttoA.UseVisualStyleBackColor = false;
            this.converttoA.Click += new System.EventHandler(this.converttoA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(239, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "HEX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(53, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ASCII";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(150, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(103, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "HEX To ASCII Converter";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hexconvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(333, 221);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.converttoA);
            this.Controls.Add(this.converttoB);
            this.Controls.Add(this.hexI);
            this.Controls.Add(this.asciiI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(349, 260);
            this.MinimumSize = new System.Drawing.Size(349, 260);
            this.Name = "hexconvert";
            this.Text = "HEX Converter";
            this.Load += new System.EventHandler(this.binconvert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox asciiI;
        private System.Windows.Forms.TextBox hexI;
        private System.Windows.Forms.Button converttoB;
        private System.Windows.Forms.Button converttoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}