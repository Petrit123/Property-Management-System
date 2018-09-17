using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolidayHomeSYS
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegisterProperty frmreg = new frmRegisterProperty();
            frmreg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDeRegisterProperty frmremove = new frmDeRegisterProperty();
            frmremove.Show();
            this.Hide();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            frmUpdateProperty frmUpdate = new frmUpdateProperty();
            frmUpdate.Show();
                this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCheckAvailability frmCheck = new frmCheckAvailability();
            frmCheck.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMakeBooking frmMake = new frmMakeBooking();
            frmMake.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCancelBooking frmCancel = new frmCancelBooking();
            frmCancel.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmCheckIn frmIn = new frmCheckIn();
            frmIn.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmCheckOut frmOut = new frmCheckOut();
            frmOut.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmIssueInvoice frmIssue = new frmIssueInvoice();
            frmIssue.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmRevenueAnalysis frmRevenue = new frmRevenueAnalysis();
            frmRevenue.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmRevenueAnalysisByProp frmProp = new frmRevenueAnalysisByProp();
            frmProp.Show();
            this.Hide();
        }

        
    }
}
