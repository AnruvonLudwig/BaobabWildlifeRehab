using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab.Data
{
    // Data layer - Feature: View
    internal partial class AnimalData
    {
        // fills DataSource and returns the skipped-line count.
        public int Load()
        {
            int skippedLines = 0;                                               
            List<Animal> animals = new List<Animal>();

            foreach (string line in File.ReadAllLines(AnimalsFilePath))
            {
                if (TryParseLine(line, out Animal animal))
                {
                    animals.Add(animal);
                }
                else
                {
                    skippedLines++;
                }
            }

            DataSource.DataSource = animals;

            return skippedLines;
        }

       
    }
}