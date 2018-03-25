using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture3DemoFlags
{
    public partial class frmFlag : Form
    {
        // Simon, April 2015
        // Illustrating methods
        // Draw an Aboriginal flag or a pattern of Aboriginal flags

        // Paper and brushes are used in most methods; if we declare them
        // here, every method throughout the module can access them.
        // private is generally used when declaring variables
        // for the whole class rather than within its methods.

        // Interestingly, while we can't do a plain assignment outside a method, we
        // can do a combined declare-and-assign, as illustrated in the next few lines.

        private Graphics graPaper;
        private SolidBrush brshBlack = new SolidBrush(Color.Black);
        private SolidBrush brshYellow = new SolidBrush(Color.Yellow);
        private SolidBrush brshRed = new SolidBrush(Color.Red);

        public frmFlag()
        {
            InitializeComponent();
            // Once the form's created, instantiate and initialise the 'paper'
            graPaper = picbxPaper.CreateGraphics();
        }

        private void btnFlag_Click(object sender, EventArgs e)
        {
            // Event handler for btnFlag
            // Draw an Aboriginal flag 240 pixels wide, with its top left
            // at 40 across and 80 down.
            // The numbers were worked out by hand.
            graPaper.FillRectangle(brshBlack, 40, 80, 240, 80);
            graPaper.FillRectangle(brshRed, 40, 160, 240, 80);
            graPaper.FillEllipse(brshYellow, 120, 120, 80, 80);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the paper to the colour it was initially given
            graPaper.Clear(Color.SandyBrown);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // The preferred way of finishing a running program
            Application.Exit();
        }

        #region Flag pattern 1: a pattern of flags
        private void btnPattern1_Click(object sender, EventArgs e)
        {
            // When btnPattern1 is clicked, draw a pattern of flags of different sizes.
            // How easy is this to read and understand?
            // How easy would it have been to write?

            // Once a position and size have been decided for each flag, its
            // three parts have to be calculated carefully.

            graPaper.FillRectangle(brshBlack, 90, 100, 180, 60);
            graPaper.FillRectangle(brshRed, 90, 160, 180, 60);
            graPaper.FillEllipse(brshYellow, 150, 130, 60, 60);
            graPaper.FillRectangle(brshBlack, 200, 10, 120, 40);
            graPaper.FillRectangle(brshRed, 200, 50, 120, 40);
            graPaper.FillEllipse(brshYellow, 240, 30, 40, 40);
            graPaper.FillRectangle(brshBlack, 200, 230, 120, 40);
            graPaper.FillRectangle(brshRed, 200, 270, 120, 40);
            graPaper.FillEllipse(brshYellow, 240, 250, 40, 40);
            graPaper.FillRectangle(brshBlack, 10, 20, 90, 30);
            graPaper.FillRectangle(brshRed, 10, 50, 90, 30);
            graPaper.FillEllipse(brshYellow, 40, 35, 30, 30);
            graPaper.FillRectangle(brshBlack, 10, 240, 90, 30);
            graPaper.FillRectangle(brshRed, 10, 270, 90, 30);
            graPaper.FillEllipse(brshYellow, 40, 255, 30, 30);
            graPaper.FillRectangle(brshBlack, 15, 110, 60, 20);
            graPaper.FillRectangle(brshRed, 15, 130, 60, 20);
            graPaper.FillEllipse(brshYellow, 35, 120, 20, 20);
            graPaper.FillRectangle(brshBlack, 15, 170, 60, 20);
            graPaper.FillRectangle(brshRed, 15, 190, 60, 20);
            graPaper.FillEllipse(brshYellow, 35, 180, 20, 20);
            graPaper.FillRectangle(brshBlack, 130, 15, 42, 14);
            graPaper.FillRectangle(brshRed, 130, 29, 42, 14);
            graPaper.FillEllipse(brshYellow, 144, 22, 14, 14);
            graPaper.FillRectangle(brshBlack, 130, 55, 42, 14);
            graPaper.FillRectangle(brshRed, 130, 69, 42, 14);
            graPaper.FillEllipse(brshYellow, 144, 62, 14, 14);
            graPaper.FillRectangle(brshBlack, 130, 235, 42, 14);
            graPaper.FillRectangle(brshRed, 130, 249, 42, 14);
            graPaper.FillEllipse(brshYellow, 144, 242, 14, 14);
            graPaper.FillRectangle(brshBlack, 130, 275, 42, 14);
            graPaper.FillRectangle(brshRed, 130, 289, 42, 14);
            graPaper.FillEllipse(brshYellow, 144, 282, 14, 14);
            graPaper.FillRectangle(brshBlack, 285, 105, 30, 10);
            graPaper.FillRectangle(brshRed, 285, 115, 30, 10);
            graPaper.FillEllipse(brshYellow, 295, 110, 10, 10);
            graPaper.FillRectangle(brshBlack, 285, 135, 30, 10);
            graPaper.FillRectangle(brshRed, 285, 145, 30, 10);
            graPaper.FillEllipse(brshYellow, 295, 140, 10, 10);
            graPaper.FillRectangle(brshBlack, 285, 165, 30, 10);
            graPaper.FillRectangle(brshRed, 285, 175, 30, 10);
            graPaper.FillEllipse(brshYellow, 295, 170, 10, 10);
            graPaper.FillRectangle(brshBlack, 285, 195, 30, 10);
            graPaper.FillRectangle(brshRed, 285, 205, 30, 10);
            graPaper.FillEllipse(brshYellow, 295, 200, 10, 10);
        }  // end of btnPattern1_Click
        #endregion

        #region Flag pattern 2: comments and white space add clarity
        private void btnPattern2_Click(object sender, EventArgs e)
        {
            // When btnPattern2 is clicked, draw a pattern of flags of different sizes.
            // Comments and white space help to read it; they would have
            // made it easier to write, too.

            // All of the calculations still have to be done for each flag.

            // A flag 180 pixels wide, at 90 across and 100 down
            graPaper.FillRectangle(brshBlack, 90, 100, 180, 60);
            graPaper.FillRectangle(brshRed, 90, 160, 180, 60);
            graPaper.FillEllipse(brshYellow, 150, 130, 60, 60);

            // A flag 120 pixels wide, at 200 across and 10 down
            graPaper.FillRectangle(brshBlack, 200, 10, 120, 40);
            graPaper.FillRectangle(brshRed, 200, 50, 120, 40);
            graPaper.FillEllipse(brshYellow, 240, 30, 40, 40);

            // A flag 120 pixels wide, at 200 across and 230 down
            graPaper.FillRectangle(brshBlack, 200, 230, 120, 40);
            graPaper.FillRectangle(brshRed, 200, 270, 120, 40);
            graPaper.FillEllipse(brshYellow, 240, 250, 40, 40);

            // A flag 90 pixels wide, at 10 across and 20 down
            graPaper.FillRectangle(brshBlack, 10, 20, 90, 30);
            graPaper.FillRectangle(brshRed, 10, 50, 90, 30);
            graPaper.FillEllipse(brshYellow, 40, 35, 30, 30);

            // A flag 90 pixels wide, at 10 across and 240 down
            graPaper.FillRectangle(brshBlack, 10, 240, 90, 30);
            graPaper.FillRectangle(brshRed, 10, 270, 90, 30);
            graPaper.FillEllipse(brshYellow, 40, 255, 30, 30);

            // A flag 60 pixels wide, at 15 across and 110 down
            graPaper.FillRectangle(brshBlack, 15, 110, 60, 20);
            graPaper.FillRectangle(brshRed, 15, 130, 60, 20);
            graPaper.FillEllipse(brshYellow, 35, 120, 20, 20);

            // A flag 60 pixels wide, at 15 across and 170 down
            graPaper.FillRectangle(brshBlack, 15, 170, 60, 20);
            graPaper.FillRectangle(brshRed, 15, 190, 60, 20);
            graPaper.FillEllipse(brshYellow, 35, 180, 20, 20);

            // A flag 42 pixels wide, at 130 across and 15 down
            graPaper.FillRectangle(brshBlack, 130, 15, 42, 14);
            graPaper.FillRectangle(brshRed, 130, 29, 42, 14);
            graPaper.FillEllipse(brshYellow, 144, 22, 14, 14);

            // A flag 42 pixels wide, at 130 across and 55 down
            graPaper.FillRectangle(brshBlack, 130, 55, 42, 14);
            graPaper.FillRectangle(brshRed, 130, 69, 42, 14);
            graPaper.FillEllipse(brshYellow, 144, 62, 14, 14);

            // A flag 42 pixels wide, at 130 across and 235 down
            graPaper.FillRectangle(brshBlack, 130, 235, 42, 14);
            graPaper.FillRectangle(brshRed, 130, 249, 42, 14);
            graPaper.FillEllipse(brshYellow, 144, 242, 14, 14);

            // A flag 42 pixels wide, at 130 across and 275 down
            graPaper.FillRectangle(brshBlack, 130, 275, 42, 14);
            graPaper.FillRectangle(brshRed, 130, 289, 42, 14);
            graPaper.FillEllipse(brshYellow, 144, 282, 14, 14);

            // A flag 30 pixels wide, at 285 across and 105 down
            graPaper.FillRectangle(brshBlack, 285, 105, 30, 10);
            graPaper.FillRectangle(brshRed, 285, 115, 30, 10);
            graPaper.FillEllipse(brshYellow, 295, 110, 10, 10);

            // A flag 30 pixels wide, at 285 across and 135 down
            graPaper.FillRectangle(brshBlack, 285, 135, 30, 10);
            graPaper.FillRectangle(brshRed, 285, 145, 30, 10);
            graPaper.FillEllipse(brshYellow, 295, 140, 10, 10);

            // A flag 30 pixels wide, at 285 across and 165 down
            graPaper.FillRectangle(brshBlack, 285, 165, 30, 10);
            graPaper.FillRectangle(brshRed, 285, 175, 30, 10);
            graPaper.FillEllipse(brshYellow, 295, 170, 10, 10);

            // A flag 30 pixels wide, at 285 across and 195 down
            graPaper.FillRectangle(brshBlack, 285, 195, 30, 10);
            graPaper.FillRectangle(brshRed, 285, 205, 30, 10);
            graPaper.FillEllipse(brshYellow, 295, 200, 10, 10);
        }  // end of btnPattern2_Click
        #endregion

        #region Flag pattern 3: procedures add more clarity AND reduce code
        private void btnPattern3_Click(object sender, EventArgs e)
        {
            // When btnPattern3 is clicked, call the Flag procedure to draw
            // each flag at given across, down, and size values.

            // These are the only values that need to be provided; the Flag
            // procedure calculates the rest.

            Flag(90, 100, 180); // ie a flag 90 across, 100 down, 180 in size
            Flag(200, 10, 120); // etc
            Flag(200, 230, 120);
            Flag(10, 20, 90);
            Flag(10, 240, 90);
            Flag(15, 110, 60);
            Flag(15, 170, 60);
            Flag(130, 15, 42);
            Flag(130, 55, 42);
            Flag(130, 235, 42);
            Flag(130, 275, 42);
            Flag(285, 105, 30);
            Flag(285, 135, 30);
            Flag(285, 165, 30);
            Flag(285, 195, 30);
        }  // end of btnPattern3_Click

        private void Flag(int iLeft, int iTop, int iSize)
        {
            int iWidth = iSize / 2;
            // Draw an Aboriginal flag iLeft across, iTop down, and iSize wide
            // Flag's height is two-thirds its width.
            // Black rectangle at top left, full width, half height
            graPaper.FillEllipse(brshBlack, iLeft, iTop, iSize, iSize);
            // Red rectangle halfway down left, full width, half height
            graPaper.FillEllipse(brshRed, iLeft + iWidth / 4, iTop + iWidth / 4, iSize - iWidth / 2, iSize - iWidth / 2);
            // Yellow circle one-third across, one-sixth down, one-third
            // width and height
            graPaper.FillEllipse(brshYellow, iLeft + iWidth / 2, iTop + iWidth / 2, iSize - iWidth, iSize - iWidth);
        }  // end of flag
        #endregion

    }  // end of class
}  // end of namespace
