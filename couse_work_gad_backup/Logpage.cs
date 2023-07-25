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
    public partial class Logpage : Form
    {
        public Logpage()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Home obj=new Home();
            obj.ShowDialog();
        }

        private void panel_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_create_Account_Click(object sender, EventArgs e)
        {
            Registration obj=new Registration();
            obj .ShowDialog();
            this.Close();
        }
    }
}
