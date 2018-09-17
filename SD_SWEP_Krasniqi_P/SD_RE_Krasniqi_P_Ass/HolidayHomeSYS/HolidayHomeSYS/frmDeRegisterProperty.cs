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
    public partial class frmDeRegisterProperty : Form
    {
        public frmDeRegisterProperty()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

       

       

        

        private void frmDeRegisterProperty_Load(object sender, EventArgs e)
        {
            

           

            Property myProp = new Property();
            

            DataSet ds = new DataSet();
            grdProp.DataSource = Property.getDeRegProps(ds).Tables["ss"];
            //ds = Property.getProp(ds);

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("Sorry there are no unused properties to deregister.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
           

            Property myProp = new Property();

            myProp.getProperty(Convert.ToInt16(cboProp.Text));

            if (cboProp.SelectedIndex == -1)
            {
                MessageBox.Show("Prop_No must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProp.Focus();
                return;
            }

            

            String status = myProp.getStatus();

         DialogResult result =   MessageBox.Show("Are you sure you want to deregister property " + cboProp.Text,"",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else if (result == DialogResult.Yes)
            {

                if (status == "D")
                {
                    MessageBox.Show("Property already D-registered");
                    cboProp.Focus();
                }
                else
                {
                    myProp.setStatus("D");

                    myProp.updPropertyStatus();

                    cboProp.Items.Clear();

                    DataSet ds = new DataSet();

                    MessageBox.Show("Property " + cboProp.Text + " De-Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grdProp.DataSource = Property.getDeRegProps(ds).Tables["ss"];
                    if (ds.Tables["ss"].Rows.Count == 0)
                    {
                        MessageBox.Show("Sorry there are no unused properties to deregister.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                        {
                            cboProp.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                        }
                    }
                }
            }

            }
        }
}
