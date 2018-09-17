using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolidayHomeSYS
{
    public partial class frmMakeBooking : Form
    {
        private DateTimeStyles provider;

        public frmMakeBooking()
        {
            InitializeComponent();
            
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

   

        private void txtSname_TextChanged(object sender, EventArgs e)
        {
            txtSname.CharacterCasing = CharacterCasing.Upper;

            if (txtSname.Text.Equals(""))
                return;

            if (txtSname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Error! This textbox only accepts numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSname.Text = "";
                txtSname.Focus();
                return;
            }
          
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            txtFname.CharacterCasing = CharacterCasing.Upper;

            if (txtFname.Text.Equals(""))
                return;

            if (txtFname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Error! This textbox only accepts numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFname.Text = "";
                txtFname.Focus();
                return;
            }
        }



        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if (arrivalDate.Value.ToString() == "")
            {
                MessageBox.Show("Error! Fields must not be left empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                arrivalDate.Focus();
                return;
            }

            if (DepartureDate.Value.ToString() == "")
            {
                MessageBox.Show("Error! Fields must not be left empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DepartureDate.Focus();
                return;
            }

            if (txtSname.Text.Equals("") || txtSname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSname.Focus();
                return;
            }

            if (txtFname.Text.Equals("") || txtFname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid firstname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFname.Focus();
                return;
            }

            if(txtPhone.Text.Equals("") || txtPhone.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Please enter a valid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if(txtCard.Text.Equals("") || txtCard.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Please enter a valid card number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCard.Focus();
                return;
            }


            String.Format("{0:dd-MMM-yy}", arrivalDate.Value);
            String.Format("{0:dd-MMM-yy}", DepartureDate.Value);

            //DateTime dtArr = Convert.ToDateTime(arrivalDate.Text);
            //DateTime dtDeparr = Convert.ToDateTime(DepartureDate.Text);

            double totalCost = 0;
            int pNo = Convert.ToInt16(grdProperties.SelectedCells[0].Value);
            totalCost = (Convert.ToDateTime(DepartureDate.Text) - Convert.ToDateTime(arrivalDate.Text)).TotalDays * Property.getPropRate(pNo);
           

            Property prop = new Property();
            prop.setTenantID(Convert.ToInt32(txtTenantID.Text));
            prop.setBookingID(Convert.ToInt32(txtBooking.Text));
            prop.setProp_No(Convert.ToInt16(grdProperties.SelectedCells[0].Value));
            prop.setStatus("B");
            prop.setArrivalDate(arrivalDate.Value);
            prop.setDepartureDate(DepartureDate.Value);
            prop.setRent(Convert.ToDecimal(grdProperties.SelectedCells[7].Value));
            prop.setAmount((Convert.ToDateTime(DepartureDate.Text) - Convert.ToDateTime(arrivalDate.Text)).TotalDays * Property.getPropRate(pNo));
            prop.setSurname(txtSname.Text);
            prop.setForename(txtFname.Text);
            prop.setPhonenumber(Convert.ToInt32(txtPhone.Text));
            prop.setCardNumber(Convert.ToInt32(txtCard.Text));

           

            prop.regTenant();
            prop.insertBooking();
            txtTenantID.Text = Property.nextTenant_Id().ToString("0000");
            txtBooking.Text = Property.nextBookingID().ToString("0000");


            MessageBox.Show("Tenant " + txtFname.Text + " " +  txtSname.Text + " has been added successfully","Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);

            confirmBookingBtnWasClicked = true;

          
            cboType.SelectedIndex = -1;
          
            cboCounty.SelectedIndex = -1;
           
            txtSname.Text = "";
            txtFname.Text = "";
            txtPhone.Text = "";
            txtCard.Text = "";
            grdDetails.Visible = false;

            grdProperties.Visible = false;

            

            return;
           
        }

        

        private void DepartureDate_ValueChanged(object sender, EventArgs e)
        {
            DepartureDate.MinDate = (arrivalDate.Value.AddDays(1)) ;
        }

        private void arrivalDate_ValueChanged(object sender, EventArgs e)
        {
            arrivalDate.MinDate = DateTime.Now;
        }

        private void frmMakeBooking_Load(object sender, EventArgs e)
        {
           

            txtTenantID.Text = Property.nextTenant_Id().ToString("0000");
            txtBooking.Text =  Property.nextBookingID().ToString("0000");

          
        }

        private bool searchbtnWasClicked = false;
        private bool confirmBookingBtnWasClicked = false;

       


        private void Searchbtn_Click(object sender, EventArgs e)
        {
            


            if (cboType.SelectedIndex == -1)
            {
                MessageBox.Show("Please specify the property type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboType.Focus();
                return;
            }


            

            if (cboCounty.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter the county", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCounty.Focus();
                return;
            }

            
            
            
                

                searchbtnWasClicked = true;
                confirmBookingBtnWasClicked = false;

                Property prop = new Property();


                DataSet ds = new DataSet();


                String.Format("{0:dd-MMM-yy}", arrivalDate.Value);
                String.Format("{0:dd-MMM-yy}", DepartureDate.Value);

            
            grdProperties.DataSource = Property.matchingProperty(ds,  cboType.Text,  cboCounty.Text.ToUpper(), arrivalDate.Value, DepartureDate.Value).Tables["ss"];
            grdProperties.Visible = true;

            MessageBox.Show("Please click on the property you would like to book","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);


            if (grdProperties.Rows.Count == 1) {
                MessageBox.Show("Sorry no matches found");
            }



           
                cboType.Text = prop.getType();
             
                cboCounty.Text = prop.getCounty();
              

            
           



        }






      
        

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Error! This textbox only accepts numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Text = "";
                txtPhone.Focus();
                return;
            }
        }

        private void txtCard_TextChanged(object sender, EventArgs e)
        {
            if (txtCard.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Error! This textbox only accepts numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCard.Text = "";
                txtCard.Focus();
                return;
            }
        }

        private void grdProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (searchbtnWasClicked == false || confirmBookingBtnWasClicked == true )
            {
                MessageBox.Show("Please search for a property");
                grdDetails.Visible = false;
            }

            if (grdProperties.Rows.Count == 1)
            {
                MessageBox.Show("Sorry no matches found");
            }


            else if (grdProperties.CurrentCell.Selected == true && searchbtnWasClicked == true)
            {
                
                grdDetails.Visible = true;

            }
        }

        private void grdProperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
