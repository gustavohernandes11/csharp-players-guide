public record BlockCoordinate(int Row, int Column)
{
    public int this[int index]
    {
        get => (index == 0) ? Row : Column;
    }
    public static BlockCoordinate operator +(BlockCoordinate blockCoordinate, BlockOffset blockOffset)
    {
        return new BlockCoordinate(
            blockCoordinate.Row + blockOffset.RowOffset,
            blockCoordinate.Column + blockOffset.ColumnOffset);
    }
    public static BlockCoordinate operator -(BlockCoordinate blockCoordinate, BlockOffset blockOffset)
    {
        return new BlockCoordinate(
            blockCoordinate.Row - blockOffset.RowOffset,
            blockCoordinate.Column - blockOffset.ColumnOffset);
    }

};

public record BlockOffset(int RowOffset, int ColumnOffset)
{
    public static implicit operator BlockOffset(Direction direction)
    {
        return direction switch
        {
            Direction.North => new BlockOffset(0, 1),
            Direction.East => new BlockOffset(1, 0),
            Direction.South => new BlockOffset(0, -1),
            Direction.West => new BlockOffset(-1, 0),
            _ => new BlockOffset(0, 0),
        };
    }
};

public enum Direction { North, East, South, West }

