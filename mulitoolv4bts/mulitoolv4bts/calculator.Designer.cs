namespace slinkosmtv4
{
    partial class calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.aI = new System.Windows.Forms.TextBox();
            this.bI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.exeButton = new System.Windows.Forms.Button();
            this.functionBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aI
            // 
            this.aI.BackColor = System.Drawing.Color.Black;
            this.aI.ForeColor = System.Drawing.Color.Lime;
            this.aI.Location = new System.Drawing.Point(12, 37);
            this.aI.Name = "aI";
            this.aI.Size = new System.Drawing.Size(80, 20);
            this.aI.TabIndex = 0;
            this.aI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aI_KeyPress);
            // 
            // bI
            // 
            this.bI.BackColor = System.Drawing.Color.Black;
            this.bI.ForeColor = System.Drawing.Color.Lime;
            this.bI.Location = new System.Drawing.Point(143, 37);
            this.bI.Name = "bI";
            this.bI.Size = new System.Drawing.Size(80, 20);
            this.bI.TabIndex = 1;
            this.bI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bI_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(181, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            // 
            // cI
            // 
            this.cI.BackColor = System.Drawing.Color.Black;
            this.cI.Enabled = false;
            this.cI.ForeColor = System.Drawing.Color.Lime;
            this.cI.Location = new System.Drawing.Point(75, 76);
            this.cI.Name = "cI";
            this.cI.Size = new System.Drawing.Size(80, 20);
            this.cI.TabIndex = 4;
            this.cI.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(83, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "C (RESULT)";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Black;
            this.clearButton.ForeColor = System.Drawing.Color.Lime;
            this.clearButton.Location = new System.Drawing.Point(166, 102);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(70, 33);
            this.clearButton.TabIndex = 6;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.BackColor = System.Drawing.Color.Black;
            this.resumeButton.ForeColor = System.Drawing.Color.Lime;
            this.resumeButton.Location = new System.Drawing.Point(1, 102);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(70, 33);
            this.resumeButton.TabIndex = 7;
            this.resumeButton.TabStop = false;
            this.resumeButton.Text = "RESUME";
            this.resumeButton.UseVisualStyleBackColor = false;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // exeButton
            // 
            this.exeButton.BackColor = System.Drawing.Color.Black;
            this.exeButton.ForeColor = System.Drawing.Color.Lime;
            this.exeButton.Location = new System.Drawing.Point(77, 102);
            this.exeButton.Name = "exeButton";
            this.exeButton.Size = new System.Drawing.Size(83, 33);
            this.exeButton.TabIndex = 8;
            this.exeButton.TabStop = false;
            this.exeButton.Text = "CALCULATE";
            this.exeButton.UseVisualStyleBackColor = false;
            this.exeButton.Click += new System.EventHandler(this.exeButton_Click);
            // 
            // functionBox
            // 
            this.functionBox.BackColor = System.Drawing.Color.Black;
            this.functionBox.ForeColor = System.Drawing.Color.Lime;
            this.functionBox.FormattingEnabled = true;
            this.functionBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.functionBox.Location = new System.Drawing.Point(99, 36);
            this.functionBox.Name = "functionBox";
            this.functionBox.Size = new System.Drawing.Size(38, 21);
            this.functionBox.TabIndex = 9;
            this.functionBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(60, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Four Function Calculator";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(77, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 38);
            this.button1.TabIndex = 11;
            this.button1.TabStop = false;
            this.button1.Text = "Key Shortcuts";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(238, 188);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.functionBox);
            this.Controls.Add(this.exeButton);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bI);
            this.Controls.Add(this.aI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(254, 227);
            this.MinimumSize = new System.Drawing.Size(254, 187);
            this.Name = "calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.calculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aI;
        private System.Windows.Forms.TextBox bI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button exeButton;
        private System.Windows.Forms.ComboBox functionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}