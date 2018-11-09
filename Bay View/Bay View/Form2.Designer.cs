namespace Bay_View
{
    partial class Form2
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
            this.lblStaffID = new System.Windows.Forms.Label();
            this.tbtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblStaffIDText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(398, 141);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(71, 15);
            this.lblStaffID.TabIndex = 7;
            this.lblStaffID.Text = "Staff ID";
            // 
            // tbtPassword
            // 
            this.tbtPassword.Location = new System.Drawing.Point(391, 191);
            this.tbtPassword.Name = "tbtPassword";
            this.tbtPassword.Size = new System.Drawing.Size(100, 25);
            this.tbtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(283, 194);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 15);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblStaffIDText
            // 
            this.lblStaffIDText.AutoSize = true;
            this.lblStaffIDText.Location = new System.Drawing.Point(283, 141);
            this.lblStaffIDText.Name = "lblStaffIDText";
            this.lblStaffIDText.Size = new System.Drawing.Size(71, 15);
            this.lblStaffIDText.TabIndex = 4;
            this.lblStaffIDText.Text = "Staff ID";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.tbtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblStaffIDText);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox tbtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblStaffIDText;
    }
}