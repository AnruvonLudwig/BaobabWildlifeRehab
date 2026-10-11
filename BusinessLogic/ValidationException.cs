namespace BaobabWildlifeRehab.BusinessLogic
{
    // Thrown when user input breaks a rule. FieldName tells the form which box gets the cursor.
    public class ValidationException : Exception
    {
        public string FieldName { get; }

        // Stores the message shown to the user and the name of the offending field.
        public ValidationException(string message, string fieldName) : base(message)
        {
            FieldName = fieldName;
        }
    }
}