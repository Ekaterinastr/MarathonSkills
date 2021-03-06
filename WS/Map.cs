using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time1;
            DateTime initial_time = Convert.ToDateTime("21.10.2021  6:00");
            DateTime current_time = DateTime.Now;
            time1 = initial_time - current_time;
            label2.Text = time1.Days.ToString() + " дней " + time1.Hours.ToString()
                + " часов и " + time1.Minutes.ToString() + " минут до старта марафона!";
        }

        private void Buttonback_Click(object sender, EventArgs e)
        {
            Info Info = new Info();
            Info.Show();
            this.Hide();
        }

        private void Fullrace_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            check1.Text = "Race Start";
            landmark.Text = "Samba Full Marathon";
            landmarkN.Visible = false;
            services.Visible = false;
            ldrinks.Visible = false;
            lenergy.Visible = false;
            ltoilets.Visible = false;
            drinks.Visible = false;
            energy.Visible = false;
            toilets.Visible = false;
        }

        private void Halfrace_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            check1.Text = "Race Start";
            landmark.Text = "Jonjo Half Marathon";
            landmarkN.Visible = false;
            services.Visible = false;
            ldrinks.Visible = false;
            lenergy.Visible = false;
            ltoilets.Visible = false;
            drinks.Visible = false;
            energy.Visible = false;
            toilets.Visible = false;
        }

        private void Funrace_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            check1.Text = "Race Start";
            landmark.Text = "Capoeira 5km Fun Run";
            landmarkN.Visible = false;
            services.Visible = false;
            ldrinks.Visible = false;
            lenergy.Visible = false;
            ltoilets.Visible = false;
            drinks.Visible = false;
            energy.Visible = false;
            toilets.Visible = false;

        }

        private void B1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            check1.Text = "Checkpoint 1";
            landmark.Text = "Landmark:";
            landmarkN.Text = "Avenida Rudge";
            services.Text = "Servces Provided";
            landmarkN.Visible = true;
            services.Visible = true;
            ldrinks.Visible = true;
            lenergy.Visible = true;
            linformation.Visible = false;
            lmedical.Visible = false;
            drinks.Visible = true;
            energy.Visible = true;
            information.Visible = false;
            medical.Visible = false;
            information.Image = WS.Properties.Resources.map_icon_information;
            linformation.Text = "Information";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            check1.Text = "Checkpoint 2";
            landmark.Text = "Landmark:";
            landmarkN.Text = "Theatro Municipal";
            landmarkN.Visible = true;
            services.Visible = true;
            ldrinks.Visible = true;
            lenergy.Visible = true;
            drinks.Visible = true;
            energy.Visible = true;
            ltoilets.Visible = true;
            linformation.Visible = true;
            lmedical.Visible = true;
            toilets.Visible = true;
            information.Visible = true;
            medical.Visible = true;
            information.Image = WS.Properties.Resources.map_icon_information;
            linformation.Text = "Information";

        }

        private void B3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            check1.Text = "Checkpoint 3";
            landmark.Text = "Landmark:";
            landmarkN.Text = "Parque do Ibirapuera";
            ldrinks.Visible = true;
            lenergy.Visible = true;
            drinks.Visible = true;
            energy.Visible = true;
            ltoilets.Visible = true;
            toilets.Visible = true;
            linformation.Visible = false;
            lmedical.Visible = false;
            information.Visible = false;
            medical.Visible = false;
            information.Image = WS.Properties.Resources.map_icon_information;
            linformation.Text = "Information";

        }

        private void B4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            check1.Text = "Checkpoint 4";
            landmark.Text = "Landmark:";
            landmarkN.Text = "Theatro Municipal";
            information.Image = WS.Properties.Resources.map_icon_medical;
            linformation.Text = "Medical";
            landmarkN.Visible = true;
            services.Visible = true;
            ldrinks.Visible = true;
            lenergy.Visible = true;
            drinks.Visible = true;
            energy.Visible = true;
            ltoilets.Visible = true;
            linformation.Visible = true;
            lmedical.Visible = false;
            toilets.Visible = true;
            information.Visible = true;
            medical.Visible = false;
        }

        private void B5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            check1.Text = "Checkpoint 5";
            landmark.Text = "Landmark:";
            landmarkN.Text = "Iguatemi";
            landmarkN.Visible = true;
            ldrinks.Visible = true;
            lenergy.Visible = true;
            drinks.Visible = true;
            energy.Visible = true;
            lenergy.Visible = true;
            services.Visible = true;
            ltoilets.Visible = true;
            linformation.Visible = true;
            lmedical.Visible = false;
            information.Image = WS.Properties.Resources.map_icon_information;
            linformation.Text = "Information";
            toilets.Visible = true;
            information.Visible = true;
            medical.Visible = false;

        }

        private void B6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            check1.Text = "Checkpoint 6";
            landmark.Text = "Landmark:";
            landmarkN.Text = "Rua Lisboa";
            landmarkN.Visible = true;
            services.Visible = true;
            ldrinks.Visible = true;
            lenergy.Visible = true;
            drinks.Visible = true;
            energy.Visible = true;
            ltoilets.Visible = true;
            linformation.Visible = false;
            lmedical.Visible = false;
            information.Image = WSR123.Properties.Resources.map_icon_information;
            linformation.Text = "Information";
            toilets.Visible = true;
            information.Visible = false;
            medical.Visible = false;
        }
    }
}
