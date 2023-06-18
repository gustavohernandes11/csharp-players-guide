using System.Text.RegularExpressions;

namespace csharp_players_guide.Challenges
{
    public class Level13
    {
        // 100xp
        public int AskForNumber(string text)
        {
            while (true)
            {
                Console.WriteLine(text);
                string? input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input) && Regex.IsMatch(input, @"^\d+$"))
                {
                    int number = Convert.ToInt32(input);
                    // Console.WriteLine(number);
                    return number;
                }

            }
        }
        // 100xp
        public void Countdown(int numberToBeDecreased)
        {
            for (int i = numberToBeDecreased; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

    }
}
