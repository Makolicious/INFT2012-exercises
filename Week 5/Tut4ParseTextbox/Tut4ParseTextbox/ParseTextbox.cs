using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut4ParseTextbox
{
    public partial class frmParseTextbox : Form
    {
        public frmParseTextbox()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            double dInput;

            if (Double.TryParse(tbInput.Text, out dInput))
                lblResult.Text = "Double the entered number is " + dInput * 2 + ".";
            else
                lblResult.Text = "The input is not a number.";
        }
    }
}
