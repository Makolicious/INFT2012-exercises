using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut2TilePlanner
{
    public partial class frmTilePlanner : Form
    {
        public frmTilePlanner()
        {
            InitializeComponent();
        }

        private void btnPlacePost_Click(object sender, EventArgs e)
        {
            Graphics graPost = pbxTile.CreateGraphics();
            SolidBrush brushGrout = new SolidBrush(Color.PaleGoldenrod);
            SolidBrush brushPost = new SolidBrush(Color.Black);
            Int32 iAcross;
            int iDown;
            Int32.TryParse(tbAcross.Text, out iAcross);
            Int32.TryParse(tbDown.Text, out iDown);

            graPost.FillRectangle(brushGrout, iAcross, iDown, 110, 110);
            graPost.FillRectangle(brushPost, iAcross + 5, iDown + 5, 100, 100);
        }

        private void btnClearPost_Click(object sender, EventArgs e)
        {
            Graphics graPost = pbxTile.CreateGraphics();
            graPost.Clear(pbxTile.BackColor);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
