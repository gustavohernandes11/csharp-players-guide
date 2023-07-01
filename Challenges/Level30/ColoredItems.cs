namespace csharp_players_guide.Challenges.Level30;

// 100xp
public record ColoredItem<T>(T Item, ConsoleColor Color)
{
    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(Item?.ToString());
        Console.ForegroundColor = ConsoleColor.White;
    }
}

public class Sword { }
public class Bow { }
public class Axe { }
