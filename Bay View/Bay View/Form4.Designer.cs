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
            this.cbRoomSize = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRooms = new System.Windows.Forms.ListBox();
            this.chbBreakFast = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbtDuration = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbDisabled = new System.Windows.Forms.CheckBox();
            this.lblAdults = new System.Windows.Forms.Label();
            this.lblChildren = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudAdults = new System.Windows.Forms.NumericUpDown();
            this.nudChildren = new System.Windows.Forms.NumericUpDown();
            this.lblSelectedRoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildren)).BeginInit();
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
            this.lblCustomer.Location = new System.Drawing.Point(192, 50);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(47, 15);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Guest";
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
            // cbRoomSize
            // 
            this.cbRoomSize.FormattingEnabled = true;
            this.cbRoomSize.Location = new System.Drawing.Point(673, 47);
            this.cbRoomSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRoomSize.Name = "cbRoomSize";
            this.cbRoomSize.Size = new System.Drawing.Size(160, 23);
            this.cbRoomSize.TabIndex = 3;
            this.cbRoomSize.SelectedIndexChanged += new System.EventHandler(this.cbRoomSize_SelectedIndexChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(452, 128);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 25);
            this.dtpStart.TabIndex = 5;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(452, 185);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 25);
            this.dtpEnd.TabIndex = 6;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(359, 135);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(87, 15);
            this.lblStart.TabIndex = 8;
            this.lblStart.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "End Date";
            // 
            // lbRooms
            // 
            this.lbRooms.FormattingEnabled = true;
            this.lbRooms.ItemHeight = 15;
            this.lbRooms.Location = new System.Drawing.Point(405, 264);
            this.lbRooms.Name = "lbRooms";
            this.lbRooms.Size = new System.Drawing.Size(270, 169);
            this.lbRooms.TabIndex = 10;
            this.lbRooms.SelectedIndexChanged += new System.EventHandler(this.lbRooms_SelectedIndexChanged);
            // 
            // chbBreakFast
            // 
            this.chbBreakFast.AutoSize = true;
            this.chbBreakFast.Location = new System.Drawing.Point(724, 313);
            this.chbBreakFast.Name = "chbBreakFast";
            this.chbBreakFast.Size = new System.Drawing.Size(109, 19);
            this.chbBreakFast.TabIndex = 11;
            this.chbBreakFast.Text = "Breakfast?";
            this.chbBreakFast.UseVisualStyleBackColor = true;
            this.chbBreakFast.CheckedChanged += new System.EventHandler(this.chbBreakFast_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(458, 582);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 15);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(504, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 15);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Bookings";
            // 
            // tbtDuration
            // 
            this.tbtDuration.Enabled = false;
            this.tbtDuration.Location = new System.Drawing.Point(702, 152);
            this.tbtDuration.Name = "tbtDuration";
            this.tbtDuration.Size = new System.Drawing.Size(100, 25);
            this.tbtDuration.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(507, 235);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbDisabled
            // 
            this.cbDisabled.AutoSize = true;
            this.cbDisabled.Location = new System.Drawing.Point(718, 225);
            this.cbDisabled.Name = "cbDisabled";
            this.cbDisabled.Size = new System.Drawing.Size(157, 19);
            this.cbDisabled.TabIndex = 18;
            this.cbDisabled.Text = "Disabled Access?";
            this.cbDisabled.UseVisualStyleBackColor = true;
            this.cbDisabled.CheckedChanged += new System.EventHandler(this.cbDisabled_CheckedChanged);
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Location = new System.Drawing.Point(142, 267);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(55, 15);
            this.lblAdults.TabIndex = 21;
            this.lblAdults.Text = "Adults";
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Location = new System.Drawing.Point(126, 333);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(71, 15);
            this.lblChildren.TabIndex = 22;
            this.lblChildren.Text = "Children";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(470, 494);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(129, 44);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudAdults
            // 
            this.nudAdults.Location = new System.Drawing.Point(216, 264);
            this.nudAdults.Name = "nudAdults";
            this.nudAdults.Size = new System.Drawing.Size(120, 25);
            this.nudAdults.TabIndex = 24;
            // 
            // nudChildren
            // 
            this.nudChildren.Location = new System.Drawing.Point(216, 333);
            this.nudChildren.Name = "nudChildren";
            this.nudChildren.Size = new System.Drawing.Size(120, 25);
            this.nudChildren.TabIndex = 25;
            // 
            // lblSelectedRoom
            // 
            this.lblSelectedRoom.AutoSize = true;
            this.lblSelectedRoom.Location = new System.Drawing.Point(423, 450);
            this.lblSelectedRoom.Name = "lblSelectedRoom";
            this.lblSelectedRoom.Size = new System.Drawing.Size(159, 15);
            this.lblSelectedRoom.TabIndex = 26;
            this.lblSelectedRoom.Text = "Your selected room:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 636);
            this.Controls.Add(this.lblSelectedRoom);
            this.Controls.Add(this.nudChildren);
            this.Controls.Add(this.nudAdults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblChildren);
            this.Controls.Add(this.lblAdults);
            this.Controls.Add(this.cbDisabled);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbtDuration);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chbBreakFast);
            this.Controls.Add(this.lbRooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.cbRoomSize);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cbCustomerID);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCustomerID;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cbRoomSize;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRooms;
        private System.Windows.Forms.CheckBox chbBreakFast;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbtDuration;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox cbDisabled;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudAdults;
        private System.Windows.Forms.NumericUpDown nudChildren;
        private System.Windows.Forms.Label lblSelectedRoom;
    }
}