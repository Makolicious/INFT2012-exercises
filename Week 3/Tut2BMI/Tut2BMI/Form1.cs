using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut2BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcBMI_Click(object sender, EventArgs e)
        {
            Double.TryParse(tbMass.Text, out double dMass);
            Double.TryParse(tbHeight.Text, out double dHeight);
            double dBMI = dMass / (dHeight * dHeight);
            tbBMI.Text = Math.Round(dBMI, 2).ToString();

            if (dBMI > 30)
                tbHealth.Text = "Obese";
            else if (dBMI > 25)
                tbHealth.Text = "Overweight";
            else if (dBMI >= 20)
                tbHealth.Text = "Healthy";
            else
                tbHealth.Text = "Underweight";
        }
    }
}
