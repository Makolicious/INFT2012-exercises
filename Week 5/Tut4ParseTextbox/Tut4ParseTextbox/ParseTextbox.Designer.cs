namespace Tut4ParseTextbox
{
    partial class frmParseTextbox
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 28);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(110, 20);
            this.tbInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter a number";
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(12, 55);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(110, 23);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(9, 81);
            this.lblResult.MaximumSize = new System.Drawing.Size(113, 0);
            this.lblResult.MinimumSize = new System.Drawing.Size(113, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(113, 26);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "This program will parse input.";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmParseTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(134, 113);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput);
            this.Name = "frmParseTextbox";
            this.Text = "Parse Textbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Label lblResult;
    }
}

