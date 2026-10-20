using BaobabWildlifeRehab.BusinessLogic;
using BaobabWildlifeRehab.Data;
using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab
{
    public partial class Form1 : Form
    {
        private string? editingId;

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (editingId == null)
                return;

            try
            {
                handler.Update(editingId, txtName.Text, txtSpecies.Text,
                    txtAge.Text, txtRecoveryScore.Text);

                MessageBox.Show("Animal updated.");
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
                FocusErrorField(ex.FieldName);
            }
            catch (DataAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetAddMode();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtSearchID.Text.Trim();

            if (id == "")
            {
                SetAddMode();
                MessageBox.Show("Enter an animal ID.");
                return;
            }

            Animal? animal = handler.FindById(id);

            if (animal == null)
            {
                SetAddMode();
                txtSearchID.Text = id;
                MessageBox.Show("Animal not found.");
                return;
            }

            LoadAnimalForEditing(animal);
        }

        private void dgvAnimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Animal? animal = dgvAnimals.Rows[e.RowIndex].DataBoundItem as Animal;

            if (animal != null)
                LoadAnimalForEditing(animal);
        }

        private void LoadAnimalForEditing(Animal animal)
        {
            editingId = animal.Id;

            txtAnimaliD.Text = animal.Id;
            txtName.Text = animal.Name;
            txtSpecies.Text = animal.Species;
            txtAge.Text = animal.Age.ToString();
            txtRecoveryScore.Text = animal.RecoveryScore.ToString();

            txtAnimaliD.ReadOnly = true;
            btnAdd.Enabled = false;
            btnSaveChanges.Enabled = true;
        }

        private void SetAddMode()
        {
            editingId = null;

            txtAnimaliD.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtRecoveryScore.Clear();
            txtSearchID.Clear();

            txtAnimaliD.ReadOnly = false;
            btnAdd.Enabled = true;
            btnSaveChanges.Enabled = false;
        }
    }
}
