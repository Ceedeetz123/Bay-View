namespace Bay_View
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnGuests = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnEditBookings = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(286, 34);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Menu";
            // 
            // btnBooking
            // 
            this.btnBooking.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.btnBooking.Location = new System.Drawing.Point(41, 204);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(136, 68);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.Text = "Book a Room";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.lblBooking_Click);
            // 
            // btnGuests
            // 
            this.btnGuests.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuests.Location = new System.Drawing.Point(219, 204);
            this.btnGuests.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGuests.Name = "btnGuests";
            this.btnGuests.Size = new System.Drawing.Size(139, 68);
            this.btnGuests.TabIndex = 2;
            this.btnGuests.Text = "Guests";
            this.btnGuests.UseVisualStyleBackColor = true;
            this.btnGuests.Click += new System.EventHandler(this.btnGuests_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnalysis.Location = new System.Drawing.Point(416, 204);
            this.btnAnalysis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(131, 67);
            this.btnAnalysis.TabIndex = 3;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(239, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome To Bay View!";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(217, 94);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(58, 18);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "You are:";
            // 
            // btnEditBookings
            // 
            this.btnEditBookings.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditBookings.Location = new System.Drawing.Point(41, 296);
            this.btnEditBookings.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEditBookings.Name = "btnEditBookings";
            this.btnEditBookings.Size = new System.Drawing.Size(136, 60);
            this.btnEditBookings.TabIndex = 6;
            this.btnEditBookings.Text = "Change Bookings";
            this.btnEditBookings.UseVisualStyleBackColor = true;
            this.btnEditBookings.Click += new System.EventHandler(this.btnEditBookings_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.PowderBlue;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(113, 111);
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(600, 390);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnEditBookings);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.btnGuests);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Menu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
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
        private System.Windows.Forms.PictureBox pbLogo;
    }
}