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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInitial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1129, 716);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(122, 33);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // chartMain
            // 
            chartArea7.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartMain.Legends.Add(legend7);
            this.chartMain.Location = new System.Drawing.Point(29, 12);
            this.chartMain.Name = "chartMain";
            this.chartMain.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartMain.Series.Add(series7);
            this.chartMain.Size = new System.Drawing.Size(728, 726);
            this.chartMain.TabIndex = 1;
            this.chartMain.Text = "Route";
            // 
            // btnZoomPlus
            // 
            this.btnZoomPlus.Location = new System.Drawing.Point(1129, 638);
            this.btnZoomPlus.Name = "btnZoomPlus";
            this.btnZoomPlus.Size = new System.Drawing.Size(122, 33);
            this.btnZoomPlus.TabIndex = 2;
            this.btnZoomPlus.Text = "Zoom +";
            this.btnZoomPlus.UseVisualStyleBackColor = true;
            this.btnZoomPlus.Click += new System.EventHandler(this.btnZoomPlus_Click);
            // 
            // btnZoomMinus
            // 
            this.btnZoomMinus.Location = new System.Drawing.Point(1129, 677);
            this.btnZoomMinus.Name = "btnZoomMinus";
            this.btnZoomMinus.Size = new System.Drawing.Size(122, 33);
            this.btnZoomMinus.TabIndex = 3;
            this.btnZoomMinus.Text = "Zoom -";
            this.btnZoomMinus.UseVisualStyleBackColor = true;
            this.btnZoomMinus.Click += new System.EventHandler(this.btnZoomMinus_Click);
            // 
            // chartInitial
            // 
            chartArea8.Name = "ChartArea1";
            this.chartInitial.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartInitial.Legends.Add(legend8);
            this.chartInitial.Location = new System.Drawing.Point(784, 12);
            this.chartInitial.Name = "chartInitial";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartInitial.Series.Add(series8);
            this.chartInitial.Size = new System.Drawing.Size(476, 453);
            this.chartInitial.TabIndex = 4;
            this.chartInitial.Text = "Initial";
            // 
            // labelInitialDist
            // 
            this.labelInitialDist.AutoSize = true;
            this.labelInitialDist.Location = new System.Drawing.Point(784, 499);
            this.labelInitialDist.Name = "labelInitialDist";
            this.labelInitialDist.Size = new System.Drawing.Size(97, 17);
            this.labelInitialDist.TabIndex = 5;
            this.labelInitialDist.Text = "Initial distance";
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(784, 556);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(106, 17);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Result distance";
            // 
            // lblInitialDistValue
            // 
            this.lblInitialDistValue.AutoSize = true;
            this.lblInitialDistValue.Location = new System.Drawing.Point(926, 498);
            this.lblInitialDistValue.Name = "lblInitialDistValue";
            this.lblInitialDistValue.Size = new System.Drawing.Size(16, 17);
            this.lblInitialDistValue.TabIndex = 6;
            this.lblInitialDistValue.Text = "0";
            // 
            // lblResultValue
            // 
            this.lblResultValue.AutoSize = true;
            this.lblResultValue.Location = new System.Drawing.Point(926, 555);
            this.lblResultValue.Name = "lblResultValue";
            this.lblResultValue.Size = new System.Drawing.Size(16, 17);
            this.lblResultValue.TabIndex = 7;
            this.lblResultValue.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1129, 599);
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
            this.labelVehicleCount.Location = new System.Drawing.Point(1007, 498);
            this.labelVehicleCount.Name = "labelVehicleCount";
            this.labelVehicleCount.Size = new System.Drawing.Size(97, 17);
            this.labelVehicleCount.TabIndex = 9;
            this.labelVehicleCount.Text = "Vehicle count:";
            // 
            // labelVehicleCapacity
            // 
            this.labelVehicleCapacity.AutoSize = true;
            this.labelVehicleCapacity.Location = new System.Drawing.Point(1007, 561);
            this.labelVehicleCapacity.Name = "labelVehicleCapacity";
            this.labelVehicleCapacity.Size = new System.Drawing.Size(114, 17);
            this.labelVehicleCapacity.TabIndex = 10;
            this.labelVehicleCapacity.Text = "Vehicle capacity:";
            // 
            // textBoxVehicleCount
            // 
            this.textBoxVehicleCount.Location = new System.Drawing.Point(1142, 494);
            this.textBoxVehicleCount.Name = "textBoxVehicleCount";
            this.textBoxVehicleCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxVehicleCount.TabIndex = 11;
            // 
            // textBoxVehicleCapacity
            // 
            this.textBoxVehicleCapacity.Location = new System.Drawing.Point(1142, 556);
            this.textBoxVehicleCapacity.Name = "textBoxVehicleCapacity";
            this.textBoxVehicleCapacity.Size = new System.Drawing.Size(100, 22);
            this.textBoxVehicleCapacity.TabIndex = 12;
            // 
            // checkedListBoxRoutes
            // 
            this.checkedListBoxRoutes.FormattingEnabled = true;
            this.checkedListBoxRoutes.Location = new System.Drawing.Point(784, 599);
            this.checkedListBoxRoutes.Name = "checkedListBoxRoutes";
            this.checkedListBoxRoutes.Size = new System.Drawing.Size(320, 140);
            this.checkedListBoxRoutes.TabIndex = 13;
            this.checkedListBoxRoutes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxRoutes_ItemCheck);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 772);
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
            this.Load += new System.EventHandler(this.Main_Load);
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
    }
}