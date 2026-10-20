using BaobabWildlifeRehab.Models;

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
            cleanName = name.Trim();
            cleanSpecies = species.Trim();

            if (cleanName == "")
                throw new ValidationException("Name is required.",FieldNames.Name);

            if (cleanSpecies == "")
                throw new ValidationException("Species is required.",FieldNames.Species);

            if (cleanName.Length > 30)
                throw new ValidationException("Name cannot be longer than 30 characters", FieldNames.Name);

            if (cleanSpecies.Length > 30)
                throw new ValidationException("Species cannot be longer than 30 characters", FieldNames.Species);

            if (cleanName.Contains("|") || cleanName.Contains("\r") || cleanName.Contains("\n"))
                throw new ValidationException("Name cannot contain | or a line break.",FieldNames.Name);

            if (cleanSpecies.Contains("|") || cleanSpecies.Contains("\r") || cleanSpecies.Contains("\n"))
                throw new ValidationException("Species cannot contain | or a line break.",FieldNames.Species);

            if (!int.TryParse(ageText, out age))
                throw new ValidationException("Age must be a whole number.",FieldNames.Age);

            if (age < 0 || age > 100)
                throw new ValidationException("Age must be between 0 and 100.", FieldNames.Age);

            if (!int.TryParse(scoreText, out score))
                throw new ValidationException("Recovery score must be a whole number.",FieldNames.RecoveryScore);

            if (score < 0 || score > 100)
                throw new ValidationException("Recovery score must be between 0 and 100.",FieldNames.RecoveryScore);
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

        public Animal? FindById(string id)
        {
            return data.FindById(id);
        }
    }


}