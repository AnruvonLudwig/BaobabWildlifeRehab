using BaobabWildlifeRehab.BusinessLogic;

namespace BaobabWildlifeRehab
{
    public partial class Form1 : Form
    {

        private readonly DataHandler handler = new DataHandler();

        public Form1()
        {
            InitializeComponent();

            dgvAnimals.DataSource = handler.DataSource;
        }

        private void LoadAnimals()
        {
            try
            {
                int skippedCount = handler.Load();

                if (skippedCount > 0)
                {
                    MessageBox.Show(
                        $"{skippedCount} malformed record(s) were skipped.",
                        "Animal Records",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Load Animals",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {

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

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAnimals();
        }
    }
}
