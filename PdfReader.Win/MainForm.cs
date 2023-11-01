using PdfReader.Business.Contracts;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PdfReader.Win
{
    public partial class MainForm : Form
    {
        private readonly IPdfParser pdfParser;

        public MainForm(IPdfParser pdfParser)
        {
            InitializeComponent();
            this.pdfParser = pdfParser;
        }

        private void btnSelectPdf_Click(object sender, System.EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtPdfFilePath.Text = openFileDialog.FileName;
                    var resume = pdfParser.Deserialize(txtPdfFilePath.Text);
                    txtFullName.Text = resume.FullName;
                    txtTitle.Text = resume.Title;
                    txtCompany.Text = resume.Company;
                    txtWorkingPlace.Text = resume.WorkingPlace;
                    txtTopSkills.Text = string.Join(Environment.NewLine, resume.TopSkills ?? Enumerable.Empty<string>());
                    txtAddress.Text = resume.Contact?.Address;
                    txtPhone.Text = resume.Contact?.Phone;
                    txtEmail.Text = resume.Contact?.Email;
                    txtLinkedIn.Text = resume.Contact?.LinkedIn;
                    txtOldCompany.Text = resume.WorkingExperience?.Company;
                    txtOldTitle.Text = resume.WorkingExperience?.Title;
                    txtPeriod.Text = resume.WorkingExperience?.Period;
                    txtDescription.Text = resume.WorkingExperience?.Description;
                    txtOthers.Text = resume.WorkingExperience?.Others;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error message: {ex.Message}");
                }
            }
        }
    }
}