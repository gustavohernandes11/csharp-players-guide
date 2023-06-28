using System.Text.RegularExpressions;

namespace csharp_players_guide.Challenges
{
    public static partial class Methods
    {
        // 100xp
        public static int AskForNumber(string text, int minRange = int.MinValue, int maxRange = int.MaxValue)
        {
            while (true)
            {
                Console.WriteLine(text);
                string? input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && MyRegex().IsMatch(input))
                {
                    int number = Convert.ToInt32(input);
                    if (number > minRange && number < maxRange)
                    {
                        return number;
                    }
                }

            }
        }
        // 100xp
        public static void Countdown(int numberToBeDecreased)
        {
            for (int i = numberToBeDecreased; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        [GeneratedRegex("^\\d+$")]
        private static partial Regex MyRegex();
    }
}
