namespace BaobabWildlifeRehab.Data
{
    // Thrown when a file problem happens (locked, read-only, missing).
    public class DataAccessException : Exception
    {
        // Wraps the original technical problem.
        public DataAccessException(string Message): base(Message) { }
    }
}