using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut3UrlSeparation
{
    public partial class frmUrlSeparation : Form
    {
        public frmUrlSeparation()
        {
            InitializeComponent();
        }

        private void btnSeparate_Click(object sender, EventArgs e)
        {
            separateURL();
        }

        private void separateURL()
        {
            try
            {
                string sURL = tbURL.Text;
                int iSlashDex = sURL.IndexOf("/");
                int iLastSlashDex = sURL.LastIndexOf("/");
                tbServer.Text = sURL.Substring(0, iSlashDex);
                tbPath.Text = sURL.Substring(iSlashDex + 1, iLastSlashDex - iSlashDex - 1);
                tbFile.Text = sURL.Substring(iLastSlashDex + 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please enter a valid URL.");
            }
        }
    }
}
