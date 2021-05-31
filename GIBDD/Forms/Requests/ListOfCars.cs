using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yt_DesignUI.Forms.Requests
{
    public partial class ListOfCars : Form
    {
        public ListOfCars()
        {
            InitializeComponent();
        }

        private void ListOfCars_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.Список_автомобилей". При необходимости она может быть перемещена или удалена.
            this.список_автомобилейTableAdapter.Fill(this.trafficPoliceDataSet.Список_автомобилей);

        }

        private void Sort_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            var Col = default(DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn35;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn36;
                    break;
            }
            список_автомобилейDataGridView.Sort(Col,
                RadioButton_ASC.Checked
                    ? ListSortDirection.Ascending
                    : ListSortDirection.Descending);
        }

        private void Filter_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            список_автомобилейBindingSource.Filter = "FIO='" + comboBox1.Text + "'";
        }

        private void ShowAll_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            список_автомобилейBindingSource.Filter = "";
        }

        private void Find_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            for (i = 0; i < список_автомобилейDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < список_автомобилейDataGridView.RowCount; j++)
                {
                    список_автомобилейDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    список_автомобилейDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < список_автомобилейDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < список_автомобилейDataGridView.RowCount; j++)
                {
                    var value = список_автомобилейDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(TextBox_CarBrandTable.Text, StringComparison.Ordinal) > -1)
                        {
                            список_автомобилейDataGridView.Rows[j].Cells[i].Style.BackColor =
                                Color.Aqua;
                            список_автомобилейDataGridView.Rows[j].Cells[i].Style.ForeColor =
                                Color.Blue;
                        }
                    }
                }
            }
        }

        private void Exit_CarBrand_Button_Click(object sender, EventArgs e)
        {
            var formMain = new FormMain();
            formMain.Show();
            Close();
        }
    }
}
