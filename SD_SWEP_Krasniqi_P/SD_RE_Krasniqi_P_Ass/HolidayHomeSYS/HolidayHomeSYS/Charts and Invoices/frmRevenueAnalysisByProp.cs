using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HolidayHomeSYS
{
    public partial class frmRevenueAnalysisByProp : Form
    {
        public frmRevenueAnalysisByProp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

            if (string.IsNullOrEmpty(cmbYear.Text))
            {
                MessageBox.Show("Please select a value");

            }
        }

        

       


        private void fillChart(string year,int pNo)
        {

            //fill chart
            chtYear.Series["Revenue"].Points.Clear();



            //get data from database
            DataSet ds = new DataSet();
            ds = Bookings.getPropertyData(ds, year,pNo);

            //add values in array to chart series
            int j = 0;
            for (int i = 1; i <= 12; i++)
            {
                if ((j == ds.Tables["ss"].Rows.Count) || (i < Convert.ToInt32(ds.Tables[0].Rows[j][0])))
                    chtYear.Series["Revenue"].Points.AddXY(getMonthName(i), 0);
                else
                {

                    chtYear.Series["Revenue"].Points.AddXY(getMonthName(i), Convert.ToDecimal(ds.Tables[0].Rows[j][1]));
                    j++;
                }
            }
        }

        public String getMonthName(int MonthNo)
        {
            string monthName = "";
            switch (MonthNo)
            {
                case 1:
                    monthName = "JAN";
                    break;
                case 2:
                    monthName = "FEB";
                    break;
                case 3:
                    monthName = "MAR";
                    break;
                case 4:
                    monthName = "APR";
                    break;
                case 5:
                    monthName = "MAY";
                    break;
                case 6:
                    monthName = "JUN";
                    break;
                case 7:
                    monthName = "JUL";
                    break;
                case 8:
                    monthName = "AUG";
                    break;
                case 9:
                    monthName = "SEP";
                    break;
                case 10:
                    monthName = "OCT";
                    break;
                case 11:
                    monthName = "NOV";
                    break;
                case 12:
                    monthName = "DEC";
                    break;
            }
            return monthName;
        }


        private void defineSeries()
        {
            chtYear.Series.Clear();
            chtYear.Series.Add("Revenue");

            chtYear.Series["Revenue"].ChartType = SeriesChartType.Column;
            chtYear.Series["Revenue"].XValueType = ChartValueType.String;
        }

        private void defineChart(string year)
        {
            //define chart
            chtYear.Size = new Size(900, 320);
            chtYear.ChartAreas[0].Name = "mainArea";
            chtYear.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chtYear.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chtYear.ChartAreas["mainArea"].AxisY.Minimum = 0;
            chtYear.ChartAreas["mainArea"].AxisY.Interval = 250;
            chtYear.ChartAreas["mainArea"].AxisY.Title = "Euros";

            chtYear.ChartAreas["mainArea"].AxisX.Interval = 1;
            chtYear.ChartAreas["mainArea"].AxisX.Title = "Month";

            chtYear.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;
            //chtData.ChartAreas["mainArea"].AxisY.MajorGrid.Enabled = false;

            //chart title   
            chtYear.Titles.Add("Monthly Revenue 20" + year);
        }

        private void frmRevenueAnalysisByProp_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Property.revenueAnalysis(ds);

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("Sorry there are no properties to analyse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboPropid.Items.Add(ds.Tables[0].Rows[i][0].ToString() );
                }
            }
        }

        private void cboPropid_SelectedIndexChanged(object sender, EventArgs e)
        {
            Property myProp = new Property();

            if(cboPropid.SelectedIndex == -1)
            {
                return;
            }

            if (cmbYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please specify the year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbYear.Focus();
                return;
            }

            myProp.getProperty(Convert.ToInt16(cboPropid.Text));
            

            


                grpReport.Visible = true;
                chtYear.Show();

                defineChart(cmbYear.Text.Substring(2, 2));

                defineSeries();

                fillChart(cmbYear.Text.Substring(2, 2), Convert.ToInt32(cboPropid.Text));
            
        }
    }
}
