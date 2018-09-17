namespace HolidayHomeSYS
{
    partial class frmCheckAvailability
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
            this.lblPropNo = new System.Windows.Forms.Label();
            this.lblPropStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.picUpdateAvailability = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.grdProperties = new System.Windows.Forms.DataGridView();
            this.cboProp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateAvailability)).BeginInit();
            this.grpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPropNo
            // 
            this.lblPropNo.AutoSize = true;
            this.lblPropNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropNo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPropNo.Location = new System.Drawing.Point(51, 64);
            this.lblPropNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPropNo.Name = "lblPropNo";
            this.lblPropNo.Size = new System.Drawing.Size(252, 31);
            this.lblPropNo.TabIndex = 2;
            this.lblPropNo.Text = " Property Number:";
            // 
            // lblPropStatus
            // 
            this.lblPropStatus.AutoSize = true;
            this.lblPropStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPropStatus.Location = new System.Drawing.Point(15, 21);
            this.lblPropStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPropStatus.Name = "lblPropStatus";
            this.lblPropStatus.Size = new System.Drawing.Size(335, 31);
            this.lblPropStatus.TabIndex = 4;
            this.lblPropStatus.Text = "Change Property Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(24, 102);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 41;
            this.lblStatus.Text = "Status";
            // 
            // picUpdateAvailability
            // 
            this.picUpdateAvailability.Image = global::HolidayHomeSYS.Properties.Resources.update1;
            this.picUpdateAvailability.Location = new System.Drawing.Point(403, 164);
            this.picUpdateAvailability.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picUpdateAvailability.Name = "picUpdateAvailability";
            this.picUpdateAvailability.Size = new System.Drawing.Size(228, 200);
            this.picUpdateAvailability.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpdateAvailability.TabIndex = 44;
            this.picUpdateAvailability.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBack.Location = new System.Drawing.Point(8, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 38);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.btnUpdate);
            this.grpStatus.Controls.Add(this.cboStatus);
            this.grpStatus.Controls.Add(this.lblStatus);
            this.grpStatus.Controls.Add(this.lblPropStatus);
            this.grpStatus.Location = new System.Drawing.Point(28, 164);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(362, 328);
            this.grpStatus.TabIndex = 47;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Property Status";
            this.grpStatus.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.Location = new System.Drawing.Point(82, 178);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 45);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "A",
            "D"});
            this.cboStatus.Location = new System.Drawing.Point(104, 102);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(41, 21);
            this.cboStatus.TabIndex = 0;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // grdProperties
            // 
            this.grdProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProperties.Location = new System.Drawing.Point(653, 64);
            this.grdProperties.Name = "grdProperties";
            this.grdProperties.ReadOnly = true;
            this.grdProperties.Size = new System.Drawing.Size(1044, 291);
            this.grdProperties.TabIndex = 48;
            // 
            // cboProp
            // 
            this.cboProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProp.FormattingEnabled = true;
            this.cboProp.Location = new System.Drawing.Point(322, 76);
            this.cboProp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboProp.Name = "cboProp";
            this.cboProp.Size = new System.Drawing.Size(92, 21);
            this.cboProp.TabIndex = 49;
            this.cboProp.SelectedIndexChanged += new System.EventHandler(this.cboProp_SelectedIndexChanged);
            // 
            // frmCheckAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 618);
            this.Controls.Add(this.cboProp);
            this.Controls.Add(this.grdProperties);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picUpdateAvailability);
            this.Controls.Add(this.lblPropNo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCheckAvailability";
            this.Text = "CheckAvailability";
            this.Load += new System.EventHandler(this.frmCheckAvailability_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateAvailability)).EndInit();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPropNo;
        private System.Windows.Forms.Label lblPropStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox picUpdateAvailability;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.DataGridView grdProperties;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboProp;
        private System.Windows.Forms.Button btnUpdate;
    }
}