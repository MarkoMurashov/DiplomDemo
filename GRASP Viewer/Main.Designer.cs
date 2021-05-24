namespace GRASP_Viewer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnRun = new System.Windows.Forms.Button();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnZoomPlus = new System.Windows.Forms.Button();
            this.btnZoomMinus = new System.Windows.Forms.Button();
            this.chartInitial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelInitialDist = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.lblInitialDistValue = new System.Windows.Forms.Label();
            this.lblResultValue = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.labelVehicleCount = new System.Windows.Forms.Label();
            this.labelVehicleCapacity = new System.Windows.Forms.Label();
            this.textBoxVehicleCount = new System.Windows.Forms.TextBox();
            this.textBoxVehicleCapacity = new System.Windows.Forms.TextBox();
            this.checkedListBoxRoutes = new System.Windows.Forms.CheckedListBox();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelInit = new System.Windows.Forms.Label();
            this.buttonUncheckAll = new System.Windows.Forms.Button();
            this.buttonCheckAll = new System.Windows.Forms.Button();
            this.buttonMoreInfo = new System.Windows.Forms.Button();
            this.richTextBoxDetailInfo = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxWaitPenalty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxReadyTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSoftWindow = new System.Windows.Forms.TextBox();
            this.numericUpDownSwapMaxIteration = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2OptMaxIteration = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownGRASPMaxIteration = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAplha = new System.Windows.Forms.TextBox();
            this.buttonBestSolution = new System.Windows.Forms.Button();
            this.buttonLoadDF = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxSwap = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInitial)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSwapMaxIteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2OptMaxIteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGRASPMaxIteration)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Black;
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(133, 784);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(167, 70);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // chartMain
            // 
            chartArea5.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartMain.Legends.Add(legend5);
            this.chartMain.Location = new System.Drawing.Point(17, 78);
            this.chartMain.Name = "chartMain";
            this.chartMain.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartMain.Series.Add(series5);
            this.chartMain.Size = new System.Drawing.Size(725, 741);
            this.chartMain.TabIndex = 1;
            this.chartMain.Text = "Route";
            // 
            // btnZoomPlus
            // 
            this.btnZoomPlus.BackColor = System.Drawing.Color.Black;
            this.btnZoomPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZoomPlus.ForeColor = System.Drawing.Color.White;
            this.btnZoomPlus.Location = new System.Drawing.Point(1346, 728);
            this.btnZoomPlus.Name = "btnZoomPlus";
            this.btnZoomPlus.Size = new System.Drawing.Size(189, 53);
            this.btnZoomPlus.TabIndex = 2;
            this.btnZoomPlus.Text = "Zoom +";
            this.btnZoomPlus.UseVisualStyleBackColor = false;
            this.btnZoomPlus.Click += new System.EventHandler(this.btnZoomPlus_Click);
            // 
            // btnZoomMinus
            // 
            this.btnZoomMinus.BackColor = System.Drawing.Color.Black;
            this.btnZoomMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZoomMinus.ForeColor = System.Drawing.Color.White;
            this.btnZoomMinus.Location = new System.Drawing.Point(1346, 803);
            this.btnZoomMinus.Name = "btnZoomMinus";
            this.btnZoomMinus.Size = new System.Drawing.Size(189, 53);
            this.btnZoomMinus.TabIndex = 3;
            this.btnZoomMinus.Text = "Zoom -";
            this.btnZoomMinus.UseVisualStyleBackColor = false;
            this.btnZoomMinus.Click += new System.EventHandler(this.btnZoomMinus_Click);
            // 
            // chartInitial
            // 
            chartArea6.Name = "ChartArea1";
            this.chartInitial.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartInitial.Legends.Add(legend6);
            this.chartInitial.Location = new System.Drawing.Point(759, 92);
            this.chartInitial.Name = "chartInitial";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartInitial.Series.Add(series6);
            this.chartInitial.Size = new System.Drawing.Size(434, 414);
            this.chartInitial.TabIndex = 4;
            this.chartInitial.Text = "Initial";
            // 
            // labelInitialDist
            // 
            this.labelInitialDist.AutoSize = true;
            this.labelInitialDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInitialDist.Location = new System.Drawing.Point(865, 544);
            this.labelInitialDist.Name = "labelInitialDist";
            this.labelInitialDist.Size = new System.Drawing.Size(73, 25);
            this.labelInitialDist.TabIndex = 5;
            this.labelInitialDist.Text = "Quality";
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(225, 822);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(106, 37);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Quality";
            // 
            // lblInitialDistValue
            // 
            this.lblInitialDistValue.AutoSize = true;
            this.lblInitialDistValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInitialDistValue.Location = new System.Drawing.Point(1007, 543);
            this.lblInitialDistValue.Name = "lblInitialDistValue";
            this.lblInitialDistValue.Size = new System.Drawing.Size(23, 25);
            this.lblInitialDistValue.TabIndex = 6;
            this.lblInitialDistValue.Text = "0";
            // 
            // lblResultValue
            // 
            this.lblResultValue.AutoSize = true;
            this.lblResultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultValue.Location = new System.Drawing.Point(337, 822);
            this.lblResultValue.Name = "lblResultValue";
            this.lblResultValue.Size = new System.Drawing.Size(23, 25);
            this.lblResultValue.TabIndex = 7;
            this.lblResultValue.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1346, 648);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(189, 53);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelVehicleCount
            // 
            this.labelVehicleCount.AutoSize = true;
            this.labelVehicleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVehicleCount.Location = new System.Drawing.Point(164, 322);
            this.labelVehicleCount.Name = "labelVehicleCount";
            this.labelVehicleCount.Size = new System.Drawing.Size(136, 25);
            this.labelVehicleCount.TabIndex = 9;
            this.labelVehicleCount.Text = "Vehicle count:";
            // 
            // labelVehicleCapacity
            // 
            this.labelVehicleCapacity.AutoSize = true;
            this.labelVehicleCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVehicleCapacity.Location = new System.Drawing.Point(164, 384);
            this.labelVehicleCapacity.Name = "labelVehicleCapacity";
            this.labelVehicleCapacity.Size = new System.Drawing.Size(160, 25);
            this.labelVehicleCapacity.TabIndex = 10;
            this.labelVehicleCapacity.Text = "Vehicle capacity:";
            // 
            // textBoxVehicleCount
            // 
            this.textBoxVehicleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVehicleCount.Location = new System.Drawing.Point(347, 322);
            this.textBoxVehicleCount.Name = "textBoxVehicleCount";
            this.textBoxVehicleCount.Size = new System.Drawing.Size(296, 30);
            this.textBoxVehicleCount.TabIndex = 11;
            this.textBoxVehicleCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVehicleCount_KeyPress);
            // 
            // textBoxVehicleCapacity
            // 
            this.textBoxVehicleCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVehicleCapacity.Location = new System.Drawing.Point(347, 379);
            this.textBoxVehicleCapacity.Name = "textBoxVehicleCapacity";
            this.textBoxVehicleCapacity.Size = new System.Drawing.Size(296, 30);
            this.textBoxVehicleCapacity.TabIndex = 12;
            this.textBoxVehicleCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVehicleCapacity_KeyPress);
            // 
            // checkedListBoxRoutes
            // 
            this.checkedListBoxRoutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxRoutes.FormattingEnabled = true;
            this.checkedListBoxRoutes.Location = new System.Drawing.Point(1088, 648);
            this.checkedListBoxRoutes.Name = "checkedListBoxRoutes";
            this.checkedListBoxRoutes.Size = new System.Drawing.Size(209, 208);
            this.checkedListBoxRoutes.TabIndex = 13;
            this.checkedListBoxRoutes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxRoutes_ItemCheck);
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes.Location = new System.Drawing.Point(280, 31);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(143, 29);
            this.labelRes.TabIndex = 14;
            this.labelRes.Text = "Final result";
            // 
            // labelInit
            // 
            this.labelInit.AutoSize = true;
            this.labelInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInit.Location = new System.Drawing.Point(865, 46);
            this.labelInit.Name = "labelInit";
            this.labelInit.Size = new System.Drawing.Size(215, 29);
            this.labelInit.TabIndex = 15;
            this.labelInit.Text = "The best solution";
            // 
            // buttonUncheckAll
            // 
            this.buttonUncheckAll.BackColor = System.Drawing.Color.Black;
            this.buttonUncheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUncheckAll.ForeColor = System.Drawing.Color.White;
            this.buttonUncheckAll.Location = new System.Drawing.Point(870, 728);
            this.buttonUncheckAll.Name = "buttonUncheckAll";
            this.buttonUncheckAll.Size = new System.Drawing.Size(189, 57);
            this.buttonUncheckAll.TabIndex = 16;
            this.buttonUncheckAll.Text = "Uncheck all";
            this.buttonUncheckAll.UseVisualStyleBackColor = false;
            this.buttonUncheckAll.Click += new System.EventHandler(this.buttonUncheckAll_Click);
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.BackColor = System.Drawing.Color.Black;
            this.buttonCheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckAll.ForeColor = System.Drawing.Color.White;
            this.buttonCheckAll.Location = new System.Drawing.Point(870, 648);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(189, 55);
            this.buttonCheckAll.TabIndex = 17;
            this.buttonCheckAll.Text = "Check all";
            this.buttonCheckAll.UseVisualStyleBackColor = false;
            this.buttonCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
            // 
            // buttonMoreInfo
            // 
            this.buttonMoreInfo.BackColor = System.Drawing.Color.Black;
            this.buttonMoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMoreInfo.ForeColor = System.Drawing.Color.White;
            this.buttonMoreInfo.Location = new System.Drawing.Point(870, 801);
            this.buttonMoreInfo.Name = "buttonMoreInfo";
            this.buttonMoreInfo.Size = new System.Drawing.Size(189, 55);
            this.buttonMoreInfo.TabIndex = 18;
            this.buttonMoreInfo.Text = "Show more info";
            this.buttonMoreInfo.UseVisualStyleBackColor = false;
            this.buttonMoreInfo.Click += new System.EventHandler(this.buttonMoreInfo_Click);
            // 
            // richTextBoxDetailInfo
            // 
            this.richTextBoxDetailInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDetailInfo.Location = new System.Drawing.Point(1222, 53);
            this.richTextBoxDetailInfo.Name = "richTextBoxDetailInfo";
            this.richTextBoxDetailInfo.Size = new System.Drawing.Size(338, 546);
            this.richTextBoxDetailInfo.TabIndex = 19;
            this.richTextBoxDetailInfo.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1631, 936);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxSwap);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.textBoxWaitPenalty);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBoxReadyTime);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBoxSoftWindow);
            this.tabPage1.Controls.Add(this.numericUpDownSwapMaxIteration);
            this.tabPage1.Controls.Add(this.numericUpDown2OptMaxIteration);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.numericUpDownGRASPMaxIteration);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxAplha);
            this.tabPage1.Controls.Add(this.buttonBestSolution);
            this.tabPage1.Controls.Add(this.buttonLoadDF);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelVehicleCount);
            this.tabPage1.Controls.Add(this.labelVehicleCapacity);
            this.tabPage1.Controls.Add(this.textBoxVehicleCount);
            this.tabPage1.Controls.Add(this.textBoxVehicleCapacity);
            this.tabPage1.Controls.Add(this.btnRun);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 45);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1623, 887);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(671, 669);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 25);
            this.label11.TabIndex = 33;
            this.label11.Text = "Wait penalty:";
            // 
            // textBoxWaitPenalty
            // 
            this.textBoxWaitPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWaitPenalty.Location = new System.Drawing.Point(864, 666);
            this.textBoxWaitPenalty.Name = "textBoxWaitPenalty";
            this.textBoxWaitPenalty.Size = new System.Drawing.Size(272, 30);
            this.textBoxWaitPenalty.TabIndex = 34;
            this.textBoxWaitPenalty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWaitPenalty_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(671, 613);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Alpha ready time:";
            // 
            // textBoxReadyTime
            // 
            this.textBoxReadyTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReadyTime.Location = new System.Drawing.Point(864, 610);
            this.textBoxReadyTime.Name = "textBoxReadyTime";
            this.textBoxReadyTime.Size = new System.Drawing.Size(272, 30);
            this.textBoxReadyTime.TabIndex = 32;
            this.textBoxReadyTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxReadyTime_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(671, 566);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Soft window:";
            // 
            // textBoxSoftWindow
            // 
            this.textBoxSoftWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSoftWindow.Location = new System.Drawing.Point(864, 563);
            this.textBoxSoftWindow.Name = "textBoxSoftWindow";
            this.textBoxSoftWindow.Size = new System.Drawing.Size(272, 30);
            this.textBoxSoftWindow.TabIndex = 30;
            this.textBoxSoftWindow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoftWindow_KeyPress);
            // 
            // numericUpDownSwapMaxIteration
            // 
            this.numericUpDownSwapMaxIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSwapMaxIteration.Location = new System.Drawing.Point(464, 613);
            this.numericUpDownSwapMaxIteration.Name = "numericUpDownSwapMaxIteration";
            this.numericUpDownSwapMaxIteration.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownSwapMaxIteration.TabIndex = 28;
            // 
            // numericUpDown2OptMaxIteration
            // 
            this.numericUpDown2OptMaxIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2OptMaxIteration.Location = new System.Drawing.Point(464, 566);
            this.numericUpDown2OptMaxIteration.Name = "numericUpDown2OptMaxIteration";
            this.numericUpDown2OptMaxIteration.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown2OptMaxIteration.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(122, 615);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(295, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Local search swap max iteration:";
            // 
            // numericUpDownGRASPMaxIteration
            // 
            this.numericUpDownGRASPMaxIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownGRASPMaxIteration.Location = new System.Drawing.Point(464, 517);
            this.numericUpDownGRASPMaxIteration.Name = "numericUpDownGRASPMaxIteration";
            this.numericUpDownGRASPMaxIteration.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownGRASPMaxIteration.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(122, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Local search two opt max iteration:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(215, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "GRASP max iteration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(671, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Alpha:";
            // 
            // textBoxAplha
            // 
            this.textBoxAplha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAplha.Location = new System.Drawing.Point(864, 519);
            this.textBoxAplha.Name = "textBoxAplha";
            this.textBoxAplha.Size = new System.Drawing.Size(272, 30);
            this.textBoxAplha.TabIndex = 22;
            this.textBoxAplha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAplha_KeyPress);
            // 
            // buttonBestSolution
            // 
            this.buttonBestSolution.BackColor = System.Drawing.Color.Black;
            this.buttonBestSolution.ForeColor = System.Drawing.Color.White;
            this.buttonBestSolution.Location = new System.Drawing.Point(444, 142);
            this.buttonBestSolution.Name = "buttonBestSolution";
            this.buttonBestSolution.Size = new System.Drawing.Size(296, 60);
            this.buttonBestSolution.TabIndex = 18;
            this.buttonBestSolution.Text = "Load the best solution";
            this.buttonBestSolution.UseVisualStyleBackColor = false;
            this.buttonBestSolution.Click += new System.EventHandler(this.buttonBestSolution_Click);
            // 
            // buttonLoadDF
            // 
            this.buttonLoadDF.BackColor = System.Drawing.Color.Black;
            this.buttonLoadDF.ForeColor = System.Drawing.Color.White;
            this.buttonLoadDF.Location = new System.Drawing.Point(148, 142);
            this.buttonLoadDF.Name = "buttonLoadDF";
            this.buttonLoadDF.Size = new System.Drawing.Size(201, 60);
            this.buttonLoadDF.TabIndex = 17;
            this.buttonLoadDF.Text = "Load dataset";
            this.buttonLoadDF.UseVisualStyleBackColor = false;
            this.buttonLoadDF.Click += new System.EventHandler(this.buttonLoadDF_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(65, 713);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 38);
            this.label4.TabIndex = 16;
            this.label4.Text = "4. Run";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(65, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "3. Set additional parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(509, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "2. Set vehicle cout and capacity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(765, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "1. Load file for with dataset and the best solution";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelRes);
            this.tabPage2.Controls.Add(this.richTextBoxDetailInfo);
            this.tabPage2.Controls.Add(this.labelInit);
            this.tabPage2.Controls.Add(this.buttonMoreInfo);
            this.tabPage2.Controls.Add(this.chartInitial);
            this.tabPage2.Controls.Add(this.buttonCheckAll);
            this.tabPage2.Controls.Add(this.chartMain);
            this.tabPage2.Controls.Add(this.buttonUncheckAll);
            this.tabPage2.Controls.Add(this.labelResult);
            this.tabPage2.Controls.Add(this.checkedListBoxRoutes);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.lblResultValue);
            this.tabPage2.Controls.Add(this.btnZoomMinus);
            this.tabPage2.Controls.Add(this.labelInitialDist);
            this.tabPage2.Controls.Add(this.btnZoomPlus);
            this.tabPage2.Controls.Add(this.lblInitialDistValue);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 45);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1623, 887);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Results";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxSwap
            // 
            this.checkBoxSwap.AutoSize = true;
            this.checkBoxSwap.Location = new System.Drawing.Point(220, 669);
            this.checkBoxSwap.Name = "checkBoxSwap";
            this.checkBoxSwap.Size = new System.Drawing.Size(302, 33);
            this.checkBoxSwap.TabIndex = 35;
            this.checkBoxSwap.Text = "Add local search - SWAP";
            this.checkBoxSwap.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1658, 986);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInitial)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSwapMaxIteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2OptMaxIteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGRASPMaxIteration)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.Button btnZoomPlus;
        private System.Windows.Forms.Button btnZoomMinus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInitial;
        private System.Windows.Forms.Label labelInitialDist;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label lblInitialDistValue;
        private System.Windows.Forms.Label lblResultValue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labelVehicleCount;
        private System.Windows.Forms.Label labelVehicleCapacity;
        private System.Windows.Forms.TextBox textBoxVehicleCount;
        private System.Windows.Forms.TextBox textBoxVehicleCapacity;
        private System.Windows.Forms.CheckedListBox checkedListBoxRoutes;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Label labelInit;
        private System.Windows.Forms.Button buttonUncheckAll;
        private System.Windows.Forms.Button buttonCheckAll;
        private System.Windows.Forms.Button buttonMoreInfo;
        private System.Windows.Forms.RichTextBox richTextBoxDetailInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonLoadDF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBestSolution;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAplha;
        private System.Windows.Forms.NumericUpDown numericUpDownGRASPMaxIteration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownSwapMaxIteration;
        private System.Windows.Forms.NumericUpDown numericUpDown2OptMaxIteration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxWaitPenalty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxReadyTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSoftWindow;
        private System.Windows.Forms.CheckBox checkBoxSwap;
    }
}