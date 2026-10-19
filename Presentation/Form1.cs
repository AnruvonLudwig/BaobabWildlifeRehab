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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private string FormatAverage(double? average)
        {
            return average.HasValue
                ? average.Value.ToString(
                    "F2",
                    System.Globalization.CultureInfo.InvariantCulture)
                : "N/A";
        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {

            // Reset the labels before generating a new summary.
            lblTotalAnimals.Text = "Total animals: -";
            lblAverageAge.Text = "Average age (years): -";
            lblAverageScore.Text = "Average recovery score: -";

            lblCriticalCount.Text = "Critical: -";
            lblSeriousCount.Text = "Serious: -";
            lblStableCount.Text = "Stable: -";
            lblRecoveringCount.Text = "Recovering: -";
            lblReleaseReadyCount.Text = "Release-Ready: -";

            try
            {

                // Generate the summary report using the DataHandler

                SummaryReport report = handler.GenerateSummary();

                // Update the labels with the summary report data

                lblTotalAnimals.Text =
                    $"Total animals: {report.TotalAnimals}";

                lblAverageAge.Text =
                    $"Average age (years): {FormatAverage(report.AverageAge)}";

                lblAverageScore.Text =
                    $"Average recovery score: " +
                    $"{FormatAverage(report.AverageRecoveryScore)}";

                lblCriticalCount.Text =
                    $"Critical: {report.StatusCounts["Critical"]}";

                lblSeriousCount.Text =
                    $"Serious: {report.StatusCounts["Serious"]}";

                lblStableCount.Text =
                    $"Stable: {report.StatusCounts["Stable"]}";

                lblRecoveringCount.Text =
                    $"Recovering: {report.StatusCounts["Recovering"]}";

                lblReleaseReadyCount.Text =
                    $"Release-Ready: {report.StatusCounts["Release-Ready"]}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Generate Summary",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

        private void dgvAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
