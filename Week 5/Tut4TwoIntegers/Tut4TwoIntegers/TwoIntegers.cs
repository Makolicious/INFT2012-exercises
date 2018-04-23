using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut4TwoIntegers
{
    public partial class TwoIntegers : Form
    {
        public TwoIntegers()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblMsgLeft.ResetText();
            lblMsgRight.ResetText();
            Int32.TryParse(tbInt1.Text, out int iOne);
            Int32.TryParse(tbInt2.Text, out int iTwo);
            int iLarge = Math.Max(iOne, iTwo);
            int iSmall = Math.Min(iOne, iTwo);

            lblMsgLeft.Text = "This label contains the numbers from 1 to " + iLarge.ToString();
            lblMsgRight.Text = "This label contains the ones that are / by " + iSmall.ToString();

            numCalc(iLarge, iSmall);
        }

        private void numCalc(int iCalcLarge, int iCalcSmall)
        {
            for (int i = 1; i <= iCalcLarge; i++)
            {
                lblResultLeft.Text += i.ToString() + "\r\n";
                if (i % iCalcSmall == 0)
                {
                    lblResultRight.Text += i.ToString() + "\r\n";
                }
            }
        }
    }
}
