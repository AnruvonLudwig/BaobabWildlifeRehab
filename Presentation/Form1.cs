using BaobabWildlifeRehab.BusinessLogic;
using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab
{
    public partial class Form1 : Form
    {

        private readonly DataHandler handler = new DataHandler();

        public Form1()
        {
            InitializeComponent();
            SetAddMode();
        }



        private void txtAnimaliD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpecies_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRecoveryScore_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {



            try
            {

                // Generate the summary report using the DataHandler

                SummaryReport report = handler.GenerateSummary();

                // Update the labels with the summary report data

                lblTotalAnimalsSummary.Text = $"Total animals: {report.TotalAnimals}";
                lblAverageAgeSummary.Text = $"Average age (years): {report.FormatAverage(report.AverageAge)}";
                lblAverageScoreSummary.Text = $"Average recovery score: " + $"{report.FormatAverage(report.AverageRecoveryScore)}";
                lblCriticalCountSummary.Text = $"Critical: {report.StatusCounts["Critical"]}";
                lblSeriousCountSummary.Text = $"Serious: {report.StatusCounts["Serious"]}";
                lblStableCountSummary.Text = $"Stable: {report.StatusCounts["Stable"]}";
                lblRecoveryCountSummary.Text = $"Recovering: {report.StatusCounts["Recovering"]}";
                lblReleaseReadyCountSummary.Text = $"Release-Ready: {report.StatusCounts["Release-Ready"]}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Generate Summary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalAnimals_Click(object sender, EventArgs e)
        {

        }

        private void lblAverageAge_Click(object sender, EventArgs e)
        {

        }

        private void lblAverageScore_Click(object sender, EventArgs e)
        {

        }

        private void lblCriticalCount_Click(object sender, EventArgs e)
        {

        }

        private void lblSeriousCount_Click(object sender, EventArgs e)
        {

        }

        private void lblStableCount_Click(object sender, EventArgs e)
        {

        }

        private void lblRecoveringCount_Click(object sender, EventArgs e)
        {

        }

        private void lblReleaseReadyCount_Click(object sender, EventArgs e)
        {

        }

        private void FocusErrorField(FieldNames fieldName)
        {
            switch (fieldName)
            {
                case FieldNames.AnimalID:
                    txtAnimaliD.Focus();
                    break;
                case FieldNames.Name:
                    txtName.Focus();
                    break;
                case FieldNames.Species:
                    txtSpecies.Focus();
                    break;
                case FieldNames.Age:
                    txtAge.Focus();
                    break;
                case FieldNames.RecoveryScore:
                    txtRecoveryScore.Focus();
                    break;

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTotalAnimalsSummary_Click(object sender, EventArgs e)
        {

        }
    }
}
 