namespace HolidayHomeSYS
{
    partial class frmCheckOut
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
            this.lblUpdateBookingStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.picCheckOut = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpBookingDetails = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboBookid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckOut)).BeginInit();
            this.grpBookingDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBookingID.Location = new System.Drawing.Point(40, 58);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(166, 31);
            this.lblBookingID.TabIndex = 43;
            this.lblBookingID.Text = "Booking ID:";
            // 
            // lblUpdateBookingStatus
            // 
            this.lblUpdateBookingStatus.AutoSize = true;
            this.lblUpdateBookingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateBookingStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUpdateBookingStatus.Location = new System.Drawing.Point(15, 31);
            this.lblUpdateBookingStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateBookingStatus.Name = "lblUpdateBookingStatus";
            this.lblUpdateBookingStatus.Size = new System.Drawing.Size(322, 31);
            this.lblUpdateBookingStatus.TabIndex = 46;
            this.lblUpdateBookingStatus.Text = "Update Booking Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(24, 145);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "Status";
            // 
            // picCheckOut
            // 
            this.picCheckOut.Image = global::HolidayHomeSYS.Properties.Resources.checkOut;
            this.picCheckOut.Location = new System.Drawing.Point(392, 22);
            this.picCheckOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCheckOut.Name = "picCheckOut";
            this.picCheckOut.Size = new System.Drawing.Size(176, 229);
            this.picCheckOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckOut.TabIndex = 57;
            this.picCheckOut.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBack.Location = new System.Drawing.Point(8, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 38);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpBookingDetails
            // 
            this.grpBookingDetails.Controls.Add(this.cboStatus);
            this.grpBookingDetails.Controls.Add(this.picCheckOut);
            this.grpBookingDetails.Controls.Add(this.lblStatus);
            this.grpBookingDetails.Controls.Add(this.lblUpdateBookingStatus);
            this.grpBookingDetails.Location = new System.Drawing.Point(25, 121);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.Size = new System.Drawing.Size(584, 331);
            this.grpBookingDetails.TabIndex = 59;
            this.grpBookingDetails.TabStop = false;
            this.grpBookingDetails.Text = "Booking Status";
            this.grpBookingDetails.Visible = false;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "C-OUT"});
            this.cboStatus.Location = new System.Drawing.Point(134, 148);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(85, 21);
            this.cboStatus.TabIndex = 0;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // cboBookid
            // 
            this.cboBookid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookid.FormattingEnabled = true;
            this.cboBookid.Location = new System.Drawing.Point(226, 70);
            this.cboBookid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBookid.Name = "cboBookid";
            this.cboBookid.Size = new System.Drawing.Size(143, 21);
            this.cboBookid.TabIndex = 60;
            this.cboBookid.SelectedIndexChanged += new System.EventHandler(this.cboBookid_SelectedIndexChanged);
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 460);
            this.Controls.Add(this.cboBookid);
            this.Controls.Add(this.grpBookingDetails);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBookingID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCheckOut)).EndInit();
            this.grpBookingDetails.ResumeLayout(false);
            this.grpBookingDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblUpdateBookingStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox picCheckOut;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpBookingDetails;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboBookid;
    }
}