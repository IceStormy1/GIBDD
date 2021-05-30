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
    public partial class Таблица : Form
    {
        public Таблица()
        {
            InitializeComponent();
        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trafficPoliceDataSet);

        }

        private void WorkersTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.trafficPoliceDataSet.Workers);

        }

        private void Sort_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            var Col = default(DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn3;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn4;
                    break;
            }

            workersDataGridView.Sort(Col,
                RadioButton_ASC.Checked
                    ? ListSortDirection.Ascending
                    : ListSortDirection.Descending);
        }

        private void Filter_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            workersBindingSource.Filter = "FIO='" + comboBox1.Text + "'";
        }

        private void ShowAll_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            workersBindingSource.Filter = "";
        }

        private void Find_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            for (i = 0; i < workersDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < workersDataGridView.RowCount; j++)
                {
                    workersDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    workersDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < workersDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < workersDataGridView.RowCount; j++)
                {
                    var value = workersDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(TextBox_CarBrandTable.Text, StringComparison.Ordinal) > -1)
                        {
                            workersDataGridView.Rows[j].Cells[i].Style.BackColor =
                                Color.Aqua;
                            workersDataGridView.Rows[j].Cells[i].Style.ForeColor =
                                Color.Blue;
                        }
                    }
                }
            }
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            var workersLenta = new Workers();
            workersLenta.Show();
            Close();
        }
    }
}
