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
    public partial class frmIssueInvoice : Form
    {
        private Label lblAmount;
        private TextBox txtAmount;
        private TextBox txtPropNo;
        private Label lblPropNo;
        private Label lblDeparture;
        private DateTimePicker departureDate;
        private Label lblArrival;
        private DateTimePicker arrivalDate;
        private Label lblForename;
        private TextBox txtFname;
        private Label lblSurname;
        private TextBox txtSname;
        private Label lblBookingDetails;
        private Button btnPrint;
        private PictureBox picInvoice;
        private Button btnBack;
        private GroupBox grpDetails;
        private ComboBox cboBookid;
        private DateTimePicker dtpArrDate;
        private Label lblBookingID;

        public frmIssueInvoice()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPropNo = new System.Windows.Forms.TextBox();
            this.lblPropNo = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.lblArrival = new System.Windows.Forms.Label();
            this.arrivalDate = new System.Windows.Forms.DateTimePicker();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.lblBookingDetails = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.picInvoice = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.cboBookid = new System.Windows.Forms.ComboBox();
            this.dtpArrDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picInvoice)).BeginInit();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBookingID.Location = new System.Drawing.Point(101, 75);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(166, 31);
            this.lblBookingID.TabIndex = 42;
            this.lblBookingID.Text = "Booking ID:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(73, 500);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 20);
            this.lblAmount.TabIndex = 66;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(311, 491);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(104, 38);
            this.txtAmount.TabIndex = 5;
            // 
            // txtPropNo
            // 
            this.txtPropNo.Enabled = false;
            this.txtPropNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropNo.Location = new System.Drawing.Point(311, 115);
            this.txtPropNo.Multiline = true;
            this.txtPropNo.Name = "txtPropNo";
            this.txtPropNo.Size = new System.Drawing.Size(65, 42);
            this.txtPropNo.TabIndex = 0;
            // 
            // lblPropNo
            // 
            this.lblPropNo.AutoSize = true;
            this.lblPropNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropNo.Location = new System.Drawing.Point(73, 115);
            this.lblPropNo.Name = "lblPropNo";
            this.lblPropNo.Size = new System.Drawing.Size(143, 20);
            this.lblPropNo.TabIndex = 63;
            this.lblPropNo.Text = "Property Number";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparture.Location = new System.Drawing.Point(73, 426);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(134, 20);
            this.lblDeparture.TabIndex = 62;
            this.lblDeparture.Text = "Departure Date";
            // 
            // departureDate
            // 
            this.departureDate.Enabled = false;
            this.departureDate.Location = new System.Drawing.Point(311, 429);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(200, 20);
            this.departureDate.TabIndex = 4;
            this.departureDate.ValueChanged += new System.EventHandler(this.departureDate_ValueChanged);
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrival.Location = new System.Drawing.Point(73, 350);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(103, 20);
            this.lblArrival.TabIndex = 60;
            this.lblArrival.Text = "Arrival Date";
            // 
            // arrivalDate
            // 
            this.arrivalDate.Enabled = false;
            this.arrivalDate.Location = new System.Drawing.Point(311, 350);
            this.arrivalDate.MinDate = new System.DateTime(2017, 12, 8, 0, 0, 0, 0);
            this.arrivalDate.Name = "arrivalDate";
            this.arrivalDate.Size = new System.Drawing.Size(200, 20);
            this.arrivalDate.TabIndex = 3;
            this.arrivalDate.Value = new System.DateTime(2017, 12, 8, 0, 0, 0, 0);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(73, 272);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(90, 20);
            this.lblForename.TabIndex = 58;
            this.lblForename.Text = "Forename";
            // 
            // txtFname
            // 
            this.txtFname.Enabled = false;
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(311, 271);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(178, 23);
            this.txtFname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(73, 195);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(81, 20);
            this.lblSurname.TabIndex = 56;
            this.lblSurname.Text = "Surname";
            // 
            // txtSname
            // 
            this.txtSname.Enabled = false;
            this.txtSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSname.Location = new System.Drawing.Point(311, 194);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(178, 23);
            this.txtSname.TabIndex = 1;
            // 
            // lblBookingDetails
            // 
            this.lblBookingDetails.AutoSize = true;
            this.lblBookingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDetails.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBookingDetails.Location = new System.Drawing.Point(70, 31);
            this.lblBookingDetails.Name = "lblBookingDetails";
            this.lblBookingDetails.Size = new System.Drawing.Size(227, 31);
            this.lblBookingDetails.TabIndex = 67;
            this.lblBookingDetails.Text = "Booking Details:";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPrint.Location = new System.Drawing.Point(330, 601);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(193, 74);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // picInvoice
            // 
            this.picInvoice.Image = global::HolidayHomeSYS.Properties.Resources.invoice;
            this.picInvoice.Location = new System.Drawing.Point(581, 130);
            this.picInvoice.Name = "picInvoice";
            this.picInvoice.Size = new System.Drawing.Size(289, 368);
            this.picInvoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInvoice.TabIndex = 69;
            this.picInvoice.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(169, 51);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.picInvoice);
            this.grpDetails.Controls.Add(this.btnPrint);
            this.grpDetails.Controls.Add(this.lblBookingDetails);
            this.grpDetails.Controls.Add(this.lblAmount);
            this.grpDetails.Controls.Add(this.txtAmount);
            this.grpDetails.Controls.Add(this.txtPropNo);
            this.grpDetails.Controls.Add(this.lblPropNo);
            this.grpDetails.Controls.Add(this.lblDeparture);
            this.grpDetails.Controls.Add(this.departureDate);
            this.grpDetails.Controls.Add(this.lblArrival);
            this.grpDetails.Controls.Add(this.arrivalDate);
            this.grpDetails.Controls.Add(this.lblForename);
            this.grpDetails.Controls.Add(this.txtFname);
            this.grpDetails.Controls.Add(this.lblSurname);
            this.grpDetails.Controls.Add(this.txtSname);
            this.grpDetails.Location = new System.Drawing.Point(31, 196);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(887, 687);
            this.grpDetails.TabIndex = 71;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Booking Details";
            this.grpDetails.Visible = false;
            // 
            // cboBookid
            // 
            this.cboBookid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookid.FormattingEnabled = true;
            this.cboBookid.Location = new System.Drawing.Point(329, 90);
            this.cboBookid.Name = "cboBookid";
            this.cboBookid.Size = new System.Drawing.Size(239, 21);
            this.cboBookid.TabIndex = 72;
            this.cboBookid.SelectedIndexChanged += new System.EventHandler(this.cboBookid_SelectedIndexChanged);
            // 
            // dtpArrDate
            // 
            this.dtpArrDate.Location = new System.Drawing.Point(322, 43);
            this.dtpArrDate.MaxDate = new System.DateTime(2018, 4, 24, 17, 36, 4, 0);
            this.dtpArrDate.Name = "dtpArrDate";
            this.dtpArrDate.Size = new System.Drawing.Size(246, 20);
            this.dtpArrDate.TabIndex = 73;
            this.dtpArrDate.Value = new System.DateTime(2018, 4, 24, 0, 0, 0, 0);
            this.dtpArrDate.ValueChanged += new System.EventHandler(this.dtpArrDate_ValueChanged);
            // 
            // frmIssueInvoice
            // 
            this.ClientSize = new System.Drawing.Size(926, 906);
            this.Controls.Add(this.dtpArrDate);
            this.Controls.Add(this.cboBookid);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBookingID);
            this.Name = "frmIssueInvoice";
            this.Load += new System.EventHandler(this.frmIssueInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picInvoice)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

       

        

        

      
    

        private void btnPrint_Click(object sender, EventArgs e)
        {
           

            
            
            
                MessageBox.Show("Invoice Printed","Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);

            
            txtPropNo.Text = "";
            txtSname.Text = "";
            txtFname.Text = "";
            txtAmount.Text = "";
            cboBookid.SelectedIndex = -1;
            grpDetails.Visible = false;
            return;
        }

     



























































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































        private void departureDate_ValueChanged(object sender, EventArgs e)
        {
            departureDate.MinDate = arrivalDate.Value;
        }

        private void frmIssueInvoice_Load(object sender, EventArgs e)
        {
          
        }

        private void cboBookid_SelectedIndexChanged(object sender, EventArgs e)
        {
            Property invoice = new Property();
            //invoice.getBooking(Convert.ToInt16(cboBookid.Text.Substring(0, 5)));

            if(cboBookid.SelectedIndex == -1)
            {
                return;
            }

            invoice.issueInvoice(Convert.ToInt32(cboBookid.Text.Substring(0,5)));
           

            //txtBookid.Text = invoice.getBookingID().ToString();
            txtPropNo.Text = invoice.getProp_No().ToString();
            txtSname.Text = invoice.getSurname();
            txtFname.Text = invoice.getForename();
            arrivalDate.Text = invoice.getArrivalDate().ToString();
            departureDate.Text = invoice.getDepartureDate().ToString();
            txtAmount.Text = invoice.getRent().ToString();

            grpDetails.Visible = true;
        }

        private void dtpArrDate_ValueChanged(object sender, EventArgs e)
        {
            cboBookid.SelectedIndex = -1;
            DataSet ds = new DataSet();
            ds = Property.getInvoice(ds, String.Format("{0:dd-MMM-yy}",dtpArrDate.Value));

            if (ds.Tables["ss"].Rows.Count == 0)
            {
                MessageBox.Show("Sorry there are no check-outs for today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                {
                    cboBookid.Items.Add(String.Format("{0:00000}", ds.Tables[0].Rows[i][0]) + " " + ds.Tables[0].Rows[i][8].ToString().Trim() + ", " + ds.Tables[0].Rows[i][9].ToString());
                }
            }
        }
    }
}
