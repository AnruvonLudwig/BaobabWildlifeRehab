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

        
    }
}
 