using BaobabWildlifeRehab.Models;


namespace BaobabWildlifeRehab.Data
{
    // Data layer - Feature: Add
    internal partial class AnimalData
    {
        // writes summary.txt
        public void WriteSummary(string summary)
        {
            try
            {
                // Write the summary to the file
                File.WriteAllText(SummaryFilePath, summary);
            }
            // Catch any IO exceptions and throw a DataAccessException
            catch (IOException)
            {
                throw new DataAccessException("Failed to write the summary to the file.");
            }

        }
    }
}