namespace Tut1MilesToKm
{
    partial class frmMilesToKm
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
            this.tbMiles = new System.Windows.Forms.TextBox();
            this.tbKm = new System.Windows.Forms.TextBox();
            this.btnEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMiles
            // 
            this.tbMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMiles.Location = new System.Drawing.Point(12, 12);
            this.tbMiles.Name = "tbMiles";
            this.tbMiles.Size = new System.Drawing.Size(100, 26);
            this.tbMiles.TabIndex = 0;
            this.tbMiles.MouseEnter += new System.EventHandler(this.tbMiles_MouseEnter);
            this.tbMiles.MouseLeave += new System.EventHandler(this.tbMiles_MouseLeave);
            // 
            // tbKm
            // 
            this.tbKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKm.Location = new System.Drawing.Point(172, 12);
            this.tbKm.Name = "tbKm";
            this.tbKm.ReadOnly = true;
            this.tbKm.Size = new System.Drawing.Size(100, 26);
            this.tbKm.TabIndex = 1;
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(129, 13);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(26, 26);
            this.btnEquals.TabIndex = 2;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // frmMilesToKm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 50);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.tbKm);
            this.Controls.Add(this.tbMiles);
            this.Name = "frmMilesToKm";
            this.Text = "Miles to Km";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMiles;
        private System.Windows.Forms.TextBox tbKm;
        private System.Windows.Forms.Button btnEquals;
    }
}

