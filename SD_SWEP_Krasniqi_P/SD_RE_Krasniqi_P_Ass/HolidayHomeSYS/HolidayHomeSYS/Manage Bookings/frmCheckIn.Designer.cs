namespace HolidayHomeSYS
{
    partial class frmCheckIn
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
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblBookingDetails = new System.Windows.Forms.Label();
            this.txtPropNo = new System.Windows.Forms.TextBox();
            this.lblPropNo = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.lblArrival = new System.Windows.Forms.Label();
            this.arrivaleDate = new System.Windows.Forms.DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.picCheckIn = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpBookingDetails = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtTenant = new System.Windows.Forms.TextBox();
            this.txtBooking = new System.Windows.Forms.TextBox();
            this.lblTenantID = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.cboBookingID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckIn)).BeginInit();
            this.grpBookingDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBookingID.Location = new System.Drawing.Point(49, 53);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(166, 31);
            this.lblBookingID.TabIndex = 9;
            this.lblBookingID.Text = "Booking ID:";
            // 
            // lblBookingDetails
            // 
            this.lblBookingDetails.AutoSize = true;
            this.lblBookingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDetails.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBookingDetails.Location = new System.Drawing.Point(29, 38);
            this.lblBookingDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingDetails.Name = "lblBookingDetails";
            this.lblBookingDetails.Size = new System.Drawing.Size(227, 31);
            this.lblBookingDetails.TabIndex = 42;
            this.lblBookingDetails.Text = "Booking Details:";
            // 
            // txtPropNo
            // 
            this.txtPropNo.Enabled = false;
            this.txtPropNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropNo.Location = new System.Drawing.Point(189, 187);
            this.txtPropNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPropNo.Multiline = true;
            this.txtPropNo.Name = "txtPropNo";
            this.txtPropNo.Size = new System.Drawing.Size(45, 29);
            this.txtPropNo.TabIndex = 2;
            this.txtPropNo.TextChanged += new System.EventHandler(this.txtPropNo_TextChanged);
            // 
            // lblPropNo
            // 
            this.lblPropNo.AutoSize = true;
            this.lblPropNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropNo.Location = new System.Drawing.Point(38, 187);
            this.lblPropNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPropNo.Name = "lblPropNo";
            this.lblPropNo.Size = new System.Drawing.Size(143, 20);
            this.lblPropNo.TabIndex = 51;
            this.lblPropNo.Text = "Property Number";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparture.Location = new System.Drawing.Point(31, 309);
            this.lblDeparture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(134, 20);
            this.lblDeparture.TabIndex = 50;
            this.lblDeparture.Text = "Departure Date";
            // 
            // departureDate
            // 
            this.departureDate.Enabled = false;
            this.departureDate.Location = new System.Drawing.Point(189, 311);
            this.departureDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(135, 20);
            this.departureDate.TabIndex = 4;
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrival.Location = new System.Drawing.Point(31, 253);
            this.lblArrival.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(103, 20);
            this.lblArrival.TabIndex = 48;
            this.lblArrival.Text = "Arrival Date";
            // 
            // arrivaleDate
            // 
            this.arrivaleDate.Enabled = false;
            this.arrivaleDate.Location = new System.Drawing.Point(189, 255);
            this.arrivaleDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.arrivaleDate.Name = "arrivaleDate";
            this.arrivaleDate.Size = new System.Drawing.Size(135, 20);
            this.arrivaleDate.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(31, 356);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 20);
            this.lblAmount.TabIndex = 54;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(189, 350);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(71, 26);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // picCheckIn
            // 
            this.picCheckIn.Image = global::HolidayHomeSYS.Properties.Resources.checkIn;
            this.picCheckIn.Location = new System.Drawing.Point(402, 89);
            this.picCheckIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCheckIn.Name = "picCheckIn";
            this.picCheckIn.Size = new System.Drawing.Size(204, 286);
            this.picCheckIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckIn.TabIndex = 56;
            this.picCheckIn.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(31, 412);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 57;
            this.lblStatus.Text = "Status";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBack.Location = new System.Drawing.Point(7, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 37);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpBookingDetails
            // 
            this.grpBookingDetails.Controls.Add(this.cmbStatus);
            this.grpBookingDetails.Controls.Add(this.txtTenant);
            this.grpBookingDetails.Controls.Add(this.txtBooking);
            this.grpBookingDetails.Controls.Add(this.lblTenantID);
            this.grpBookingDetails.Controls.Add(this.lblBookID);
            this.grpBookingDetails.Controls.Add(this.lblStatus);
            this.grpBookingDetails.Controls.Add(this.picCheckIn);
            this.grpBookingDetails.Controls.Add(this.lblAmount);
            this.grpBookingDetails.Controls.Add(this.txtAmount);
            this.grpBookingDetails.Controls.Add(this.txtPropNo);
            this.grpBookingDetails.Controls.Add(this.lblPropNo);
            this.grpBookingDetails.Controls.Add(this.lblDeparture);
            this.grpBookingDetails.Controls.Add(this.departureDate);
            this.grpBookingDetails.Controls.Add(this.lblArrival);
            this.grpBookingDetails.Controls.Add(this.arrivaleDate);
            this.grpBookingDetails.Controls.Add(this.lblBookingDetails);
            this.grpBookingDetails.Location = new System.Drawing.Point(13, 94);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.Size = new System.Drawing.Size(614, 541);
            this.grpBookingDetails.TabIndex = 60;
            this.grpBookingDetails.TabStop = false;
            this.grpBookingDetails.Text = "Booking Details";
            this.grpBookingDetails.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "C-IN"});
            this.cmbStatus.Location = new System.Drawing.Point(189, 415);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(71, 21);
            this.cmbStatus.TabIndex = 6;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // txtTenant
            // 
            this.txtTenant.Enabled = false;
            this.txtTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenant.Location = new System.Drawing.Point(189, 130);
            this.txtTenant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenant.Multiline = true;
            this.txtTenant.Name = "txtTenant";
            this.txtTenant.Size = new System.Drawing.Size(45, 29);
            this.txtTenant.TabIndex = 1;
            // 
            // txtBooking
            // 
            this.txtBooking.Enabled = false;
            this.txtBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBooking.Location = new System.Drawing.Point(189, 83);
            this.txtBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBooking.Multiline = true;
            this.txtBooking.Name = "txtBooking";
            this.txtBooking.Size = new System.Drawing.Size(45, 29);
            this.txtBooking.TabIndex = 0;
            // 
            // lblTenantID
            // 
            this.lblTenantID.AutoSize = true;
            this.lblTenantID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenantID.Location = new System.Drawing.Point(38, 136);
            this.lblTenantID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenantID.Name = "lblTenantID";
            this.lblTenantID.Size = new System.Drawing.Size(89, 20);
            this.lblTenantID.TabIndex = 60;
            this.lblTenantID.Text = "Tenant ID";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(38, 89);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(98, 20);
            this.lblBookID.TabIndex = 59;
            this.lblBookID.Text = "Booking ID";
            // 
            // cboBookingID
            // 
            this.cboBookingID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookingID.FormattingEnabled = true;
            this.cboBookingID.Location = new System.Drawing.Point(222, 60);
            this.cboBookingID.Name = "cboBookingID";
            this.cboBookingID.Size = new System.Drawing.Size(174, 21);
            this.cboBookingID.TabIndex = 61;
            this.cboBookingID.SelectedIndexChanged += new System.EventHandler(this.cboBookingID_SelectedIndexChanged);
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 647);
            this.Controls.Add(this.cboBookingID);
            this.Controls.Add(this.grpBookingDetails);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBookingID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCheckIn";
            this.Text = "CheckIn";
            this.Load += new System.EventHandler(this.frmCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCheckIn)).EndInit();
            this.grpBookingDetails.ResumeLayout(false);
            this.grpBookingDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblBookingDetails;
        private System.Windows.Forms.TextBox txtPropNo;
        private System.Windows.Forms.Label lblPropNo;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.DateTimePicker departureDate;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.DateTimePicker arrivaleDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.PictureBox picCheckIn;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpBookingDetails;
        private System.Windows.Forms.Label lblTenantID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtTenant;
        private System.Windows.Forms.TextBox txtBooking;
        private System.Windows.Forms.ComboBox cboBookingID;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}