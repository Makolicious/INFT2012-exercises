namespace Lecture3DemoFlags
{
    partial class frmFlag
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
            this.btnPattern3 = new System.Windows.Forms.Button();
            this.btnPattern2 = new System.Windows.Forms.Button();
            this.btnFlag = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPattern1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.picbxPaper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxPaper)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPattern3
            // 
            this.btnPattern3.Location = new System.Drawing.Point(19, 297);
            this.btnPattern3.Name = "btnPattern3";
            this.btnPattern3.Size = new System.Drawing.Size(96, 23);
            this.btnPattern3.TabIndex = 40;
            this.btnPattern3.Text = "Flag pattern 3";
            this.btnPattern3.Click += new System.EventHandler(this.btnPattern3_Click);
            // 
            // btnPattern2
            // 
            this.btnPattern2.Location = new System.Drawing.Point(19, 265);
            this.btnPattern2.Name = "btnPattern2";
            this.btnPattern2.Size = new System.Drawing.Size(96, 23);
            this.btnPattern2.TabIndex = 39;
            this.btnPattern2.Text = "Flag pattern 2";
            this.btnPattern2.Click += new System.EventHandler(this.btnPattern2_Click);
            // 
            // btnFlag
            // 
            this.btnFlag.Location = new System.Drawing.Point(19, 169);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(96, 23);
            this.btnFlag.TabIndex = 38;
            this.btnFlag.Text = "Draw flag";
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(27, 337);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(80, 23);
            this.btnQuit.TabIndex = 37;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(27, 201);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 23);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear screen";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPattern1
            // 
            this.btnPattern1.Location = new System.Drawing.Point(19, 233);
            this.btnPattern1.Name = "btnPattern1";
            this.btnPattern1.Size = new System.Drawing.Size(96, 23);
            this.btnPattern1.TabIndex = 35;
            this.btnPattern1.Text = "Flag pattern 1";
            this.btnPattern1.Click += new System.EventHandler(this.btnPattern1_Click);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(11, 121);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(144, 40);
            this.Label2.TabIndex = 34;
            this.Label2.Text = "It was officially proclaimed as a flag of Australia in 1995.";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(11, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(144, 104);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "Designed by Harold Thomas in 1971, this flag was adopted nationally by Aboriginal" +
    " and Torres Strait Islander People in 1972 after being flown over the Aboriginal" +
    " tent embassy in Canberra.";
            // 
            // picbxPaper
            // 
            this.picbxPaper.BackColor = System.Drawing.Color.SandyBrown;
            this.picbxPaper.Location = new System.Drawing.Point(163, 17);
            this.picbxPaper.Name = "picbxPaper";
            this.picbxPaper.Size = new System.Drawing.Size(330, 330);
            this.picbxPaper.TabIndex = 32;
            this.picbxPaper.TabStop = false;
            // 
            // frmFlag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 376);
            this.Controls.Add(this.btnPattern3);
            this.Controls.Add(this.btnPattern2);
            this.Controls.Add(this.btnFlag);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPattern1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.picbxPaper);
            this.Name = "frmFlag";
            this.Text = "The Aboriginal Flag";
            ((System.ComponentModel.ISupportInitialize)(this.picbxPaper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnPattern3;
        internal System.Windows.Forms.Button btnPattern2;
        internal System.Windows.Forms.Button btnFlag;
        internal System.Windows.Forms.Button btnQuit;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnPattern1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox picbxPaper;
    }
}

