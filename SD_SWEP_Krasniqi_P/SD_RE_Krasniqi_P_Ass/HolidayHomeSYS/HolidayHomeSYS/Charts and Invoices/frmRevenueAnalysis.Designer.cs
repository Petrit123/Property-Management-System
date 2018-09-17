namespace HolidayHomeSYS
{
    partial class frmRevenueAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblAnalysisChart = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.picChart = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.chtYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.picChart)).BeginInit();
            this.grpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtYear)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnalysisChart
            // 
            this.lblAnalysisChart.AutoSize = true;
            this.lblAnalysisChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalysisChart.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAnalysisChart.Location = new System.Drawing.Point(53, 64);
            this.lblAnalysisChart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnalysisChart.Name = "lblAnalysisChart";
            this.lblAnalysisChart.Size = new System.Drawing.Size(426, 31);
            this.lblAnalysisChart.TabIndex = 6;
            this.lblAnalysisChart.Text = "Select a year for analysis chart:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(59, 156);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(47, 20);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "Year";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2018"});
            this.cmbYear.Location = new System.Drawing.Point(146, 156);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(120, 24);
            this.cmbYear.TabIndex = 13;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBack.Location = new System.Drawing.Point(8, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 36);
            this.btnBack.TabIndex = 71;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picChart
            // 
            this.picChart.Image = global::HolidayHomeSYS.Properties.Resources.report;
            this.picChart.Location = new System.Drawing.Point(570, 131);
            this.picChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picChart.Name = "picChart";
            this.picChart.Size = new System.Drawing.Size(198, 190);
            this.picChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChart.TabIndex = 70;
            this.picChart.TabStop = false;
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.chtYear);
            this.grpReport.Location = new System.Drawing.Point(22, 340);
            this.grpReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpReport.Name = "grpReport";
            this.grpReport.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpReport.Size = new System.Drawing.Size(970, 423);
            this.grpReport.TabIndex = 72;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Yearly Analysis";
            this.grpReport.Visible = false;
            // 
            // chtYear
            // 
            chartArea3.Name = "ChartArea1";
            this.chtYear.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtYear.Legends.Add(legend3);
            this.chtYear.Location = new System.Drawing.Point(46, 52);
            this.chtYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chtYear.Name = "chtYear";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chtYear.Series.Add(series3);
            this.chtYear.Size = new System.Drawing.Size(687, 299);
            this.chtYear.TabIndex = 0;
            this.chtYear.Text = "chart1";
            // 
            // frmRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 827);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picChart);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblAnalysisChart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRevenueAnalysis";
            this.Text = "RevenueAnalysis";
            ((System.ComponentModel.ISupportInitialize)(this.picChart)).EndInit();
            this.grpReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnalysisChart;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.PictureBox picChart;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtYear;
    }
}