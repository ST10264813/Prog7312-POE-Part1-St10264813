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
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";//allows for these types of files and images
            openFileDialog1.Multiselect = false;//only allows for one file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//if file selected shows the file name in txtAttachment
            {
                txtAttachment.Text = openFileDialog1.FileName;
            }
        }//(Microsoft, 2025)

        private void UpdateBar()
        {
            int totalFields = 4; // txtLocation, comboCategory, rchTxtDescription, txtAttachment
            int currentField = 0;
            //adds currentField to increase as each field is filled

            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                currentField++;

            if (comboCategory.SelectedIndex >= 0)
                currentField++;

            if (!string.IsNullOrWhiteSpace(rchTxtDescription.Text))
                currentField++;

            if (!string.IsNullOrWhiteSpace(txtAttachment.Text))
                currentField++;

            //progress bar gets updated based on how many fields are filled
            prgressBar.Value = (currentField * 100) / totalFields;

        }//(Stack Overflow, 2020)
        private void reportIssues_Load(object sender, EventArgs e)
        {
            //updates progress bar based on event happening
            txtLocation.TextChanged += (s, ev) => UpdateBar();
            rchTxtDescription.TextChanged += (s, ev) => UpdateBar();
            comboCategory.SelectedIndexChanged += (s, ev) => UpdateBar();
            txtAttachment.TextChanged += (s, ev) => UpdateBar();


            //list of issues for dropdown
            List<string> IssueList = new List<string>();
            IssueList.Add("Sanitation");
            IssueList.Add("Roads");
            IssueList.Add("Utilities");
            IssueList.Add("Public Safety ");
            IssueList.Add("Environmental Concerns");
            IssueList.Add("Other ");

            comboCategory.DataSource = IssueList; //links list to dropdown
            comboCategory.SelectedIndex = -1;//AllowDrop down starts empty

        }

        private void prgressBar_Click(object sender, EventArgs e)
        {
            prgressBar.Minimum = 0;
            prgressBar.Maximum = 100;//bar maxes at 100
            prgressBar.Value = 0;//starts at 0
            prgressBar.Style = ProgressBarStyle.Continuous;
            prgressBar.Step = 1;//increments by 1

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this style prevents users from changing list in dropdown
            comboCategory.DropDownStyle = ComboBoxStyle.DropDownList; //(DevExpress, 2025)
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<string> ReportList = new List<string>();
            if (prgressBar.Value == 100)//if all fields are filled allows for issue to be submitted
            {

                ReportList.Add(txtLocation.Text);
                ReportList.Add(comboCategory.Text);
                ReportList.Add(rchTxtDescription.Text);
                ReportList.Add(txtAttachment.Text);

                string report = string.Join(", ", ReportList);

                MessageBox.Show("Issue has been submitted!/n" + report, "Success");

                //clears form for new issue
                txtAttachment.Clear();
                rchTxtDescription.Clear();
                txtLocation.Clear();
                comboCategory.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Please fill out all fields.", "Error");//message if not all fields are filled
            }
        }

        
    }
}
//references
//DevExpress.2025.ComboBoxProperties.DropDownStyle Property . <https://docs.devexpress.com/AspNet/DevExpress.Web.comboBoxProperties.DropDownStyle?utm_source=SupportCenter&utm_medium=website&utm_campaign=docs-feedback&utm_content=T343861> [Accessed 5 September 2025].
//Miscosoft., 2025. OpenFileDialog Class (System.Windows.Forms). [online] Microsoft.com. Available at: <https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-9.0&redirectedfrom=MSDN> [Accessed 1 September 2025].
//Stack Overflow, 2020. How to increase a ProgressBar Value according to the content of TextBoxes? [online] Stack Overflow. Available at: <https://stackoverflow.com/questions/65061068/how-to-increase-a-progressbar-value-according-to-the-content-of-textboxes> [Accessed 1 September 2025].