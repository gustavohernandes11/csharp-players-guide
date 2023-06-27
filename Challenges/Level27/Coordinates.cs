namespace csharp_players_guide.Challenges.Level27;

// 50xp
public readonly struct Coordinate
{
    readonly int X;
    readonly int Y;

    public Coordinate(int x, int y) : this()
    {
        X = x;
        Y = y;
    }

    public readonly bool IsAdjacent(Coordinate coordinate)
    {
        if (Equals(coordinate)) return false;

        bool isColumnAdjacent =
            coordinate.X == X - 1 || coordinate.X == X + 1 || coordinate.X == X;
        bool isRowAdjacent =
            coordinate.Y == Y - 1 || coordinate.Y == Y + 1 || coordinate.Y == Y;

        return isColumnAdjacent && isRowAdjacent;
    }
}
