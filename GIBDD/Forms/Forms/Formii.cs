using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using yt_DesignUI.Forms.TablesFromDB;

namespace yt_DesignUI
{
    public partial class Formii : Form
    {
        public Formii()
        {
            InitializeComponent();
        }

        private void AboutProgramm_button_exit_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void CarBrand_Button_Click(object sender, EventArgs e)
        {
            CarBrand carBrand = new CarBrand();
            carBrand.Show();
        }

        private void Cars_Button_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.Show();
        }

        private void Drivers_Button_Click(object sender, EventArgs e)
        {
            Drivers drivers = new Drivers();
            drivers.Show();
        }

        private void Position_Button_Click(object sender, EventArgs e)
        {
            Position position = new Position();
            position.Show();
        }

        private void Ranks_Button_Click(object sender, EventArgs e)
        {
            Ranks ranks = new Ranks();
            ranks.Show();
        }

        private void StolenCar_Button_Click(object sender, EventArgs e)
        {
            StolenCar stolenCar = new StolenCar();
            stolenCar.Show();
        }

        private void Workers_Button_Click(object sender, EventArgs e)
        {
            Workers workers = new Workers();
            workers.Show();
        }
    }
}
