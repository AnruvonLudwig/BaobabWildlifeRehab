namespace BaobabWildlifeRehab.BusinessLogic
{
    // Business layer - logic shared by Add and Update
    public partial class DataHandler
    {
        // Validates Name, Species, Age and Score (trimmed) for BOTH Add and Update.
        // Throws ValidationException naming the field. Returns the cleaned values.
        private static void ValidateCommonFields(string name, string species,
            string ageText, string scoreText,
            out string cleanName, out string cleanSpecies, out int age, out int score)
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}