using csharp_players_guide.lib;

namespace csharp_players_guide.Challenges;

public static class Level17
{
    enum FoodType { Soup, Stew, Gumbo };
    enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes };
    enum Seasoning { Spicy, Salty, Sweet };

    public static void SimulasSoup()
    {
        string userChoiceFoodType;
        string userChoiceMainIngredient;
        string userChoiceSeasoning;

        userChoiceFoodType = GetFoodType();
        if (!Helper.IsValidEnumValue<FoodType>(userChoiceFoodType))
        {
            Console.WriteLine("Não está dentro das opções!");
            userChoiceFoodType = GetFoodType();
        }

        userChoiceMainIngredient = GetMainIngredient();
        if (!Helper.IsValidEnumValue<MainIngredient>(userChoiceMainIngredient))
        {
            Console.WriteLine("Não está dentro das opções!");
            userChoiceMainIngredient = GetFoodType();
        }

        userChoiceSeasoning = GetSeasoning();
        if (!Helper.IsValidEnumValue<Seasoning>(userChoiceSeasoning))
        {
            Console.WriteLine("Não está dentro das opções!");
            userChoiceSeasoning = GetSeasoning();
        }

        (string Seasoning, string MainIngredient, string FoodType) meal = (userChoiceSeasoning, userChoiceMainIngredient, userChoiceFoodType);

        Console.WriteLine($"{meal.Seasoning} {meal.MainIngredient} {meal.FoodType}!");
    }
    private static string GetFoodType()
    {
        string userInput = GetInput.AskForString("Which food type? (soup, stew, gumbo)");
        return userInput;
    }
    private static string GetSeasoning()
    {
        string userInput = GetInput.AskForString("Which seasoning? (spicy, salty, sweet)");
        return userInput;
    }
    private static string GetMainIngredient()
    {
        string userInput = GetInput.AskForString("Which main ingredient? (mushrooms, chicken, carrots, potatoes)");
        return userInput;
    }


}

