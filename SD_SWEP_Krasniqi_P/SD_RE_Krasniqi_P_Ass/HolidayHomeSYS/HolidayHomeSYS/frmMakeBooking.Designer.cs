namespace HolidayHomeSYS
{
    partial class frmMakeBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMakeBooking = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.arrivalDate = new System.Windows.Forms.DateTimePicker();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.DepartureDate = new System.Windows.Forms.DateTimePicker();
            this.confrimbtn = new System.Windows.Forms.Button();
            this.picCheckIn = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.grdProperties = new System.Windows.Forms.DataGridView();
            this.lblTenantId = new System.Windows.Forms.Label();
            this.txtTenantID = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtBooking = new System.Windows.Forms.TextBox();
            this.lblBookingId = new System.Windows.Forms.Label();
            this.grdDetails = new System.Windows.Forms.GroupBox();
            this.bkDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).BeginInit();
            this.grdDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMakeBooking
            // 
            this.lblMakeBooking.AutoSize = true;
            this.lblMakeBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeBooking.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMakeBooking.Location = new System.Drawing.Point(53, 51);
            this.lblMakeBooking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMakeBooking.Name = "lblMakeBooking";
            this.lblMakeBooking.Size = new System.Drawing.Size(206, 31);
            this.lblMakeBooking.TabIndex = 5;
            this.lblMakeBooking.Text = "Make Booking:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(129, 196);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(81, 20);
            this.lblSurname.TabIndex = 15;
            this.lblSurname.Text = "Surname";
            // 
            // txtSname
            // 
            this.txtSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSname.Location = new System.Drawing.Point(289, 195);
            this.txtSname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(120, 23);
            this.txtSname.TabIndex = 0;
            this.txtSname.TextChanged += new System.EventHandler(this.txtSname_TextChanged);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(129, 252);
            this.lblForename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(90, 20);
            this.lblForename.TabIndex = 17;
            this.lblForename.Text = "Forename";
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(289, 249);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(120, 23);
            this.txtFname.TabIndex = 1;
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            // 
            // arrivalDate
            // 
            this.arrivalDate.CustomFormat = "dd-MMM-yy";
            this.arrivalDate.Location = new System.Drawing.Point(215, 119);
            this.arrivalDate.Margin = new System.Windows.Forms.Padding(2);
            this.arrivalDate.MinDate = new System.DateTime(2018, 4, 24, 12, 20, 31, 0);
            this.arrivalDate.Name = "arrivalDate";
            this.arrivalDate.Size = new System.Drawing.Size(135, 20);
            this.arrivalDate.TabIndex = 0;
            this.arrivalDate.Value = new System.DateTime(2018, 4, 24, 12, 20, 31, 0);
            this.arrivalDate.ValueChanged += new System.EventHandler(this.arrivalDate_ValueChanged);
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalDate.Location = new System.Drawing.Point(55, 119);
            this.lblArrivalDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(103, 20);
            this.lblArrivalDate.TabIndex = 19;
            this.lblArrivalDate.Text = "Arrival Date";
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureDate.Location = new System.Drawing.Point(55, 175);
            this.lblDepartureDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(134, 20);
            this.lblDepartureDate.TabIndex = 21;
            this.lblDepartureDate.Text = "Departure Date";
            // 
            // DepartureDate
            // 
            this.DepartureDate.CustomFormat = "dd-MMM-yy";
            this.DepartureDate.Location = new System.Drawing.Point(215, 177);
            this.DepartureDate.Margin = new System.Windows.Forms.Padding(2);
            this.DepartureDate.MinDate = new System.DateTime(2018, 4, 24, 0, 0, 0, 0);
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.Size = new System.Drawing.Size(135, 20);
            this.DepartureDate.TabIndex = 1;
            this.DepartureDate.ValueChanged += new System.EventHandler(this.DepartureDate_ValueChanged);
            // 
            // confrimbtn
            // 
            this.confrimbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrimbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.confrimbtn.Location = new System.Drawing.Point(286, 442);
            this.confrimbtn.Margin = new System.Windows.Forms.Padding(2);
            this.confrimbtn.Name = "confrimbtn";
            this.confrimbtn.Size = new System.Drawing.Size(121, 48);
            this.confrimbtn.TabIndex = 4;
            this.confrimbtn.Text = "Confirm";
            this.confrimbtn.UseVisualStyleBackColor = true;
            this.confrimbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // picCheckIn
            // 
            this.picCheckIn.Image = global::HolidayHomeSYS.Properties.Resources.confirm;
            this.picCheckIn.Location = new System.Drawing.Point(370, 38);
            this.picCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.picCheckIn.Name = "picCheckIn";
            this.picCheckIn.Size = new System.Drawing.Size(219, 244);
            this.picCheckIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckIn.TabIndex = 40;
            this.picCheckIn.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBack.Location = new System.Drawing.Point(2, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 37);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(59, 306);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(65, 20);
            this.lblCounty.TabIndex = 61;
            this.lblCounty.Text = "County";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(59, 239);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 20);
            this.lblType.TabIndex = 58;
            this.lblType.Text = "Type";
            // 
            // cboCounty
            // 
            this.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cboCounty.Location = new System.Drawing.Point(215, 314);
            this.cboCounty.Margin = new System.Windows.Forms.Padding(2);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(120, 24);
            this.cboCounty.TabIndex = 3;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "H",
            "A"});
            this.cboType.Location = new System.Drawing.Point(215, 240);
            this.cboType.Margin = new System.Windows.Forms.Padding(2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(120, 24);
            this.cboType.TabIndex = 2;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.Searchbtn.Location = new System.Drawing.Point(154, 478);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(120, 57);
            this.Searchbtn.TabIndex = 4;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // grdProperties
            // 
            this.grdProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProperties.Location = new System.Drawing.Point(603, 29);
            this.grdProperties.Margin = new System.Windows.Forms.Padding(2);
            this.grdProperties.Name = "grdProperties";
            this.grdProperties.ReadOnly = true;
            this.grdProperties.RowTemplate.Height = 24;
            this.grdProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProperties.Size = new System.Drawing.Size(843, 281);
            this.grdProperties.TabIndex = 69;
            this.grdProperties.Visible = false;
            this.grdProperties.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProperties_CellClick);
            this.grdProperties.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProperties_CellContentClick);
            // 
            // lblTenantId
            // 
            this.lblTenantId.AutoSize = true;
            this.lblTenantId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenantId.Location = new System.Drawing.Point(127, 99);
            this.lblTenantId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenantId.Name = "lblTenantId";
            this.lblTenantId.Size = new System.Drawing.Size(89, 20);
            this.lblTenantId.TabIndex = 70;
            this.lblTenantId.Text = "Tenant ID";
            // 
            // txtTenantID
            // 
            this.txtTenantID.Enabled = false;
            this.txtTenantID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenantID.Location = new System.Drawing.Point(289, 99);
            this.txtTenantID.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenantID.Multiline = true;
            this.txtTenantID.Name = "txtTenantID";
            this.txtTenantID.Size = new System.Drawing.Size(71, 26);
            this.txtTenantID.TabIndex = 72;
            this.txtTenantID.Text = "0001";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(129, 303);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(127, 20);
            this.lblPhone.TabIndex = 74;
            this.lblPhone.Text = "Phone Number";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(288, 303);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(120, 23);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard.Location = new System.Drawing.Point(129, 359);
            this.lblCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(114, 20);
            this.lblCard.TabIndex = 76;
            this.lblCard.Text = "Card Number";
            // 
            // txtCard
            // 
            this.txtCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard.Location = new System.Drawing.Point(288, 356);
            this.txtCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(120, 23);
            this.txtCard.TabIndex = 3;
            this.txtCard.TextChanged += new System.EventHandler(this.txtCard_TextChanged);
            // 
            // txtBooking
            // 
            this.txtBooking.Enabled = false;
            this.txtBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBooking.Location = new System.Drawing.Point(286, 138);
            this.txtBooking.Margin = new System.Windows.Forms.Padding(2);
            this.txtBooking.Multiline = true;
            this.txtBooking.Name = "txtBooking";
            this.txtBooking.Size = new System.Drawing.Size(71, 26);
            this.txtBooking.TabIndex = 83;
            this.txtBooking.Text = "0001";
            // 
            // lblBookingId
            // 
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingId.Location = new System.Drawing.Point(127, 144);
            this.lblBookingId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(98, 20);
            this.lblBookingId.TabIndex = 82;
            this.lblBookingId.Text = "Booking ID";
            // 
            // grdDetails
            // 
            this.grdDetails.Controls.Add(this.bkDetails);
            this.grdDetails.Controls.Add(this.txtBooking);
            this.grdDetails.Controls.Add(this.lblBookingId);
            this.grdDetails.Controls.Add(this.lblCard);
            this.grdDetails.Controls.Add(this.txtCard);
            this.grdDetails.Controls.Add(this.lblTenantId);
            this.grdDetails.Controls.Add(this.lblPhone);
            this.grdDetails.Controls.Add(this.txtSname);
            this.grdDetails.Controls.Add(this.txtPhone);
            this.grdDetails.Controls.Add(this.lblSurname);
            this.grdDetails.Controls.Add(this.txtTenantID);
            this.grdDetails.Controls.Add(this.txtFname);
            this.grdDetails.Controls.Add(this.lblForename);
            this.grdDetails.Controls.Add(this.confrimbtn);
            this.grdDetails.Location = new System.Drawing.Point(603, 335);
            this.grdDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grdDetails.Name = "grdDetails";
            this.grdDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grdDetails.Size = new System.Drawing.Size(617, 513);
            this.grdDetails.TabIndex = 81;
            this.grdDetails.TabStop = false;
            this.grdDetails.Text = "Property Booking Details";
            this.grdDetails.Visible = false;
            // 
            // bkDetails
            // 
            this.bkDetails.AutoSize = true;
            this.bkDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkDetails.ForeColor = System.Drawing.Color.DarkRed;
            this.bkDetails.Location = new System.Drawing.Point(116, 20);
            this.bkDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bkDetails.Name = "bkDetails";
            this.bkDetails.Size = new System.Drawing.Size(211, 31);
            this.bkDetails.TabIndex = 84;
            this.bkDetails.Text = "Booking Details:";
            // 
            // frmMakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 810);
            this.Controls.Add(this.grdDetails);
            this.Controls.Add(this.grdProperties);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cboCounty);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picCheckIn);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.DepartureDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.arrivalDate);
            this.Controls.Add(this.lblMakeBooking);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMakeBooking";
            this.Text = "MakeBooking";
            this.Load += new System.EventHandler(this.frmMakeBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).EndInit();
            this.grdDetails.ResumeLayout(false);
            this.grdDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMakeBooking;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.DateTimePicker arrivalDate;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.DateTimePicker DepartureDate;
        private System.Windows.Forms.Button confrimbtn;
        private System.Windows.Forms.PictureBox picCheckIn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.DataGridView grdProperties;
        private System.Windows.Forms.Label lblTenantId;
        private System.Windows.Forms.TextBox txtTenantID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtBooking;
        private System.Windows.Forms.Label lblBookingId;
        private System.Windows.Forms.GroupBox grdDetails;
        private System.Windows.Forms.Label bkDetails;
    }
}