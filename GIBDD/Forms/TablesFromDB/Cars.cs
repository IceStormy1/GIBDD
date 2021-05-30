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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void carsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trafficPoliceDataSet);

        }

        private void Cars_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.Cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.trafficPoliceDataSet.Cars);

        }

        private void First_CarBrand_Button_Click(object sender, EventArgs e)
        {
            carsBindingSource.MoveFirst();
        }

        private void Last_CarBrand_Button_Click(object sender, EventArgs e)
        {
            carsBindingSource.MoveLast();
        }

        private void Previevs_CarBrand_Button_Click(object sender, EventArgs e)
        {
            carsBindingSource.MoveLast();
        }

        private void Next_CarBrand_Button_Click(object sender, EventArgs e)
        {
            carsBindingSource.MoveNext();
        }

        private void Add_CarBrand_Button_Click(object sender, EventArgs e)
        {
            carsBindingSource.AddNew();
        }

        private void Remove_CarBrand_Button_Click(object sender, EventArgs e)
        {
            carsBindingSource.RemoveCurrent();
        }

        private void Exit_CarBrand_Button_Click(object sender, EventArgs e)
        {
            var formMain = new FormMain();
            formMain.Show();
            Close();
        }

        private void Save_CarBrand_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                carsBindingSource.EndEdit();
                carsTableAdapter.Update(trafficPoliceDataSet);
                MessageBox.Show("SUCCESFULL!");
            }
            catch (Exception)
            {
                MessageBox.Show("FAIL");
            }
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            var carsTable = new CarsTableForm();
            carsTable.Show();
            Close();
        }
    }
}
