namespace csharp_players_guide.Challenges;

// 150xp
public abstract class InventoryItem
{
    public double Weight { get; private set; }
    public double Volume { get; private set; }

    public InventoryItem(double weight, double volume)
    {
        Weight = weight;
        Volume = volume;
    }
}
public class ArrowItem : InventoryItem
{
    public ArrowItem() : base(0.1, 0.05) { }
    public override string ToString() => "Arrow";

}
public class Bow : InventoryItem
{
    public Bow() : base(1, 4) { }
    public override string ToString() => "Bow";
}
public class Rope : InventoryItem
{
    public Rope() : base(1, 1.5) { }
    public override string ToString() => "Rope";
}
public class Water : InventoryItem
{
    public Water() : base(2, 3) { }
    public override string ToString() => "Water";
}
public class FoodRations : InventoryItem
{
    public FoodRations() : base(1, 0.5) { }
    public override string ToString() => "FoodRations";
}
public class SwordItem : InventoryItem
{
    public SwordItem() : base(5, 3) { }
    public override string ToString() => "Sword";
}



