namespace Bay_View
{
    partial class frmEdit_Bookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit_Bookings));
            this.lblEdit = new System.Windows.Forms.Label();
            this.chbBooking = new System.Windows.Forms.ComboBox();
            this.tbtBookingNo = new System.Windows.Forms.TextBox();
            this.tbtGuestID = new System.Windows.Forms.TextBox();
            this.tbtRoomNo = new System.Windows.Forms.TextBox();
            this.tbtDuration = new System.Windows.Forms.TextBox();
            this.tbtChildren = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.tbtAdults = new System.Windows.Forms.TextBox();
            this.tbtTotal = new System.Windows.Forms.TextBox();
            this.lblBooking = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lblAdults = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cbDisabled = new System.Windows.Forms.CheckBox();
            this.cbBreakfast = new System.Windows.Forms.CheckBox();
            this.lblDisabled = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblEdit.Location = new System.Drawing.Point(387, 28);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(125, 20);
            this.lblEdit.TabIndex = 0;
            this.lblEdit.Text = "Edit Bookings";
            // 
            // chbBooking
            // 
            this.chbBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.chbBooking.FormattingEnabled = true;
            this.chbBooking.Location = new System.Drawing.Point(389, 66);
            this.chbBooking.Name = "chbBooking";
            this.chbBooking.Size = new System.Drawing.Size(121, 28);
            this.chbBooking.TabIndex = 1;
            this.chbBooking.SelectedIndexChanged += new System.EventHandler(this.chbBooking_SelectedIndexChanged);
            // 
            // tbtBookingNo
            // 
            this.tbtBookingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbtBookingNo.Location = new System.Drawing.Point(196, 178);
            this.tbtBookingNo.Name = "tbtBookingNo";
            this.tbtBookingNo.Size = new System.Drawing.Size(100, 26);
            this.tbtBookingNo.TabIndex = 2;
            // 
            // tbtGuestID
            // 
            this.tbtGuestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbtGuestID.Location = new System.Drawing.Point(196, 273);
            this.tbtGuestID.Name = "tbtGuestID";
            this.tbtGuestID.Size = new System.Drawing.Size(100, 26);
            this.tbtGuestID.TabIndex = 4;
            // 
            // tbtRoomNo
            // 
            this.tbtRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbtRoomNo.Location = new System.Drawing.Point(196, 346);
            this.tbtRoomNo.Name = "tbtRoomNo";
            this.tbtRoomNo.Size = new System.Drawing.Size(100, 26);
            this.tbtRoomNo.TabIndex = 5;
            // 
            // tbtDuration
            // 
            this.tbtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbtDuration.Location = new System.Drawing.Point(700, 173);
            this.tbtDuration.Name = "tbtDuration";
            this.tbtDuration.Size = new System.Drawing.Size(100, 26);
            this.tbtDuration.TabIndex = 8;
            // 
            // tbtChildren
            // 
            this.tbtChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbtChildren.Location = new System.Drawing.Point(424, 346);
            this.tbtChildren.Name = "tbtChildren";
            this.tbtChildren.Size = new System.Drawing.Size(100, 26);
            this.tbtChildren.TabIndex = 9;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dtpStart.Location = new System.Drawing.Point(368, 173);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 26);
            this.dtpStart.TabIndex = 10;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dtpEnd.Location = new System.Drawing.Point(368, 227);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 26);
            this.dtpEnd.TabIndex = 11;
            // 
            // tbtAdults
            // 
            this.tbtAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbtAdults.Location = new System.Drawing.Point(424, 277);
            this.tbtAdults.Name = "tbtAdults";
            this.tbtAdults.Size = new System.Drawing.Size(100, 26);
            this.tbtAdults.TabIndex = 12;
            // 
            // tbtTotal
            // 
            this.tbtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbtTotal.Location = new System.Drawing.Point(700, 351);
            this.tbtTotal.Name = "tbtTotal";
            this.tbtTotal.Size = new System.Drawing.Size(100, 26);
            this.tbtTotal.TabIndex = 15;
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblBooking.Location = new System.Drawing.Point(28, 181);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(140, 20);
            this.lblBooking.TabIndex = 16;
            this.lblBooking.Text = "Booking Ref No";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStaffID.Location = new System.Drawing.Point(655, 14);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(74, 20);
            this.lblStaffID.TabIndex = 17;
            this.lblStaffID.Text = "Staff ID";
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblGuestID.Location = new System.Drawing.Point(84, 277);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(84, 20);
            this.lblGuestID.TabIndex = 18;
            this.lblGuestID.Text = "Guest ID";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblRoomNo.Location = new System.Drawing.Point(84, 351);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(86, 20);
            this.lblRoomNo.TabIndex = 19;
            this.lblRoomNo.Text = "Room No";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStart.Location = new System.Drawing.Point(315, 180);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(50, 20);
            this.lblStart.TabIndex = 20;
            this.lblStart.Text = "Start";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblEnd.Location = new System.Drawing.Point(320, 231);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(41, 20);
            this.lblEnd.TabIndex = 21;
            this.lblEnd.Text = "End";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDuration.Location = new System.Drawing.Point(611, 178);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(81, 20);
            this.lblDuration.TabIndex = 22;
            this.lblDuration.Text = "Duration";
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblChildren.Location = new System.Drawing.Point(320, 350);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(79, 20);
            this.lblChildren.TabIndex = 23;
            this.lblChildren.Text = "Children";
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAdults.Location = new System.Drawing.Point(339, 280);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(62, 20);
            this.lblAdults.TabIndex = 24;
            this.lblAdults.Text = "Adults";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAmount.Location = new System.Drawing.Point(598, 357);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(96, 20);
            this.lblAmount.TabIndex = 27;
            this.lblAmount.Text = "Total Cost";
            // 
            // cbDisabled
            // 
            this.cbDisabled.AutoSize = true;
            this.cbDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbDisabled.Location = new System.Drawing.Point(737, 285);
            this.cbDisabled.Name = "cbDisabled";
            this.cbDisabled.Size = new System.Drawing.Size(18, 17);
            this.cbDisabled.TabIndex = 28;
            this.cbDisabled.UseVisualStyleBackColor = true;
            this.cbDisabled.CheckedChanged += new System.EventHandler(this.cbDisabled_CheckedChanged);
            // 
            // cbBreakfast
            // 
            this.cbBreakfast.AutoSize = true;
            this.cbBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbBreakfast.Location = new System.Drawing.Point(737, 250);
            this.cbBreakfast.Name = "cbBreakfast";
            this.cbBreakfast.Size = new System.Drawing.Size(18, 17);
            this.cbBreakfast.TabIndex = 29;
            this.cbBreakfast.UseVisualStyleBackColor = true;
            this.cbBreakfast.CheckedChanged += new System.EventHandler(this.cbBreakfast_CheckedChanged);
            // 
            // lblDisabled
            // 
            this.lblDisabled.AutoSize = true;
            this.lblDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDisabled.Location = new System.Drawing.Point(637, 283);
            this.lblDisabled.Name = "lblDisabled";
            this.lblDisabled.Size = new System.Drawing.Size(93, 20);
            this.lblDisabled.TabIndex = 30;
            this.lblDisabled.Text = "Disabled?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(629, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Breakfast?";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(228, 421);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 45);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(531, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 45);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(16, 14);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(151, 128);
            this.pbLogo.TabIndex = 34;
            this.pbLogo.TabStop = false;
            // 
            // frmEdit_Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(871, 530);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDisabled);
            this.Controls.Add(this.cbBreakfast);
            this.Controls.Add(this.cbDisabled);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblAdults);
            this.Controls.Add(this.lblChildren);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.tbtTotal);
            this.Controls.Add(this.tbtAdults);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.tbtChildren);
            this.Controls.Add(this.tbtDuration);
            this.Controls.Add(this.tbtRoomNo);
            this.Controls.Add(this.tbtGuestID);
            this.Controls.Add(this.tbtBookingNo);
            this.Controls.Add(this.chbBooking);
            this.Controls.Add(this.lblEdit);
            this.Name = "frmEdit_Bookings";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.ComboBox chbBooking;
        private System.Windows.Forms.TextBox tbtBookingNo;
        private System.Windows.Forms.TextBox tbtGuestID;
        private System.Windows.Forms.TextBox tbtRoomNo;
        private System.Windows.Forms.TextBox tbtDuration;
        private System.Windows.Forms.TextBox tbtChildren;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.TextBox tbtAdults;
        private System.Windows.Forms.TextBox tbtTotal;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.CheckBox cbDisabled;
        private System.Windows.Forms.CheckBox cbBreakfast;
        private System.Windows.Forms.Label lblDisabled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}