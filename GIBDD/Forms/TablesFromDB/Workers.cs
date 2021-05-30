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
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trafficPoliceDataSet);

        }

        private void Workers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.trafficPoliceDataSet.Workers);

        }

        private void First_CarBrand_Button_Click(object sender, EventArgs e)
        {
            workersBindingSource.MoveFirst();
        }

        private void Last_CarBrand_Button_Click(object sender, EventArgs e)
        {
            workersBindingSource.MoveLast();
        }

        private void Previevs_CarBrand_Button_Click(object sender, EventArgs e)
        {
            workersBindingSource.MovePrevious();
        }

        private void Next_CarBrand_Button_Click(object sender, EventArgs e)
        {
            workersBindingSource.MoveNext();
        }

        private void Add_CarBrand_Button_Click(object sender, EventArgs e)
        {
            workersBindingSource.AddNew();
        }

        private void Remove_CarBrand_Button_Click(object sender, EventArgs e)
        {
            workersBindingSource.RemoveCurrent();
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
                workersBindingSource.EndEdit();
                workersTableAdapter.Update(trafficPoliceDataSet);
                MessageBox.Show("SUCCESFULL!");
            }
            catch (Exception)
            {
                MessageBox.Show("FAIL");
            }
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            var workersTableForm = new Таблица();
            workersTableForm.Show();
            Close();
        }
    }
}
