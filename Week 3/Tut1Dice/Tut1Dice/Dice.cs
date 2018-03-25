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
        Graphics graPaper;
        Pen penBlack = new Pen(Color.Black);
        SolidBrush brshBlack = new SolidBrush(Color.Black);
        public frmDice()
        {
            InitializeComponent();
            graPaper = pbxDie.CreateGraphics();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            graPaper.Clear(Form.DefaultBackColor);
            graPaper.DrawRectangle(penBlack, 0, 0, 259, 259);
            diceRoll(110, 110); //Middle
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            graPaper.Clear(Form.DefaultBackColor);
            graPaper.DrawRectangle(penBlack, 0, 0, 259, 259);
            diceRoll(50, 110); //Middle Left
            diceRoll(170, 110); //Middle Right
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            graPaper.Clear(Form.DefaultBackColor);
            graPaper.DrawRectangle(penBlack, 0, 0, 259, 259);
            diceRoll(50, 170); //Bottom Left
            diceRoll(110, 110); //Middle
            diceRoll(170, 50); //Top Right
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            graPaper.Clear(Form.DefaultBackColor);
            graPaper.DrawRectangle(penBlack, 0, 0, 259, 259);
            diceRoll(50, 170); //Bottom Left
            diceRoll(50, 50); //Top Left
            diceRoll(170, 50); //Top Right
            diceRoll(170, 170); //Bottom Right
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            graPaper.Clear(Form.DefaultBackColor);
            graPaper.DrawRectangle(penBlack, 0, 0, 259, 259);
            diceRoll(50, 170); //Bottom Left
            diceRoll(50, 50); //Top Left
            diceRoll(170, 50); //Top Right
            diceRoll(170, 170); //Bottom Right
            diceRoll(110, 110); //Middle
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            graPaper.Clear(Form.DefaultBackColor);
            graPaper.DrawRectangle(penBlack, 0, 0, 259, 259);
            diceRoll(50, 170); //Bottom Left
            diceRoll(50, 50); //Top Left
            diceRoll(50, 110); //Middle Left
            diceRoll(170, 170); //Bottom Right
            diceRoll(170, 110); //Middle Right
            diceRoll(170, 50); //Top Right
        }

        #region Random Roll
        private void btnRoll_Click(object sender, EventArgs e)
        {
            graPaper.Clear(Form.DefaultBackColor);
            graPaper.DrawRectangle(penBlack, 0, 0, 259, 259);
            Random rnd = new Random();
            int iRndNum = rnd.Next(1, 7);
            switch (iRndNum)
            {
                case 1:
                    if (iRndNum == 1)
                        btn1_Click(sender, e);
                    break;

                case 2:
                    if (iRndNum == 2)
                        btn2_Click(sender, e);
                    break;

                case 3:
                    if (iRndNum == 3)
                        btn3_Click(sender, e);
                    break;

                case 4:
                    if (iRndNum == 4)
                        btn4_Click(sender, e);
                    break;

                case 5:
                    if (iRndNum == 5)
                        btn5_Click(sender, e);
                    break;

                case 6:
                    if (iRndNum == 6)
                        btn6_Click(sender, e);
                    break;
            }

        }
        #endregion

        private void diceRoll(int x, int y)
        {
            graPaper.FillEllipse(brshBlack, x, y, 40, 40);
        }
    }
}
