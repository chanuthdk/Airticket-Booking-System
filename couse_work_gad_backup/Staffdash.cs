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
    public partial class Staffdash : Form
    {
        public Staffdash()
        {
            InitializeComponent();
        }
        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCf.Controls.Add(childForm);
            panelCf.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_title.Text = childForm.Text;
        }

        private void pB_intro_Click(object sender, EventArgs e)
        {

        }

        private void panelCf_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            panel_nav.BringToFront();
            panel_nav.Height = btn_dashboard.Height;
            panel_nav.Top = btn_dashboard.Top;
            panel_nav.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_adminpanel_Click(object sender, EventArgs e)
        {
            panel_nav.BringToFront();
            panel_nav.Height = btn_adminpanel.Height;
            panel_nav.Top = btn_adminpanel.Top;
            panel_nav.Left = btn_adminpanel.Left;
            btn_adminpanel.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_csdetails_Click(object sender, EventArgs e)
        {
            panel_nav.BringToFront();
            panel_nav.Height = btn_csdetails.Height;
            panel_nav.Top = btn_csdetails.Top;
            panel_nav.Left = btn_csdetails.Left;
            btn_csdetails.BackColor = Color.FromArgb(24, 30, 54);
            OpenChildForm(new Customerdetails());
        }

        private void btn_addflight_Click(object sender, EventArgs e)
        {
            panel_nav.BringToFront();
            panel_nav.Height = btn_addflight.Height;
            panel_nav.Top = btn_addflight.Top;
            panel_nav.Left = btn_addflight.Left;
            btn_addflight.BackColor = Color.FromArgb(24, 30, 54);
            OpenChildForm(new Addflight());
        }

        private void btn_addpromo_Click(object sender, EventArgs e)
        {
            panel_nav.BringToFront();
            panel_nav.Height = btn_addpromo.Height;
            panel_nav.Top = btn_addpromo.Top;
            panel_nav.Left = btn_addpromo.Left;
            btn_addpromo.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_deletecs_Click(object sender, EventArgs e)
        {
            panel_nav.BringToFront();
            panel_nav.Height = btn_deletecs.Height;
            panel_nav.Top = btn_deletecs.Top;
            panel_nav.Left = btn_deletecs.Left;
            btn_deletecs.BackColor = Color.FromArgb(24, 30, 54);
            OpenChildForm(new deletecustomer());
        }
        private void btn_addairline_Click(object sender, EventArgs e)
        {
            panel_nav.BringToFront();
            panel_nav.Height = btn_addairline.Height;
            panel_nav.Top = btn_addairline.Top;
            panel_nav.Left = btn_addairline.Left;
            btn_addairline.BackColor = Color.FromArgb(24, 30, 54);
            OpenChildForm(new Addairline());
        }

        private void btn_addairport_Click(object sender, EventArgs e)
        {
            panel_nav.BringToFront();
            panel_nav.Height = btn_addairport.Height;
            panel_nav.Top = btn_addairport.Top;
            panel_nav.Left = btn_addairport.Left;
            btn_addairport.BackColor = Color.FromArgb(24, 30, 54);

            OpenChildForm(new Addairport());
        }
    }
}
