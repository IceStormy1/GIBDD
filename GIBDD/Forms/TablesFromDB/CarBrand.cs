using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yt_DesignUI.Forms.TablesFromDB
{
    public partial class CarBrand : Form
    {
        public CarBrand()
        {
            InitializeComponent();
        }

        private void carBrandBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carBrandBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trafficPoliceDataSet);

        }

        private void CarBrand_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.CarBrand". При необходимости она может быть перемещена или удалена.
            this.carBrandTableAdapter.Fill(this.trafficPoliceDataSet.CarBrand);

        }

        private void First_CarBrand_Button_Click(object sender, EventArgs e)
        {
            carBrandBindingSource.MoveFirst();
        }

        private void Previevs_CarBrand_Button_Click(object sender, EventArgs e)
        {
            carBrandBindingSource.MovePrevious();
        }

        private void Add_CarBrand_Button_Click(object sender, EventArgs e)
        {
            carBrandBindingSource.AddNew();
        }

        private void Remove_CarBrand_Button_Click(object sender, EventArgs e)
        {
            carBrandBindingSource.RemoveCurrent();
        }

        private void Last_CarBrand_Button_Click(object sender, EventArgs e)
        {
            carBrandBindingSource.MoveLast();
        }

        private void Next_CarBrand_Button_Click(object sender, EventArgs e)
        {
            carBrandBindingSource.MoveNext();
        }

        private void Save_CarBrand_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                carBrandBindingSource.EndEdit();
                carBrandTableAdapter.Update(trafficPoliceDataSet);
                MessageBox.Show("SUCCESFULL!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("FAIL");
            }
        }

        private void Exit_CarBrand_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void egoldsToggleSwitch1_CheckedChanged(object sender)
        {

        }

        private void Back_CarBrand_Button_Click(object sender, EventArgs e)
        {
            var formMain = new FormMain();
            formMain.Show();
            Close();
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            var carBrandTable = new CarBrandTableForm();
            carBrandTable.Show();
            Close();
        }
    }
}
