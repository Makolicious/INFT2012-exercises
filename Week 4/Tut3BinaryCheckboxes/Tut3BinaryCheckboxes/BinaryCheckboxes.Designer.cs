namespace Tut3BinaryCheckboxes
{
    partial class frmBinaryCheckboxes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.cb32 = new System.Windows.Forms.CheckBox();
            this.cb16 = new System.Windows.Forms.CheckBox();
            this.cb64 = new System.Windows.Forms.CheckBox();
            this.cb128 = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb1);
            this.groupBox1.Controls.Add(this.cb2);
            this.groupBox1.Controls.Add(this.cb4);
            this.groupBox1.Controls.Add(this.cb8);
            this.groupBox1.Controls.Add(this.cb32);
            this.groupBox1.Controls.Add(this.cb16);
            this.groupBox1.Controls.Add(this.cb64);
            this.groupBox1.Controls.Add(this.cb128);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Binary Digits";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(7, 181);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(32, 17);
            this.cb1.TabIndex = 7;
            this.cb1.Text = "1";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(7, 158);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(32, 17);
            this.cb2.TabIndex = 6;
            this.cb2.Text = "2";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(7, 135);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(32, 17);
            this.cb4.TabIndex = 5;
            this.cb4.Text = "4";
            this.cb4.UseVisualStyleBackColor = true;
            this.cb4.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cb8
            // 
            this.cb8.AutoSize = true;
            this.cb8.Location = new System.Drawing.Point(7, 112);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(32, 17);
            this.cb8.TabIndex = 4;
            this.cb8.Text = "8";
            this.cb8.UseVisualStyleBackColor = true;
            this.cb8.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cb32
            // 
            this.cb32.AutoSize = true;
            this.cb32.Location = new System.Drawing.Point(7, 66);
            this.cb32.Name = "cb32";
            this.cb32.Size = new System.Drawing.Size(38, 17);
            this.cb32.TabIndex = 3;
            this.cb32.Text = "32";
            this.cb32.UseVisualStyleBackColor = true;
            this.cb32.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cb16
            // 
            this.cb16.AutoSize = true;
            this.cb16.Location = new System.Drawing.Point(7, 89);
            this.cb16.Name = "cb16";
            this.cb16.Size = new System.Drawing.Size(38, 17);
            this.cb16.TabIndex = 2;
            this.cb16.Text = "16";
            this.cb16.UseVisualStyleBackColor = true;
            this.cb16.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cb64
            // 
            this.cb64.AutoSize = true;
            this.cb64.Location = new System.Drawing.Point(7, 43);
            this.cb64.Name = "cb64";
            this.cb64.Size = new System.Drawing.Size(38, 17);
            this.cb64.TabIndex = 1;
            this.cb64.Text = "64";
            this.cb64.UseVisualStyleBackColor = true;
            this.cb64.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cb128
            // 
            this.cb128.AutoSize = true;
            this.cb128.Location = new System.Drawing.Point(7, 20);
            this.cb128.Name = "cb128";
            this.cb128.Size = new System.Drawing.Size(44, 17);
            this.cb128.TabIndex = 0;
            this.cb128.Text = "128";
            this.cb128.UseVisualStyleBackColor = true;
            this.cb128.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 218);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 1;
            // 
            // frmBinaryCheckboxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 240);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBinaryCheckboxes";
            this.Text = "Binary Checkboxes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb8;
        private System.Windows.Forms.CheckBox cb32;
        private System.Windows.Forms.CheckBox cb16;
        private System.Windows.Forms.CheckBox cb64;
        private System.Windows.Forms.CheckBox cb128;
        private System.Windows.Forms.Label lblResult;
    }
}

