
namespace csharp_players_guide.Challenges.Level25;
// 150px
public class Pack
{
    public int ItemsAmount { get; private set; }
    public double CurrentVolume { get; private set; }
    public double CurrentWeight { get; private set; }
    List<InventoryItem> Items;

    int MaxItems { get; set; }
    double MaxVolume { get; set; }
    double MaxWeight { get; set; }

    public Pack(int maxItems, double maxVolume, double maxWeight)
    {
        Items = new List<InventoryItem>();
        MaxItems = maxItems;
        MaxVolume = maxVolume;
        MaxWeight = maxWeight;

        ItemsAmount = 0;
        CurrentVolume = 0;
        CurrentWeight = 0;
    }
    public new string ToString()
    {
        string invetoryItems = "The pack is containing";

        for (int i = 0; i < ItemsAmount; i++)
        {
            invetoryItems = $"{invetoryItems} {Items[i].ToString()},";
        }

        return invetoryItems;
    }
    public void DisplayStatus()
    {
        Console.WriteLine($"Volume: {CurrentVolume}/{MaxVolume}");
        Console.WriteLine($"Weight: {CurrentWeight}/{MaxWeight}");
        Console.WriteLine($"Items: {ItemsAmount}/{MaxItems}");
    }
    public bool Add(InventoryItem item)
    {
        if (ItemsAmount >= MaxItems)
        {
            Console.WriteLine("The backpack is full!");
            return false;
        }

        bool IsAbleToKeepItemVolume = (CurrentVolume + item.Volume) < MaxVolume;
        bool IsAbleToKeepItemWeight = (CurrentWeight + item.Weight) < MaxWeight;

        if (!IsAbleToKeepItemVolume)
        {
            Console.WriteLine("The item exceeds the volume that the backpack can support.");
            return false;
        };

        if (!IsAbleToKeepItemWeight)
        {
            Console.WriteLine("The item exceeds the weight that the backpack can support.");
            return false;
        };

        if (IsAbleToKeepItemVolume && IsAbleToKeepItemWeight)
        {
            CurrentVolume += item.Volume;
            CurrentWeight += item.Weight;
            Items.Add(item);
            ItemsAmount++;
            return true;
        }
        else return false;
    }
}

public class SmallPack : Pack
{
    public SmallPack() : base(5, 2, 5)
    {

    }
}
public class MediumPack : Pack
{
    public MediumPack() : base(10, 8, 10)
    {

    }
}
public class BigPack : Pack
{
    public BigPack() : base(15, 12, 14)
    {

    }
}


