using BaobabWildlifeRehab.Models;
using static System.Formats.Asn1.AsnWriter;

namespace BaobabWildlifeRehab.BusinessLogic
{
    // Business layer - Feature: Add
    internal partial class DataHandler
    {
        //Validates and Creates new Animal and calls data.add
        public Animal Add(string id,string name, string species, string ageText, string scoreText)
        {
            int age;
            int score;

            //Validation
            if (id == String.Empty) throw new ValidationException("Field not filled in!",FieldNames.AnimalID);
            ValidateCommonFields(name, species, ageText, scoreText,out name,out species,out age,out score); 

            if (data.FindById(id) != null) throw new ValidationException("Animal exists! Duplicate ID",FieldNames.AnimalID);

            (string status, string housingUnit) = Classify(score);

            Animal animal = new Animal(id, name, species, age, score, status, housingUnit);

            data.Add(animal);
            return animal;
        }
    }
}