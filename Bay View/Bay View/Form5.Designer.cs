namespace Bay_View
{
    partial class Form5
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnGuests = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnEditBookings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(381, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Menu";
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(55, 235);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(181, 78);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.Text = "Book a Room";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.lblBooking_Click);
            // 
            // btnGuests
            // 
            this.btnGuests.Location = new System.Drawing.Point(292, 235);
            this.btnGuests.Name = "btnGuests";
            this.btnGuests.Size = new System.Drawing.Size(185, 78);
            this.btnGuests.TabIndex = 2;
            this.btnGuests.Text = "Guests";
            this.btnGuests.UseVisualStyleBackColor = true;
            this.btnGuests.Click += new System.EventHandler(this.btnGuests_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(555, 235);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(175, 77);
            this.btnAnalysis.TabIndex = 3;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome To Bay View!";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(289, 108);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(71, 15);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "You are:";
            // 
            // btnEditBookings
            // 
            this.btnEditBookings.Location = new System.Drawing.Point(55, 341);
            this.btnEditBookings.Name = "btnEditBookings";
            this.btnEditBookings.Size = new System.Drawing.Size(181, 69);
            this.btnEditBookings.TabIndex = 6;
            this.btnEditBookings.Text = "Change Bookings";
            this.btnEditBookings.UseVisualStyleBackColor = true;
            this.btnEditBookings.Click += new System.EventHandler(this.btnEditBookings_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditBookings);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.btnGuests);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnGuests;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnEditBookings;
    }
}