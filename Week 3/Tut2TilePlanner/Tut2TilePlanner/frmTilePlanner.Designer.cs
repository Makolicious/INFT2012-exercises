namespace Tut2TilePlanner
{
    partial class frmTilePlanner
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
            this.pbxTile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAcross = new System.Windows.Forms.TextBox();
            this.tbDown = new System.Windows.Forms.TextBox();
            this.btnPlacePost = new System.Windows.Forms.Button();
            this.btnClearPost = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTile)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxTile
            // 
            this.pbxTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pbxTile.Location = new System.Drawing.Point(242, 12);
            this.pbxTile.Name = "pbxTile";
            this.pbxTile.Size = new System.Drawing.Size(330, 330);
            this.pbxTile.TabIndex = 0;
            this.pbxTile.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.MaximumSize = new System.Drawing.Size(210, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visualise how a 110x110 post intrudes in 330x330 tile, to help decide how to cut " +
    "the tile.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.MaximumSize = new System.Drawing.Size(210, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the coordinates within the tile of a corner of the post.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Across";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Down";
            // 
            // tbAcross
            // 
            this.tbAcross.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAcross.Location = new System.Drawing.Point(69, 157);
            this.tbAcross.Name = "tbAcross";
            this.tbAcross.Size = new System.Drawing.Size(100, 26);
            this.tbAcross.TabIndex = 5;
            // 
            // tbDown
            // 
            this.tbDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDown.Location = new System.Drawing.Point(69, 191);
            this.tbDown.Name = "tbDown";
            this.tbDown.Size = new System.Drawing.Size(100, 26);
            this.tbDown.TabIndex = 6;
            // 
            // btnPlacePost
            // 
            this.btnPlacePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlacePost.Location = new System.Drawing.Point(69, 242);
            this.btnPlacePost.Name = "btnPlacePost";
            this.btnPlacePost.Size = new System.Drawing.Size(84, 26);
            this.btnPlacePost.TabIndex = 7;
            this.btnPlacePost.Text = "Place post";
            this.btnPlacePost.UseVisualStyleBackColor = true;
            this.btnPlacePost.Click += new System.EventHandler(this.btnPlacePost_Click);
            // 
            // btnClearPost
            // 
            this.btnClearPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPost.Location = new System.Drawing.Point(69, 274);
            this.btnClearPost.Name = "btnClearPost";
            this.btnClearPost.Size = new System.Drawing.Size(84, 26);
            this.btnClearPost.TabIndex = 8;
            this.btnClearPost.Text = "Clear post";
            this.btnClearPost.UseVisualStyleBackColor = true;
            this.btnClearPost.Click += new System.EventHandler(this.btnClearPost_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(69, 306);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(84, 26);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmTilePlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClearPost);
            this.Controls.Add(this.btnPlacePost);
            this.Controls.Add(this.tbDown);
            this.Controls.Add(this.tbAcross);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxTile);
            this.Name = "frmTilePlanner";
            this.Text = "Tile Planner";
            ((System.ComponentModel.ISupportInitialize)(this.pbxTile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxTile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAcross;
        private System.Windows.Forms.TextBox tbDown;
        private System.Windows.Forms.Button btnPlacePost;
        private System.Windows.Forms.Button btnClearPost;
        private System.Windows.Forms.Button btnQuit;
    }
}

