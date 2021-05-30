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
    public partial class StolenCarTableForm : Form
    {
        public StolenCarTableForm()
        {
            InitializeComponent();
        }

        private void stolenCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stolenCarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trafficPoliceDataSet);

        }

        private void StolenCarTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.StolenCar". При необходимости она может быть перемещена или удалена.
            this.stolenCarTableAdapter.Fill(this.trafficPoliceDataSet.StolenCar);

        }

        private void Sort_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            var Col = default(DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn3;
                    break;
            }

            stolenCarDataGridView.Sort(Col,
                RadioButton_ASC.Checked
                    ? ListSortDirection.Ascending
                    : ListSortDirection.Descending);
        }

        private void Filter_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            stolenCarBindingSource.Filter = "DateOfRequest='" + comboBox1.Text + "'";
        }

        private void ShowAll_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            stolenCarBindingSource.Filter = "";
        }

        private void Find_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            for (i = 0; i < stolenCarDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < stolenCarDataGridView.RowCount; j++)
                {
                    stolenCarDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    stolenCarDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < stolenCarDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < stolenCarDataGridView.RowCount; j++)
                {
                    var value = stolenCarDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(TextBox_CarBrandTable.Text, StringComparison.Ordinal) > -1)
                        {
                            stolenCarDataGridView.Rows[j].Cells[i].Style.BackColor =
                                Color.Aqua;
                            stolenCarDataGridView.Rows[j].Cells[i].Style.ForeColor =
                                Color.Blue;
                        }
                    }
                }
            }
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            var stolenCarLenta = new StolenCar();
            stolenCarLenta.Show();
            Close();
        }
    }
}
