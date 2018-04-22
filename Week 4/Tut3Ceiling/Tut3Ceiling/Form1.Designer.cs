namespace Tut3Ceiling
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnCeiling = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MaximumSize = new System.Drawing.Size(140, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number for which to find the next multiple of 5 for";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 39);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(140, 20);
            this.tbInput.TabIndex = 1;
            // 
            // btnCeiling
            // 
            this.btnCeiling.Location = new System.Drawing.Point(12, 66);
            this.btnCeiling.Name = "btnCeiling";
            this.btnCeiling.Size = new System.Drawing.Size(140, 23);
            this.btnCeiling.TabIndex = 2;
            this.btnCeiling.Text = "Find Multiple";
            this.btnCeiling.UseVisualStyleBackColor = true;
            this.btnCeiling.Click += new System.EventHandler(this.btnCeiling_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(15, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 1);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 102);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(140, 20);
            this.tbResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 133);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCeiling);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnCeiling;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbResult;
    }
}

