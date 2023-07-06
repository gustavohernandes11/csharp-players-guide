using csharp_players_guide.lib;

namespace Level40;

public class PotionStand
{
    Potion Current { get; set; } = Potion.Water;
    bool ShouldContinue { get; set; } = true;

    public void Init()
    {
        DisplayIntro();

        while (ShouldContinue)
        {
            Console.WriteLine("Current potion: " + Current.ToString());
            string input = Helper.AskForString("Which ingredient? ").Trim().Replace(" ", "");

            if (input == "help")
            {
                DisplayRecipes();
                continue;
            }
            if (input == "exit")
            {
                ShouldContinue = false;
                continue;
            }
            if (!Enum.TryParse(input, true, out Ingredient ingredient))
            {
                Console.WriteLine("Invalid.");
                continue;
            }
            UpdateCurrentPotion(ingredient);

            if (Current == Potion.Ruined)
            {
                Console.WriteLine("The potion got ruined!");
                ShouldContinue = false;
            }
        }

    }
    public void UpdateCurrentPotion(Ingredient ingredient)
    {
        Current = (Current, ingredient) switch
        {
            (Potion.Water, Ingredient.Stardust) => Potion.Elixir,
            (Potion.Elixir, Ingredient.SnakeVenom) => Potion.Poison,
            (Potion.Elixir, Ingredient.DragonBreath) => Potion.Flying,
            (Potion.Elixir, Ingredient.ShadowGlass) => Potion.Invisibility,
            (Potion.Elixir, Ingredient.EyeshineGem) => Potion.NightSight,
            (Potion.NightSight, Ingredient.ShadowGlass) => Potion.CloudyBrew,
            (Potion.Invisibility, Ingredient.EyeshineGem) => Potion.CloudyBrew,
            (Potion.CloudyBrew, Ingredient.Stardust) => Potion.Wraith,
            _ => Potion.Ruined,
        };

    }

    public void DisplayIntro()
    {
        Console.WriteLine("Useful commands: help, exit.");
        Console.WriteLine("Here is the recipes for each type of potions: ");
        DisplayRecipes();
    }
    public void DisplayRecipes()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Elixir                   = Stardust + Water");
        Console.WriteLine("Poison Potion            = Elixir + Snake Venon");
        Console.WriteLine("Flying Potion            = Elixir + Dragon Breath");
        Console.WriteLine("Invisibility Position    = Elixir + Shadow Glass");
        Console.WriteLine("Nigth Sight Potion       = Elixir + Eyeshine Gem");
        Console.WriteLine("Cloudy Brew              = Night Sight Potion + Shadow Glass");
        Console.WriteLine("Cloudy Brew              = Invisibility Potion + Eyeshine Gem");
        Console.WriteLine("Wraith Potion            = Cloudy Brew + Stardust");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

public enum Potion
{
    Elixir, Poison, Flying, Invisibility, NightSight, CloudyBrew, Wraith, Ruined, Water
}
public enum Ingredient
{
    Stardust, SnakeVenom, DragonBreath, ShadowGlass, EyeshineGem
}
