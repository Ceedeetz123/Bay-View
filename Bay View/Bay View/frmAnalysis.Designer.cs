namespace Bay_View
{
    partial class frmAnalysis
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
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(107, 122);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(136, 66);
            this.btnRooms.TabIndex = 0;
            this.btnRooms.Text = "Room Occupancy each month";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(335, 122);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(136, 66);
            this.btnYear.TabIndex = 3;
            this.btnYear.Text = "Yearly Revenue";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(563, 122);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(136, 66);
            this.btnMonth.TabIndex = 4;
            this.btnMonth.Text = "Occupancy for a year";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(335, 263);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(136, 62);
            this.btnData.TabIndex = 5;
            this.btnData.Text = "Track Booking Form";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // frmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnRooms);
            this.Name = "frmAnalysis";
            this.Text = "Analysis";
            this.Load += new System.EventHandler(this.frmAnalysis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnData;
    }
}