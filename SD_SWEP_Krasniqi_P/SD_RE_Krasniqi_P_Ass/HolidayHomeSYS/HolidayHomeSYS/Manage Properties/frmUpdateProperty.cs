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
    public partial class frmUpdateProperty : Form
    {
        private Label lblPropNo;
        private Label lblRent;
        private Label lblNoBeds;
        private TextBox txtRent;
        private RadioButton radGardenN;
        private RadioButton radGardenY;
        private RadioButton radGarageN;
        private RadioButton radGarageY;
        private ComboBox cmboBeds;
        private Button btnUpdate;
        private PictureBox pictUpdate;
        private Button btnBack;
        private GroupBox grpBoxGarage;
        private GroupBox grpBoxGarden;
        private GroupBox grpProperty;
        private Label lblStatus;
        private DataGridView grdProperties;
        private ComboBox cboProp;
        private ComboBox cboStatus;
        private Label lblPropDetails;

        public frmUpdateProperty()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblPropNo = new System.Windows.Forms.Label();
            this.lblPropDetails = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.lblNoBeds = new System.Windows.Forms.Label();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.radGardenN = new System.Windows.Forms.RadioButton();
            this.radGardenY = new System.Windows.Forms.RadioButton();
            this.radGarageN = new System.Windows.Forms.RadioButton();
            this.radGarageY = new System.Windows.Forms.RadioButton();
            this.cmboBeds = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictUpdate = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpBoxGarage = new System.Windows.Forms.GroupBox();
            this.grpBoxGarden = new System.Windows.Forms.GroupBox();
            this.grpProperty = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grdProperties = new System.Windows.Forms.DataGridView();
            this.cboProp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictUpdate)).BeginInit();
            this.grpBoxGarage.SuspendLayout();
            this.grpBoxGarden.SuspendLayout();
            this.grpProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPropNo
            // 
            this.lblPropNo.AutoSize = true;
            this.lblPropNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropNo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPropNo.Location = new System.Drawing.Point(56, 105);
            this.lblPropNo.Name = "lblPropNo";
            this.lblPropNo.Size = new System.Drawing.Size(252, 31);
            this.lblPropNo.TabIndex = 0;
            this.lblPropNo.Text = " Property Number:";
            // 
            // lblPropDetails
            // 
            this.lblPropDetails.AutoSize = true;
            this.lblPropDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropDetails.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPropDetails.Location = new System.Drawing.Point(18, 46);
            this.lblPropDetails.Name = "lblPropDetails";
            this.lblPropDetails.Size = new System.Drawing.Size(452, 31);
            this.lblPropDetails.TabIndex = 2;
            this.lblPropDetails.Text = "Enter Updated Details of Propety:";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRent.Location = new System.Drawing.Point(43, 543);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(48, 20);
            this.lblRent.TabIndex = 36;
            this.lblRent.Text = "Rent";
            // 
            // lblNoBeds
            // 
            this.lblNoBeds.AutoSize = true;
            this.lblNoBeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBeds.Location = new System.Drawing.Point(42, 169);
            this.lblNoBeds.Name = "lblNoBeds";
            this.lblNoBeds.Size = new System.Drawing.Size(77, 20);
            this.lblNoBeds.TabIndex = 29;
            this.lblNoBeds.Text = "No Beds";
            // 
            // txtRent
            // 
            this.txtRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRent.Location = new System.Drawing.Point(137, 543);
            this.txtRent.Multiline = true;
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(104, 38);
            this.txtRent.TabIndex = 4;
            this.txtRent.TextChanged += new System.EventHandler(this.txtRent_TextChanged);
            // 
            // radGardenN
            // 
            this.radGardenN.AutoSize = true;
            this.radGardenN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGardenN.Location = new System.Drawing.Point(147, 23);
            this.radGardenN.Name = "radGardenN";
            this.radGardenN.Size = new System.Drawing.Size(34, 19);
            this.radGardenN.TabIndex = 27;
            this.radGardenN.Text = "N";
            this.radGardenN.UseVisualStyleBackColor = true;
            // 
            // radGardenY
            // 
            this.radGardenY.AutoSize = true;
            this.radGardenY.Checked = true;
            this.radGardenY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGardenY.Location = new System.Drawing.Point(37, 20);
            this.radGardenY.Name = "radGardenY";
            this.radGardenY.Size = new System.Drawing.Size(32, 19);
            this.radGardenY.TabIndex = 26;
            this.radGardenY.TabStop = true;
            this.radGardenY.Text = "Y";
            this.radGardenY.UseVisualStyleBackColor = true;
            // 
            // radGarageN
            // 
            this.radGarageN.AutoSize = true;
            this.radGarageN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGarageN.Location = new System.Drawing.Point(155, 25);
            this.radGarageN.Name = "radGarageN";
            this.radGarageN.Size = new System.Drawing.Size(34, 19);
            this.radGarageN.TabIndex = 25;
            this.radGarageN.Text = "N";
            this.radGarageN.UseVisualStyleBackColor = true;
            // 
            // radGarageY
            // 
            this.radGarageY.AutoSize = true;
            this.radGarageY.Checked = true;
            this.radGarageY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGarageY.Location = new System.Drawing.Point(43, 25);
            this.radGarageY.Name = "radGarageY";
            this.radGarageY.Size = new System.Drawing.Size(32, 19);
            this.radGarageY.TabIndex = 24;
            this.radGarageY.TabStop = true;
            this.radGarageY.Text = "Y";
            this.radGarageY.UseVisualStyleBackColor = true;
            // 
            // cmboBeds
            // 
            this.cmboBeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBeds.FormattingEnabled = true;
            this.cmboBeds.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmboBeds.Location = new System.Drawing.Point(173, 169);
            this.cmboBeds.Name = "cmboBeds";
            this.cmboBeds.Size = new System.Drawing.Size(74, 24);
            this.cmboBeds.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.Location = new System.Drawing.Point(338, 561);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(181, 74);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictUpdate
            // 
            this.pictUpdate.Image = global::HolidayHomeSYS.Properties.Resources.update1;
            this.pictUpdate.Location = new System.Drawing.Point(429, 149);
            this.pictUpdate.Name = "pictUpdate";
            this.pictUpdate.Size = new System.Drawing.Size(250, 284);
            this.pictUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictUpdate.TabIndex = 38;
            this.pictUpdate.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBack.Location = new System.Drawing.Point(34, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 51);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpBoxGarage
            // 
            this.grpBoxGarage.Controls.Add(this.radGarageN);
            this.grpBoxGarage.Controls.Add(this.radGarageY);
            this.grpBoxGarage.Location = new System.Drawing.Point(47, 249);
            this.grpBoxGarage.Name = "grpBoxGarage";
            this.grpBoxGarage.Size = new System.Drawing.Size(244, 74);
            this.grpBoxGarage.TabIndex = 1;
            this.grpBoxGarage.TabStop = false;
            this.grpBoxGarage.Text = "Garage?";
            // 
            // grpBoxGarden
            // 
            this.grpBoxGarden.Controls.Add(this.radGardenN);
            this.grpBoxGarden.Controls.Add(this.radGardenY);
            this.grpBoxGarden.Location = new System.Drawing.Point(53, 351);
            this.grpBoxGarden.Name = "grpBoxGarden";
            this.grpBoxGarden.Size = new System.Drawing.Size(238, 82);
            this.grpBoxGarden.TabIndex = 2;
            this.grpBoxGarden.TabStop = false;
            this.grpBoxGarden.Text = "Garden?";
            // 
            // grpProperty
            // 
            this.grpProperty.Controls.Add(this.cboStatus);
            this.grpProperty.Controls.Add(this.lblStatus);
            this.grpProperty.Controls.Add(this.grpBoxGarden);
            this.grpProperty.Controls.Add(this.grpBoxGarage);
            this.grpProperty.Controls.Add(this.pictUpdate);
            this.grpProperty.Controls.Add(this.btnUpdate);
            this.grpProperty.Controls.Add(this.lblRent);
            this.grpProperty.Controls.Add(this.lblNoBeds);
            this.grpProperty.Controls.Add(this.txtRent);
            this.grpProperty.Controls.Add(this.cmboBeds);
            this.grpProperty.Controls.Add(this.lblPropDetails);
            this.grpProperty.Location = new System.Drawing.Point(34, 157);
            this.grpProperty.Name = "grpProperty";
            this.grpProperty.Size = new System.Drawing.Size(715, 641);
            this.grpProperty.TabIndex = 46;
            this.grpProperty.TabStop = false;
            this.grpProperty.Text = "Property Details";
            this.grpProperty.Visible = false;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "A",
            "D"});
            this.cboStatus.Location = new System.Drawing.Point(149, 474);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(50, 21);
            this.cboStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(43, 470);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "Status";
            // 
            // grdProperties
            // 
            this.grdProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProperties.Location = new System.Drawing.Point(778, 157);
            this.grdProperties.Name = "grdProperties";
            this.grdProperties.ReadOnly = true;
            this.grdProperties.Size = new System.Drawing.Size(890, 255);
            this.grdProperties.TabIndex = 47;
            // 
            // cboProp
            // 
            this.cboProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProp.FormattingEnabled = true;
            this.cboProp.Location = new System.Drawing.Point(432, 120);
            this.cboProp.Name = "cboProp";
            this.cboProp.Size = new System.Drawing.Size(121, 21);
            this.cboProp.TabIndex = 48;
            this.cboProp.SelectedIndexChanged += new System.EventHandler(this.cboProp_SelectedIndexChanged);
            // 
            // frmUpdateProperty
            // 
            this.ClientSize = new System.Drawing.Size(1827, 836);
            this.Controls.Add(this.cboProp);
            this.Controls.Add(this.grdProperties);
            this.Controls.Add(this.grpProperty);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPropNo);
            this.Name = "frmUpdateProperty";
            this.Load += new System.EventHandler(this.frmUpdateProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictUpdate)).EndInit();
            this.grpBoxGarage.ResumeLayout(false);
            this.grpBoxGarage.PerformLayout();
            this.grpBoxGarden.ResumeLayout(false);
            this.grpBoxGarden.PerformLayout();
            this.grpProperty.ResumeLayout(false);
            this.grpProperty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu Main = new frmMainMenu();
            Main.Show();
            this.Close();
        }

        

     

        
        private void txtRent_TextChanged(object sender, EventArgs e)
        {
            if(txtRent.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Numbers Only");
                txtRent.Text = "";
                txtRent.Focus();
                return;
            }
        }
      
    

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            



            if(String.IsNullOrEmpty(cmboBeds.Text))
            {
                MessageBox.Show("Error! Please enter the number of beds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmboBeds.Focus();
                return;
            }

            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Error! Please enter the property status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboStatus.Focus();
                return;
            }

            if(txtRent.Text.Equals("") || txtRent.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Error! Please enter a valid rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRent.Focus();
                return;
            }

            Property myProp = new Property();
            String status = myProp.getStatus();
            status = cboStatus.Text;

           

            myProp.setProp_No(Convert.ToInt16(cboProp.Text));
            myProp.setNo_beds(Convert.ToInt32(cmboBeds.Text));
            if(radGarageY.Checked == true)
            {
                myProp.setGarage(radGarageY.Text);
            }
            else if(radGarageN.Checked == true)
            {
                myProp.setGarage(radGarageN.Text);
            }
            
            if(radGardenY.Checked == true)
            {
                myProp.setGarden(radGardenY.Text);
            }
            else if(radGardenN.Checked == true)
            {
                myProp.setGarden(radGardenN.Text);
            }

            myProp.setStatus(cboStatus.Text);

            myProp.setRent(Convert.ToDecimal(txtRent.Text));

            myProp.updProperty();

            MessageBox.Show("Property " + cboProp.Text + " Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);



            

            cboProp.SelectedIndex = -1;
            cmboBeds.SelectedIndex = 0;
            cboStatus.SelectedIndex = -1;
            txtRent.Text = "";
            cboProp.Focus();
            grpProperty.Visible = false;
            DataSet ds = new DataSet();

            grdProperties.DataSource = Property.searchProperty2(ds).Tables["ss"];
            return;
        }

       

        

        private void frmUpdateProperty_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            grdProperties.DataSource = Property.searchProperty2(ds).Tables["ss"];

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("Sorry there are no unused properties to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (cboProp.SelectedIndex == -1)
            {
                return;
            }

            updProperty.getProperty(Convert.ToInt16(cboProp.Text));



            


            cmboBeds.Text = updProperty.getNo_Beds().ToString();
            String garageStatus = "";
            String gardenStatus = "";

            garageStatus = updProperty.getGarage();
            gardenStatus = updProperty.getGarden();


            cboStatus.Text = updProperty.getStatus();
            txtRent.Text = updProperty.getRent().ToString();

            grpProperty.Visible = true;
        }
    }
}
