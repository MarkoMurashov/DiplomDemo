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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInitial)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(721, 776);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(122, 33);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
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
            this.btnZoomPlus.Location = new System.Drawing.Point(1346, 728);
            this.btnZoomPlus.Name = "btnZoomPlus";
            this.btnZoomPlus.Size = new System.Drawing.Size(147, 53);
            this.btnZoomPlus.TabIndex = 2;
            this.btnZoomPlus.Text = "Zoom +";
            this.btnZoomPlus.UseVisualStyleBackColor = true;
            this.btnZoomPlus.Click += new System.EventHandler(this.btnZoomPlus_Click);
            // 
            // btnZoomMinus
            // 
            this.btnZoomMinus.Location = new System.Drawing.Point(1346, 803);
            this.btnZoomMinus.Name = "btnZoomMinus";
            this.btnZoomMinus.Size = new System.Drawing.Size(147, 53);
            this.btnZoomMinus.TabIndex = 3;
            this.btnZoomMinus.Text = "Zoom -";
            this.btnZoomMinus.UseVisualStyleBackColor = true;
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
            this.btnClear.Location = new System.Drawing.Point(1346, 648);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 53);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelVehicleCount
            // 
            this.labelVehicleCount.AutoSize = true;
            this.labelVehicleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVehicleCount.Location = new System.Drawing.Point(458, 278);
            this.labelVehicleCount.Name = "labelVehicleCount";
            this.labelVehicleCount.Size = new System.Drawing.Size(136, 25);
            this.labelVehicleCount.TabIndex = 9;
            this.labelVehicleCount.Text = "Vehicle count:";
            // 
            // labelVehicleCapacity
            // 
            this.labelVehicleCapacity.AutoSize = true;
            this.labelVehicleCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVehicleCapacity.Location = new System.Drawing.Point(458, 340);
            this.labelVehicleCapacity.Name = "labelVehicleCapacity";
            this.labelVehicleCapacity.Size = new System.Drawing.Size(160, 25);
            this.labelVehicleCapacity.TabIndex = 10;
            this.labelVehicleCapacity.Text = "Vehicle capacity:";
            // 
            // textBoxVehicleCount
            // 
            this.textBoxVehicleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVehicleCount.Location = new System.Drawing.Point(641, 278);
            this.textBoxVehicleCount.Name = "textBoxVehicleCount";
            this.textBoxVehicleCount.Size = new System.Drawing.Size(296, 30);
            this.textBoxVehicleCount.TabIndex = 11;
            this.textBoxVehicleCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVehicleCount_KeyPress);
            // 
            // textBoxVehicleCapacity
            // 
            this.textBoxVehicleCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVehicleCapacity.Location = new System.Drawing.Point(641, 335);
            this.textBoxVehicleCapacity.Name = "textBoxVehicleCapacity";
            this.textBoxVehicleCapacity.Size = new System.Drawing.Size(296, 30);
            this.textBoxVehicleCapacity.TabIndex = 12;
            this.textBoxVehicleCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVehicleCapacity_KeyPress);
            // 
            // checkedListBoxRoutes
            // 
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
            this.buttonUncheckAll.Location = new System.Drawing.Point(912, 728);
            this.buttonUncheckAll.Name = "buttonUncheckAll";
            this.buttonUncheckAll.Size = new System.Drawing.Size(147, 57);
            this.buttonUncheckAll.TabIndex = 16;
            this.buttonUncheckAll.Text = "Uncheck all";
            this.buttonUncheckAll.UseVisualStyleBackColor = true;
            this.buttonUncheckAll.Click += new System.EventHandler(this.buttonUncheckAll_Click);
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.Location = new System.Drawing.Point(912, 648);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(147, 55);
            this.buttonCheckAll.TabIndex = 17;
            this.buttonCheckAll.Text = "Check all";
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            this.buttonCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
            // 
            // buttonMoreInfo
            // 
            this.buttonMoreInfo.Location = new System.Drawing.Point(912, 801);
            this.buttonMoreInfo.Name = "buttonMoreInfo";
            this.buttonMoreInfo.Size = new System.Drawing.Size(147, 55);
            this.buttonMoreInfo.TabIndex = 18;
            this.buttonMoreInfo.Text = "Show more info";
            this.buttonMoreInfo.UseVisualStyleBackColor = true;
            this.buttonMoreInfo.Click += new System.EventHandler(this.buttonMoreInfo_Click);
            // 
            // richTextBoxDetailInfo
            // 
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
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1631, 936);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelVehicleCount);
            this.tabPage1.Controls.Add(this.labelVehicleCapacity);
            this.tabPage1.Controls.Add(this.textBoxVehicleCount);
            this.tabPage1.Controls.Add(this.textBoxVehicleCapacity);
            this.tabPage1.Controls.Add(this.btnRun);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1623, 907);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1623, 907);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 986);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInitial)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
    }
}