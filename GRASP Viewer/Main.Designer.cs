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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInitial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1225, 809);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(122, 33);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // chartMain
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMain.Legends.Add(legend1);
            this.chartMain.Location = new System.Drawing.Point(21, 54);
            this.chartMain.Name = "chartMain";
            this.chartMain.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMain.Series.Add(series1);
            this.chartMain.Size = new System.Drawing.Size(832, 726);
            this.chartMain.TabIndex = 1;
            this.chartMain.Text = "Route";
            // 
            // btnZoomPlus
            // 
            this.btnZoomPlus.Location = new System.Drawing.Point(1225, 731);
            this.btnZoomPlus.Name = "btnZoomPlus";
            this.btnZoomPlus.Size = new System.Drawing.Size(122, 33);
            this.btnZoomPlus.TabIndex = 2;
            this.btnZoomPlus.Text = "Zoom +";
            this.btnZoomPlus.UseVisualStyleBackColor = true;
            this.btnZoomPlus.Click += new System.EventHandler(this.btnZoomPlus_Click);
            // 
            // btnZoomMinus
            // 
            this.btnZoomMinus.Location = new System.Drawing.Point(1225, 770);
            this.btnZoomMinus.Name = "btnZoomMinus";
            this.btnZoomMinus.Size = new System.Drawing.Size(122, 33);
            this.btnZoomMinus.TabIndex = 3;
            this.btnZoomMinus.Text = "Zoom -";
            this.btnZoomMinus.UseVisualStyleBackColor = true;
            this.btnZoomMinus.Click += new System.EventHandler(this.btnZoomMinus_Click);
            // 
            // chartInitial
            // 
            chartArea2.Name = "ChartArea1";
            this.chartInitial.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartInitial.Legends.Add(legend2);
            this.chartInitial.Location = new System.Drawing.Point(871, 54);
            this.chartInitial.Name = "chartInitial";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartInitial.Series.Add(series2);
            this.chartInitial.Size = new System.Drawing.Size(476, 453);
            this.chartInitial.TabIndex = 4;
            this.chartInitial.Text = "Initial";
            // 
            // labelInitialDist
            // 
            this.labelInitialDist.AutoSize = true;
            this.labelInitialDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInitialDist.Location = new System.Drawing.Point(1021, 522);
            this.labelInitialDist.Name = "labelInitialDist";
            this.labelInitialDist.Size = new System.Drawing.Size(73, 25);
            this.labelInitialDist.TabIndex = 5;
            this.labelInitialDist.Text = "Quality";
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(288, 792);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(106, 37);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Quality";
            // 
            // lblInitialDistValue
            // 
            this.lblInitialDistValue.AutoSize = true;
            this.lblInitialDistValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInitialDistValue.Location = new System.Drawing.Point(1163, 521);
            this.lblInitialDistValue.Name = "lblInitialDistValue";
            this.lblInitialDistValue.Size = new System.Drawing.Size(23, 25);
            this.lblInitialDistValue.TabIndex = 6;
            this.lblInitialDistValue.Text = "0";
            // 
            // lblResultValue
            // 
            this.lblResultValue.AutoSize = true;
            this.lblResultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultValue.Location = new System.Drawing.Point(400, 792);
            this.lblResultValue.Name = "lblResultValue";
            this.lblResultValue.Size = new System.Drawing.Size(23, 25);
            this.lblResultValue.TabIndex = 7;
            this.lblResultValue.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1225, 692);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 33);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelVehicleCount
            // 
            this.labelVehicleCount.AutoSize = true;
            this.labelVehicleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVehicleCount.Location = new System.Drawing.Point(868, 572);
            this.labelVehicleCount.Name = "labelVehicleCount";
            this.labelVehicleCount.Size = new System.Drawing.Size(136, 25);
            this.labelVehicleCount.TabIndex = 9;
            this.labelVehicleCount.Text = "Vehicle count:";
            // 
            // labelVehicleCapacity
            // 
            this.labelVehicleCapacity.AutoSize = true;
            this.labelVehicleCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVehicleCapacity.Location = new System.Drawing.Point(868, 634);
            this.labelVehicleCapacity.Name = "labelVehicleCapacity";
            this.labelVehicleCapacity.Size = new System.Drawing.Size(160, 25);
            this.labelVehicleCapacity.TabIndex = 10;
            this.labelVehicleCapacity.Text = "Vehicle capacity:";
            // 
            // textBoxVehicleCount
            // 
            this.textBoxVehicleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVehicleCount.Location = new System.Drawing.Point(1051, 572);
            this.textBoxVehicleCount.Name = "textBoxVehicleCount";
            this.textBoxVehicleCount.Size = new System.Drawing.Size(296, 30);
            this.textBoxVehicleCount.TabIndex = 11;
            this.textBoxVehicleCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVehicleCount_KeyPress);
            // 
            // textBoxVehicleCapacity
            // 
            this.textBoxVehicleCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVehicleCapacity.Location = new System.Drawing.Point(1051, 629);
            this.textBoxVehicleCapacity.Name = "textBoxVehicleCapacity";
            this.textBoxVehicleCapacity.Size = new System.Drawing.Size(296, 30);
            this.textBoxVehicleCapacity.TabIndex = 12;
            this.textBoxVehicleCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVehicleCapacity_KeyPress);
            // 
            // checkedListBoxRoutes
            // 
            this.checkedListBoxRoutes.FormattingEnabled = true;
            this.checkedListBoxRoutes.Location = new System.Drawing.Point(1026, 685);
            this.checkedListBoxRoutes.Name = "checkedListBoxRoutes";
            this.checkedListBoxRoutes.Size = new System.Drawing.Size(169, 157);
            this.checkedListBoxRoutes.TabIndex = 13;
            this.checkedListBoxRoutes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxRoutes_ItemCheck);
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes.Location = new System.Drawing.Point(326, 13);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(143, 29);
            this.labelRes.TabIndex = 14;
            this.labelRes.Text = "Final result";
            // 
            // labelInit
            // 
            this.labelInit.AutoSize = true;
            this.labelInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInit.Location = new System.Drawing.Point(1077, 13);
            this.labelInit.Name = "labelInit";
            this.labelInit.Size = new System.Drawing.Size(215, 29);
            this.labelInit.TabIndex = 15;
            this.labelInit.Text = "The best solution";
            // 
            // buttonUncheckAll
            // 
            this.buttonUncheckAll.Location = new System.Drawing.Point(873, 743);
            this.buttonUncheckAll.Name = "buttonUncheckAll";
            this.buttonUncheckAll.Size = new System.Drawing.Size(122, 37);
            this.buttonUncheckAll.TabIndex = 16;
            this.buttonUncheckAll.Text = "Uncheck all";
            this.buttonUncheckAll.UseVisualStyleBackColor = true;
            this.buttonUncheckAll.Click += new System.EventHandler(this.buttonUncheckAll_Click);
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.Location = new System.Drawing.Point(873, 692);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(122, 35);
            this.buttonCheckAll.TabIndex = 17;
            this.buttonCheckAll.Text = "Check all";
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            this.buttonCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
            // 
            // buttonMoreInfo
            // 
            this.buttonMoreInfo.Location = new System.Drawing.Point(873, 794);
            this.buttonMoreInfo.Name = "buttonMoreInfo";
            this.buttonMoreInfo.Size = new System.Drawing.Size(122, 35);
            this.buttonMoreInfo.TabIndex = 18;
            this.buttonMoreInfo.Text = "Show more info";
            this.buttonMoreInfo.UseVisualStyleBackColor = true;
            this.buttonMoreInfo.Click += new System.EventHandler(this.buttonMoreInfo_Click);
            // 
            // richTextBoxDetailInfo
            // 
            this.richTextBoxDetailInfo.Location = new System.Drawing.Point(1372, 54);
            this.richTextBoxDetailInfo.Name = "richTextBoxDetailInfo";
            this.richTextBoxDetailInfo.Size = new System.Drawing.Size(323, 788);
            this.richTextBoxDetailInfo.TabIndex = 19;
            this.richTextBoxDetailInfo.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 857);
            this.Controls.Add(this.richTextBoxDetailInfo);
            this.Controls.Add(this.buttonMoreInfo);
            this.Controls.Add(this.buttonCheckAll);
            this.Controls.Add(this.buttonUncheckAll);
            this.Controls.Add(this.labelInit);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.checkedListBoxRoutes);
            this.Controls.Add(this.textBoxVehicleCapacity);
            this.Controls.Add(this.textBoxVehicleCount);
            this.Controls.Add(this.labelVehicleCapacity);
            this.Controls.Add(this.labelVehicleCount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResultValue);
            this.Controls.Add(this.lblInitialDistValue);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelInitialDist);
            this.Controls.Add(this.chartInitial);
            this.Controls.Add(this.btnZoomMinus);
            this.Controls.Add(this.btnZoomPlus);
            this.Controls.Add(this.chartMain);
            this.Controls.Add(this.btnRun);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInitial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}