using BaobabWildlifeRehab.Models;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace BaobabWildlifeRehab.Data
{
    // Data layer base: holds the shared list, file paths and parsing helpers.
    internal partial class AnimalData
    {
        private readonly BindingList<Animal> animals = new();

        // The grid binds to this BindingSource once. The underlying list is refreshed in-place.
        public BindingSource DataSource { get; } = new BindingSource();

        // Keep the data files beside the running executable.
        public string AnimalsFilePath { get; } = Path.Combine(AppContext.BaseDirectory, "animals.txt");
        public string SummaryFilePath { get; } = Path.Combine(AppContext.BaseDirectory, "summary.txt");

        public AnimalData()
        {
            DataSource.DataSource = animals;
        }

        // Converts an Animal to one pipe-separated file line.
        public string ToLine(Animal animal)
        {
            ArgumentNullException.ThrowIfNull(animal);
            return string.Join("|", new[]
            {
                animal.Id,
                animal.Name,
                animal.Species,
                animal.Age.ToString(CultureInfo.InvariantCulture),
                animal.RecoveryScore.ToString(CultureInfo.InvariantCulture),
                animal.Status,
                animal.HousingUnit
            });
        }

        // Tries to convert a file line to an Animal; returns false if the line is malformed.
        public bool TryParseLine(string line, out Animal animal)
        {
            animal = null!;
            if (string.IsNullOrWhiteSpace(line))
                return false;

            string[] fields = line.Split('|');
            if (fields.Length != 7 || string.IsNullOrWhiteSpace(fields[0]) ||
                string.IsNullOrWhiteSpace(fields[1]) || string.IsNullOrWhiteSpace(fields[2]))
            {
                return false;
            }

            if (!int.TryParse(fields[3], NumberStyles.Integer, CultureInfo.InvariantCulture, out int age) || age < 0 ||
                !int.TryParse(fields[4], NumberStyles.Integer, CultureInfo.InvariantCulture, out int score) || score < 0 || score > 100)
            {
                return false;
            }

            animal = new Animal(fields[0], fields[1], fields[2], age, score, fields[5], fields[6]);
            return true;
        }

        private List<Animal> CurrentAnimals => animals.ToList();

        private void ReplaceAll(IEnumerable<Animal> loadedAnimals)
        {
            animals.RaiseListChangedEvents = false;
            try
            {
                animals.Clear();
                foreach (Animal animal in loadedAnimals)
                    animals.Add(animal);
            }
            finally
            {
                animals.RaiseListChangedEvents = true;
                DataSource.ResetBindings(false);
            }
        }

        private DataAccessException WrapFileError(string action, Exception exception) =>
            new DataAccessException($"Could not {action} '{Path.GetFileName(AnimalsFilePath)}'. Check that the file is available and writable. Details: {exception.Message}");
    }
}
