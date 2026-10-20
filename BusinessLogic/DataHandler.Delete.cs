using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab.BusinessLogic
{
    // Business layer - Feature: Delete
    internal partial class DataHandler
    {
        //Validates delete and calls data.Delete
        public void Delete(string id)
        {

            //Validate
            if (data.FindById(id) == null) throw new ValidationException("ID not Found",FieldNames.AnimalID);

            data.Delete(id);
        }
    }
}