using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab.Data
{
    // Data layer - Feature: Update
    internal partial class AnimalData
    {
        // Replace the matching record and leave all other lines unchanged.
        public void Update(Animal animal)
        {
            try
            {
                string[] lines = File.ReadAllLines(AnimalsFilePath);
                bool found = false;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (TryParseLine(lines[i], out Animal current) &&
                        string.Equals(current.Id, animal.Id, StringComparison.OrdinalIgnoreCase))
                    {
                        lines[i] = ToLine(animal);
                        found = true;
                        break;
                    }
                }

                if (!found)
                    throw new DataAccessException($"Animal ID '{animal.Id}' was not found.");

                File.WriteAllLines(AnimalsFilePath, lines);

                for (int i = 0; i < animals.Count; i++)
                {
                    if (string.Equals(animals[i].Id, animal.Id, StringComparison.OrdinalIgnoreCase))
                    {
                        animals[i] = animal;
                        break;
                    }
                }
            }
            catch (DataAccessException)
            {
                throw;
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                throw WrapFileError("save changes to", ex);
            }
        }
    }
}
