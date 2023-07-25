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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }



        private void Home_Load(object sender, EventArgs e)
        {
            
            user_control_promotion1.Hide();
            user_control_about_us1.Hide();
            userControl_cargo1.Hide();
            userControl_service_traval1.Hide();
            panel_services.Visible = false;
            userControl_service_traval1.BackColor = Color.White;
            user_control_promotion1.BackColor = Color.LightGray;
            
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Logpage obj= new Logpage();
            obj.Show();
            this.Hide();
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
            panel_services.Visible = true;
            panel_services.BringToFront();
        }

        private void panel_Home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            

        }

       

        private void btn_Home_Click(object sender, EventArgs e)
        {
            user_control_promotion1.Hide();
            user_control_about_us1.Hide();
            userControl_cargo1.Hide();
            userControl_service_traval1.Hide();



            userControl1_Home1.Show();
            userControl1_Home1.BringToFront();


        }

        private void btn_promotions_Click(object sender, EventArgs e)
        {
            userControl1_Home1.Hide();
            user_control_about_us1.Hide();
            userControl_cargo1.Hide();
            userControl_service_traval1.Hide();


            user_control_promotion1.Show();
            user_control_promotion1.BringToFront();

        }

        private void btn_about_us_Click(object sender, EventArgs e)
        {
            user_control_promotion1.Hide();
            userControl1_Home1.Hide();
            userControl_cargo1.Hide();


            user_control_about_us1.Show();
            user_control_about_us1.BringToFront();



        }

        private void user_control_promotion1_Load(object sender, EventArgs e)
        {

        }

        private void btn_travel_Click(object sender, EventArgs e)
        {
            user_control_promotion1.Hide();
            userControl1_Home1.Hide();
            userControl_cargo1.Hide();
            user_control_about_us1.Hide();

            userControl_service_traval1.Show();
            userControl_service_traval1.BringToFront();
        }

        private void btn_cargo_Click(object sender, EventArgs e)
        {
            user_control_promotion1.Hide();
            userControl1_Home1.Hide();
            userControl_service_traval1.Hide();
            user_control_about_us1.Hide();

            userControl_cargo1.Show();
            userControl_cargo1.BringToFront();
        }
    }
}
