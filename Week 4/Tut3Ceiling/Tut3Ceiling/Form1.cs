using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut3Ceiling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCeiling_Click(object sender, EventArgs e)
        {
            Double.TryParse(tbInput.Text, out double dInput);
            int iWholeInput = (int)Math.Ceiling(dInput);

            while (iWholeInput % 5 != 0)
            {
                iWholeInput++;
            }

            tbResult.Text = iWholeInput.ToString();
        }
    }
}
