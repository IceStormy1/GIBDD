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
    public partial class RanksTableForm : Form
    {
        public RanksTableForm()
        {
            InitializeComponent();
        }

        private void ranksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ranksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trafficPoliceDataSet);

        }

        private void RanksTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.Ranks". При необходимости она может быть перемещена или удалена.
            this.ranksTableAdapter.Fill(this.trafficPoliceDataSet.Ranks);

        }

        private void Filter_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            ranksBindingSource.Filter = "RankName='" + comboBox1.Text + "'";
        }

        private void ShowAll_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            ranksBindingSource.Filter = "";
        }

        private void Find_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            for (i = 0; i < ranksDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < ranksDataGridView.RowCount; j++)
                {
                    ranksDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    ranksDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < ranksDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < ranksDataGridView.RowCount; j++)
                {
                    var value = ranksDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(TextBox_CarBrandTable.Text, StringComparison.Ordinal) > -1)
                        {
                            ranksDataGridView.Rows[j].Cells[i].Style.BackColor =
                                Color.Aqua;
                            ranksDataGridView.Rows[j].Cells[i].Style.ForeColor =
                                Color.Blue;
                        }
                    }
                }
            }
        }

        private void Sort_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            var Col = default(DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn3;
                    break;
            }
            
            ranksDataGridView.Sort(Col,
                RadioButton_ASC.Checked
                    ? ListSortDirection.Ascending
                    : ListSortDirection.Descending);
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            var ranksLenta = new Ranks();
            ranksLenta.Show();
            Close();
        }
    }
}
