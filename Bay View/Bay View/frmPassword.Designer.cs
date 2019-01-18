namespace Bay_View
{
    partial class frmPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPassword));
            this.tbtNewPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.tbtStaffID = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbtOldPass = new System.Windows.Forms.TextBox();
            this.lblOld = new System.Windows.Forms.Label();
            this.tbtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbtNewPass
            // 
            this.tbtNewPass.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.tbtNewPass.Location = new System.Drawing.Point(281, 223);
            this.tbtNewPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbtNewPass.Name = "tbtNewPass";
            this.tbtNewPass.Size = new System.Drawing.Size(191, 34);
            this.tbtNewPass.TabIndex = 6;
            this.tbtNewPass.TextChanged += new System.EventHandler(this.tbtPassword_TextChanged);
            this.tbtNewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.lblNewPass.Location = new System.Drawing.Point(157, 226);
            this.lblNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(100, 18);
            this.lblNewPass.TabIndex = 5;
            this.lblNewPass.Text = "New Password";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.lblStaffID.Location = new System.Drawing.Point(157, 85);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(55, 18);
            this.lblStaffID.TabIndex = 4;
            this.lblStaffID.Text = "Staff ID";
            // 
            // tbtStaffID
            // 
            this.tbtStaffID.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.tbtStaffID.Location = new System.Drawing.Point(281, 82);
            this.tbtStaffID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbtStaffID.Name = "tbtStaffID";
            this.tbtStaffID.Size = new System.Drawing.Size(191, 34);
            this.tbtStaffID.TabIndex = 8;
            this.tbtStaffID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(383, 279);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 34);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(512, 332);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 35);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbtOldPass
            // 
            this.tbtOldPass.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.tbtOldPass.Location = new System.Drawing.Point(281, 130);
            this.tbtOldPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbtOldPass.Name = "tbtOldPass";
            this.tbtOldPass.Size = new System.Drawing.Size(191, 34);
            this.tbtOldPass.TabIndex = 12;
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.lblOld.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.lblOld.Location = new System.Drawing.Point(157, 133);
            this.lblOld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(94, 18);
            this.lblOld.TabIndex = 11;
            this.lblOld.Text = "Old Password";
            // 
            // tbtEmail
            // 
            this.tbtEmail.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.tbtEmail.Location = new System.Drawing.Point(281, 177);
            this.tbtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbtEmail.Name = "tbtEmail";
            this.tbtEmail.Size = new System.Drawing.Size(191, 34);
            this.tbtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(157, 180);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 18);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(113, 111);
            this.pbLogo.TabIndex = 15;
            this.pbLogo.TabStop = false;
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(591, 379);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.tbtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbtOldPass);
            this.Controls.Add(this.lblOld);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbtStaffID);
            this.Controls.Add(this.tbtNewPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblStaffID);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Password";
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbtNewPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox tbtStaffID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbtOldPass;
        private System.Windows.Forms.Label lblOld;
        private System.Windows.Forms.TextBox tbtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}