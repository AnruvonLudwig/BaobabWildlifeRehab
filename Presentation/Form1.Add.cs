using BaobabWildlifeRehab.BusinessLogic;
using BaobabWildlifeRehab.Data;

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
                handler.Add(id,name,species,ageText,scoreText);
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
