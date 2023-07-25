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
    public partial class Loadingwindow : Form
    {
        public Loadingwindow()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_load.Width += 3;
            if (panel_load.Width >= 943)
            {
                timer1.Stop();
                Home hm = new Home();
                hm.Show();
                this.Hide();

            }
        }

        private void Loadingwindow_Load(object sender, EventArgs e)
        {
        }
    }
}
