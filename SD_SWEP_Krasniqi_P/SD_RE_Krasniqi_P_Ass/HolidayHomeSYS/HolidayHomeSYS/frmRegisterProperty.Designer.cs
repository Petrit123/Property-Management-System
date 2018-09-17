namespace HolidayHomeSYS
{
    partial class frmRegisterProperty
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
            this.cboBeds = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.lblNoBeds = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.lblPropDetails = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.picAddProp = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPropNo = new System.Windows.Forms.Label();
            this.txtPropNo = new System.Windows.Forms.TextBox();
            this.grpGarage = new System.Windows.Forms.GroupBox();
            this.radGarageN = new System.Windows.Forms.RadioButton();
            this.radGarageY = new System.Windows.Forms.RadioButton();
            this.grpGarden = new System.Windows.Forms.GroupBox();
            this.radGdnN = new System.Windows.Forms.RadioButton();
            this.radGdnY = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picAddProp)).BeginInit();
            this.grpGarage.SuspendLayout();
            this.grpGarden.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboBeds
            // 
            this.cboBeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBeds.FormattingEnabled = true;
            this.cboBeds.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboBeds.Location = new System.Drawing.Point(158, 159);
            this.cboBeds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBeds.Name = "cboBeds";
            this.cboBeds.Size = new System.Drawing.Size(51, 24);
            this.cboBeds.TabIndex = 1;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "H",
            "A"});
            this.cboType.Location = new System.Drawing.Point(158, 211);
            this.cboType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(120, 24);
            this.cboType.TabIndex = 2;
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(158, 267);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(120, 23);
            this.txtStreet.TabIndex = 3;
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged);
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
            this.cboCounty.Location = new System.Drawing.Point(158, 371);
            this.cboCounty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(120, 24);
            this.cboCounty.TabIndex = 5;
            // 
            // txtTown
            // 
            this.txtTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(158, 323);
            this.txtTown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(120, 23);
            this.txtTown.TabIndex = 4;
            this.txtTown.TextChanged += new System.EventHandler(this.txtTown_TextChanged);
            // 
            // txtRent
            // 
            this.txtRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRent.Location = new System.Drawing.Point(158, 414);
            this.txtRent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRent.Multiline = true;
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(71, 26);
            this.txtRent.TabIndex = 6;
            this.txtRent.TextChanged += new System.EventHandler(this.txtRent_TextChanged);
            // 
            // lblNoBeds
            // 
            this.lblNoBeds.AutoSize = true;
            this.lblNoBeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBeds.Location = new System.Drawing.Point(70, 159);
            this.lblNoBeds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoBeds.Name = "lblNoBeds";
            this.lblNoBeds.Size = new System.Drawing.Size(77, 20);
            this.lblNoBeds.TabIndex = 11;
            this.lblNoBeds.Text = "No Beds";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(70, 211);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 20);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Type";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(70, 267);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(59, 20);
            this.lblStreet.TabIndex = 13;
            this.lblStreet.Text = "Street";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(70, 321);
            this.lblTown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(51, 20);
            this.lblTown.TabIndex = 14;
            this.lblTown.Text = "Town";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(74, 371);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(65, 20);
            this.lblCounty.TabIndex = 15;
            this.lblCounty.Text = "County";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRent.Location = new System.Drawing.Point(74, 414);
            this.lblRent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(48, 20);
            this.lblRent.TabIndex = 18;
            this.lblRent.Text = "Rent";
            // 
            // lblPropDetails
            // 
            this.lblPropDetails.AutoSize = true;
            this.lblPropDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropDetails.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPropDetails.Location = new System.Drawing.Point(72, 23);
            this.lblPropDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPropDetails.Name = "lblPropDetails";
            this.lblPropDetails.Size = new System.Drawing.Size(397, 31);
            this.lblPropDetails.TabIndex = 19;
            this.lblPropDetails.Text = "Please enter property details:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAdd.Location = new System.Drawing.Point(249, 591);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Property\r\n";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // picAddProp
            // 
            this.picAddProp.Image = global::HolidayHomeSYS.Properties.Resources.addprop;
            this.picAddProp.Location = new System.Drawing.Point(527, 267);
            this.picAddProp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAddProp.Name = "picAddProp";
            this.picAddProp.Size = new System.Drawing.Size(295, 313);
            this.picAddProp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddProp.TabIndex = 20;
            this.picAddProp.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBack.Location = new System.Drawing.Point(843, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 24);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPropNo
            // 
            this.lblPropNo.AutoSize = true;
            this.lblPropNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropNo.Location = new System.Drawing.Point(71, 105);
            this.lblPropNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPropNo.Name = "lblPropNo";
            this.lblPropNo.Size = new System.Drawing.Size(73, 20);
            this.lblPropNo.TabIndex = 25;
            this.lblPropNo.Text = "Prop No";
            // 
            // txtPropNo
            // 
            this.txtPropNo.Enabled = false;
            this.txtPropNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropNo.Location = new System.Drawing.Point(156, 105);
            this.txtPropNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPropNo.Multiline = true;
            this.txtPropNo.Name = "txtPropNo";
            this.txtPropNo.Size = new System.Drawing.Size(71, 26);
            this.txtPropNo.TabIndex = 0;
            this.txtPropNo.Text = "102";
            // 
            // grpGarage
            // 
            this.grpGarage.Controls.Add(this.radGarageN);
            this.grpGarage.Controls.Add(this.radGarageY);
            this.grpGarage.Location = new System.Drawing.Point(78, 464);
            this.grpGarage.Name = "grpGarage";
            this.grpGarage.Size = new System.Drawing.Size(145, 66);
            this.grpGarage.TabIndex = 7;
            this.grpGarage.TabStop = false;
            this.grpGarage.Text = "Garage?";
            // 
            // radGarageN
            // 
            this.radGarageN.AutoSize = true;
            this.radGarageN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGarageN.Location = new System.Drawing.Point(72, 27);
            this.radGarageN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radGarageN.Name = "radGarageN";
            this.radGarageN.Size = new System.Drawing.Size(34, 19);
            this.radGarageN.TabIndex = 18;
            this.radGarageN.Text = "N";
            this.radGarageN.UseVisualStyleBackColor = true;
            // 
            // radGarageY
            // 
            this.radGarageY.AutoSize = true;
            this.radGarageY.Checked = true;
            this.radGarageY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGarageY.Location = new System.Drawing.Point(14, 27);
            this.radGarageY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radGarageY.Name = "radGarageY";
            this.radGarageY.Size = new System.Drawing.Size(32, 19);
            this.radGarageY.TabIndex = 17;
            this.radGarageY.TabStop = true;
            this.radGarageY.Text = "Y";
            this.radGarageY.UseVisualStyleBackColor = true;
            // 
            // grpGarden
            // 
            this.grpGarden.Controls.Add(this.radGdnN);
            this.grpGarden.Controls.Add(this.radGdnY);
            this.grpGarden.Location = new System.Drawing.Point(78, 561);
            this.grpGarden.Name = "grpGarden";
            this.grpGarden.Size = new System.Drawing.Size(145, 66);
            this.grpGarden.TabIndex = 8;
            this.grpGarden.TabStop = false;
            this.grpGarden.Text = "Garden?";
            // 
            // radGdnN
            // 
            this.radGdnN.AutoSize = true;
            this.radGdnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGdnN.Location = new System.Drawing.Point(72, 27);
            this.radGdnN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radGdnN.Name = "radGdnN";
            this.radGdnN.Size = new System.Drawing.Size(34, 19);
            this.radGdnN.TabIndex = 18;
            this.radGdnN.Text = "N";
            this.radGdnN.UseVisualStyleBackColor = true;
            // 
            // radGdnY
            // 
            this.radGdnY.AutoSize = true;
            this.radGdnY.Checked = true;
            this.radGdnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGdnY.Location = new System.Drawing.Point(14, 27);
            this.radGdnY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radGdnY.Name = "radGdnY";
            this.radGdnY.Size = new System.Drawing.Size(32, 19);
            this.radGdnY.TabIndex = 17;
            this.radGdnY.TabStop = true;
            this.radGdnY.Text = "Y";
            this.radGdnY.UseVisualStyleBackColor = true;
            // 
            // frmRegisterProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 711);
            this.Controls.Add(this.grpGarden);
            this.Controls.Add(this.grpGarage);
            this.Controls.Add(this.lblPropNo);
            this.Controls.Add(this.picAddProp);
            this.Controls.Add(this.txtPropNo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPropDetails);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblNoBeds);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.cboCounty);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboBeds);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRegisterProperty";
            this.Text = "RegisterProperty";
            this.Load += new System.EventHandler(this.frmRegisterProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAddProp)).EndInit();
            this.grpGarage.ResumeLayout(false);
            this.grpGarage.PerformLayout();
            this.grpGarden.ResumeLayout(false);
            this.grpGarden.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboBeds;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label lblNoBeds;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label lblPropDetails;
        private System.Windows.Forms.PictureBox picAddProp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPropNo;
        private System.Windows.Forms.TextBox txtPropNo;
        private System.Windows.Forms.GroupBox grpGarage;
        private System.Windows.Forms.RadioButton radGarageN;
        private System.Windows.Forms.RadioButton radGarageY;
        private System.Windows.Forms.GroupBox grpGarden;
        private System.Windows.Forms.RadioButton radGdnN;
        private System.Windows.Forms.RadioButton radGdnY;
    }
}