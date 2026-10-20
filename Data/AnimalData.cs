using BaobabWildlifeRehab.Data;
using System.Windows.Forms;
using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab.Data
{
    // Data layer base: holds the shared list, the file paths and the parsing helpers.
    // Each feature adds its own methods in AnimalData.<Feature>.cs.
    internal partial class AnimalData
    {
        // The grid binds to this ONCE. Features edit this list AND the file, so the grid stays current.
        public BindingSource DataSource { get; } = new BindingSource();

        // Both files live beside the running .exe.
        public string AnimalsFilePath { get; } = "animals.txt";
        public string SummaryFilePath { get; } = "summary.txt";

        // Converts an Animal to one pipe-separated file line.
        public string ToLine(Animal animal)
        {
            return string.Join("|", new[]
            {
                animal.Id,
                animal.Name,
                animal.Species,
                animal.Age.ToString(System.Globalization.CultureInfo.InvariantCulture),
                animal.RecoveryScore.ToString(System.Globalization.CultureInfo.InvariantCulture),
                animal.Status,
                animal.HousingUnit
            });
        }

        // Tries to convert a file line to an Animal; returns false if the line is malformed.
        public bool TryParseLine(string line, out Animal animal)
        {
            animal = null;


            // Check for null or whitespace line
            if (string.IsNullOrWhiteSpace(line))
                return false;

            string[] parts = line.Split('|');

            // A valid record must contain exactly 7 fields
            if (parts.Length != 7)
                return false;

            // Remove unnecessary whitespace
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = parts[i].Trim();
            }

            // Check required text fields
            if (string.IsNullOrWhiteSpace(parts[0]) || string.IsNullOrWhiteSpace(parts[1]) || string.IsNullOrWhiteSpace(parts[2]) || string.IsNullOrWhiteSpace(parts[5]) || string.IsNullOrWhiteSpace(parts[6]))
            {
                return false;
            }

            // Check that Age and RecoveryScore are valid integers
            if (!int.TryParse(parts[3], out int age))
                return false;

            if (!int.TryParse(parts[4], out int recoveryScore))
                return false;

            // Check that numeric values are within sensible ranges
            if (age < 0 || recoveryScore < 0 || recoveryScore > 100)
                return false;

            // Construct the Animal only after validation succeeds
            animal = new Animal(parts[0], parts[1], parts[2], age, recoveryScore, parts[5], parts[6]);

            return true;

    }

        // finds animal by id
        public Animal? FindById(string id)
        {
            if (!DataSource.Cast<Animal>().Any(a => a.Id == id)) return null;
            return DataSource.Cast<Animal>().First(a => a.Id == id);

        }


    }
}