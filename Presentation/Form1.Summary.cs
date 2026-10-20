using BaobabWildlifeRehab.BusinessLogic;
using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab
{
    public partial class Form1 : Form
    {
        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {

            try
            {

                // Generate the summary report using the DataHandler

                SummaryReport report = handler.GenerateSummary();

                // Update the labels with the summary report data

                lblTotalAnimalsSummary.Text = $"{report.TotalAnimals}";
                lblAverageAgeSummary.Text = $"{report.FormatAverage(report.AverageAge)}";
                lblAverageScoreSummary.Text = $"{report.FormatAverage(report.AverageRecoveryScore)}";
                lblCriticalCountSummary.Text = $"{report.StatusCounts["Critical"]}";
                lblSeriousCountSummary.Text = $"{report.StatusCounts["Serious"]}";
                lblStableCountSummary.Text = $"{report.StatusCounts["Stable"]}";
                lblRecoveryCountSummary.Text = $"{report.StatusCounts["Recovering"]}";
                lblReleaseReadyCountSummary.Text = $"{report.StatusCounts["Release-Ready"]}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Generate Summary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}