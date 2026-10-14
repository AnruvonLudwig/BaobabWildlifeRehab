using BaobabWildlifeRehab.Data;
using BaobabWildlifeRehab.Models;
using System.ComponentModel;

namespace BaobabWildlifeRehab.BusinessLogic
{
    // The business layer. Each feature is a partial file.
    // Methods throw ValidationException / DataAccessException when something fails.
    internal partial class DataHandler
    {
        private readonly AnimalData data = new AnimalData();

        // The grid binds to this once; it updates automatically after add/update/delete.
        public BindingSource Source => data.Source;
    }
}