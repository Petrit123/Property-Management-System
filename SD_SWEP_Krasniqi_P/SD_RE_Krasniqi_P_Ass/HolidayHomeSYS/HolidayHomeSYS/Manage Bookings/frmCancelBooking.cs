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
    public partial class frmCancelBooking : Form
    {
        public frmCancelBooking()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

      

     

        private void frmCancelBooking_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            

            grdBookings.DataSource = Bookings.searchBooking(ds).Tables["ss"];

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("Sorry there are no check-outs for today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboBookid.Items.Add(String.Format("{0:00000}", ds.Tables[0].Rows[i][0]) + " " + ds.Tables[0].Rows[i][8].ToString().Trim() + ", "+  ds.Tables[0].Rows[i][9].ToString());
                }
            }
        }

        private void cboBookid_SelectedIndexChanged(object sender, EventArgs e)
        {

            Bookings booking = new Bookings();
            if (cboBookid.SelectedIndex == -1)
            {
                cboBookid.SelectedIndex = -1;
                return;
               
            }
            booking.getBooking(Convert.ToInt32(cboBookid.Text.Substring(0, 5)));


            DialogResult result = MessageBox.Show("Are you sure you would like to cancel booking", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else if (result == DialogResult.Yes)
            {





                booking.cancelBooking();


                MessageBox.Show("Booking " + cboBookid.Text.Substring(0, 5) + " cancelled successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboBookid.SelectedIndex = -1;
                cboBookid.Focus();


            }


        }
    }
}
