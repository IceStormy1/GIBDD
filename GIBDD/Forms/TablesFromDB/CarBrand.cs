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
    }
}
