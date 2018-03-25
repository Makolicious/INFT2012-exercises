using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut1SecondsConverter
{
    public partial class secondsConverter : Form
    {
        public secondsConverter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int inputSeconds;
            int iHours;
            int iMinutes;

            Int32.TryParse(tbInputSeconds.Text, out inputSeconds);
            iHours = inputSeconds / 3600;
            inputSeconds = inputSeconds % 3600;
            iMinutes = inputSeconds / 60;
            inputSeconds = inputSeconds % 60;

            tbDispResult.Text = "Hours: " + iHours.ToString() + "  Minutes: " + iMinutes.ToString() + "  Seconds: " + inputSeconds.ToString();
        }
    }
}
