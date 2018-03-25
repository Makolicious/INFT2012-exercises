using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut1ButtonProperties
{
    public partial class frmBtnProperties : Form
    {
        public frmBtnProperties()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = "Press Me";
            btn2.Text = "Press Me";
            btn3.Text = "Press Me";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn1.Visible == true && btn2.Visible == true)
            {
                btn1.Visible = false;
                btn2.Visible = false;
            }
            else
            {
                btn1.Visible = true;
                btn2.Visible = true;
            }
        }
    }
}
