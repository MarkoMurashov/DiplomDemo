using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GRASP.Business_logic;
using GRASP.Models;

namespace GRASP_Viewer
{
    public partial class Main : Form
    {
        private int zoomXStart = 0;
        private int zoomXEnd = 100;
        private int zoomYStart = 0;
        private int zoomYEnd = 100;

        private List<List<int>> result = new List<List<int>>();

        private GRASPManager grasp;

        public Main()
        {
            InitializeComponent();
            EnableChart(chartMain);
            EnableChart(chartInitial);
        }

        #region private methods

        private void EnableChart(Chart chart)
        {
            chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
        }

        private void Zoom(Chart chart, bool isZoom)
        {
            chart.ChartAreas[0].AxisX.ScaleView.Zoom(zoomXStart, zoomXEnd);
            chart.ChartAreas[0].AxisY.ScaleView.Zoom(zoomYStart, zoomYEnd);
        }

        private void DrawRoute(Chart chart, List<Instance> dataset, List<List<int>> result)
        {
            for (int i = 0; i < result.Count; i++)
            {
                string str_i = i.ToString();
                chart.Series.Add(new Series(str_i));

                for (int j = 0; j < result[i].Count; j++)
                {
                    var instance = dataset.FirstOrDefault(item => item.ID == result[i][j]);
                    chart.Series[str_i].Points.AddXY(instance.X, instance.Y);

                    chart.Series[str_i].Points[j].ToolTip = instance.ToString();
                }

                var instance_tmp = dataset.FirstOrDefault(item => item.ID == result[i][0]);
                chart.Series[str_i].Points.AddXY(instance_tmp.X, instance_tmp.Y);

                chart.Series[str_i].ChartType = SeriesChartType.Line;

                chart.Series[str_i].MarkerStyle = MarkerStyle.Circle;
                chart.Series[str_i].BorderDashStyle = ChartDashStyle.Dash;
                chart.Series[str_i].BorderWidth = 3;
                chart.Series[str_i].BorderColor = Color.Black;
                chart.Series[str_i].MarkerBorderWidth = 2;

                int count = chart.Series[str_i].Points.Count;
                chart.Series[str_i].Points[count - 1].BorderColor = Color.Red;
            }
        }

        #endregion

        private void btnRun_Click(object sender, EventArgs e)
        {           
            var fileReader = new FileReader();
            //var dataset = fileReader.Read("super df.txt"); //50
            var dataset = fileReader.Read("super df 3.txt");
            //var dataset = fileReader.Read("small test.txt");

            if (!int.TryParse(textBoxVehicleCount.Text, out int vCount))
            {
                MessageBox.Show("Please enter valid value for vehicle count");
                return;
            }
            if(!float.TryParse(textBoxVehicleCapacity.Text, out float vCapacity))
            {
                MessageBox.Show("Please enter valid value for vehicle capacity");
                return;
            }

            grasp = new GRASPManager(dataset, vCount, vCapacity);
            result = grasp.Execute(out List<List<int>> initialRoute);

            DrawRoute(chartMain, dataset, result);
            //DrawRoute(chartInitial, dataset, initialRoute);
            DrawBestSolution();

            for (int i = 0; i < result.Count; i++)
            {
                checkedListBoxRoutes.Items.Add(i);
                checkedListBoxRoutes.SetItemChecked(i, true);
            }

            lblResultValue.Text = grasp.CalculateDistanceValueForAllRouteWithVehicles(dataset, result).ToString();
            //lblInitialDistValue.Text = grasp.EvaluateGlobalRoute(initialRoute).ToString();

           
        }

        private void DrawBestSolution()
        {
            var fileReader = new FileReader();
            //var dataset = fileReader.Read("super df.txt");
            var dataset = fileReader.Read("super df 3.txt");

            List<List<int>> solution = new List<List<int>>();
            foreach (var line in File.ReadLines("super df 3 solution.txt"))
            {
                var values = line.Split(' ').Where(s => !string.IsNullOrEmpty(s)).Select(Int32.Parse).ToList();
                solution.Add(values);
            }

            DrawRoute(chartInitial, dataset, solution);
            lblInitialDistValue.Text = grasp.CalculateDistanceValueForAllRouteWithVehicles(dataset, solution).ToString();
        }
           
        private void btnZoomPlus_Click(object sender, EventArgs e)
        {
            zoomXStart += 5;
            zoomXEnd += 5;
            zoomYStart += 5;
            zoomYEnd += 5;
            Zoom(chartMain, true);
            Zoom(chartInitial, true);
        }

        private void btnZoomMinus_Click(object sender, EventArgs e)
        {
            zoomXStart -= 5;
            zoomXEnd -= 5;
            zoomYStart -= 5;
            zoomYEnd -= 5;
            Zoom(chartMain, false);
            Zoom(chartInitial, false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chartMain.Series.Clear();
            chartInitial.Series.Clear();
            checkedListBoxRoutes.Items.Clear();
        }

        private void checkedListBoxRoutes_ItemCheck(object sender, ItemCheckEventArgs e)
        {           
            foreach (var item in checkedListBoxRoutes.Items)
            {
                if(e.Index.ToString() == item.ToString())
                {
                    chartMain.Series[item.ToString()].Enabled = e.NewValue == CheckState.Checked ? true : false;
                    //chartInitial.Series[item.ToString()].Enabled = e.NewValue == CheckState.Checked ? true : false;
                }
            }
        }

        private void buttonCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxRoutes.Items.Count; i++)
            {
                checkedListBoxRoutes.SetItemChecked(i, true);
            }
        }

        private void buttonUncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxRoutes.Items.Count; i++)
            {
                checkedListBoxRoutes.SetItemChecked(i, false);
            }
        }

        private void textBoxVehicleCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxVehicleCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void buttonMoreInfo_Click(object sender, EventArgs e)
        {
            string strToShow = string.Empty;

            foreach (var item in checkedListBoxRoutes.CheckedItems)
            {
                int index = int.Parse(item.ToString());

                strToShow += "\n============= " + index + " ====================\n";
                strToShow += grasp.GetRouteInfo(result[index]);
            }

            richTextBoxDetailInfo.Text = strToShow;
        }
    }
}
