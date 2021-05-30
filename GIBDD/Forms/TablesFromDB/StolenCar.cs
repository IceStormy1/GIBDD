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
    public partial class StolenCar : Form
    {
        public StolenCar()
        {
            InitializeComponent();
        }

        private void stolenCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stolenCarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trafficPoliceDataSet);

        }

        private void StolenCar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.StolenCar". При необходимости она может быть перемещена или удалена.
            this.stolenCarTableAdapter.Fill(this.trafficPoliceDataSet.StolenCar);

        }

        private void First_CarBrand_Button_Click(object sender, EventArgs e)
        {
            stolenCarBindingSource.MoveFirst();
        }

        private void Last_CarBrand_Button_Click(object sender, EventArgs e)
        {
            stolenCarBindingSource.MoveLast();
        }

        private void Previevs_CarBrand_Button_Click(object sender, EventArgs e)
        {
            stolenCarBindingSource.MovePrevious();
        }

        private void Next_CarBrand_Button_Click(object sender, EventArgs e)
        {
            stolenCarBindingSource.MoveNext();
        }

        private void Add_CarBrand_Button_Click(object sender, EventArgs e)
        {
            stolenCarBindingSource.AddNew();
        }

        private void Remove_CarBrand_Button_Click(object sender, EventArgs e)
        {
            stolenCarBindingSource.RemoveCurrent();
        }

        private void Exit_CarBrand_Button_Click(object sender, EventArgs e)
        {
            var formMain = new FormMain();
            formMain.Show();
            Dispose();
        }

        private void Save_CarBrand_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                stolenCarBindingSource.EndEdit();
                stolenCarTableAdapter.Update(trafficPoliceDataSet);
                MessageBox.Show("SUCCESFULL!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("FAIL");
            }
        }
    }
}
