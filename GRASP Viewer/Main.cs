using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GRASP.Business_logic;
using GRASP.Models;

namespace GRASP_Viewer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private int zoomXStart = 0;
        private int zoomXEnd = 100;
        private int zoomYStart = 0;
        private int zoomYEnd = 100;

        private void btnRun_Click(object sender, EventArgs e)
        {           
            var fileReader = new FileReader();
            var dataset = fileReader.Read("dataset.txt");
            //var dataset = fileReader.Read("small test.txt");

            int vCount = int.Parse(textBoxVehicleCount.Text);
            float vCapacity = float.Parse(textBoxVehicleCapacity.Text, CultureInfo.InvariantCulture.NumberFormat);

            var grasp = new GRASPManager(vCount, vCapacity);
            var result = grasp.Execute(dataset, out List<List<int>> initialRoute);

            DrawRoute(chartMain, dataset, result);
            DrawRoute(chartInitial, dataset, initialRoute);

            for(int i = 0; i < initialRoute.Count; i++)
            {
                checkedListBoxRoutes.Items.Add(i);
            }

            lblResultValue.Text = grasp.CalculateDistanceValueForAllRouteWithVehicles(dataset, result).ToString();
            lblInitialDistValue.Text = grasp.CalculateDistanceValueForAllRouteWithVehicles(dataset, initialRoute).ToString();
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
                //Random rnd = new Random();
                //chart.Series[str_i].Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                chart.Series[str_i].MarkerStyle = MarkerStyle.Circle;
                chart.Series[str_i].BorderDashStyle = ChartDashStyle.Dash;
                chart.Series[str_i].BorderWidth = 3;
                chart.Series[str_i].BorderColor = Color.Black;
                chart.Series[str_i].MarkerBorderWidth = 2;

                int count = chart.Series[str_i].Points.Count;
                chart.Series[str_i].Points[count - 1].BorderColor = Color.Red;
            }
        }

        private void Zoom(Chart chart, bool isZoom)
        {
            chart.ChartAreas[0].AxisX.ScaleView.Zoom(zoomXStart, zoomXEnd);
            chart.ChartAreas[0].CursorX.IsUserEnabled = isZoom;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = isZoom;
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = isZoom;
            chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = isZoom;

            chart.ChartAreas[0].AxisY.ScaleView.Zoom(zoomYStart, zoomYEnd);
            chart.ChartAreas[0].CursorY.IsUserEnabled = isZoom;
            chart.ChartAreas[0].CursorY.IsUserSelectionEnabled = isZoom;
            chart.ChartAreas[0].AxisY.ScaleView.Zoomable = isZoom;
            chart.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = isZoom;
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
            chartMain.Series["Series1"].Points.Clear();
            chartInitial.Series["Series1"].Points.Clear();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //ChartControl chartControl = new ChartControl();
        }

        private void checkedListBoxRoutes_ItemCheck(object sender, ItemCheckEventArgs e)
        {           
            foreach (var item in checkedListBoxRoutes.Items)
            {
                if(e.Index.ToString() == item.ToString())
                {
                    chartMain.Series[item.ToString()].Enabled = e.NewValue == CheckState.Checked ? false : true;
                }
            }
        }
    }
}
