using BaobabWildlifeRehab.BusinessLogic;

namespace BaobabWildlifeRehab
{
    public partial class Form1 : Form
    {
        private void LoadAnimals()
        {
            try
            {
                int skippedCount = handler.Load();
                dgvAnimals.DataSource = handler.DataSource;

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


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAnimals();
        }

    }
}