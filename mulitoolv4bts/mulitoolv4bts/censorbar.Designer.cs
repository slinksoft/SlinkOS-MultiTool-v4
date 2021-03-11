namespace slinkosmtv4
{
    partial class censorbar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(censorbar));
            this.wI = new System.Windows.Forms.TextBox();
            this.hI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.spawnandmove = new System.Windows.Forms.Timer(this.components);
            this.dButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wI
            // 
            this.wI.BackColor = System.Drawing.Color.Black;
            this.wI.ForeColor = System.Drawing.Color.Lime;
            this.wI.Location = new System.Drawing.Point(68, 51);
            this.wI.Name = "wI";
            this.wI.Size = new System.Drawing.Size(70, 20);
            this.wI.TabIndex = 0;
            // 
            // hI
            // 
            this.hI.BackColor = System.Drawing.Color.Black;
            this.hI.ForeColor = System.Drawing.Color.Lime;
            this.hI.Location = new System.Drawing.Point(68, 89);
            this.hI.Name = "hI";
            this.hI.Size = new System.Drawing.Size(70, 20);
            this.hI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(86, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(83, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // dI
            // 
            this.dI.BackColor = System.Drawing.Color.Black;
            this.dI.ForeColor = System.Drawing.Color.Lime;
            this.dI.Location = new System.Drawing.Point(67, 172);
            this.dI.Name = "dI";
            this.dI.Size = new System.Drawing.Size(70, 20);
            this.dI.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(68, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delete (By #)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(65, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Bar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dButton
            // 
            this.dButton.BackColor = System.Drawing.Color.Black;
            this.dButton.ForeColor = System.Drawing.Color.Lime;
            this.dButton.Location = new System.Drawing.Point(65, 197);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(75, 23);
            this.dButton.TabIndex = 7;
            this.dButton.Text = "Delete Bar";
            this.dButton.UseVisualStyleBackColor = false;
            this.dButton.Click += new System.EventHandler(this.dButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(64, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Censorbar Tool";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Black;
            this.helpButton.ForeColor = System.Drawing.Color.Lime;
            this.helpButton.Location = new System.Drawing.Point(67, 238);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 9;
            this.helpButton.Text = "Tutorial";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // censorbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(208, 264);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hI);
            this.Controls.Add(this.wI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(224, 303);
            this.MinimumSize = new System.Drawing.Size(224, 303);
            this.Name = "censorbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Censorbar Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wI;
        private System.Windows.Forms.TextBox hI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer spawnandmove;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button helpButton;
    }
}