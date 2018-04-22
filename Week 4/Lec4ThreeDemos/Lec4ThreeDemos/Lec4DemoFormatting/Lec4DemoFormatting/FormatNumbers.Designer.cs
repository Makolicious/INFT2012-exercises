namespace Lec4DemoFormatting
{
    partial class frmFormatNumbers
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnAussieShort = new System.Windows.Forms.Button();
            this.btnMakeDate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbxYear = new System.Windows.Forms.TextBox();
            this.txbxMonth = new System.Windows.Forms.TextBox();
            this.txbxDay = new System.Windows.Forms.TextBox();
            this.btnAussieMedium = new System.Windows.Forms.Button();
            this.btnShortFormat = new System.Windows.Forms.Button();
            this.btnLongFormat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbxInteger = new System.Windows.Forms.TextBox();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.txbxFloat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxSpecifier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInteger = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Location = new System.Drawing.Point(20, 273);
            this.lblDisplay.MinimumSize = new System.Drawing.Size(260, 20);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(260, 20);
            this.lblDisplay.TabIndex = 27;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAussieShort
            // 
            this.btnAussieShort.Location = new System.Drawing.Point(54, 232);
            this.btnAussieShort.Name = "btnAussieShort";
            this.btnAussieShort.Size = new System.Drawing.Size(86, 23);
            this.btnAussieShort.TabIndex = 20;
            this.btnAussieShort.Text = "Aussie short";
            this.btnAussieShort.UseVisualStyleBackColor = true;
            this.btnAussieShort.Click += new System.EventHandler(this.btnAussieShort_Click);
            // 
            // btnMakeDate
            // 
            this.btnMakeDate.Location = new System.Drawing.Point(122, 134);
            this.btnMakeDate.Name = "btnMakeDate";
            this.btnMakeDate.Size = new System.Drawing.Size(86, 23);
            this.btnMakeDate.TabIndex = 18;
            this.btnMakeDate.Text = "Make date";
            this.btnMakeDate.UseVisualStyleBackColor = true;
            this.btnMakeDate.Click += new System.EventHandler(this.btnMakeDate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Enter the year";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Enter the month";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Enter the day";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbxYear
            // 
            this.txbxYear.Location = new System.Drawing.Point(167, 108);
            this.txbxYear.Name = "txbxYear";
            this.txbxYear.Size = new System.Drawing.Size(100, 20);
            this.txbxYear.TabIndex = 17;
            // 
            // txbxMonth
            // 
            this.txbxMonth.Location = new System.Drawing.Point(167, 71);
            this.txbxMonth.Name = "txbxMonth";
            this.txbxMonth.Size = new System.Drawing.Size(100, 20);
            this.txbxMonth.TabIndex = 16;
            // 
            // txbxDay
            // 
            this.txbxDay.Location = new System.Drawing.Point(167, 35);
            this.txbxDay.Name = "txbxDay";
            this.txbxDay.Size = new System.Drawing.Size(100, 20);
            this.txbxDay.TabIndex = 15;
            // 
            // btnAussieMedium
            // 
            this.btnAussieMedium.Location = new System.Drawing.Point(167, 232);
            this.btnAussieMedium.Name = "btnAussieMedium";
            this.btnAussieMedium.Size = new System.Drawing.Size(86, 23);
            this.btnAussieMedium.TabIndex = 23;
            this.btnAussieMedium.Text = "Unambiguous";
            this.btnAussieMedium.UseVisualStyleBackColor = true;
            this.btnAussieMedium.Click += new System.EventHandler(this.btnAussieMedium_Click);
            // 
            // btnShortFormat
            // 
            this.btnShortFormat.Location = new System.Drawing.Point(167, 203);
            this.btnShortFormat.Name = "btnShortFormat";
            this.btnShortFormat.Size = new System.Drawing.Size(86, 23);
            this.btnShortFormat.TabIndex = 22;
            this.btnShortFormat.Text = "Shorter format";
            this.btnShortFormat.UseVisualStyleBackColor = true;
            this.btnShortFormat.Click += new System.EventHandler(this.btnShortFormat_Click);
            // 
            // btnLongFormat
            // 
            this.btnLongFormat.Location = new System.Drawing.Point(54, 203);
            this.btnLongFormat.Name = "btnLongFormat";
            this.btnLongFormat.Size = new System.Drawing.Size(86, 23);
            this.btnLongFormat.TabIndex = 21;
            this.btnLongFormat.Text = "Long format";
            this.btnLongFormat.UseVisualStyleBackColor = true;
            this.btnLongFormat.Click += new System.EventHandler(this.btnLongFormat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDisplay);
            this.groupBox2.Controls.Add(this.btnAussieShort);
            this.groupBox2.Controls.Add(this.btnMakeDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txbxYear);
            this.groupBox2.Controls.Add(this.txbxMonth);
            this.groupBox2.Controls.Add(this.txbxDay);
            this.groupBox2.Controls.Add(this.btnAussieMedium);
            this.groupBox2.Controls.Add(this.btnShortFormat);
            this.groupBox2.Controls.Add(this.btnLongFormat);
            this.groupBox2.Location = new System.Drawing.Point(342, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 329);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date formats";
            // 
            // txbxInteger
            // 
            this.txbxInteger.Location = new System.Drawing.Point(21, 33);
            this.txbxInteger.Name = "txbxInteger";
            this.txbxInteger.Size = new System.Drawing.Size(125, 20);
            this.txbxInteger.TabIndex = 1;
            this.txbxInteger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMultiple
            // 
            this.btnMultiple.Location = new System.Drawing.Point(218, 130);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(75, 23);
            this.btnMultiple.TabIndex = 10;
            this.btnMultiple.Text = "Multiple";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // btnFloat
            // 
            this.btnFloat.Location = new System.Drawing.Point(119, 130);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(75, 23);
            this.btnFloat.TabIndex = 9;
            this.btnFloat.Text = "Float";
            this.btnFloat.UseVisualStyleBackColor = true;
            this.btnFloat.Click += new System.EventHandler(this.btnFloat_Click);
            // 
            // txbxFloat
            // 
            this.txbxFloat.Location = new System.Drawing.Point(169, 33);
            this.txbxFloat.Name = "txbxFloat";
            this.txbxFloat.Size = new System.Drawing.Size(124, 20);
            this.txbxFloat.TabIndex = 2;
            this.txbxFloat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output";
            // 
            // txbxResult
            // 
            this.txbxResult.Location = new System.Drawing.Point(67, 208);
            this.txbxResult.Multiline = true;
            this.txbxResult.Name = "txbxResult";
            this.txbxResult.Size = new System.Drawing.Size(166, 56);
            this.txbxResult.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Specifier";
            // 
            // txbxSpecifier
            // 
            this.txbxSpecifier.Location = new System.Drawing.Point(21, 88);
            this.txbxSpecifier.Name = "txbxSpecifier";
            this.txbxSpecifier.Size = new System.Drawing.Size(272, 20);
            this.txbxSpecifier.TabIndex = 4;
            this.txbxSpecifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Float";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(66, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(40, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Integer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbxInteger);
            this.groupBox1.Controls.Add(this.btnMultiple);
            this.groupBox1.Controls.Add(this.btnInteger);
            this.groupBox1.Controls.Add(this.btnFloat);
            this.groupBox1.Controls.Add(this.txbxFloat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbxResult);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbxSpecifier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 329);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number formats";
            // 
            // btnInteger
            // 
            this.btnInteger.Location = new System.Drawing.Point(21, 130);
            this.btnInteger.Name = "btnInteger";
            this.btnInteger.Size = new System.Drawing.Size(75, 23);
            this.btnInteger.TabIndex = 0;
            this.btnInteger.Text = "Integer";
            this.btnInteger.UseVisualStyleBackColor = true;
            this.btnInteger.Click += new System.EventHandler(this.btnInteger_Click);
            // 
            // frmFormatNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 352);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFormatNumbers";
            this.Text = "Numeric format specifiers";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblDisplay;
        internal System.Windows.Forms.Button btnAussieShort;
        internal System.Windows.Forms.Button btnMakeDate;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txbxYear;
        internal System.Windows.Forms.TextBox txbxMonth;
        internal System.Windows.Forms.TextBox txbxDay;
        internal System.Windows.Forms.Button btnAussieMedium;
        internal System.Windows.Forms.Button btnShortFormat;
        internal System.Windows.Forms.Button btnLongFormat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbxInteger;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.TextBox txbxFloat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbxSpecifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInteger;
    }
}

