using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec4DemoStrings
{
    public partial class frmStringDemo : Form
    {
        // Simon, May 2015
        // Illustrating a number of string methods and properties

        // Note that to insert a quotation mark (") in a literal string we
        // precede it with the escape character \.

        public frmStringDemo()
        {
            InitializeComponent();
        }

        private void btnConcatenate_Click(object sender, EventArgs e)
        {
            // Concatenate string1 and string2 a few times in OutputTextbox
            string sTring1, sTring2, sOutput;
            sTring1 = txbxString1.Text; // Note the difference between the textbox and its Text property
            sTring2 = txbxString2.Text;
            sOutput = sTring1 + " " + sTring2;
            sOutput = sOutput + "\r\n" + sTring1;
            sOutput = sOutput + "\r\n" + sTring2;
            sOutput = sOutput + "\r\n" + "\"" + sTring1 + "\" \"" + sTring2 + "\"";
            sOutput = sOutput + "\r\n" + sTring1;
            sOutput = sOutput + "\r\n" + sTring2;
            sOutput = sOutput + "\r\n" + sTring1 + "? " + sTring2 + "!";
            sOutput = sOutput + "\r\n" + sTring1;
            sOutput = sOutput + "\r\n" + sTring2;
            txbxOutput.Text = sOutput + "\r\nThat's all, folks!";
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            // Compare string1 and string2 alphabetically
            string sTring1, sTring2, sOutput;
            sTring1 = txbxString1.Text;
            sTring2 = txbxString2.Text;

            int iComparator = sTring1.CompareTo(sTring2);
            if (iComparator == -1)
            {
                sOutput = sTring1 + " comes before " + sTring2;
            }
            else if (iComparator == 0)
            {
                sOutput = sTring1 + " is the same as " + sTring2;
            }
            else
            {
                sOutput = sTring1 + " comes after " + sTring2;
            }

            txbxOutput.Text = sOutput;
        }

        private void btnElementN1S1_Click(object sender, EventArgs e)
        {
            // Use substring to display element n of string 1
            int n = 0;
            string sNumstring = txbxNumber1.Text;
            // Handle the possible exception of no number provided
            try
            {
                n = Convert.ToInt32(sNumstring);
            }
            catch (FormatException exceptionObject)
            {
                MessageBox.Show("We need a number in the Number 1 box", "Missing data");
            }

            string sTring1 = txbxString1.Text;
            // Handle the possible exception of iNdex being beyond end of string
            try
            {
                txbxOutput.Text = "Element " + sNumstring + " of \"" + sTring1 +
                    "\" is \"" + sTring1.Substring(n, 1) + "\".";
            }
            catch (ArgumentOutOfRangeException exceptionObject)
            {
                MessageBox.Show("There aren't that many characters in String 1", "Going too far");
            }
        }

        private void btnS1ToUpper_Click(object sender, EventArgs e)
        {
            // Display the uppercase equivalent of String 1
            txbxOutput.Text = txbxString1.Text.ToUpper();
        }

        private void btnS2ToLower_Click(object sender, EventArgs e)
        {
            // Display the lowercase equivalent of String 1
            txbxOutput.Text = txbxString1.Text.ToLower();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Insert String 2 at the specified index position in String 1
            int n = 0; // Shouldn't need initialising, but C# worries that it might not be assigned before it's used
            string sNumstring = txbxNumber1.Text;
            // Handle the possible exception of no number provided
            try
            {
                n = Convert.ToInt32(sNumstring);
            }
            catch (FormatException exceptionObject)
            {
                MessageBox.Show("We need a number in the Number 1 box", "Missing data");
            }

            // Handle the possible exception of index being beyond end of string
            try
            {
                txbxOutput.Text = txbxString1.Text.Insert(n, txbxString2.Text);
            }
            catch (ArgumentOutOfRangeException exceptionObject)
            {
                MessageBox.Show("We need a (longer) string in String 1", "Data missing");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Display string1 with specified number of characters removed at specified index
            int iNdex = 0; int iCount = 0;
            string sTring1 = txbxString1.Text;
            string sTring2 = txbxString2.Text;

            // Handle the possible exception of either number missing or non-numeric
            try
            {
                iNdex = Convert.ToInt32(txbxNumber1.Text);
                iCount = Convert.ToInt32(txbxNumber2.Text);
            }
            catch (FormatException exceptionObject)
            {
                MessageBox.Show("We need numbers in both Number boxes", "Missing data");
            }

            // Handle the possible exception of iNdex + iCount going beyond end of string
            try
            {
                txbxOutput.Text = txbxString1.Text.Remove(iNdex, iCount);
            }
            catch (ArgumentOutOfRangeException exceptionObject)
            {
                MessageBox.Show("String 1 doesn't have that many characters beyond that index", "Data missing");
            }
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            // Where is string 2 first found in string 1?
            string sTring1 = txbxString1.Text;
            string sTring2 = txbxString2.Text;
            // No need for try-catch - IndexOf returns -1 if not found
            int iNdex = sTring1.IndexOf(sTring2);
            txbxOutput.Text = "\"" + sTring2 + "\" first appears at index " +
                Convert.ToString(iNdex) + " in \"" + sTring1 + "\"";
            txbxOutput.Text = txbxOutput.Text +
                "\r\n    (an index of -1 means it does not appear at all)";
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            // Where is string 2 last found in string 1?
            string sTring1 = txbxString1.Text;
            string sTring2 = txbxString2.Text;
            // No need for try-catch - IndexOf returns -1 if not found
            int iNdex = sTring1.LastIndexOf(sTring2);
            txbxOutput.Text = "\"" + sTring2 + "\" last appears at index " +
                Convert.ToString(iNdex) + " in \"" + sTring1 + "\"";
            txbxOutput.Text = txbxOutput.Text +
                "\r\n    (an index of -1 means it does not appear at all)";
        }

        private void btnSubstringSize_Click(object sender, EventArgs e)
        {
            // A substring of string1 at a given index and length
            int iNdex = 0; int iCount = 0;
            string sTring1 = txbxString1.Text;

            // Handle the possible exception of either number missing or non-numeric
            try
            {
                iNdex = Convert.ToInt32(txbxNumber1.Text);
                iCount = Convert.ToInt32(txbxNumber2.Text);
            }
            catch (FormatException exceptionObject)
            {
                MessageBox.Show("We need numbers in both Number boxes", "Missing data");
            }

            // Handle the possible exception of iNdex + iCount going beyond end of string
            try
            {
                txbxOutput.Text = sTring1.Substring(iNdex, iCount);
            }
            catch (ArgumentOutOfRangeException exceptionObject)
            {
                MessageBox.Show("String 1 doesn't have that many characters beyond that index", "Data missing");
            }
        }

        private void btnSubstringOnward_Click(object sender, EventArgs e)
        {
            // A substring of string1 from a given index to the end
            int iNdex = 0;
            string sTring1 = txbxString1.Text;

            // Handle the possible exception of Number 1 missing or non-numeric
            try
            {
                iNdex = Convert.ToInt32(txbxNumber1.Text);
            }
            catch (FormatException exceptionObject)
            {
                MessageBox.Show("We need a numbers in the Number 1 box", "Missing data");
            }

            // Handle the possible exception of iNdex being beyond end of string
            try
            {
                txbxOutput.Text = sTring1.Substring(iNdex);
            }
            catch (ArgumentOutOfRangeException exceptionObject)
            {
                MessageBox.Show("We need a (longer) string in String 1", "Data missing");
            }
        }  // end method
    }  // end class
}  // end namespace
