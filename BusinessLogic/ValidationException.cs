using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaobabWildlifeRehab.BusinessLogic
{
    public enum FieldNames
    {
        AnimalID,
        Name,
        Species,
        Age,
        RecoveryScore,
        Status,
        HousingUnit
    }

    // Thrown when user input breaks a rule. FieldName tells the form which box gets the cursor.
    public class ValidationException : Exception
    {
        public FieldNames FieldName { get; }
        public string getFieldNameString()
        {
            switch (FieldName)
            {
                case FieldNames.AnimalID:
                    return "Animal ID";
                case FieldNames.Name:
                    return "Name";
                case FieldNames.Species:
                    return "Species";
                case FieldNames.Age:
                    return "Age";
                case FieldNames.RecoveryScore:
                    return "Recovery Score";
                case FieldNames.Status:
                    return "Status";
                case FieldNames.HousingUnit:
                    return "Housing Unit";
                default:
                    return string.Empty;
            }

            }

        // Stores the message shown to the user and the name of the offending field.
        public ValidationException(string message, FieldNames fieldName) : base(message)
        {
            FieldName = fieldName;
        }
    }
}