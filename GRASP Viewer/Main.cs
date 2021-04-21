using System;
using System.Collections.Generic;
using System.Drawing;
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

            var grasp = new GRASPManager();
            var result = grasp.Execute(dataset, out List<int> initialRoute);

            DrawRoute(chartMain, dataset, result);
            DrawRoute(chartInitial, dataset, initialRoute);

            lblResultValue.Text = grasp.CalculateDistanceValueForAllRoute(dataset, result).ToString();
            lblInitialDistValue.Text = grasp.CalculateDistanceValueForAllRoute(dataset, initialRoute).ToString();
        }

        private void DrawRoute(Chart chart, List<Instance> dataset, List<int> result)
        {
            for (int i = 0; i < result.Count; i++)
            {
                var instance = dataset.FirstOrDefault(item => item.ID == result[i]);
                chart.Series["Series1"].Points.AddXY(instance.X, instance.Y);

                //TO DO: override ToString()
                string toolTipText = $"ID: {instance.ID}\n X: {instance.X}\n Y: {instance.Y}\n";

                chart.Series["Series1"].Points[i].ToolTip = toolTipText;
            }

            chart.Series["Series1"].ChartType = SeriesChartType.Line;
            chart.Series["Series1"].Color = Color.Blue;
            chart.Series["Series1"].MarkerStyle = MarkerStyle.Circle;
            chart.Series["Series1"].BorderDashStyle = ChartDashStyle.Dash;
            chart.Series["Series1"].BorderWidth = 3;
            chart.Series["Series1"].BorderColor = Color.Black;
            chart.Series["Series1"].MarkerBorderWidth = 2;

            chart.Series["Series1"].Points[0].Color = Color.Red;
            chart.Series["Series1"].Points[0].BorderColor = Color.Red;
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
    }
}
