using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab.BusinessLogic
{
    // Business layer - Feature: View
    internal partial class DataHandler
    {
        // Loads all valid records into the shared BindingSource and returns the skipped-line count.
        public int Load()
        {
            return data.Load();
        }

        // Looks up an animal by ID for Search and edit mode.
        public Animal? FindById(string id)
        {
            string cleanId = (id ?? string.Empty).Trim();
            if (cleanId.Length == 0)
                return null;

            return data.FindById(cleanId);
        }
    }
}
