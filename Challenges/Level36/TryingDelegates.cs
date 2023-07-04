namespace Level36;

public class TryingDelegates
{
    public delegate int NumberDelegate(int number);

    public int AddOne(int number) => number + 1;
    public int SubtractOne(int number) => number - 1;
    public int Double(int number) => number * 2;

    public int DoOperation(int value, NumberDelegate operation)
    {
        return operation(value);
    }
}
