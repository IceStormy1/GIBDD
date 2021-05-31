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
    public partial class ListOfHijackings : Form
    {
        public ListOfHijackings()
        {
            InitializeComponent();
        }

        private void ListOfHijackings_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.Список_угонов". При необходимости она может быть перемещена или удалена.
            this.список_угоновTableAdapter.Fill(this.trafficPoliceDataSet.Список_угонов);

        }

        private void Sort_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            var Col = default(DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn23;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn2;
                    break;
            }
            список_угоновDataGridView.Sort(Col,
                RadioButton_ASC.Checked
                    ? ListSortDirection.Ascending
                    : ListSortDirection.Descending);
        }

        private void Filter_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            список_угоновBindingSource.Filter = "FIO='" + comboBox1.Text + "'";
        }

        private void ShowAll_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            список_угоновBindingSource.Filter = "";
        }

        private void Find_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            for (i = 0; i < список_угоновDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < список_угоновDataGridView.RowCount; j++)
                {
                    список_угоновDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    список_угоновDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < список_угоновDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < список_угоновDataGridView.RowCount; j++)
                {
                    var value = список_угоновDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(TextBox_CarBrandTable.Text, StringComparison.Ordinal) > -1)
                        {
                            список_угоновDataGridView.Rows[j].Cells[i].Style.BackColor =
                                Color.Aqua;
                            список_угоновDataGridView.Rows[j].Cells[i].Style.ForeColor =
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
