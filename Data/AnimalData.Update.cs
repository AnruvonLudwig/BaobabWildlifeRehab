using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab.Data
{
    // Data layer - Feature: Update
    internal partial class AnimalData
    {

        public void Update(Animal animal)
        {
            Animal? currentAnimal = FindById(animal.Id);

            if (currentAnimal == null)
                throw new DataAccessException("Animal ID was not found.");

            currentAnimal.Name = animal.Name;
            currentAnimal.Species = animal.Species;
            currentAnimal.Age = animal.Age;
            currentAnimal.RecoveryScore = animal.RecoveryScore;
            currentAnimal.Status = animal.Status;
            currentAnimal.HousingUnit = animal.HousingUnit;

            List<string> lines = new List<string>();

            foreach (Animal current in DataSource)
                lines.Add(ToLine(current));

            try
            {
                File.WriteAllLines(AnimalsFilePath, lines);
            }
            catch (UnauthorizedAccessException)
            {
                throw new DataAccessException("You do not have permission to update animals.txt.");
            }
            catch (IOException)
            {
                throw new DataAccessException("Could not update animals.txt.");
            }

            DataSource.ResetBindings(false);
        }
    }
}