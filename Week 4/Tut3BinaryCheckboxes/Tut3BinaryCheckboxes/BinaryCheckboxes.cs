using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut3BinaryCheckboxes
{
    public partial class frmBinaryCheckboxes : Form
    {
        public frmBinaryCheckboxes()
        {
            InitializeComponent();
        }

        int iTotal = 0;

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbCalc = (CheckBox)sender;
            Int32.TryParse(cbCalc.Text, out int iCalc);

            if (cbCalc.Checked)
            {
                iTotal += iCalc;
            }
            else
            {
                iTotal -= iCalc;
            }
            lblResult.Text = "The decimal value is " + iTotal.ToString();
        }
    }
}
