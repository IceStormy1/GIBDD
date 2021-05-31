using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;


namespace yt_DesignUI.Forms.Forms
{
    public partial class Diagramma : Form
    {
        public Diagramma()
        {
            InitializeComponent();
        }

        private void Diagramma_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trafficPoliceDataSet.Отдел_кадров". При необходимости она может быть перемещена или удалена.
            this.отдел_кадровTableAdapter.Fill(this.trafficPoliceDataSet.Отдел_кадров);
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();

            ChartValues<string> namePositionValues = new ChartValues<string>();
            ChartValues<int> salaryValues = new ChartValues<int>();
            foreach (var sportrow in trafficPoliceDataSet.Отдел_кадров)
            {
                        salaryValues.Add(sportrow.Salary);
                        namePositionValues.Add(sportrow.NamePosition);
            }
            cartesianChart1.AxisX.Clear();

            cartesianChart1.AxisX.Add(new Axis()
            {
                Title = "Должность",
                Labels = namePositionValues
            });

            LineSeries sportLineSeries = new LineSeries();
            sportLineSeries.Title = "Сотрудник";
            sportLineSeries.Values = salaryValues;

            series.Add(sportLineSeries);
            cartesianChart1.Series = series;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
