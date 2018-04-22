namespace Lec4DemoStrings
{
    partial class frmStringDemo
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
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnSubstringOnward = new System.Windows.Forms.Button();
            this.btnSubstringSize = new System.Windows.Forms.Button();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnS2ToLower = new System.Windows.Forms.Button();
            this.btnS1ToUpper = new System.Windows.Forms.Button();
            this.txbxNumber2 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnElementN1S1 = new System.Windows.Forms.Button();
            this.txbxNumber1 = new System.Windows.Forms.TextBox();
            this.txbxString2 = new System.Windows.Forms.TextBox();
            this.txbxString1 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblStr2 = new System.Windows.Forms.Label();
            this.lblStr1 = new System.Windows.Forms.Label();
            this.btnConcatenate = new System.Windows.Forms.Button();
            this.txbxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(129, 138);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(104, 23);
            this.btnCompare.TabIndex = 96;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnSubstringOnward
            // 
            this.btnSubstringOnward.Location = new System.Drawing.Point(17, 412);
            this.btnSubstringOnward.Name = "btnSubstringOnward";
            this.btnSubstringOnward.Size = new System.Drawing.Size(216, 40);
            this.btnSubstringOnward.TabIndex = 95;
            this.btnSubstringOnward.Text = "Substring of String 1 from index Number 1 onward";
            this.btnSubstringOnward.Click += new System.EventHandler(this.btnSubstringOnward_Click);
            // 
            // btnSubstringSize
            // 
            this.btnSubstringSize.Location = new System.Drawing.Point(17, 363);
            this.btnSubstringSize.Name = "btnSubstringSize";
            this.btnSubstringSize.Size = new System.Drawing.Size(216, 40);
            this.btnSubstringSize.TabIndex = 94;
            this.btnSubstringSize.Text = "Substring of String 1 at index Number 1 of size Number 2";
            this.btnSubstringSize.Click += new System.EventHandler(this.btnSubstringSize_Click);
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Location = new System.Drawing.Point(17, 331);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(216, 23);
            this.btnLastIndexOf.TabIndex = 93;
            this.btnLastIndexOf.Text = "LastIndexOf String 2 in String 1";
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(17, 299);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(216, 23);
            this.btnIndexOf.TabIndex = 92;
            this.btnIndexOf.Text = "IndexOf String 2 in String 1";
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(17, 267);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(216, 23);
            this.btnRemove.TabIndex = 91;
            this.btnRemove.Text = "Remove Num2 from Str1 at index Num1";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(17, 235);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(216, 23);
            this.btnInsert.TabIndex = 90;
            this.btnInsert.Text = "Insert Str2 before index Num1 of Str1";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnS2ToLower
            // 
            this.btnS2ToLower.Location = new System.Drawing.Point(129, 203);
            this.btnS2ToLower.Name = "btnS2ToLower";
            this.btnS2ToLower.Size = new System.Drawing.Size(104, 23);
            this.btnS2ToLower.TabIndex = 89;
            this.btnS2ToLower.Text = "String 1 ToLower";
            this.btnS2ToLower.Click += new System.EventHandler(this.btnS2ToLower_Click);
            // 
            // btnS1ToUpper
            // 
            this.btnS1ToUpper.Location = new System.Drawing.Point(17, 203);
            this.btnS1ToUpper.Name = "btnS1ToUpper";
            this.btnS1ToUpper.Size = new System.Drawing.Size(104, 23);
            this.btnS1ToUpper.TabIndex = 88;
            this.btnS1ToUpper.Text = "String 1 ToUpper";
            this.btnS1ToUpper.Click += new System.EventHandler(this.btnS1ToUpper_Click);
            // 
            // txbxNumber2
            // 
            this.txbxNumber2.Location = new System.Drawing.Point(97, 108);
            this.txbxNumber2.Name = "txbxNumber2";
            this.txbxNumber2.Size = new System.Drawing.Size(136, 20);
            this.txbxNumber2.TabIndex = 80;
            // 
            // lblNum2
            // 
            this.lblNum2.Location = new System.Drawing.Point(9, 108);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(80, 23);
            this.lblNum2.TabIndex = 87;
            this.lblNum2.Text = "Number 2";
            this.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnElementN1S1
            // 
            this.btnElementN1S1.Location = new System.Drawing.Point(17, 171);
            this.btnElementN1S1.Name = "btnElementN1S1";
            this.btnElementN1S1.Size = new System.Drawing.Size(216, 23);
            this.btnElementN1S1.TabIndex = 86;
            this.btnElementN1S1.Text = "Element Number 1 of String 1";
            this.btnElementN1S1.Click += new System.EventHandler(this.btnElementN1S1_Click);
            // 
            // txbxNumber1
            // 
            this.txbxNumber1.Location = new System.Drawing.Point(97, 76);
            this.txbxNumber1.Name = "txbxNumber1";
            this.txbxNumber1.Size = new System.Drawing.Size(136, 20);
            this.txbxNumber1.TabIndex = 79;
            // 
            // txbxString2
            // 
            this.txbxString2.Location = new System.Drawing.Point(65, 44);
            this.txbxString2.Name = "txbxString2";
            this.txbxString2.Size = new System.Drawing.Size(168, 20);
            this.txbxString2.TabIndex = 78;
            // 
            // txbxString1
            // 
            this.txbxString1.Location = new System.Drawing.Point(65, 12);
            this.txbxString1.Name = "txbxString1";
            this.txbxString1.Size = new System.Drawing.Size(168, 20);
            this.txbxString1.TabIndex = 77;
            // 
            // lblNum1
            // 
            this.lblNum1.Location = new System.Drawing.Point(9, 76);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(80, 23);
            this.lblNum1.TabIndex = 85;
            this.lblNum1.Text = "Number 1";
            this.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStr2
            // 
            this.lblStr2.Location = new System.Drawing.Point(9, 44);
            this.lblStr2.Name = "lblStr2";
            this.lblStr2.Size = new System.Drawing.Size(48, 23);
            this.lblStr2.TabIndex = 84;
            this.lblStr2.Text = "String 2";
            this.lblStr2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStr1
            // 
            this.lblStr1.Location = new System.Drawing.Point(9, 12);
            this.lblStr1.Name = "lblStr1";
            this.lblStr1.Size = new System.Drawing.Size(48, 23);
            this.lblStr1.TabIndex = 83;
            this.lblStr1.Text = "String 1";
            this.lblStr1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConcatenate
            // 
            this.btnConcatenate.Location = new System.Drawing.Point(18, 138);
            this.btnConcatenate.Name = "btnConcatenate";
            this.btnConcatenate.Size = new System.Drawing.Size(103, 23);
            this.btnConcatenate.TabIndex = 82;
            this.btnConcatenate.Text = "Concatenate";
            this.btnConcatenate.Click += new System.EventHandler(this.btnConcatenate_Click);
            // 
            // txbxOutput
            // 
            this.txbxOutput.Location = new System.Drawing.Point(241, 11);
            this.txbxOutput.Multiline = true;
            this.txbxOutput.Name = "txbxOutput";
            this.txbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbxOutput.Size = new System.Drawing.Size(344, 441);
            this.txbxOutput.TabIndex = 81;
            // 
            // frmStringDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 462);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnSubstringOnward);
            this.Controls.Add(this.btnSubstringSize);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnS2ToLower);
            this.Controls.Add(this.btnS1ToUpper);
            this.Controls.Add(this.txbxNumber2);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.btnElementN1S1);
            this.Controls.Add(this.txbxNumber1);
            this.Controls.Add(this.txbxString2);
            this.Controls.Add(this.txbxString1);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblStr2);
            this.Controls.Add(this.lblStr1);
            this.Controls.Add(this.btnConcatenate);
            this.Controls.Add(this.txbxOutput);
            this.Name = "frmStringDemo";
            this.Text = "String demonstrations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompare;
        internal System.Windows.Forms.Button btnSubstringOnward;
        internal System.Windows.Forms.Button btnSubstringSize;
        internal System.Windows.Forms.Button btnLastIndexOf;
        internal System.Windows.Forms.Button btnIndexOf;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.Button btnInsert;
        internal System.Windows.Forms.Button btnS2ToLower;
        internal System.Windows.Forms.Button btnS1ToUpper;
        internal System.Windows.Forms.TextBox txbxNumber2;
        internal System.Windows.Forms.Label lblNum2;
        internal System.Windows.Forms.Button btnElementN1S1;
        internal System.Windows.Forms.TextBox txbxNumber1;
        internal System.Windows.Forms.TextBox txbxString2;
        internal System.Windows.Forms.TextBox txbxString1;
        internal System.Windows.Forms.Label lblNum1;
        internal System.Windows.Forms.Label lblStr2;
        internal System.Windows.Forms.Label lblStr1;
        internal System.Windows.Forms.Button btnConcatenate;
        internal System.Windows.Forms.TextBox txbxOutput;
    }
}

