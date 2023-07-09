public class RecentNumbers
{
    int LastNumber { get; set; }
    int PenultimateNumber { get; set; }

    public bool IsEqualLastNumbers() =>
        LastNumber == PenultimateNumber;

    public void GenerateNumbers()
    {
        Random rnd = new();

        while (true)
        {
            PenultimateNumber = LastNumber;
            LastNumber = rnd.Next(10);

            Console.WriteLine(LastNumber);
            Thread.Sleep(1000);
        }
    }
}
