using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut3MaxFourNum
{
    public partial class frmMaxFourNum : Form
    {
        public frmMaxFourNum()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbNum1.Text, out int iNum1); //Take entered numbers,
            Int32.TryParse(tbNum2.Text, out int iNum2); //parse them to confirm
            Int32.TryParse(tbNum3.Text, out int iNum3); //they are integers, and
            Int32.TryParse(tbNum4.Text, out int iNum4); //place values in an int

            tbResult.Text = calcMax(iNum1, iNum2, iNum3, iNum4).ToString(); //Call calcMax method to return the max
        }

        private int calcMax(int cNum1, int cNum2, int cNum3, int cNum4)
        {
            int iMax1 = Math.Max(cNum1, cNum2);
            int iMax2 = Math.Max(cNum3, cNum4);
            int iMaxFinal = Math.Max(iMax1, iMax2); //Compare two numbers per func, compare largest of first two
            return iMaxFinal;
        }
    }
}
