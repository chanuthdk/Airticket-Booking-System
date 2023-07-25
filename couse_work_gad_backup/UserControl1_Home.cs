using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace couse_work_gad
{
    public partial class UserControl1_Home : UserControl
    {
        public UserControl1_Home()
        {
            InitializeComponent();
        }
        int count = 0;

        private void timer1_imagelist1_Tick(object sender, EventArgs e)
        {
            if (count < 8)
            {
                pictureBox1.Image = imageList1_welcomeimage.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void timer2_traval_Tick(object sender, EventArgs e)
        {
            {
                if (count < 8)
                {
                    pictureBox2.Image = imageList1_traval.Images[count];
                    count++;
                }
                else
                {
                    count = 0;
                }
            }

        }

        private void timer3_cargo_Tick(object sender, EventArgs e)
        {
            {
                if (count < 9)
                {
                    pictureBox3.Image = imageList3_cargo.Images[count];
                    count++;
                }
                else
                {
                    count = 0;
                }
            }
        }
    }
}
