using BaobabWildlifeRehab.Models;
using System.Text.RegularExpressions;
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
            if (id == String.Empty) throw new ValidationException("Animal ID cannot be blank!",FieldNames.AnimalID);

            //set id to uppercase
            id = id.ToUpper();

            //Regular expression to match pattern
            if (!Regex.IsMatch(id, @"^WR-[0-9]{4}$")) throw new ValidationException($"ID is not in format WR-0000",FieldNames.AnimalID);

            //Check Uniqueness 
            if (data.FindById(id) != null) throw new ValidationException($"Duplicate ID: {id} exists!",FieldNames.AnimalID);

            //Validate common fields
            ValidateCommonFields(name, species, ageText, scoreText, out name, out species, out age, out score);



            (string status, string housingUnit) = Classify(score);

            Animal animal = new Animal(id, name, species, age, score, status, housingUnit);

            data.Add(animal);
            return animal;
        }
    }
}