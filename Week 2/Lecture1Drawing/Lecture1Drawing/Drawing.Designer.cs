namespace Lecture1Drawing
{
    partial class frmDrawing
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
            this.picbxDrawing = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxDrawing
            // 
            this.picbxDrawing.Location = new System.Drawing.Point(12, 12);
            this.picbxDrawing.Name = "picbxDrawing";
            this.picbxDrawing.Size = new System.Drawing.Size(259, 285);
            this.picbxDrawing.TabIndex = 0;
            this.picbxDrawing.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(102, 343);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // frmDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 429);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.picbxDrawing);
            this.Name = "frmDrawing";
            this.Text = "Drawing in C#";
            ((System.ComponentModel.ISupportInitialize)(this.picbxDrawing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxDrawing;
        private System.Windows.Forms.Button btnDraw;
    }
}

