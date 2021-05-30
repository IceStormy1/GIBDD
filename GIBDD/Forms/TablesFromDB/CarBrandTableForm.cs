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
    public partial class CarBrandTableForm : Form
    {
        public CarBrandTableForm()
        {
            InitializeComponent();
        }

        private void carBrandBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carBrandBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trafficPoliceDataSet);

        }

        private void CarBrandTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.CarBrand". При необходимости она может быть перемещена или удалена.
            this.carBrandTableAdapter.Fill(this.trafficPoliceDataSet.CarBrand);

        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            var carBrandLenta = new CarBrand();
            carBrandLenta.Show();
            Close();
        }

        private void carBrandDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sort_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = default(DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    Col = dataGridViewTextBoxColumn7;
                    break;
                case 5:
                    Col = dataGridViewTextBoxColumn8;
                    break;
                case 6:
                    Col = dataGridViewTextBoxColumn9;
                    break;
                
            }

            carBrandDataGridView.Sort(Col,
                RadioButton_ASC.Checked
                    ? ListSortDirection.Ascending
                    : ListSortDirection.Descending);
        }

        private void Filter_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            carBrandBindingSource.Filter = "CompanyName='" + comboBox1.Text
                                                         + "'";
        }

        private void ShowAll_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            carBrandBindingSource.Filter = "";
        }

        private void Find_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            for (i = 0; i < carBrandDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < carBrandDataGridView.RowCount; j++)
                {
                    carBrandDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    carBrandDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < carBrandDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < carBrandDataGridView.RowCount; j++)
                {
                    var value = carBrandDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(TextBox_CarBrandTable.Text, StringComparison.Ordinal) > -1)
                        {
                            carBrandDataGridView.Rows[j].Cells[i].Style.BackColor =
                                Color.Aqua;
                            carBrandDataGridView.Rows[j].Cells[i].Style.ForeColor =
                                Color.Blue;
                        }
                    }
                }
            }
        }
    }
}

