namespace BaobabWildlifeRehab.BusinessLogic
{
    // Business layer - logic shared by Add and Update
    internal partial class DataHandler
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

        // Maps a recovery score (0-100) to its status and housing unit.
        /// <summary>
        /// To use: (string status, string housingUnit) = Classify(score);
        /// 
        /// ... = status;
        /// ...
        /// </summary>
        public static (string Status, string HousingUnit) Classify(int score)
        {
            if (score <= 19) return ("Critical", "Intensive Care Unit");
            if (score <= 39) return ("Serious", "High-Dependency Ward");
            if (score <= 59) return ("Stable", "Recovery Ward");
            if (score <= 79) return ("Recovering", "Outdoor Enclosure");
            return ("Release-Ready", "Pre-Release Camp");
        }
    }


}