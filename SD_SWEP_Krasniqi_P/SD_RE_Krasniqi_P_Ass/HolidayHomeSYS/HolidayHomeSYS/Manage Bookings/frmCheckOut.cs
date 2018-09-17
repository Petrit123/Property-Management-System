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
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

       

        

        private void checkoutbtn_Click(object sender, EventArgs e)
        {
            if(cboBookid.SelectedIndex == -1)
            {
                MessageBox.Show("Error! Please specify the booking id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboBookid.Focus();
                return;
            }

            if(cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Error! Please set the booking status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboStatus.Focus();
                return;
            }

            if (!cboStatus.Text.Equals("C-OUT"))
            {
                MessageBox.Show("Error!Invalid Status. Status must be C-OUT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboStatus.Focus();
                return;
            }

        
           
        }

      

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Bookings.getCheckOuts(ds, DateTime.Now.ToString("yyyy-MM-dd"));

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("Sorry there are no check-outs for today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboBookid.Items.Add(String.Format("{0:00000}", ds.Tables[0].Rows[i][0]) + " " + String.Format("{0:0000000000}", ds.Tables[0].Rows[i][2]) + " " +  ds.Tables[0].Rows[i][8].ToString().Trim() + ", " + ds.Tables[0].Rows[i][9].ToString());
                }
            }
        }

        private void cboBookid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Bookings booking = new Bookings();
            if(cboBookid.SelectedIndex == -1)
            {
                return;
            }

            booking.getBooking(Convert.ToInt32(cboBookid.Text.Substring(0, 5)));
            if (booking.getProp_No().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboBookid.Focus();
                return;
            }

            cboStatus.Text = booking.getBookingStatus();

            grpBookingDetails.Visible = true;
            cboStatus.Focus();
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            Bookings booking = new Bookings();
            if(cboStatus.SelectedIndex == -1)
            {
                return;
            }

            booking.setBooking_Id(Convert.ToInt32(cboBookid.Text.Substring(0, 5)));
            booking.setBooking_Status(cboStatus.Text);


            booking.checkOut();
            Property.propertyCheckInOut(Convert.ToInt32(cboBookid.Text.Substring(7,10)), "A");


            MessageBox.Show("Check - out successful", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cboBookid.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            cboBookid.Focus();
            grpBookingDetails.Visible = false;

            cboBookid.Items.Clear();

            DataSet ds = new DataSet();
            ds = Bookings.getCheckOuts(ds, DateTime.Now.ToString("yyyy-MM-dd"));

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("Sorry there are no check-outs for today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboBookid.Items.Add(String.Format("{0:00000}", ds.Tables[0].Rows[i][0]) + " " + String.Format("{0:0000000000}", ds.Tables[0].Rows[i][2]) + " " + ds.Tables[0].Rows[i][8].ToString().Trim() + ", " + ds.Tables[0].Rows[i][9].ToString());
                }
            }
        }
    }
}
