using BaobabWildlifeRehab.BusinessLogic;
using BaobabWildlifeRehab.Data;
using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab
{
    public partial class Form1 : Form
    {
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtAnimaliD.Text;
            string name = txtName.Text;
            string species = txtSpecies.Text;
            string ageText = txtAge.Text;
            string scoreText = txtRecoveryScore.Text;


            try
            {
                Animal newAnimal = handler.Add(id,name,species,ageText,scoreText);
                MessageBox.Show($"Added new animal: {id}.\nStatus is: {newAnimal.Status}\nHoused at: {newAnimal.HousingUnit}");
            }
            catch (ValidationException valEx)
            {
                MessageBox.Show($"{valEx.Message}");
                FocusErrorField(valEx.FieldName);
            }
            catch (DataAccessException datEx)
            {
                MessageBox.Show($"{datEx.Message}");
            }
        }

    }
}
