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
    public partial class LoadWindow : Form
    {
        public LoadWindow()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void LoadWindow_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
