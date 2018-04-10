using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut2DeskCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i1, i2, i3;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            i1 = 1;
            i2 = 5;
            i3 = PlayWith(i1);
            tb1.Text = "i1 = " + i1.ToString();
            tb2.Text = "i2 = " + i2.ToString();
            tb3.Text = "i3 = " + i3.ToString();
        }

        private int PlayWith(int i2)
        {
            int i3 = i1 + i2;
            i1 = i2 + i3;
            i2 = 23;
            return i2 - i1 + i3;
        }
    }
}
