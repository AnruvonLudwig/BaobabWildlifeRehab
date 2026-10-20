using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab.Data
{
    // Data layer - Feature: Add
    internal partial class AnimalData
    {
        // Appends one line to animals.txt and adds the animal to DataSource.
        public void Add(Animal animal)
        { 
            //DataSource.EndEdit();

            //List<string> Lines = DataSource.Cast<Animal>().Select(a => ToLine(a)).ToList();

            try
            {
                //If file is deleted add it back.
                if (!File.Exists(AnimalsFilePath))
                {
                    File.WriteAllLines(AnimalsFilePath, DataSource.Cast<Animal>().Select(a => ToLine(a)).ToList());
                }
                //First write. If this throws, the list is untouched.
                File.AppendAllText(AnimalsFilePath, ToLine(animal));
            }
            catch (UnauthorizedAccessException exAuth)
            {
               
                throw new DataAccessException("Does not have Permission to Add record");
            }
            catch (IOException exIO)
            {
                throw new DataAccessException("Could not Add record in file.");
            }

            DataSource.Add(animal);

        }
    }
}