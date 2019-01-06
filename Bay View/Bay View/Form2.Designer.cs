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
            this.SuspendLayout();
            // 
            // tbtNewPass
            // 
            this.tbtNewPass.Location = new System.Drawing.Point(391, 257);
            this.tbtNewPass.Name = "tbtNewPass";
            this.tbtNewPass.Size = new System.Drawing.Size(100, 25);
            this.tbtNewPass.TabIndex = 6;
            this.tbtNewPass.TextChanged += new System.EventHandler(this.tbtPassword_TextChanged);
            this.tbtNewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(283, 260);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(103, 15);
            this.lblNewPass.TabIndex = 5;
            this.lblNewPass.Text = "New Password";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(283, 97);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(71, 15);
            this.lblStaffID.TabIndex = 4;
            this.lblStaffID.Text = "Staff ID";
            // 
            // tbtStaffID
            // 
            this.tbtStaffID.Location = new System.Drawing.Point(391, 94);
            this.tbtStaffID.Name = "tbtStaffID";
            this.tbtStaffID.Size = new System.Drawing.Size(100, 25);
            this.tbtStaffID.TabIndex = 8;
            this.tbtStaffID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(401, 324);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(36, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 54);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbtOldPass
            // 
            this.tbtOldPass.Location = new System.Drawing.Point(391, 149);
            this.tbtOldPass.Name = "tbtOldPass";
            this.tbtOldPass.Size = new System.Drawing.Size(100, 25);
            this.tbtOldPass.TabIndex = 12;
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.lblOld.Location = new System.Drawing.Point(283, 152);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(103, 15);
            this.lblOld.TabIndex = 11;
            this.lblOld.Text = "Old Password";
            // 
            // tbtEmail
            // 
            this.tbtEmail.Location = new System.Drawing.Point(391, 203);
            this.tbtEmail.Name = "tbtEmail";
            this.tbtEmail.Size = new System.Drawing.Size(100, 25);
            this.tbtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(283, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
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
    }
}