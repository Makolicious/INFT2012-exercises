using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut2CylinderFunctions
{
    public partial class frmCylinder : Form
    {
        public frmCylinder()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double.TryParse(tbHeight.Text, out double dH);
            Double.TryParse(tbRadius.Text, out double dR);

            tbResult.Text = "Total Surface Area: " + calcCylinder(dH, dR).ToString();
        }

        private double calcCylinder(double h, double r)
        {
            double dCircleArea = (Math.PI * (r * r)) * 2;
            double dRectangleArea = h * (2 * Math.PI * r);
            double dTotalArea = dCircleArea + dRectangleArea;

            return dTotalArea;
        }

    }
}
