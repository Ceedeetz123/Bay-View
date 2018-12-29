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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tbtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.tbtStaffID = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // tbtPassword
            // 
            this.tbtPassword.Location = new System.Drawing.Point(264, 108);
            this.tbtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtPassword.Name = "tbtPassword";
            this.tbtPassword.Size = new System.Drawing.Size(176, 26);
            this.tbtPassword.TabIndex = 6;
            this.tbtPassword.TextChanged += new System.EventHandler(this.tbtPassword_TextChanged);
            this.tbtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Candara", 11.25F);
            this.lblPassword.Location = new System.Drawing.Point(185, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 18);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(185, 52);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(54, 18);
            this.lblStaffID.TabIndex = 4;
            this.lblStaffID.Text = "Staff ID";
            // 
            // tbtStaffID
            // 
            this.tbtStaffID.Location = new System.Drawing.Point(264, 44);
            this.tbtStaffID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtStaffID.Name = "tbtStaffID";
            this.tbtStaffID.Size = new System.Drawing.Size(176, 26);
            this.tbtStaffID.TabIndex = 8;
            this.tbtStaffID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Silver;
            this.btnSubmit.Location = new System.Drawing.Point(327, 177);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(129, 45);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Silver;
            this.btnReset.Location = new System.Drawing.Point(161, 177);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 45);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(113, 111);
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(452, 263);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(40, 31);
            this.pbExit.TabIndex = 12;
            this.pbExit.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(504, 306);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbtStaffID);
            this.Controls.Add(this.tbtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblStaffID);
            this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox tbtStaffID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbExit;
    }
}