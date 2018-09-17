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
            ds = Property.getCheckIns(ds, DateTime.Now.ToString("yyyy-MM-dd"));

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
            Property checkIn = new Property();



            if(cboBookingID.SelectedIndex == -1)
            {
                return;
            }





            checkIn.getBooking(Convert.ToInt32(cboBookingID.Text.Substring(0, 5)));



            if (checkIn.getProp_No().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropNo.Focus();
                return;
            }





            txtBooking.Text = checkIn.getBookingID().ToString();
            txtTenant.Text = checkIn.getTenantID().ToString();
            txtPropNo.Text = checkIn.getProp_No().ToString();
            arrivaleDate.Text = checkIn.getArrivalDate().ToString();
            departureDate.Text = checkIn.getDepartureDate().ToString();
            txtAmount.Text = checkIn.getRent().ToString();
            cmbStatus.Text = checkIn.getStatus();





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





            Property prop = new Property();

            prop.setBookingID(Convert.ToInt32(txtBooking.Text));
            prop.setStatus(cmbStatus.Text);
            prop.setPaymentId(Property.nextPayment_Id());
            prop.setTenantID(Convert.ToInt32(txtTenant.Text));
            String.Format("{0:dd-MMM-yy}", arrivaleDate.Value);
            prop.setArrivalDate(arrivaleDate.Value);
            prop.setRent(Convert.ToDecimal(txtAmount.Text));



            prop.checkIn();
            prop.recordPayment();


            MessageBox.Show("Check - in successful", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboBookingID.SelectedIndex = -1;
            txtPropNo.Text = "";
            //txtSname.Text = "";
            //txtFname.Text = "";
            txtAmount.Text = "";
            //txtStatus.Text = "";
            cboBookingID.Focus();
            grpBookingDetails.Visible = false;

            cboBookingID.Items.Clear();
            DataSet ds = new DataSet();
            ds = Property.getCheckIns(ds, DateTime.Now.ToString("yyyy-MM-dd"));

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("Sorry there are no check-ins for today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboBookingID.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][8].ToString() + ds.Tables[0].Rows[i][9].ToString());
                }
            }




        }
    }
}
