using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec4DemoFormatting
{
    public partial class frmFormatNumbers : Form
    {
        // Simon, May 2015
        // Explore some of the number format specifiers in String.Format
        // Also some of the date formatting options

        // This is an instance (class-level) variable, used in several methods
        private DateTime dtmDate;

        public frmFormatNumbers()
        {
            InitializeComponent();
        }

        private void btnInteger_Click(object sender, EventArgs e)
        {
            // Format the integer according to the specifier
            // Notice how the format string is made up from the entered text and the other components
            int iNumber = Convert.ToInt32(txbxInteger.Text);
            string sFormat = "{0:" + txbxSpecifier.Text + "}";
            txbxResult.Text = String.Format(sFormat, iNumber);
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            // Format the double according to the specifier
            double dNumber = Convert.ToDouble(txbxFloat.Text);
            string sFormat = "{0:" + txbxSpecifier.Text + "}";
            txbxResult.Text = String.Format(sFormat, dNumber);
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            // Format three particular numbers - after filling the input textboxes
            txbxInteger.Text = "17";
            txbxFloat.Text = "1.68742 & 72.45677";
            txbxSpecifier.Text = "You are {0:d} years old, {1:n}m tall, and you weigh {2:n1} kilos.";
            int iAge = 17; double dHeight = 1.68742; double dWeight = 72.45677;
            txbxResult.Text = String.Format("You are {0:d} years old, {1:n}m tall, and you weigh {2:n1} kilos.", iAge, dHeight, dWeight);
        }

        private void btnMakeDate_Click(object sender, EventArgs e)
        {
            // Convert the 3 textbox values to a date and display it

            // These variables are 'local', existing only in this handler, because they're not needed once
            // the handler finishes.

            int iYear = Convert.ToInt32(txbxYear.Text);
            int iMonth = Convert.ToInt32(txbxMonth.Text);
            int iDay = Convert.ToInt32(txbxDay.Text);
            dtmDate = new DateTime(iYear, iMonth, iDay);

            // After adding dtpInDate to the form, uncomment the next two lines and comment all above
            //dtmDate = dtpInDate.Value;
            //MessageBox.Show("You selected " + dtpInDate.Text);
            
            lblDisplay.Text = Convert.ToString(dtmDate);

        }  // end btnMakeDate_Click

        private void btnLongFormat_Click(object sender, EventArgs e)
        {
            // Display the date with full day name, day, full month name, and 4-digit year
            lblDisplay.Text = String.Format("{0:dddd d MMMM yyyy}", dtmDate);
        }

        private void btnShortFormat_Click(object sender, EventArgs e)
        {
            // Display the date with short day name, day, short month name, and 4-digit year
            lblDisplay.Text = String.Format("{0:ddd d MMM yyyy}", dtmDate);
        }

        private void btnAussieShort_Click(object sender, EventArgs e)
        {
            // Display the date with 2-digit day, 2-digit month, and 2-digit year
            lblDisplay.Text = String.Format("{0:dd/MM/yy}", dtmDate);
        }

        private void btnAussieMedium_Click(object sender, EventArgs e)
        {
            // Display the date with day, short month name, and 2-digit year
            lblDisplay.Text = String.Format("{0:d MMM yy}", dtmDate);
        }
    }  // end class
}  // end namespace
