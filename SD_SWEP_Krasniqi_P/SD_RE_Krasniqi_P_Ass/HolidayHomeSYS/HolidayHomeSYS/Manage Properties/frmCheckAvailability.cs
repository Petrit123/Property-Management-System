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
    public partial class frmCheckAvailability : Form
    {
        public frmCheckAvailability()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

     

        

        

        

        private void frmCheckAvailability_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            grdProperties.DataSource = Property.searchPropertyAvail(ds).Tables["ss"];

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("Sorry there are no deregistered properties to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboProp.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }

        }

        private void cboProp_SelectedIndexChanged(object sender, EventArgs e)
        {

            Property updProperty = new Property();

            if(cboProp.SelectedIndex == -1)
            {
                return;
            }

            updProperty.getProperty(Convert.ToInt16(cboProp.Text));

           





            Property updPropertyStatus = new Property();
            updPropertyStatus.getProperty(Convert.ToInt16(cboProp.Text));

            

            cboStatus.Text = updProperty.getStatus();


            grpStatus.Visible = true;
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cboStatus.SelectedIndex == -1)
            {
                return;
            }


            Property myProp = new Property();

            String status = myProp.getStatus();
            status = cboStatus.Text;

            myProp.setProp_No(Convert.ToInt16(cboProp.Text));


            myProp.setStatus(cboStatus.Text);






            myProp.updPropertyStatus();

            MessageBox.Show("Property " + cboProp.Text + " Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            cboProp.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            cboProp.Focus();
            grpStatus.Visible = false;
            DataSet ds = new DataSet();

            grdProperties.DataSource = Property.searchProperty2(ds).Tables["ss"];
            return;
        }
    }
}
