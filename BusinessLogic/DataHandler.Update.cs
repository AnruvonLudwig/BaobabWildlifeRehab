using BaobabWildlifeRehab.Models;

namespace BaobabWildlifeRehab.BusinessLogic
{
    // Business layer - Feature: Update
    internal partial class DataHandler
    {
        //Validates and Creates new Animal and calls data.Update
        public Animal Update(string existingId, string name, string species, string ageText, string scoreText)
        {
            throw new NotImplementedException();
            //throw exception and validate
            //ValidateCommonFields(/*peram*/)

            //data.Update(/*animal*/);
            //return /*animal*/
        }
    }
}