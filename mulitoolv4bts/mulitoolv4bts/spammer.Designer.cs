namespace slinkosmtv4
{
    partial class spammer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spammer));
            this.textI = new System.Windows.Forms.TextBox();
            this.intervalI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.spamtick = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textI
            // 
            this.textI.BackColor = System.Drawing.Color.Black;
            this.textI.ForeColor = System.Drawing.Color.Lime;
            this.textI.Location = new System.Drawing.Point(27, 53);
            this.textI.Multiline = true;
            this.textI.Name = "textI";
            this.textI.Size = new System.Drawing.Size(127, 107);
            this.textI.TabIndex = 0;
            this.textI.Text = "spamm3rz";
            // 
            // intervalI
            // 
            this.intervalI.BackColor = System.Drawing.Color.Black;
            this.intervalI.ForeColor = System.Drawing.Color.Lime;
            this.intervalI.Location = new System.Drawing.Point(67, 183);
            this.intervalI.MaxLength = 5;
            this.intervalI.Name = "intervalI";
            this.intervalI.Size = new System.Drawing.Size(44, 20);
            this.intervalI.TabIndex = 1;
            this.intervalI.Text = "1000";
            this.intervalI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intervalI_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(68, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(51, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text To Spam";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(50, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // spamtick
            // 
            this.spamtick.Tick += new System.EventHandler(this.spamtick_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(32, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 59);
            this.button2.TabIndex = 5;
            this.button2.Text = "(READ) In Case The Macro Goes Out Of Wack...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Black;
            this.helpButton.ForeColor = System.Drawing.Color.Lime;
            this.helpButton.Location = new System.Drawing.Point(50, 308);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 6;
            this.helpButton.Text = "Tutorial";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(51, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Text Spammer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(181, 337);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intervalI);
            this.Controls.Add(this.textI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(197, 376);
            this.MinimumSize = new System.Drawing.Size(197, 376);
            this.Name = "spammer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Spammer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spammer_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textI;
        private System.Windows.Forms.TextBox intervalI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer spamtick;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label label3;
    }
}