using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut1MilesToKm
{
    public partial class frmMilesToKm : Form
    {
        public frmMilesToKm()
        {
            InitializeComponent();
        }

        private void tbMiles_MouseEnter(object sender, EventArgs e)
        {
            tbMiles.BackColor = Color.LightYellow;
        }

        private void tbMiles_MouseLeave(object sender, EventArgs e)
        {
            tbMiles.BackColor = Color.White;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            int nMiles = 0;
            double nKm = 0;

            if (Int32.TryParse(tbMiles.Text, out nMiles))
            {
                nKm = nMiles * 1.61;
                tbKm.Text = nKm.ToString();
            }

            else
            {
                tbKm.Text = "Invalid Num";
            }
        }
    }
}
