using System.Text.RegularExpressions;

namespace csharp_players_guide.lib;

public class Helper
{
    public static bool IsValidEnumValue<TEnum>(string value) =>
        Enum.TryParse(typeof(TEnum), value, true, out _);


    public static int AskForNumber(string text, int minRange = int.MinValue, int maxRange = int.MaxValue)
    {
        while (true)
        {
            Console.WriteLine(text);
            string? input = Console.ReadLine();

            if (!String.IsNullOrEmpty(input) && Regex.IsMatch(input, @"^\d+$"))
            {
                int number = Convert.ToInt32(input);
                if (number > minRange && number < maxRange)
                {
                    return number;
                }
            }

        }
    }
    public static string AskForString(string text)
    {
        while (true)
        {
            Console.WriteLine(text);
            string? input = Console.ReadLine();

            if (!String.IsNullOrEmpty(input))
            {
                return input;
            }

        }
    }
}

