using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab.BusinessLogic
{
    // Business layer - Feature: View
    internal partial class DataHandler
    {
        //Calls data.Load to populate the BindingSource
        public int Load()
        {
            return data.Load();
        }
    }
}