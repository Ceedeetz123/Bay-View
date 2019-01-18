namespace Bay_View
{
    partial class frmOccupancyTypes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbtYear = new System.Windows.Forms.TextBox();
            this.tbtSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(24, 27);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(596, 365);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tbtYear
            // 
            this.tbtYear.Location = new System.Drawing.Point(660, 141);
            this.tbtYear.Name = "tbtYear";
            this.tbtYear.Size = new System.Drawing.Size(100, 25);
            this.tbtYear.TabIndex = 1;
            this.tbtYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbtYear_KeyDown);
            // 
            // tbtSize
            // 
            this.tbtSize.Location = new System.Drawing.Point(660, 201);
            this.tbtSize.Name = "tbtSize";
            this.tbtSize.Size = new System.Drawing.Size(100, 25);
            this.tbtSize.TabIndex = 2;
            this.tbtSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbtSize_KeyDown);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(693, 183);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(39, 15);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(693, 123);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 15);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(673, 248);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(72, 51);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // OccupancyTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.tbtSize);
            this.Controls.Add(this.tbtYear);
            this.Controls.Add(this.chart1);
            this.Name = "OccupancyTypes";
            this.Text = "OccupancyTypes";
            this.Load += new System.EventHandler(this.OccupancyTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox tbtYear;
        private System.Windows.Forms.TextBox tbtSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnSubmit;
    }
}