namespace Lec4DemoCarpark
{
    partial class frmCarpark
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
            this.components = new System.ComponentModel.Container();
            this.tmrEvacuate = new System.Windows.Forms.Timer(this.components);
            this.lblEvacuate = new System.Windows.Forms.Label();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.tkbarFullness = new System.Windows.Forms.TrackBar();
            this.lblCarParkFull = new System.Windows.Forms.Label();
            this.btnLeaving = new System.Windows.Forms.Button();
            this.btnArriving = new System.Windows.Forms.Button();
            this.txbVacantSpaces = new System.Windows.Forms.TextBox();
            this.lblSpaces = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tkbarFullness)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrEvacuate
            // 
            this.tmrEvacuate.Interval = 3000;
            this.tmrEvacuate.Tick += new System.EventHandler(this.tmrEvacuate_Tick);
            // 
            // lblEvacuate
            // 
            this.lblEvacuate.AutoSize = true;
            this.lblEvacuate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvacuate.ForeColor = System.Drawing.Color.Red;
            this.lblEvacuate.Location = new System.Drawing.Point(45, 144);
            this.lblEvacuate.Name = "lblEvacuate";
            this.lblEvacuate.Size = new System.Drawing.Size(127, 13);
            this.lblEvacuate.TabIndex = 39;
            this.lblEvacuate.Text = "Evacuate! Evacuate!";
            this.lblEvacuate.Visible = false;
            // 
            // btnEmergency
            // 
            this.btnEmergency.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEmergency.Location = new System.Drawing.Point(213, 168);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(140, 23);
            this.btnEmergency.TabIndex = 38;
            this.btnEmergency.Text = "Press in emergency";
            this.btnEmergency.UseVisualStyleBackColor = false;
            this.btnEmergency.Click += new System.EventHandler(this.btnEmergency_Click);
            // 
            // tkbarFullness
            // 
            this.tkbarFullness.Location = new System.Drawing.Point(32, 93);
            this.tkbarFullness.Maximum = 200;
            this.tkbarFullness.Name = "tkbarFullness";
            this.tkbarFullness.Size = new System.Drawing.Size(304, 45);
            this.tkbarFullness.TabIndex = 37;
            this.tkbarFullness.Scroll += new System.EventHandler(this.tkbarFullness_Scroll);
            // 
            // lblCarParkFull
            // 
            this.lblCarParkFull.BackColor = System.Drawing.Color.PeachPuff;
            this.lblCarParkFull.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCarParkFull.Location = new System.Drawing.Point(56, 213);
            this.lblCarParkFull.Name = "lblCarParkFull";
            this.lblCarParkFull.Size = new System.Drawing.Size(272, 32);
            this.lblCarParkFull.TabIndex = 36;
            this.lblCarParkFull.Text = "CAR PARK IS FULL";
            this.lblCarParkFull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCarParkFull.Visible = false;
            // 
            // btnLeaving
            // 
            this.btnLeaving.Location = new System.Drawing.Point(216, 21);
            this.btnLeaving.Name = "btnLeaving";
            this.btnLeaving.Size = new System.Drawing.Size(96, 48);
            this.btnLeaving.TabIndex = 35;
            this.btnLeaving.Text = "Car Leaving";
            this.btnLeaving.Click += new System.EventHandler(this.btnLeaving_Click);
            // 
            // btnArriving
            // 
            this.btnArriving.Location = new System.Drawing.Point(56, 21);
            this.btnArriving.Name = "btnArriving";
            this.btnArriving.Size = new System.Drawing.Size(88, 48);
            this.btnArriving.TabIndex = 34;
            this.btnArriving.Text = "Car Arriving";
            this.btnArriving.Click += new System.EventHandler(this.btnArriving_Click);
            // 
            // txbVacantSpaces
            // 
            this.txbVacantSpaces.Location = new System.Drawing.Point(141, 168);
            this.txbVacantSpaces.Name = "txbVacantSpaces";
            this.txbVacantSpaces.Size = new System.Drawing.Size(40, 20);
            this.txbVacantSpaces.TabIndex = 33;
            this.txbVacantSpaces.Text = "200";
            // 
            // lblSpaces
            // 
            this.lblSpaces.Location = new System.Drawing.Point(21, 168);
            this.lblSpaces.Name = "lblSpaces";
            this.lblSpaces.Size = new System.Drawing.Size(112, 24);
            this.lblSpaces.TabIndex = 32;
            this.lblSpaces.Text = "Vacant car spaces:";
            this.lblSpaces.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCarpark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 267);
            this.Controls.Add(this.lblEvacuate);
            this.Controls.Add(this.btnEmergency);
            this.Controls.Add(this.tkbarFullness);
            this.Controls.Add(this.lblCarParkFull);
            this.Controls.Add(this.btnLeaving);
            this.Controls.Add(this.btnArriving);
            this.Controls.Add(this.txbVacantSpaces);
            this.Controls.Add(this.lblSpaces);
            this.Name = "frmCarpark";
            this.Text = "The car park";
            ((System.ComponentModel.ISupportInitialize)(this.tkbarFullness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Timer tmrEvacuate;
        internal System.Windows.Forms.Label lblEvacuate;
        internal System.Windows.Forms.Button btnEmergency;
        internal System.Windows.Forms.TrackBar tkbarFullness;
        internal System.Windows.Forms.Label lblCarParkFull;
        internal System.Windows.Forms.Button btnLeaving;
        internal System.Windows.Forms.Button btnArriving;
        internal System.Windows.Forms.TextBox txbVacantSpaces;
        internal System.Windows.Forms.Label lblSpaces;
    }
}

