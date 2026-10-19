using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab.BusinessLogic
{
    // Business layer - Feature: Update
    internal partial class DataHandler
    {
        public Animal? FindById(string id)
        {
            return data.FindById(id);
        }

        public Animal Update(string existingId, string name, string species, string ageText, string scoreText)
        {
            Animal? existingAnimal = data.FindById(existingId);

            if (existingAnimal == null)
                throw new ValidationException("Animal ID was not found.", "ID");

            ValidateCommonFields(name, species, ageText, scoreText,
                out string cleanName, out string cleanSpecies, out int age, out int score);

            (string status, string housingUnit) = Classify(score);

            Animal updatedAnimal = new Animal(
                existingAnimal.Id,
                cleanName,
                cleanSpecies,
                age,
                score,
                status,
                housingUnit);

            data.Update(updatedAnimal);
            return updatedAnimal;
        }
    }
}