using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab.Data
{
    // Data layer - Feature: Add
    internal partial class AnimalData
    {
        // Appends one line to animals.txt and reloads the bound list.
        public void Add(Animal animal)
        {
            try
            {
                string? directory = Path.GetDirectoryName(AnimalsFilePath);
                if (!string.IsNullOrEmpty(directory))
                    Directory.CreateDirectory(directory);

                string separator = string.Empty;
                if (File.Exists(AnimalsFilePath))
                {
                    string existingText = File.ReadAllText(AnimalsFilePath);
                    if (existingText.Length > 0 && !existingText.EndsWith('\n') && !existingText.EndsWith('\r'))
                        separator = Environment.NewLine;
                }

                File.AppendAllText(AnimalsFilePath, separator + ToLine(animal) + Environment.NewLine);
                Load();
            }
            catch (DataAccessException)
            {
                throw;
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or NotSupportedException)
            {
                throw WrapFileError("add a record to", ex);
            }
        }
    }
}
