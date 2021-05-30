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
    public partial class Ranks : Form
    {
        public Ranks()
        {
            InitializeComponent();
        }

        private void ranksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ranksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trafficPoliceDataSet);

        }

        private void ranksBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ranksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trafficPoliceDataSet);

        }

        private void Ranks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.Ranks". При необходимости она может быть перемещена или удалена.
            this.ranksTableAdapter.Fill(this.trafficPoliceDataSet.Ranks);

        }

        private void First_CarBrand_Button_Click(object sender, EventArgs e)
        {
            ranksBindingSource.MoveFirst();
        }

        private void Last_CarBrand_Button_Click(object sender, EventArgs e)
        {
            ranksBindingSource.MoveLast();
        }

        private void Previevs_CarBrand_Button_Click(object sender, EventArgs e)
        {
            ranksBindingSource.MovePrevious();
        }

        private void Next_CarBrand_Button_Click(object sender, EventArgs e)
        {
            ranksBindingSource.MoveNext();
        }

        private void Add_CarBrand_Button_Click(object sender, EventArgs e)
        {
            ranksBindingSource.AddNew();
        }

        private void Remove_CarBrand_Button_Click(object sender, EventArgs e)
        {
            ranksBindingSource.RemoveCurrent();
        }

        private void Save_CarBrand_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                ranksBindingSource.EndEdit();
                ranksTableAdapter.Update(trafficPoliceDataSet);
                MessageBox.Show("SUCCESFULL!");
            }
            catch (Exception)
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

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            var ranksTableForm = new RanksTableForm();
            ranksTableForm.Show();
            Close();
        }
    }
}
