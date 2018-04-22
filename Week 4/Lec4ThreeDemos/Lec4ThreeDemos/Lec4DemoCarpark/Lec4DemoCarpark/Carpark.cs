using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec4DemoCarpark
{
    public partial class frmCarpark : Form
    {
        // Instance variables
        private int iMaxSpaces = 200; // Car park size
        private int iSpaceCount = 200; // Initial number of free space
        Random chance = new Random();

        public frmCarpark()
        {
            InitializeComponent();
        }

        private void btnArriving_Click(object sender, EventArgs e)
        {
            // Simulates a car arriving at the car park
            if (iSpaceCount == 0)
            {
                // There are no vacant spaces
                // The car cannot enter or park so do not decrement iSpaceCount
                MessageBox.Show("Sorry, there's no room!", "Car park full");
            }
            else
            {
                // There are still vacant spaces
                iSpaceCount = iSpaceCount - 1;
                txbVacantSpaces.Text = Convert.ToString(iSpaceCount);
                tkbarFullness.Value = iMaxSpaces - iSpaceCount;

                // Check to see if this was the last vacant space
                // If so, display the CAR PARK FULL sign
                if (iSpaceCount == 0)
                {
                    lblCarParkFull.Visible = true;
                }  // end inner if
            }  // end outer if
        }  // end btnArriving_Click

        private void btnLeaving_Click(object sender, EventArgs e)
        {
            // Simulates a car leaving the car park
            // Check to see if the car park was full
            // If so, turn off the CAR PARK FULL sign, ie
            //    set the Visible property of lblFullCarPark to false
            if (lblCarParkFull.Visible)
            {
                lblCarParkFull.Visible = false;
            }
            // allocate another vacant space (up to the limit)
            if (iSpaceCount < iMaxSpaces)
            {
                iSpaceCount = iSpaceCount + 1;
                txbVacantSpaces.Text = Convert.ToString(iSpaceCount);
                tkbarFullness.Value = iMaxSpaces - iSpaceCount;
            }  // end second if
        }  // end btnLeaving_Click

        private void tkbarFullness_Scroll(object sender, EventArgs e)
        {
            // If the trackbar is scrolled, adjust the carcount and consequences
            iSpaceCount = iMaxSpaces - tkbarFullness.Value;
            txbVacantSpaces.Text = Convert.ToString(iSpaceCount);
            // Look carefully at this boolean assignment statement;
            // most programmers would code it unnecessarily as an If statement.
            lblCarParkFull.Visible = iSpaceCount == 0;
        }  // end tkbarFullness_Scroll

        #region Emergency procedure
        private void btnEmergency_Click(object sender, EventArgs e)
        {
            // Start the timer that controls an emergency evacuation
            tmrEvacuate.Interval = 3000; // Start tick interval at 3sec (3000ms)
            tmrEvacuate.Start();
            // The Evacuate label turns on
            lblEvacuate.Visible = true;
        }  // end btnEmergency_Click

        private void tmrEvacuate_Tick(object sender, EventArgs e)
        {
            // Each time the timer ticks . . .
            // . . . a car leaves . . .
            if (lblCarParkFull.Visible)
            {
                lblCarParkFull.Visible = false;
            }
            // The Evacuate label flashes on or off
            lblEvacuate.Visible = !lblEvacuate.Visible;

            if (iSpaceCount < iMaxSpaces)
            {
                iSpaceCount = iSpaceCount + 1;
                txbVacantSpaces.Text = Convert.ToString(iSpaceCount);
                tkbarFullness.Value = iMaxSpaces - iSpaceCount;
            }
            // . . . the tick interval is reduced a little
            tmrEvacuate.Interval = tmrEvacuate.Interval * 15 / 16;
            // . . . and if it's dropped to less than 2 . . .
            if (tmrEvacuate.Interval < 2)
            {
                tmrEvacuate.Stop();
                // Simon's 9-year-old son Calum suggested this addition - a 15% chance of it being a false alarm
                if (chance.NextDouble() < 0.15)
                {
                    MessageBox.Show("You can stop evacuating - it was a false alarm!", "Panic's over");
                }
                // The rest was in the original
                else if (iSpaceCount < iMaxSpaces)
                {
                    MessageBox.Show("Too late!", "Kaboom!");
                }
                else
                {
                    MessageBox.Show("Phew - everyone got out!", "Kaboom!");
                }
            }  // end if
        }  // end tmrEvacuate_Tick
        #endregion

    }  // end class
}  // end namespace
