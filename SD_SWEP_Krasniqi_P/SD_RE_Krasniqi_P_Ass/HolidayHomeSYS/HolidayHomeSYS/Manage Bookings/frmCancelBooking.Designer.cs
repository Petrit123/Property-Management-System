namespace HolidayHomeSYS
{
    partial class frmCancelBooking
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
            this.lblCanceBooking = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.picCancel = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.grdBookings = new System.Windows.Forms.DataGridView();
            this.cboBookid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCanceBooking
            // 
            this.lblCanceBooking.AutoSize = true;
            this.lblCanceBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanceBooking.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCanceBooking.Location = new System.Drawing.Point(56, 74);
            this.lblCanceBooking.Name = "lblCanceBooking";
            this.lblCanceBooking.Size = new System.Drawing.Size(281, 39);
            this.lblCanceBooking.TabIndex = 6;
            this.lblCanceBooking.Text = "Cancel Booking:";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBookID.Location = new System.Drawing.Point(56, 226);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(205, 39);
            this.lblBookID.TabIndex = 7;
            this.lblBookID.Text = "Booking ID:";
            // 
            // picCancel
            // 
            this.picCancel.Image = global::HolidayHomeSYS.Properties.Resources.cancel1;
            this.picCancel.Location = new System.Drawing.Point(492, 74);
            this.picCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCancel.Name = "picCancel";
            this.picCancel.Size = new System.Drawing.Size(327, 244);
            this.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancel.TabIndex = 9;
            this.picCancel.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBack.Location = new System.Drawing.Point(11, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 39);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grdBookings
            // 
            this.grdBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBookings.Location = new System.Drawing.Point(856, 74);
            this.grdBookings.Margin = new System.Windows.Forms.Padding(4);
            this.grdBookings.Name = "grdBookings";
            this.grdBookings.ReadOnly = true;
            this.grdBookings.Size = new System.Drawing.Size(977, 389);
            this.grdBookings.TabIndex = 42;
            this.grdBookings.Visible = false;
            // 
            // cboBookid
            // 
            this.cboBookid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookid.FormattingEnabled = true;
            this.cboBookid.Location = new System.Drawing.Point(282, 241);
            this.cboBookid.Name = "cboBookid";
            this.cboBookid.Size = new System.Drawing.Size(179, 24);
            this.cboBookid.TabIndex = 43;
            this.cboBookid.SelectedIndexChanged += new System.EventHandler(this.cboBookid_SelectedIndexChanged);
            // 
            // frmCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 844);
            this.Controls.Add(this.cboBookid);
            this.Controls.Add(this.grdBookings);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picCancel);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblCanceBooking);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCancelBooking";
            this.Text = "CancelBooking";
            this.Load += new System.EventHandler(this.frmCancelBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCanceBooking;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.PictureBox picCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdBookings;
        private System.Windows.Forms.ComboBox cboBookid;
    }
}