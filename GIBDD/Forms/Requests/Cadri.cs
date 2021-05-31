using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using yt_DesignUI.Forms.Forms;

namespace yt_DesignUI.Forms.Requests
{
    public partial class Cadri : Form
    {
        public Cadri()
        {
            InitializeComponent();
        }

        private void Cadri_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.Отдел_кадров". При необходимости она может быть перемещена или удалена.
            this.отдел_кадровTableAdapter.Fill(this.trafficPoliceDataSet.Отдел_кадров);

        }

        private void Exit_CarBrand_Button_Click(object sender, EventArgs e)
        {
            var formMain = new FormMain();
            formMain.Show();
            Close();
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
                case 2:
                    Col = dataGridViewTextBoxColumn12;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn17;
                    break;
            }
            отдел_кадровDataGridView.Sort(Col,
                RadioButton_ASC.Checked
                    ? ListSortDirection.Ascending
                    : ListSortDirection.Descending);
        }

        private void Filter_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            отдел_кадровBindingSource.Filter = "FIO='" + comboBox1.Text + "'";
        }

        private void ShowAll_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            отдел_кадровBindingSource.Filter = "";
        }

        private void Find_CarBrandTable_Button_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            for (i = 0; i < отдел_кадровDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < отдел_кадровDataGridView.RowCount; j++)
                {
                    отдел_кадровDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    отдел_кадровDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < отдел_кадровDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < отдел_кадровDataGridView.RowCount; j++)
                {
                    var value = отдел_кадровDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(TextBox_CarBrandTable.Text, StringComparison.Ordinal) > -1)
                        {
                            отдел_кадровDataGridView.Rows[j].Cells[i].Style.BackColor =
                                Color.Aqua;
                            отдел_кадровDataGridView.Rows[j].Cells[i].Style.ForeColor =
                                Color.Blue;
                        }
                    }
                }
            }
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            var diagramma = new Diagramma();
            diagramma.Show();
        }
    }
}