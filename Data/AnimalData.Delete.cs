using BaobabWildlifeRehab.Models;
using System.Linq;
using System.Linq.Expressions;
namespace BaobabWildlifeRehab.Data
{
    // Data layer - Feature: Delete
    internal partial class AnimalData
    {
        // removes the item and rewrites the file.
        public void Delete(string id)
        {
            List<string> remainingLines = DataSource.Cast<Animal>().Where(a => a.Id != id).Select(a => ToLine(a)).ToList();

            try
            {
                // FIRST write. If this throws, the list is untouched
                File.WriteAllLines(AnimalsFilePath, remainingLines);
            }
            catch (UnauthorizedAccessException exAuth)
            {
                throw new DataAccessException("Does not have Permission to delete record");
            }
            catch (IOException exIO)
            {
                throw new DataAccessException("Could not Delete record in file.");
            }
            

            // Only after a successful write, remove it from the list so the grid updates
            Animal toRemove = DataSource.Cast<Animal>().First(a => a.Id == id);
            DataSource.Remove(toRemove);

        }
    }
}