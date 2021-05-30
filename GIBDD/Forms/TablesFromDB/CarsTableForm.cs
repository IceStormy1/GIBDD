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
    public partial class CarsTableForm : Form
    {
        public CarsTableForm()
        {
            InitializeComponent();
        }

        private void carsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trafficPoliceDataSet);

        }

        private void CarsTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.Cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.trafficPoliceDataSet.Cars);

        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            var carsLenta = new Cars();
            carsLenta.Show();
            Close();
        }

        private void Sort_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = default;
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
                    Col = dataGridViewTextBoxColumn6;
                    break;
                case 5:
                    Col = dataGridViewTextBoxColumn7;
                    break;
                case 6:
                    Col = dataGridViewTextBoxColumn8;
                    break;
                case 7:
                    Col = dataGridViewTextBoxColumn9;
                    break;
                case 8:
                    Col = dataGridViewTextBoxColumn10;
                    break;
                case 9:
                    Col = dataGridViewTextBoxColumn11;
                    break;
            }
            carsDataGridView.Sort(Col,
                RadioButton_ASC.Checked
                    ? ListSortDirection.Ascending
                    : ListSortDirection.Descending);
        }

        private void Filter_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            carsBindingSource.Filter = "DateTechnicalInspection='" + comboBox1.Text + "'";
        }

        private void ShowAll_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            carsBindingSource.Filter = "";
        }

        private void Find_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            for (i = 0; i < carsDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < carsDataGridView.RowCount; j++)
                {
                    carsDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    carsDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < carsDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < carsDataGridView.RowCount; j++)
                {
                    var value = carsDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(TextBox_CarBrandTable.Text, StringComparison.Ordinal) > -1)
                        {
                            carsDataGridView.Rows[j].Cells[i].Style.BackColor =
                                Color.Aqua;
                            carsDataGridView.Rows[j].Cells[i].Style.ForeColor =
                                Color.Blue;
                        }
                    }
                }
            }
        }
    }
}
