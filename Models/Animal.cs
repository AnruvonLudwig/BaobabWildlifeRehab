namespace BaobabWildlifeRehab.Models
{
    // One animal record (one line of animals.txt).
    internal class Animal
    {
        public Animal(string id, string name, string species, int age, int recoveryScore, string status, string housingUnit)
        {
            Id = id;
            Name = name;
            Species = species;
            Age = age;
            RecoveryScore = recoveryScore;
            Status = status;
            HousingUnit = housingUnit;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int RecoveryScore { get; set; }
        public string Status { get; set; }      // calculated
        public string HousingUnit { get; set; } // calculated
    }
}