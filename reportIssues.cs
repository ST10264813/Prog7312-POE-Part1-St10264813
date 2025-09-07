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
    public partial class reportIssues : Form
    {
        public reportIssues()
        {
            InitializeComponent();
        }


        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes issues form

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtAttachment.Text = openFileDialog1.FileName;
            }
        }

        private void UpdateBar()
        {
            int totalFields = 4; // txtLocation, comboCategory, rchTxtDescription, txtAttachment
            int currentField = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                currentField++;

            if (comboCategory.SelectedIndex >= 0)
                currentField++;

            if (!string.IsNullOrWhiteSpace(rchTxtDescription.Text))
                currentField++;

            if (!string.IsNullOrWhiteSpace(txtAttachment.Text))
                currentField++;


            prgressBar.Value = (currentField * 100) / totalFields;

        }
        private void reportIssues_Load(object sender, EventArgs e)
        {
            txtLocation.TextChanged += (s, ev) => UpdateBar();
            rchTxtDescription.TextChanged += (s, ev) => UpdateBar();
            comboCategory.SelectedIndexChanged += (s, ev) => UpdateBar();
            txtAttachment.TextChanged += (s, ev) => UpdateBar();

            List<string> IssueList = new List<string>();
            IssueList.Add("Sanitation");
            IssueList.Add("Roads");
            IssueList.Add("Utilities");
            IssueList.Add("Public Safety ");
            IssueList.Add("Environmental Concerns");
            IssueList.Add("Other ");

            comboCategory.DataSource = IssueList;
            comboCategory.SelectedIndex = -1;

        }

        private void prgressBar_Click(object sender, EventArgs e)
        {
            prgressBar.Minimum = 0;
            prgressBar.Maximum = 100;
            prgressBar.Value = 0;
            prgressBar.Style = ProgressBarStyle.Continuous;
            prgressBar.Step = 1;

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this style prevents users from changing list in dropdown
            comboCategory.DropDownStyle = ComboBoxStyle.DropDownList; //(DevExpress, 2025)
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<string> ReportList = new List<string>();
            if (prgressBar.Value == 100)
            {

                ReportList.Add(txtLocation.Text);
                ReportList.Add(comboCategory.Text);
                ReportList.Add(rchTxtDescription.Text);
                ReportList.Add(txtAttachment.Text);

                string report = string.Join(", ", ReportList);

                MessageBox.Show("Issue has been submitted!/n" + report, "Success");
                txtAttachment.Clear();
                rchTxtDescription.Clear();
                txtLocation.Clear();
                comboCategory.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Please fill out all fields.", "Error");
            }
        }
    }
}
//references
//DevExpress.2025.ComboBoxProperties.DropDownStyle Property . <https://docs.devexpress.com/AspNet/DevExpress.Web.comboBoxProperties.DropDownStyle?utm_source=SupportCenter&utm_medium=website&utm_campaign=docs-feedback&utm_content=T343861> [Accessed 5 September 2025].

