namespace slinkosmtv4
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.label1 = new System.Windows.Forms.Label();
            this.installButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.unInput = new System.Windows.Forms.TextBox();
            this.paintOpenOp = new System.Windows.Forms.CheckBox();
            this.checkVersion = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.showCredits = new System.Windows.Forms.Button();
            this.noStartup = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Startup Options";
            // 
            // installButton
            // 
            this.installButton.BackColor = System.Drawing.Color.Black;
            this.installButton.ForeColor = System.Drawing.Color.Lime;
            this.installButton.Location = new System.Drawing.Point(12, 57);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(75, 23);
            this.installButton.TabIndex = 1;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = false;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(177, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // unInput
            // 
            this.unInput.BackColor = System.Drawing.Color.Black;
            this.unInput.ForeColor = System.Drawing.Color.Lime;
            this.unInput.Location = new System.Drawing.Point(151, 59);
            this.unInput.MaxLength = 20;
            this.unInput.Name = "unInput";
            this.unInput.Size = new System.Drawing.Size(100, 20);
            this.unInput.TabIndex = 3;
            // 
            // paintOpenOp
            // 
            this.paintOpenOp.AutoSize = true;
            this.paintOpenOp.ForeColor = System.Drawing.Color.Lime;
            this.paintOpenOp.Location = new System.Drawing.Point(11, 86);
            this.paintOpenOp.Name = "paintOpenOp";
            this.paintOpenOp.Size = new System.Drawing.Size(261, 17);
            this.paintOpenOp.TabIndex = 4;
            this.paintOpenOp.Text = "Quick Snap Desktop Opens Screenshot In Paint?";
            this.paintOpenOp.UseVisualStyleBackColor = true;
            this.paintOpenOp.CheckedChanged += new System.EventHandler(this.paintOpenOp_CheckedChanged);
            // 
            // checkVersion
            // 
            this.checkVersion.AutoSize = true;
            this.checkVersion.ForeColor = System.Drawing.Color.Lime;
            this.checkVersion.Location = new System.Drawing.Point(11, 104);
            this.checkVersion.Name = "checkVersion";
            this.checkVersion.Size = new System.Drawing.Size(151, 17);
            this.checkVersion.TabIndex = 5;
            this.checkVersion.Text = "Check For Latest Version?";
            this.checkVersion.UseVisualStyleBackColor = true;
            this.checkVersion.CheckedChanged += new System.EventHandler(this.checkVersion_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(20, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "(All settings other than the Startup setting require installing to startup first)" +
    "";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Black;
            this.saveButton.ForeColor = System.Drawing.Color.Lime;
            this.saveButton.Location = new System.Drawing.Point(15, 197);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 36);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save && Close";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Black;
            this.closeButton.ForeColor = System.Drawing.Color.Lime;
            this.closeButton.Location = new System.Drawing.Point(148, 197);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(118, 36);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // showCredits
            // 
            this.showCredits.BackColor = System.Drawing.Color.Black;
            this.showCredits.ForeColor = System.Drawing.Color.Lime;
            this.showCredits.Location = new System.Drawing.Point(94, 239);
            this.showCredits.Name = "showCredits";
            this.showCredits.Size = new System.Drawing.Size(96, 29);
            this.showCredits.TabIndex = 9;
            this.showCredits.Text = "Credits";
            this.showCredits.UseVisualStyleBackColor = false;
            this.showCredits.Click += new System.EventHandler(this.showCredits_Click);
            // 
            // noStartup
            // 
            this.noStartup.AutoSize = true;
            this.noStartup.ForeColor = System.Drawing.Color.Lime;
            this.noStartup.Location = new System.Drawing.Point(11, 123);
            this.noStartup.Name = "noStartup";
            this.noStartup.Size = new System.Drawing.Size(147, 17);
            this.noStartup.TabIndex = 10;
            this.noStartup.Text = "Disable Startup Terminal?";
            this.noStartup.UseVisualStyleBackColor = true;
            this.noStartup.CheckedChanged += new System.EventHandler(this.NoStartup_CheckedChanged);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(283, 275);
            this.ControlBox = false;
            this.Controls.Add(this.noStartup);
            this.Controls.Add(this.showCredits);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkVersion);
            this.Controls.Add(this.paintOpenOp);
            this.Controls.Add(this.unInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "§linkOS Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unInput;
        private System.Windows.Forms.CheckBox paintOpenOp;
        private System.Windows.Forms.CheckBox checkVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button showCredits;
        private System.Windows.Forms.CheckBox noStartup;
    }
}