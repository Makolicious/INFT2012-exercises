namespace Tut4TwoIntegers
{
    partial class TwoIntegers
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
            this.tbInt1 = new System.Windows.Forms.TextBox();
            this.tbInt2 = new System.Windows.Forms.TextBox();
            this.lblMsgLeft = new System.Windows.Forms.Label();
            this.lblMsgRight = new System.Windows.Forms.Label();
            this.lblResultLeft = new System.Windows.Forms.Label();
            this.lblResultRight = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInt1
            // 
            this.tbInt1.Location = new System.Drawing.Point(12, 29);
            this.tbInt1.Name = "tbInt1";
            this.tbInt1.Size = new System.Drawing.Size(107, 20);
            this.tbInt1.TabIndex = 0;
            this.tbInt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbInt2
            // 
            this.tbInt2.Location = new System.Drawing.Point(167, 29);
            this.tbInt2.Name = "tbInt2";
            this.tbInt2.Size = new System.Drawing.Size(107, 20);
            this.tbInt2.TabIndex = 1;
            this.tbInt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMsgLeft
            // 
            this.lblMsgLeft.AutoSize = true;
            this.lblMsgLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMsgLeft.Location = new System.Drawing.Point(12, 56);
            this.lblMsgLeft.MaximumSize = new System.Drawing.Size(125, 28);
            this.lblMsgLeft.MinimumSize = new System.Drawing.Size(125, 0);
            this.lblMsgLeft.Name = "lblMsgLeft";
            this.lblMsgLeft.Size = new System.Drawing.Size(125, 28);
            this.lblMsgLeft.TabIndex = 2;
            this.lblMsgLeft.Text = "This label contains the numbers from 1 to ...";
            this.lblMsgLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMsgRight
            // 
            this.lblMsgRight.AutoSize = true;
            this.lblMsgRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMsgRight.Location = new System.Drawing.Point(149, 56);
            this.lblMsgRight.MaximumSize = new System.Drawing.Size(125, 28);
            this.lblMsgRight.MinimumSize = new System.Drawing.Size(125, 0);
            this.lblMsgRight.Name = "lblMsgRight";
            this.lblMsgRight.Size = new System.Drawing.Size(125, 28);
            this.lblMsgRight.TabIndex = 3;
            this.lblMsgRight.Text = "This label contains the ones that are / by ...";
            this.lblMsgRight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblResultLeft
            // 
            this.lblResultLeft.AutoSize = true;
            this.lblResultLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultLeft.Location = new System.Drawing.Point(12, 83);
            this.lblResultLeft.MaximumSize = new System.Drawing.Size(125, 165);
            this.lblResultLeft.MinimumSize = new System.Drawing.Size(125, 165);
            this.lblResultLeft.Name = "lblResultLeft";
            this.lblResultLeft.Size = new System.Drawing.Size(125, 165);
            this.lblResultLeft.TabIndex = 4;
            this.lblResultLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblResultRight
            // 
            this.lblResultRight.AutoSize = true;
            this.lblResultRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultRight.Location = new System.Drawing.Point(149, 83);
            this.lblResultRight.MaximumSize = new System.Drawing.Size(125, 165);
            this.lblResultRight.MinimumSize = new System.Drawing.Size(125, 165);
            this.lblResultRight.Name = "lblResultRight";
            this.lblResultRight.Size = new System.Drawing.Size(125, 165);
            this.lblResultRight.TabIndex = 5;
            this.lblResultRight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(125, 29);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(36, 20);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "GO";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Integer 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Integer 2";
            // 
            // TwoIntegers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResultRight);
            this.Controls.Add(this.lblResultLeft);
            this.Controls.Add(this.lblMsgRight);
            this.Controls.Add(this.lblMsgLeft);
            this.Controls.Add(this.tbInt2);
            this.Controls.Add(this.tbInt1);
            this.Name = "TwoIntegers";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInt1;
        private System.Windows.Forms.TextBox tbInt2;
        private System.Windows.Forms.Label lblMsgLeft;
        private System.Windows.Forms.Label lblMsgRight;
        private System.Windows.Forms.Label lblResultLeft;
        private System.Windows.Forms.Label lblResultRight;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

