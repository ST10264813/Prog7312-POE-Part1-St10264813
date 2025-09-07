namespace Prog7312_Poe
{
    partial class reportIssues
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
            this.prgressBar = new System.Windows.Forms.ProgressBar();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rchTxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnMedia = new System.Windows.Forms.Button();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // prgressBar
            // 
            this.prgressBar.Location = new System.Drawing.Point(200, 460);
            this.prgressBar.Name = "prgressBar";
            this.prgressBar.Size = new System.Drawing.Size(400, 20);
            this.prgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgressBar.TabIndex = 0;
            this.prgressBar.Click += new System.EventHandler(this.prgressBar_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightGray;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReturn.Location = new System.Drawing.Point(250, 400);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 35);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = " ⬅ Return to Home";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(400, 400);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 50);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit Issue";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rchTxtDescription
            // 
            this.rchTxtDescription.Location = new System.Drawing.Point(250, 140);
            this.rchTxtDescription.Name = "rchTxtDescription";
            this.rchTxtDescription.Size = new System.Drawing.Size(251, 120);
            this.rchTxtDescription.TabIndex = 3;
            this.rchTxtDescription.Text = "";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(250, 40);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(300, 22);
            this.txtLocation.TabIndex = 4;
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.Teal;
            this.btnMedia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMedia.ForeColor = System.Drawing.Color.White;
            this.btnMedia.Location = new System.Drawing.Point(520, 278);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(138, 30);
            this.btnMedia.TabIndex = 5;
            this.btnMedia.Text = "Attach Media";
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(250, 90);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(200, 24);
            this.comboCategory.TabIndex = 6;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocation.Location = new System.Drawing.Point(50, 40);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(252, 23);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Step 1: Enter Location of Issue";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(50, 90);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(218, 23);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Step 2: Select a Category:";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(50, 140);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(331, 23);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = " Step 3: Enter a Description of the Issue:";
            // 
            // txtAttachment
            // 
            this.txtAttachment.Location = new System.Drawing.Point(250, 280);
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.ReadOnly = true;
            this.txtAttachment.Size = new System.Drawing.Size(250, 22);
            this.txtAttachment.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // reportIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 520);
            this.Controls.Add(this.txtAttachment);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.rchTxtDescription);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.prgressBar);
            this.Name = "reportIssues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report an Issue";
            this.Load += new System.EventHandler(this.reportIssues_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgressBar;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox rchTxtDescription;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}