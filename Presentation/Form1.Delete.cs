using BaobabWildlifeRehab.BusinessLogic;
using BaobabWildlifeRehab.Data;

namespace BaobabWildlifeRehab
{
    public partial class Form1 : Form
    {
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvAnimals.CurrentRow;
            string id = (string)row.Cells[1].Value;
            if (id == string.Empty || id == null)
            {
                MessageBox.Show("No row to delete is selected, Please select one.");
                return;
            }

            DialogResult result = MessageBox.Show($"Delete {id} ({(string)row.Cells[2].Value})? This cannot be undone","Confirm Delete",MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes) return;

            try
            {
                handler.Delete(id);
            }
            catch (ValidationException valEx)
            {
                MessageBox.Show($"{valEx.Message} Due to Field: {valEx.FieldName}");
            }
            catch (DataAccessException datEx)
            {
                MessageBox.Show($"{datEx.Message}");
            }
        }

    }
}
