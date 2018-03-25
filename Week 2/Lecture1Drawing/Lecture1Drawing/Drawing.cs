using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture1Drawing
{
    public partial class frmDrawing : Form
    {
        public frmDrawing()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Graphics graPaper = picbxDrawing.CreateGraphics();
            Pen penBlack = new Pen(Color.Black);
            graPaper.DrawRectangle(penBlack, 10, 10, 100, 50);
            graPaper.DrawRectangle(penBlack, 10, 75, 100, 100);
            Pen penBlue = new Pen(Color.Blue, 3);
            graPaper.DrawEllipse(penBlue, 10, 10, 100, 50);
            SolidBrush brshGreen = new SolidBrush(Color.Green);
            graPaper.FillEllipse(brshGreen, 10, 75, 100, 100);
        }
    }
}
