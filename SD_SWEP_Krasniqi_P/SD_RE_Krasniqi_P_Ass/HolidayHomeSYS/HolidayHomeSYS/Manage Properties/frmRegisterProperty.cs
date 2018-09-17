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
    public partial class frmRegisterProperty : Form
    {
        public frmRegisterProperty()
        {
            InitializeComponent();
        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMain = new frmMainMenu();
            frmMain.Show();
            this.Close();
        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {
            txtStreet.CharacterCasing = CharacterCasing.Upper;
        }

        private void frmRegisterProperty_Load(object sender, EventArgs e)
        {
            txtPropNo.Text = Property.nextProp_No().ToString("0000");
        }

        private void txtTown_TextChanged(object sender, EventArgs e)
        {
            txtTown.CharacterCasing = CharacterCasing.Upper;

            if (txtTown.Text.Any(char.IsDigit))
            {
                MessageBox.Show("This textbox accepts letters only");
                txtTown.Text = "";
                txtTown.Focus();
            }
            
        }

   

        private void txtRent_TextChanged(object sender, EventArgs e)
        {
            

            if (txtRent.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Numbers Only");
                txtRent.Text = "";
                txtRent.Focus();
            }
            
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
           


           

            //validate data
            if(txtStreet.Text.Equals(""))
            {
                MessageBox.Show("Error! Please enter the street", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return;

            }

            if(txtTown.Text.Equals("") || txtTown.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Error! Please enter a valid town", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }

           

            if (txtRent.Text.Equals("") || txtRent.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Error! Please enter a valid rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRent.Focus();
                return;
            }

            if(string.IsNullOrEmpty(cboBeds.Text))
            {
                MessageBox.Show("Error! Please specify the number of beds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboBeds.Focus();
                return;
            }

            if(string.IsNullOrEmpty(cboType.Text))
            {
                MessageBox.Show("Error! Please specify the property type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboType.Focus();
                return;
            }

            if(string.IsNullOrEmpty(cboCounty.Text))
            {
                MessageBox.Show("Error! Please specify the county", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCounty.Focus();
                return;
            }

            //save data in database
           

            Property property = new Property();
            property.setProp_No(Convert.ToInt16(txtPropNo.Text));
            property.setNo_beds(Convert.ToInt32(cboBeds.Text));
            property.setType(cboType.Text);
            property.setStreet(txtStreet.Text);
            property.setTown(txtTown.Text);
            property.setCounty(cboCounty.Text);
            property.setStatus("A");
            property.setRent(Convert.ToDecimal(txtRent.Text));
            //property.setGarage(radGarageY.Text);
            //property.setGarden(radGdnY.Text);

            if(radGarageY.Checked == true)
            {
                property.setGarage(radGarageY.Text);
            }
            else if(radGarageN.Checked == true)
            {
                property.setGarage(radGarageN.Text);
            }

            if(radGdnY.Checked == true)
            {
                property.setGarden(radGdnY.Text);
            }
            else if(radGdnN.Checked == true)
            {
                property.setGarden(radGdnN.Text);
            }


            //display confirmation message
            MessageBox.Show("Property " + txtPropNo.Text + " registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            property.regProperty();
            txtPropNo.Text = Property.nextProp_No().ToString("0000");


            //Reset UI

            cboType.SelectedIndex = -1;
            cboBeds.SelectedIndex = -1;
            cboCounty.SelectedIndex = -1;
            txtStreet.Text = "";
            txtTown.Text = "";
            txtRent.Text = "";
            radGarageY.Checked = true;
            radGdnY.Checked = true;
            cboBeds.Focus();
            return;
        }

        
    }
}
