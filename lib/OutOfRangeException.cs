public class OutOfRangeException : Exception
{
    public OutOfRangeException(string message) : base(message)
    {
        throw new Exception(message);
    }
}
