using System;
using System.Collections.Generic;
using System.Drawing;
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
        #region private fields

        private int zoomXStart = 0;
        private int zoomXEnd = 100;
        private int zoomYStart = 0;
        private int zoomYEnd = 100;

        private List<List<int>> result = new List<List<int>>();

        private GRASPManager grasp;

        private List<Instance> dataset;

        private string solutionPath;

        #endregion

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

        private void DrawBestSolution()
        {
            List<List<int>> solution = new List<List<int>>();
            foreach (var line in File.ReadLines(solutionPath))
            {
                var values = line.Split(' ').Where(s => !string.IsNullOrEmpty(s)).Select(Int32.Parse).ToList();
                solution.Add(values);
            }

            DrawRoute(chartInitial, dataset, solution);
            lblInitialDistValue.Text = grasp.CalculateDistance(solution).ToString();
        }

        private void ValidateDoubleNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        #endregion

        private void btnRun_Click(object sender, EventArgs e)
        {           
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

            if(numericUpDown2OptMaxIteration.Value == 0 || numericUpDownGRASPMaxIteration.Value == 0
                || numericUpDownSwapMaxIteration.Value == 0)
            {
                MessageBox.Show("Please enter valid value for max iteration");
                return;
            }

            if(dataset == null)
            {
                MessageBox.Show("Please enter load dataset");
                return;
            }

            if (string.IsNullOrEmpty(solutionPath))
            {
                MessageBox.Show("Please enter load the best solution");
                return;
            }

            double.TryParse(textBoxAplha.Text, out Parameters.ALPHA);
            double.TryParse(textBoxReadyTime.Text, out Parameters.ALPHA_READY_TIME);
            double.TryParse(textBoxWaitPenalty.Text, out Parameters.COEF_WAIT_PENALTY);
            double.TryParse(textBoxSoftWindow.Text, out Parameters.SOFT_DUE_WINDOW);

            Parameters.MAX_GRASP_ITERATION = (int)numericUpDownGRASPMaxIteration.Value;
            Parameters.MAX_LOCAL_SEARCH_SWAP_ITERATION = (int)numericUpDownSwapMaxIteration.Value;
            Parameters.MAX_LOCAL_SEARCH_TWO_OPT_ITERATION = (int)numericUpDown2OptMaxIteration.Value;

            grasp = new GRASPManager(dataset, vCount, vCapacity);
            result = grasp.Execute(checkBoxSwap.Checked);

            DrawRoute(chartMain, dataset, result);
            DrawBestSolution();

            for (int i = 0; i < result.Count; i++)
            {
                checkedListBoxRoutes.Items.Add(i);
                checkedListBoxRoutes.SetItemChecked(i, true);
            }

            lblResultValue.Text = grasp.CalculateDistance(result).ToString();

            MessageBox.Show("Done");
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
            ValidateDoubleNumber(e);
        }

        private void buttonMoreInfo_Click(object sender, EventArgs e)
        {
            string strToShow = string.Empty;

            foreach (var item in checkedListBoxRoutes.CheckedItems)
            {
                int index = int.Parse(item.ToString());

                strToShow += "\n=====Route # " + index + " =====\n";
                strToShow += grasp.GetInfo(result[index]);
            }

            richTextBoxDetailInfo.Text = strToShow;
        }

        private void buttonLoadDF_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Load dataset";
            dialog.DefaultExt = "txt";

            if (dialog.ShowDialog() == DialogResult.OK)

            {
                string path = dialog.FileName;
                dataset = new FileReader().Read(path);
                MessageBox.Show("File loaded successfully");
            }
        }

        private void buttonBestSolution_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Load the best solution";
            dialog.DefaultExt = "txt";

            if (dialog.ShowDialog() == DialogResult.OK)

            {
                solutionPath = dialog.FileName;
                MessageBox.Show("File loaded successfully");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            textBoxAplha.Text = Parameters.ALPHA.ToString();
            textBoxReadyTime.Text = Parameters.ALPHA_READY_TIME.ToString();
            textBoxSoftWindow.Text = Parameters.SOFT_DUE_WINDOW.ToString();
            textBoxWaitPenalty.Text = Parameters.COEF_WAIT_PENALTY.ToString();

            numericUpDown2OptMaxIteration.Value = Parameters.MAX_LOCAL_SEARCH_TWO_OPT_ITERATION;
            numericUpDownGRASPMaxIteration.Value = Parameters.MAX_GRASP_ITERATION;
            numericUpDownSwapMaxIteration.Value = Parameters.MAX_LOCAL_SEARCH_SWAP_ITERATION;
        }

        private void textBoxAplha_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDoubleNumber(e);
        }

        private void textBoxSoftWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDoubleNumber(e);
        }

        private void textBoxReadyTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDoubleNumber(e);
        }

        private void textBoxWaitPenalty_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDoubleNumber(e);
        }
    }
}
