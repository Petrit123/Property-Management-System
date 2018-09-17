namespace HolidayHomeSYS
{
    partial class frmDeRegisterProperty
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
            this.btnBack = new System.Windows.Forms.Button();
            this.picX = new System.Windows.Forms.PictureBox();
            this.grdProp = new System.Windows.Forms.DataGridView();
            this.cboProp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPropNo
            // 
            this.lblPropNo.AutoSize = true;
            this.lblPropNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropNo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPropNo.Location = new System.Drawing.Point(15, 105);
            this.lblPropNo.Name = "lblPropNo";
            this.lblPropNo.Size = new System.Drawing.Size(310, 39);
            this.lblPropNo.TabIndex = 2;
            this.lblPropNo.Text = " Property Number:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBack.Location = new System.Drawing.Point(23, 7);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 48);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picX
            // 
            this.picX.Image = global::HolidayHomeSYS.Properties.Resources.remove;
            this.picX.Location = new System.Drawing.Point(23, 246);
            this.picX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picX.Name = "picX";
            this.picX.Size = new System.Drawing.Size(265, 204);
            this.picX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picX.TabIndex = 42;
            this.picX.TabStop = false;
            // 
            // grdProp
            // 
            this.grdProp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProp.Location = new System.Drawing.Point(425, 235);
            this.grdProp.Margin = new System.Windows.Forms.Padding(4);
            this.grdProp.Name = "grdProp";
            this.grdProp.ReadOnly = true;
            this.grdProp.Size = new System.Drawing.Size(1419, 394);
            this.grdProp.TabIndex = 43;
            // 
            // cboProp
            // 
            this.cboProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProp.FormattingEnabled = true;
            this.cboProp.Location = new System.Drawing.Point(366, 120);
            this.cboProp.Name = "cboProp";
            this.cboProp.Size = new System.Drawing.Size(121, 24);
            this.cboProp.TabIndex = 44;
            this.cboProp.SelectedIndexChanged += new System.EventHandler(this.cboProp_SelectedIndexChanged);
            // 
            // frmDeRegisterProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 816);
            this.Controls.Add(this.cboProp);
            this.Controls.Add(this.grdProp);
            this.Controls.Add(this.picX);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPropNo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDeRegisterProperty";
            this.Text = "RemoveProperty";
            this.Load += new System.EventHandler(this.frmDeRegisterProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPropNo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picX;
        private System.Windows.Forms.DataGridView grdProp;
        private System.Windows.Forms.ComboBox cboProp;
    }
}