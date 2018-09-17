using HolidayHomeSYS.Classes;
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
    public partial class frmCheckIn : Form
    {
        public frmCheckIn()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private void txtPropNo_TextChanged(object sender, EventArgs e)
        {
            if (txtPropNo.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Numbers Only");
                txtPropNo.Focus();
                return;
            }
            
        }

     

       

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Numbers Only");
                txtAmount.Focus();
                return;
            }
            
        }


      
        
       

        

       

        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Bookings.getCheckIns(ds, DateTime.Now.ToString("yyyy-MM-dd"));

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("Sorry there are no check-ins for today.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboBookingID.Items.Add(String.Format("{0:00000}", ds.Tables[0].Rows[i][0]) + " " + ds.Tables[0].Rows[i][8].ToString().Trim() + ", "  + ds.Tables[0].Rows[i][9].ToString());
                }
            }
        }

        private void cboBookingID_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            Bookings booking = new Bookings();

           

            if (cboBookingID.SelectedIndex == -1)
            {
                return;
            }

            booking.getBooking(Convert.ToInt32(cboBookingID.Text.Substring(0, 5)));







            if (booking.getProp_No().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropNo.Focus();
                return;
            }

            



            txtBooking.Text = booking.getBooking_Id().ToString();
            txtTenant.Text = booking.getTenant_Id().ToString();
            txtPropNo.Text = booking.getProp_No().ToString();
            arrivaleDate.Text = booking.getDateFrom().ToString();
            departureDate.Text = booking.getDateTo().ToString();
            txtAmount.Text = booking.getAmount().ToString();
            cmbStatus.Text = booking.getBookingStatus();





            grpBookingDetails.Visible = true;
            cmbStatus.Focus();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Error! Please fill in the booking status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbStatus.Focus();
                return;
            }





          

            Bookings booking = new Bookings();
            Payments payments = new Payments();

            booking.setBooking_Id(Convert.ToInt32(txtBooking.Text));
            booking.setBooking_Status(cmbStatus.Text);
            payments.setPaymentID(Payments.nextPayment_Id());
            booking.setTenant_Id(Convert.ToInt32(txtTenant.Text));
            payments.setTenantID(Convert.ToInt32(txtTenant.Text));
            String.Format("{0:dd-MMM-yy}", arrivaleDate.Value);
            booking.setDateFrom(arrivaleDate.Value);
            payments.setDatePaid(arrivaleDate.Value);
            booking.setAmount(Convert.ToDouble(txtAmount.Text));
            payments.setAmount(Convert.ToDouble(txtAmount.Text));



            booking.checkIn();
            Property.propertyCheckInOut(Convert.ToInt32(txtPropNo.Text), "O");
            payments.recordPayment();


            MessageBox.Show("Check - in successful", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboBookingID.SelectedIndex = -1;
            txtPropNo.Text = "";
            txtAmount.Text = "";
            cboBookingID.Focus();
            grpBookingDetails.Visible = false;
            
            cboBookingID.Items.Clear();
            
            DataSet ds = new DataSet();
            ds = Bookings.getCheckIns(ds, DateTime.Now.ToString("yyyy-MM-dd"));

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("Sorry there are no check-ins for today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboBookingID.Items.Add(String.Format("{0:00000}", ds.Tables[0].Rows[i][0]) + " " + ds.Tables[0].Rows[i][8].ToString().Trim() + ", " + ds.Tables[0].Rows[i][9].ToString());
                }
            }




        }
    }
}
