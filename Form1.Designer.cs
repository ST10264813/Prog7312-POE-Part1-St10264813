namespace Prog7312_Poe
{
    partial class Form1
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
            this.btnReport = new System.Windows.Forms.Button();
            this.btnAnnouncement = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.Location = new System.Drawing.Point(270, 150);
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReport.Name = "btnReport";
            this.btnReport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Size = new System.Drawing.Size(350, 50);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Report Issues";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnAnnouncement
            // 
            this.btnAnnouncement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnouncement.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnnouncement.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAnnouncement.ForeColor = System.Drawing.Color.White;
            this.btnAnnouncement.Location = new System.Drawing.Point(270, 220);
            this.btnAnnouncement.Name = "btnAnnouncement";
            this.btnAnnouncement.Size = new System.Drawing.Size(350, 50);
            this.btnAnnouncement.TabIndex = 1;
            this.btnAnnouncement.Text = "Local Events and Announcements";
            this.btnAnnouncement.UseVisualStyleBackColor = false;
            this.btnAnnouncement.Click += new System.EventHandler(this.btnAnnouncement_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(270, 290);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(350, 50);
            this.btnStatus.TabIndex = 2;
            this.btnStatus.Text = "Service Request Status";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 30);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOption
            // 
            this.lblOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.Location = new System.Drawing.Point(300, 80);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(300, 35);
            this.lblOption.TabIndex = 4;
            this.lblOption.Text = "Please select an option below:";
            this.lblOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOption.Click += new System.EventHandler(this.lblOption_Click);
            // 
            // Form1
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.BackColor = System.Drawing.Color.WhiteSmoke; // background

            this.Controls.Add(this.lblOption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnAnnouncement);
            this.Controls.Add(this.btnReport);
            this.Name = "Form1";
            this.Text = "Municipality Services - Home";
            this.ResumeLayout(false);
            this.PerformLayout();




        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnAnnouncement;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOption;
    }
}

