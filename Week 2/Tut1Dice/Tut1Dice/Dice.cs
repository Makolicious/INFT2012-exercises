using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut1Dice
{
    public partial class frmDice : Form
    {
        Pen penBlack = new Pen(Color.Black);

        public frmDice()
        {
            InitializeComponent();
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Graphics graPaper = pbxDie.CreateGraphics();
            graPaper.Clear(Form.DefaultBackColor);
            graPaper.DrawRectangle(penBlack, 0, 0, 259, 259);
            graPaper.FillEllipse(Brushes.Black, 110, 110, 40, 40); //Middle
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Graphics graPaper = pbxDie.CreateGraphics();
            graPaper.Clear(Form.DefaultBackColor);
            graPaper.DrawRectangle(penBlack, 0, 0, 259, 259);
            graPaper.FillEllipse(Brushes.Black, 50, 110, 40, 40); //Left
            graPaper.FillEllipse(Brushes.Black, 170, 110, 40, 40); //Right
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Graphics graPaper = pbxDie.CreateGraphics();
            graPaper.Clear(Form.DefaultBackColor);
            graPaper.DrawRectangle(penBlack, 0, 0, 259, 259);
            graPaper.FillEllipse(Brushes.Black, 50, 170, 40, 40); //Bottom Left
            graPaper.FillEllipse(Brushes.Black, 110, 110, 40, 40); //Middle
            graPaper.FillEllipse(Brushes.Black, 170, 50, 40, 40); //Top Right
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Graphics graPaper = pbxDie.CreateGraphics();
            graPaper.Clear(Form.DefaultBackColor);
            graPaper.DrawRectangle(penBlack, 0, 0, 259, 259);
            graPaper.FillEllipse(Brushes.Black, 50, 170, 40, 40); //Bottom Left
            graPaper.FillEllipse(Brushes.Black, 50, 50, 40, 40); //Top Left
            graPaper.FillEllipse(Brushes.Black, 170, 50, 40, 40); //Top Right
            graPaper.FillEllipse(Brushes.Black, 170, 170, 40, 40); //Bottom Right
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Graphics graPaper = pbxDie.CreateGraphics();
            graPaper.Clear(Form.DefaultBackColor);
            graPaper.DrawRectangle(penBlack, 0, 0, 259, 259);
            graPaper.FillEllipse(Brushes.Black, 50, 170, 40, 40); //Bottom Left
            graPaper.FillEllipse(Brushes.Black, 50, 50, 40, 40); //Top Left
            graPaper.FillEllipse(Brushes.Black, 170, 50, 40, 40); //Top Right
            graPaper.FillEllipse(Brushes.Black, 170, 170, 40, 40); //Bottom Right
            graPaper.FillEllipse(Brushes.Black, 110, 110, 40, 40); //Middle
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Graphics graPaper = pbxDie.CreateGraphics();
            graPaper.Clear(Form.DefaultBackColor);
            graPaper.DrawRectangle(penBlack, 0, 0, 259, 259);
            graPaper.FillEllipse(Brushes.Black, 50, 170, 40, 40); //Bottom Left
            graPaper.FillEllipse(Brushes.Black, 50, 50, 40, 40); //Top Left
            graPaper.FillEllipse(Brushes.Black, 50, 110, 40, 40); //Middle Left
            graPaper.FillEllipse(Brushes.Black, 170, 170, 40, 40); //Bottom Right
            graPaper.FillEllipse(Brushes.Black, 170, 110, 40, 40); //Middle Right
            graPaper.FillEllipse(Brushes.Black, 170, 50, 40, 40); //Top Right
        }
    }
}
