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
                File.WriteAllText(SummaryFilePath, summary);
            }
            catch (IOException)
            {
                throw new DataAccessException("Failed to write the summary to the file.");
            }

        }
    }
}