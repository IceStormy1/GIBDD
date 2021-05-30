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
    public partial class Drivers : Form
    {
        public Drivers()
        {
            InitializeComponent();
        }

        private void driversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trafficPoliceDataSet);

        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.Drivers". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.Fill(this.trafficPoliceDataSet.Drivers);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void First_CarBrand_Button_Click(object sender, EventArgs e)
        {
            driversBindingSource.MoveFirst();
        }

        private void Previevs_CarBrand_Button_Click(object sender, EventArgs e)
        {
            driversBindingSource.MovePrevious();
        }

        private void Add_CarBrand_Button_Click(object sender, EventArgs e)
        {
            driversBindingSource.AddNew();
        }

        private void Remove_CarBrand_Button_Click(object sender, EventArgs e)
        {
            driversBindingSource.RemoveCurrent();
        }

        private void Next_CarBrand_Button_Click(object sender, EventArgs e)
        {
            driversBindingSource.MoveNext();
        }

        private void Last_CarBrand_Button_Click(object sender, EventArgs e)
        {
            driversBindingSource.MoveLast();
        }

        private void Save_CarBrand_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                driversBindingSource.EndEdit();
                driversTableAdapter.Update(trafficPoliceDataSet);
                MessageBox.Show("SUCCESFULL!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("FAIL");
            }
        }

        private void Exit_CarBrand_Button_Click(object sender, EventArgs e)
        {
            var formMain = new FormMain();
            formMain.Show();
            Dispose();
        }
    }
}
