using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog7312_Poe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            reportIssues report = new reportIssues();
            report.Show();
            MessageBox.Show("Welcome to Report Issues! Please complete the form to report any issues.", "Success");
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disabled until further notice.", "Error");
            btnAnnouncement.Enabled = false;
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disabled until further notice.", "Error");
            btnStatus.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void lblOption_Click(object sender, EventArgs e)
        {
            lblOption.Font = new Font(lblOption.Font, FontStyle.Bold);
        }
    }
}
