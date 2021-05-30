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
    public partial class Position : Form
    {
        public Position()
        {
            InitializeComponent();
        }

        private void positionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.positionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trafficPoliceDataSet);

        }

        private void Position_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.Position". При необходимости она может быть перемещена или удалена.
            this.positionTableAdapter.Fill(this.trafficPoliceDataSet.Position);

        }

        private void Exit_CarBrand_Button_Click(object sender, EventArgs e)
        {
            var formMain = new FormMain();
            formMain.Show();
            Dispose();
        }

        private void First_CarBrand_Button_Click(object sender, EventArgs e)
        {
            positionBindingSource.MoveFirst();
        }

        private void Last_CarBrand_Button_Click(object sender, EventArgs e)
        {
            positionBindingSource.MoveLast();
        }

        private void Previevs_CarBrand_Button_Click(object sender, EventArgs e)
        {
            positionBindingSource.MovePrevious();
        }

        private void Next_CarBrand_Button_Click(object sender, EventArgs e)
        {
            positionBindingSource.MoveNext();
        }

        private void Add_CarBrand_Button_Click(object sender, EventArgs e)
        {
            positionBindingSource.AddNew();
        }

        private void Remove_CarBrand_Button_Click(object sender, EventArgs e)
        {
            positionBindingSource.RemoveCurrent();
        }

        private void Save_CarBrand_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                positionBindingSource.EndEdit();
                positionTableAdapter.Update(trafficPoliceDataSet);
                MessageBox.Show("SUCCESFULL!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("FAIL");
            }
            
        }

        private void dutiesTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
