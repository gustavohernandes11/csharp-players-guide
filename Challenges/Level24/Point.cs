namespace csharp_players_guide.Challenges.Level24;

// 75xp
public class Point
{
    public float X { get; set; }
    public float Y { get; set; }
    public string Coordinates => $"({X}, {Y})";

    public Point(float x = 0, float y = 0)
    {
        X = x;
        Y = y;
    }

}

