namespace HolidayHomeSYS
{
    partial class frmRevenueAnalysisByProp
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
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblSelectAnalysis = new System.Windows.Forms.Label();
            this.lblPropNo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.picChart = new System.Windows.Forms.PictureBox();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.chtYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboPropid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChart)).BeginInit();
            this.grpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtYear)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(53, 161);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(47, 20);
            this.lblYear.TabIndex = 73;
            this.lblYear.Text = "Year";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2018"});
            this.cmbYear.Location = new System.Drawing.Point(212, 161);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(120, 24);
            this.cmbYear.TabIndex = 0;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // lblSelectAnalysis
            // 
            this.lblSelectAnalysis.AutoSize = true;
            this.lblSelectAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAnalysis.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSelectAnalysis.Location = new System.Drawing.Point(47, 69);
            this.lblSelectAnalysis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectAnalysis.Name = "lblSelectAnalysis";
            this.lblSelectAnalysis.Size = new System.Drawing.Size(426, 31);
            this.lblSelectAnalysis.TabIndex = 71;
            this.lblSelectAnalysis.Text = "Select a year for analysis chart:";
            // 
            // lblPropNo
            // 
            this.lblPropNo.AutoSize = true;
            this.lblPropNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropNo.Location = new System.Drawing.Point(53, 243);
            this.lblPropNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPropNo.Name = "lblPropNo";
            this.lblPropNo.Size = new System.Drawing.Size(143, 20);
            this.lblPropNo.TabIndex = 76;
            this.lblPropNo.Text = "Property Number";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBack.Location = new System.Drawing.Point(8, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 38);
            this.btnBack.TabIndex = 78;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picChart
            // 
            this.picChart.Image = global::HolidayHomeSYS.Properties.Resources.report;
            this.picChart.Location = new System.Drawing.Point(470, 143);
            this.picChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picChart.Name = "picChart";
            this.picChart.Size = new System.Drawing.Size(198, 190);
            this.picChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChart.TabIndex = 75;
            this.picChart.TabStop = false;
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.chtYear);
            this.grpReport.Location = new System.Drawing.Point(20, 441);
            this.grpReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpReport.Name = "grpReport";
            this.grpReport.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpReport.Size = new System.Drawing.Size(943, 383);
            this.grpReport.TabIndex = 79;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "groupBox1";
            this.grpReport.Visible = false;
            // 
            // chtYear
            // 
            chartArea1.Name = "ChartArea1";
            this.chtYear.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtYear.Legends.Add(legend1);
            this.chtYear.Location = new System.Drawing.Point(28, 38);
            this.chtYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chtYear.Name = "chtYear";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtYear.Series.Add(series1);
            this.chtYear.Size = new System.Drawing.Size(898, 334);
            this.chtYear.TabIndex = 0;
            this.chtYear.Text = "chart1";
            // 
            // cboPropid
            // 
            this.cboPropid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPropid.FormattingEnabled = true;
            this.cboPropid.Location = new System.Drawing.Point(212, 246);
            this.cboPropid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPropid.Name = "cboPropid";
            this.cboPropid.Size = new System.Drawing.Size(93, 21);
            this.cboPropid.TabIndex = 1;
            this.cboPropid.SelectedIndexChanged += new System.EventHandler(this.cboPropid_SelectedIndexChanged);
            // 
            // frmRevenueAnalysisByProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 837);
            this.Controls.Add(this.cboPropid);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPropNo);
            this.Controls.Add(this.picChart);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblSelectAnalysis);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRevenueAnalysisByProp";
            this.Text = "RevenueAnalysisByProp";
            this.Load += new System.EventHandler(this.frmRevenueAnalysisByProp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picChart)).EndInit();
            this.grpReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picChart;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblSelectAnalysis;
        private System.Windows.Forms.Label lblPropNo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtYear;
        private System.Windows.Forms.ComboBox cboPropid;
    }
}