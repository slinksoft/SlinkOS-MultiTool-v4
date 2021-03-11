namespace slinkosmtv4
{
    partial class equationCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equationCalc));
            this.equationInput = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.messageFeatures = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // equationInput
            // 
            this.equationInput.BackColor = System.Drawing.Color.Black;
            this.equationInput.ForeColor = System.Drawing.Color.Lime;
            this.equationInput.Location = new System.Drawing.Point(69, 25);
            this.equationInput.Name = "equationInput";
            this.equationInput.Size = new System.Drawing.Size(168, 20);
            this.equationInput.TabIndex = 0;
            this.equationInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EquationInput_KeyDown);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Black;
            this.calculate.ForeColor = System.Drawing.Color.Lime;
            this.calculate.Location = new System.Drawing.Point(43, 73);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // messageFeatures
            // 
            this.messageFeatures.BackColor = System.Drawing.Color.Black;
            this.messageFeatures.ForeColor = System.Drawing.Color.Lime;
            this.messageFeatures.Location = new System.Drawing.Point(124, 73);
            this.messageFeatures.Name = "messageFeatures";
            this.messageFeatures.Size = new System.Drawing.Size(75, 23);
            this.messageFeatures.TabIndex = 2;
            this.messageFeatures.Text = "Features";
            this.messageFeatures.UseVisualStyleBackColor = false;
            this.messageFeatures.Click += new System.EventHandler(this.MessageFeatures_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(76, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Equation Calculator";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultOutput
            // 
            this.resultOutput.BackColor = System.Drawing.Color.Black;
            this.resultOutput.ForeColor = System.Drawing.Color.Lime;
            this.resultOutput.Location = new System.Drawing.Point(69, 47);
            this.resultOutput.Name = "resultOutput";
            this.resultOutput.Size = new System.Drawing.Size(168, 20);
            this.resultOutput.TabIndex = 12;
            this.resultOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResultOutput_KeyDown);
            this.resultOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResultOutput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Equation:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Result:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equationCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(247, 107);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.messageFeatures);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.equationInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(263, 146);
            this.MinimumSize = new System.Drawing.Size(263, 146);
            this.Name = "equationCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expression Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox equationInput;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button messageFeatures;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}