﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using yt_DesignUI.Forms.Forms;
using yt_DesignUI.Forms.Requests;
using yt_DesignUI.Forms.TablesFromDB;

namespace yt_DesignUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void egoldsGoogleTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {

        }

        private void yt_Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Otchet_Button_Click(object sender, EventArgs e)
        {
            Otchet otchetForm = new Otchet();
            otchetForm.Show();
            
        }

        private void Formii_Button_Click(object sender, EventArgs e)
        {
            Formii formii = new Formii();
            formii.Show();
        }

        private void AboutProgramm_Click(object sender, EventArgs e)
        {
            AboutProgramm aboutProgramm = new AboutProgramm();
            aboutProgramm.Show();
        }

        private void Drivers_Button_Click(object sender, EventArgs e)
        {

        }

        private void Ranks_Button_Click(object sender, EventArgs e)
        {

        }

        private void StolenCar_Button_Click(object sender, EventArgs e)
        {

        }

        private void Position_Button_Click(object sender, EventArgs e)
        {

        }

        private void Workers_Button_Click(object sender, EventArgs e)
        {

        }

        private void CarBrand_Button_Click(object sender, EventArgs e)
        {

        }

        private void CarBrand_Button_Click_1(object sender, EventArgs e)
        {
            Hide();
            var carBrand = new CarBrand();
            carBrand.Show();
        }

        private void Cars_Button_Click(object sender, EventArgs e)
        {
            Hide();
            var cars = new Cars();
            cars.Show();
        }

        private void StolenCar_Button_Click_1(object sender, EventArgs e)
        {
            Hide();
            var stolenCars = new StolenCar();
            stolenCars.Show();
        }

        private void Drivers_Button_Click_1(object sender, EventArgs e)
        {
            Hide();
            var drivers = new Drivers();
            drivers.Show();
        }

        private void Workers_Button_Click_1(object sender, EventArgs e)
        {
            Hide();
            var workers = new Workers();
            workers.Show();
        }

        private void Ranks_Button_Click_1(object sender, EventArgs e)
        {
            Hide();
            var ranks = new Ranks();
            ranks.Show();
        }

        private void Position_Button_Click_1(object sender, EventArgs e)
        {
            Hide();
            var position = new Position();
            position.Show();
        }

        private void Cadr_FormMain_Button_Click(object sender, EventArgs e)
        {
            Hide();
            var cadr = new Cadri();
            cadr.Show();
        }

        private void ListOfCars_FormMain_Button_Click(object sender, EventArgs e)
        {
            Hide();
            var listOfCars = new ListOfCars();
            listOfCars.Show();
        }

        private void ListOfHijackings_Click(object sender, EventArgs e)
        {
            Hide();
            var listOfHijackings = new ListOfHijackings();
            listOfHijackings.Show();
        }

        private void yt_Button1_Click_1(object sender, EventArgs e)
        {
            var carBrand = new Diagramma();
            carBrand.Show();
        }
    }
}
