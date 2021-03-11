namespace slinkosmtv4
{
    partial class dataConversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dataConversion));
            this.asciiI = new System.Windows.Forms.TextBox();
            this.binI = new System.Windows.Forms.TextBox();
            this.converttoB = new System.Windows.Forms.Button();
            this.converttoA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.binaryBase = new System.Windows.Forms.TextBox();
            this.octaBase = new System.Windows.Forms.TextBox();
            this.hexBase = new System.Windows.Forms.TextBox();
            this.decimalBase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.updateBases = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.point32Decimal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.thirtyTwoPointRepresenation = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.sixtyFourPointRepresenation = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.point64Decimal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.unsignedDecimal = new System.Windows.Forms.TextBox();
            this.unsignedHex = new System.Windows.Forms.TextBox();
            this.unsignedOcta = new System.Windows.Forms.TextBox();
            this.unsignedBinary = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.signedDataType = new System.Windows.Forms.ComboBox();
            this.unsignedDataType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.clearHex = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.hexToAscii = new System.Windows.Forms.Button();
            this.asciiToHex = new System.Windows.Forms.Button();
            this.hexI = new System.Windows.Forms.TextBox();
            this.asciiI2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // asciiI
            // 
            this.asciiI.BackColor = System.Drawing.Color.Black;
            this.asciiI.ForeColor = System.Drawing.Color.Lime;
            this.asciiI.Location = new System.Drawing.Point(12, 51);
            this.asciiI.Multiline = true;
            this.asciiI.Name = "asciiI";
            this.asciiI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.asciiI.Size = new System.Drawing.Size(134, 156);
            this.asciiI.TabIndex = 0;
            // 
            // binI
            // 
            this.binI.BackColor = System.Drawing.Color.Black;
            this.binI.ForeColor = System.Drawing.Color.Lime;
            this.binI.Location = new System.Drawing.Point(187, 51);
            this.binI.Multiline = true;
            this.binI.Name = "binI";
            this.binI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.binI.Size = new System.Drawing.Size(134, 156);
            this.binI.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Binary";
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
            this.label3.Location = new System.Drawing.Point(133, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Binary Tools";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(89, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Base Types (Signed Conversions)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // binaryBase
            // 
            this.binaryBase.BackColor = System.Drawing.Color.Black;
            this.binaryBase.ForeColor = System.Drawing.Color.Lime;
            this.binaryBase.Location = new System.Drawing.Point(12, 264);
            this.binaryBase.Multiline = true;
            this.binaryBase.Name = "binaryBase";
            this.binaryBase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.binaryBase.Size = new System.Drawing.Size(111, 60);
            this.binaryBase.TabIndex = 9;
            this.binaryBase.TextChanged += new System.EventHandler(this.binaryBase_TextChanged);
            this.binaryBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.binaryBase_KeyPress);
            // 
            // octaBase
            // 
            this.octaBase.BackColor = System.Drawing.Color.Black;
            this.octaBase.ForeColor = System.Drawing.Color.Lime;
            this.octaBase.Location = new System.Drawing.Point(210, 264);
            this.octaBase.Multiline = true;
            this.octaBase.Name = "octaBase";
            this.octaBase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.octaBase.Size = new System.Drawing.Size(111, 60);
            this.octaBase.TabIndex = 10;
            this.octaBase.TextChanged += new System.EventHandler(this.octaBase_TextChanged);
            this.octaBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.octaBase_KeyPress);
            // 
            // hexBase
            // 
            this.hexBase.BackColor = System.Drawing.Color.Black;
            this.hexBase.ForeColor = System.Drawing.Color.Lime;
            this.hexBase.Location = new System.Drawing.Point(210, 345);
            this.hexBase.Multiline = true;
            this.hexBase.Name = "hexBase";
            this.hexBase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hexBase.Size = new System.Drawing.Size(111, 60);
            this.hexBase.TabIndex = 11;
            this.hexBase.TextChanged += new System.EventHandler(this.hexBase_TextChanged);
            this.hexBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hexBase_KeyPress);
            // 
            // decimalBase
            // 
            this.decimalBase.BackColor = System.Drawing.Color.Black;
            this.decimalBase.ForeColor = System.Drawing.Color.Lime;
            this.decimalBase.Location = new System.Drawing.Point(12, 345);
            this.decimalBase.Multiline = true;
            this.decimalBase.Name = "decimalBase";
            this.decimalBase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decimalBase.Size = new System.Drawing.Size(111, 60);
            this.decimalBase.TabIndex = 12;
            this.decimalBase.TextChanged += new System.EventHandler(this.decimalBase_TextChanged);
            this.decimalBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimalBase_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(23, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Base 2 (Binary)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(230, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Base 8 (Octa)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(14, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Base 10 (Decimal)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(228, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Base 16 (Hex)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(470, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Point Float To Binary";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // point32Decimal
            // 
            this.point32Decimal.BackColor = System.Drawing.Color.Black;
            this.point32Decimal.ForeColor = System.Drawing.Color.Lime;
            this.point32Decimal.Location = new System.Drawing.Point(373, 72);
            this.point32Decimal.Multiline = true;
            this.point32Decimal.Name = "point32Decimal";
            this.point32Decimal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.point32Decimal.Size = new System.Drawing.Size(299, 29);
            this.point32Decimal.TabIndex = 18;
            this.point32Decimal.TextChanged += new System.EventHandler(this.pointDecimal_TextChanged);
            this.point32Decimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.point32Decimal_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(466, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Point Decimal (32 bits)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(463, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Binary Representation";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirtyTwoPointRepresenation
            // 
            this.thirtyTwoPointRepresenation.BackColor = System.Drawing.Color.Black;
            this.thirtyTwoPointRepresenation.ForeColor = System.Drawing.Color.Lime;
            this.thirtyTwoPointRepresenation.Location = new System.Drawing.Point(373, 132);
            this.thirtyTwoPointRepresenation.Multiline = true;
            this.thirtyTwoPointRepresenation.Name = "thirtyTwoPointRepresenation";
            this.thirtyTwoPointRepresenation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.thirtyTwoPointRepresenation.Size = new System.Drawing.Size(299, 29);
            this.thirtyTwoPointRepresenation.TabIndex = 20;
            this.thirtyTwoPointRepresenation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thirtyTwoPointRepresenation_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Lime;
            this.label15.Location = new System.Drawing.Point(463, 305);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Binary Representation";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sixtyFourPointRepresenation
            // 
            this.sixtyFourPointRepresenation.BackColor = System.Drawing.Color.Black;
            this.sixtyFourPointRepresenation.ForeColor = System.Drawing.Color.Lime;
            this.sixtyFourPointRepresenation.Location = new System.Drawing.Point(373, 321);
            this.sixtyFourPointRepresenation.Multiline = true;
            this.sixtyFourPointRepresenation.Name = "sixtyFourPointRepresenation";
            this.sixtyFourPointRepresenation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sixtyFourPointRepresenation.Size = new System.Drawing.Size(299, 62);
            this.sixtyFourPointRepresenation.TabIndex = 30;
            this.sixtyFourPointRepresenation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sixtyFourPointRepresenation_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(466, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Point Decimal (64 bits)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // point64Decimal
            // 
            this.point64Decimal.BackColor = System.Drawing.Color.Black;
            this.point64Decimal.ForeColor = System.Drawing.Color.Lime;
            this.point64Decimal.Location = new System.Drawing.Point(373, 261);
            this.point64Decimal.Multiline = true;
            this.point64Decimal.Name = "point64Decimal";
            this.point64Decimal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.point64Decimal.Size = new System.Drawing.Size(299, 29);
            this.point64Decimal.TabIndex = 28;
            this.point64Decimal.TextChanged += new System.EventHandler(this.point64Decimal_TextChanged);
            this.point64Decimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.point64Decimal_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Lime;
            this.label17.Location = new System.Drawing.Point(463, 226);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Point Double To Binary";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(223, 516);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Base 16 (Hex)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Location = new System.Drawing.Point(9, 517);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Base 10 (Decimal)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.Location = new System.Drawing.Point(225, 437);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Base 8 (Octa)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Lime;
            this.label18.Location = new System.Drawing.Point(18, 437);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Base 2 (Binary)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unsignedDecimal
            // 
            this.unsignedDecimal.BackColor = System.Drawing.Color.Black;
            this.unsignedDecimal.ForeColor = System.Drawing.Color.Lime;
            this.unsignedDecimal.Location = new System.Drawing.Point(7, 534);
            this.unsignedDecimal.Multiline = true;
            this.unsignedDecimal.Name = "unsignedDecimal";
            this.unsignedDecimal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.unsignedDecimal.Size = new System.Drawing.Size(111, 60);
            this.unsignedDecimal.TabIndex = 36;
            this.unsignedDecimal.TextChanged += new System.EventHandler(this.unsignedDecimal_TextChanged);
            this.unsignedDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unsignedDecimal_KeyPress);
            // 
            // unsignedHex
            // 
            this.unsignedHex.BackColor = System.Drawing.Color.Black;
            this.unsignedHex.ForeColor = System.Drawing.Color.Lime;
            this.unsignedHex.Location = new System.Drawing.Point(205, 534);
            this.unsignedHex.Multiline = true;
            this.unsignedHex.Name = "unsignedHex";
            this.unsignedHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.unsignedHex.Size = new System.Drawing.Size(111, 60);
            this.unsignedHex.TabIndex = 35;
            this.unsignedHex.TextChanged += new System.EventHandler(this.unsignedHex_TextChanged);
            this.unsignedHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unsignedHex_KeyPress);
            // 
            // unsignedOcta
            // 
            this.unsignedOcta.BackColor = System.Drawing.Color.Black;
            this.unsignedOcta.ForeColor = System.Drawing.Color.Lime;
            this.unsignedOcta.Location = new System.Drawing.Point(205, 453);
            this.unsignedOcta.Multiline = true;
            this.unsignedOcta.Name = "unsignedOcta";
            this.unsignedOcta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.unsignedOcta.Size = new System.Drawing.Size(111, 60);
            this.unsignedOcta.TabIndex = 34;
            this.unsignedOcta.TextChanged += new System.EventHandler(this.unsignedOcta_TextChanged);
            this.unsignedOcta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unsignedOcta_KeyPress);
            // 
            // unsignedBinary
            // 
            this.unsignedBinary.BackColor = System.Drawing.Color.Black;
            this.unsignedBinary.ForeColor = System.Drawing.Color.Lime;
            this.unsignedBinary.Location = new System.Drawing.Point(7, 453);
            this.unsignedBinary.Multiline = true;
            this.unsignedBinary.Name = "unsignedBinary";
            this.unsignedBinary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.unsignedBinary.Size = new System.Drawing.Size(111, 60);
            this.unsignedBinary.TabIndex = 33;
            this.unsignedBinary.TextChanged += new System.EventHandler(this.unsignedBinary_TextChanged);
            this.unsignedBinary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unsignedBinary_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Lime;
            this.label19.Location = new System.Drawing.Point(77, 417);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(178, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Base Types (Unsigned Conversions)";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signedDataType
            // 
            this.signedDataType.BackColor = System.Drawing.Color.Black;
            this.signedDataType.ForeColor = System.Drawing.Color.Lime;
            this.signedDataType.FormattingEnabled = true;
            this.signedDataType.Items.AddRange(new object[] {
            "32 bits",
            "64 bits"});
            this.signedDataType.Location = new System.Drawing.Point(133, 324);
            this.signedDataType.Name = "signedDataType";
            this.signedDataType.Size = new System.Drawing.Size(68, 21);
            this.signedDataType.TabIndex = 41;
            this.signedDataType.SelectedIndexChanged += new System.EventHandler(this.signedDataType_SelectedIndexChanged);
            // 
            // unsignedDataType
            // 
            this.unsignedDataType.BackColor = System.Drawing.Color.Black;
            this.unsignedDataType.ForeColor = System.Drawing.Color.Lime;
            this.unsignedDataType.FormattingEnabled = true;
            this.unsignedDataType.Items.AddRange(new object[] {
            "32 bits",
            "64 bits"});
            this.unsignedDataType.Location = new System.Drawing.Point(128, 514);
            this.unsignedDataType.Name = "unsignedDataType";
            this.unsignedDataType.Size = new System.Drawing.Size(68, 21);
            this.unsignedDataType.TabIndex = 42;
            this.unsignedDataType.SelectedIndexChanged += new System.EventHandler(this.unsignedDataType_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Lime;
            this.label20.Location = new System.Drawing.Point(454, 399);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "HEX To ASCII Converter";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearHex
            // 
            this.clearHex.BackColor = System.Drawing.Color.Black;
            this.clearHex.ForeColor = System.Drawing.Color.Lime;
            this.clearHex.Location = new System.Drawing.Point(501, 531);
            this.clearHex.Name = "clearHex";
            this.clearHex.Size = new System.Drawing.Size(31, 51);
            this.clearHex.TabIndex = 49;
            this.clearHex.Text = "CLEAR";
            this.clearHex.UseVisualStyleBackColor = false;
            this.clearHex.Click += new System.EventHandler(this.clearHex_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Lime;
            this.label21.Location = new System.Drawing.Point(404, 425);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "ASCII";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Lime;
            this.label22.Location = new System.Drawing.Point(590, 425);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "HEX";
            // 
            // hexToAscii
            // 
            this.hexToAscii.BackColor = System.Drawing.Color.Black;
            this.hexToAscii.ForeColor = System.Drawing.Color.Lime;
            this.hexToAscii.Location = new System.Drawing.Point(501, 494);
            this.hexToAscii.Name = "hexToAscii";
            this.hexToAscii.Size = new System.Drawing.Size(31, 31);
            this.hexToAscii.TabIndex = 46;
            this.hexToAscii.Text = "<-";
            this.hexToAscii.UseVisualStyleBackColor = false;
            this.hexToAscii.Click += new System.EventHandler(this.hexToAscii_Click);
            // 
            // asciiToHex
            // 
            this.asciiToHex.BackColor = System.Drawing.Color.Black;
            this.asciiToHex.ForeColor = System.Drawing.Color.Lime;
            this.asciiToHex.Location = new System.Drawing.Point(501, 457);
            this.asciiToHex.Name = "asciiToHex";
            this.asciiToHex.Size = new System.Drawing.Size(31, 31);
            this.asciiToHex.TabIndex = 45;
            this.asciiToHex.Text = "->";
            this.asciiToHex.UseVisualStyleBackColor = false;
            this.asciiToHex.Click += new System.EventHandler(this.asciiToHex_Click);
            // 
            // hexI
            // 
            this.hexI.BackColor = System.Drawing.Color.Black;
            this.hexI.ForeColor = System.Drawing.Color.Lime;
            this.hexI.Location = new System.Drawing.Point(538, 441);
            this.hexI.Multiline = true;
            this.hexI.Name = "hexI";
            this.hexI.Size = new System.Drawing.Size(134, 156);
            this.hexI.TabIndex = 44;
            // 
            // asciiI2
            // 
            this.asciiI2.BackColor = System.Drawing.Color.Black;
            this.asciiI2.ForeColor = System.Drawing.Color.Lime;
            this.asciiI2.Location = new System.Drawing.Point(363, 441);
            this.asciiI2.Multiline = true;
            this.asciiI2.Name = "asciiI2";
            this.asciiI2.Size = new System.Drawing.Size(134, 156);
            this.asciiI2.TabIndex = 43;
            // 
            // dataConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(681, 602);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.clearHex);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.hexToAscii);
            this.Controls.Add(this.asciiToHex);
            this.Controls.Add(this.hexI);
            this.Controls.Add(this.asciiI2);
            this.Controls.Add(this.unsignedDataType);
            this.Controls.Add(this.signedDataType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.unsignedDecimal);
            this.Controls.Add(this.unsignedHex);
            this.Controls.Add(this.unsignedOcta);
            this.Controls.Add(this.unsignedBinary);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.sixtyFourPointRepresenation);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.point64Decimal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.thirtyTwoPointRepresenation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.point32Decimal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decimalBase);
            this.Controls.Add(this.hexBase);
            this.Controls.Add(this.octaBase);
            this.Controls.Add(this.binaryBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.converttoA);
            this.Controls.Add(this.converttoB);
            this.Controls.Add(this.binI);
            this.Controls.Add(this.asciiI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(697, 641);
            this.MinimumSize = new System.Drawing.Size(697, 641);
            this.Name = "dataConversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Conversions";
            this.Load += new System.EventHandler(this.binconvert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox asciiI;
        private System.Windows.Forms.TextBox binI;
        private System.Windows.Forms.Button converttoB;
        private System.Windows.Forms.Button converttoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox binaryBase;
        private System.Windows.Forms.TextBox octaBase;
        private System.Windows.Forms.TextBox hexBase;
        private System.Windows.Forms.TextBox decimalBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer updateBases;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox point32Decimal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox thirtyTwoPointRepresenation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox sixtyFourPointRepresenation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox point64Decimal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox unsignedDecimal;
        private System.Windows.Forms.TextBox unsignedHex;
        private System.Windows.Forms.TextBox unsignedOcta;
        private System.Windows.Forms.TextBox unsignedBinary;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox signedDataType;
        private System.Windows.Forms.ComboBox unsignedDataType;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button clearHex;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button hexToAscii;
        private System.Windows.Forms.Button asciiToHex;
        private System.Windows.Forms.TextBox hexI;
        private System.Windows.Forms.TextBox asciiI2;
    }
}