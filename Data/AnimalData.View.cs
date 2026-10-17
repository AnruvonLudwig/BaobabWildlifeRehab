using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab.Data
{
    // Data layer - Feature: View and search
    internal partial class AnimalData
    {
        // Fills the bound list and returns the number of non-empty malformed lines skipped.
        public int Load()
        {
            try
            {
                if (!File.Exists(AnimalsFilePath))
                {
                    ReplaceAll(Array.Empty<Animal>());
                    return 0;
                }

                var loaded = new List<Animal>();
                int skippedLines = 0;
                foreach (string line in File.ReadAllLines(AnimalsFilePath))
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;
                    if (TryParseLine(line, out Animal animal))
                        loaded.Add(animal);
                    else
                        skippedLines++;
                }

                ReplaceAll(loaded);
                return skippedLines;
            }
            catch (DataAccessException)
            {
                throw;
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or NotSupportedException)
            {
                throw WrapFileError("load", ex);
            }
        }

        // Finds an animal by ID, reading the file so a stale grid cannot return an old record.
        public Animal? FindById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return null;

            try
            {
                if (File.Exists(AnimalsFilePath))
                {
                    foreach (string line in File.ReadAllLines(AnimalsFilePath))
                    {
                        if (TryParseLine(line, out Animal animal) &&
                            string.Equals(animal.Id, id.Trim(), StringComparison.OrdinalIgnoreCase))
                        {
                            return animal;
                        }
                    }
                }
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or NotSupportedException)
            {
                throw WrapFileError("search", ex);
            }

            return CurrentAnimals.FirstOrDefault(animal =>
                string.Equals(animal.Id, id.Trim(), StringComparison.OrdinalIgnoreCase));
        }
    }
}
