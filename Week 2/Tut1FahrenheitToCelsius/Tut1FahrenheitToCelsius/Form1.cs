using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut1FahrenheitToCelsius
{
    public partial class frmFtoC : Form
    {
        public frmFtoC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nF = 0;
            int nC = 0;

            if (Int32.TryParse(tbF.Text, out nF))
            {
                nC = (nF - 32) * 5 / 9;
                tbC.Text = nC.ToString();
            }
            else
            {
                tbC.Text = "Invalid Num";
            }
        }
    }
}
