namespace Level37;

public class CharberryTree
{
    private Random _random = new Random();
    public bool Ripe { get; set; }
    public event Action? Ripened;

    public void MaybeGrow()
    {
        // Only a tiny chance of ripening each time, but we try a lot!
        if (_random.NextDouble() < 0.00000001 && !Ripe)
        {
            Ripe = true;
            Ripened?.Invoke();
        }
    }
}

public class Notifier
{
    public void HasRipened() => Console.WriteLine("A charberry fruit has ripened!");

    public Notifier(CharberryTree charberryTree)
    {
        charberryTree.Ripened += HasRipened;
    }
}

public class Harvester
{
    public CharberryTree CharberryTree { get; set; }
    public void HarvestTree()
    {
        Console.WriteLine("Harvested!");
        CharberryTree.Ripe = false;
    }

    public Harvester(CharberryTree charberryTree)
    {
        CharberryTree = charberryTree;
        charberryTree.Ripened += HarvestTree;
    }
}
