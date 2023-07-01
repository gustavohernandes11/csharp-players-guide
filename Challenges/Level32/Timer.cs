namespace Level32;

public class MyTimer
{
    DateTime initial = new();

    public void Init()
    {
        initial = DateTime.Now;

        while (true)
        {
            Console.Clear();
            TimeSpan passedTime = DateTime.Now - initial;
            Console.WriteLine($"[{passedTime.Hours}:{passedTime.Minutes}:{passedTime.Seconds}]");
            Thread.Sleep(1000);
        }
    }

}
