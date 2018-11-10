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
            this.tbtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.tbtStaffID = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(283, 141);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(71, 15);
            this.lblStaffID.TabIndex = 4;
            this.lblStaffID.Text = "Staff ID";
            // 
            // tbtStaffID
            // 
            this.tbtStaffID.Location = new System.Drawing.Point(391, 138);
            this.tbtStaffID.Name = "tbtStaffID";
            this.tbtStaffID.Size = new System.Drawing.Size(100, 25);
            this.tbtStaffID.TabIndex = 8;
            this.tbtStaffID.TextChanged += new System.EventHandler(this.tbtStaffID_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(401, 324);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbtStaffID);
            this.Controls.Add(this.tbtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblStaffID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox tbtStaffID;
        private System.Windows.Forms.Button btnSubmit;
    }
}