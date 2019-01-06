namespace Bay_View
{
    partial class Form4
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
            this.cbCustomerID = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cbRoomNo = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRooms = new System.Windows.Forms.ListBox();
            this.chbBreakFast = new System.Windows.Forms.CheckBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbtStaff = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbtDuration = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCustomerID
            // 
            this.cbCustomerID.FormattingEnabled = true;
            this.cbCustomerID.Location = new System.Drawing.Point(256, 47);
            this.cbCustomerID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCustomerID.Name = "cbCustomerID";
            this.cbCustomerID.Size = new System.Drawing.Size(160, 23);
            this.cbCustomerID.TabIndex = 0;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(180, 50);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(71, 15);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(12, 9);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(47, 15);
            this.lblStaff.TabIndex = 2;
            this.lblStaff.Text = "Staff";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(627, 50);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(39, 15);
            this.lblRoom.TabIndex = 4;
            this.lblRoom.Text = "Room";
            // 
            // cbRoomNo
            // 
            this.cbRoomNo.FormattingEnabled = true;
            this.cbRoomNo.Location = new System.Drawing.Point(673, 47);
            this.cbRoomNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRoomNo.Name = "cbRoomNo";
            this.cbRoomNo.Size = new System.Drawing.Size(160, 23);
            this.cbRoomNo.TabIndex = 3;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(423, 125);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 25);
            this.dtpStart.TabIndex = 5;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(423, 182);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 25);
            this.dtpEnd.TabIndex = 6;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(330, 132);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(87, 15);
            this.lblStart.TabIndex = 8;
            this.lblStart.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "End Date";
            // 
            // lbRooms
            // 
            this.lbRooms.FormattingEnabled = true;
            this.lbRooms.ItemHeight = 15;
            this.lbRooms.Location = new System.Drawing.Point(376, 261);
            this.lbRooms.Name = "lbRooms";
            this.lbRooms.Size = new System.Drawing.Size(270, 169);
            this.lbRooms.TabIndex = 10;
            // 
            // chbBreakFast
            // 
            this.chbBreakFast.AutoSize = true;
            this.chbBreakFast.Location = new System.Drawing.Point(452, 446);
            this.chbBreakFast.Name = "chbBreakFast";
            this.chbBreakFast.Size = new System.Drawing.Size(109, 19);
            this.chbBreakFast.TabIndex = 11;
            this.chbBreakFast.Text = "Breakfast?";
            this.chbBreakFast.UseVisualStyleBackColor = true;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(478, 515);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 25);
            this.tbTotal.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(425, 518);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 15);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // tbtStaff
            // 
            this.tbtStaff.Location = new System.Drawing.Point(65, 6);
            this.tbtStaff.Name = "tbtStaff";
            this.tbtStaff.Size = new System.Drawing.Size(100, 25);
            this.tbtStaff.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(490, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 15);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Bookings";
            // 
            // tbtDuration
            // 
            this.tbtDuration.Enabled = false;
            this.tbtDuration.Location = new System.Drawing.Point(673, 149);
            this.tbtDuration.Name = "tbtDuration";
            this.tbtDuration.Size = new System.Drawing.Size(100, 25);
            this.tbtDuration.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(478, 232);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 636);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbtDuration);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbtStaff);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.chbBreakFast);
            this.Controls.Add(this.lbRooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.cbRoomNo);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cbCustomerID);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCustomerID;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cbRoomNo;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRooms;
        private System.Windows.Forms.CheckBox chbBreakFast;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbtStaff;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbtDuration;
        private System.Windows.Forms.Button btnSearch;
    }
}