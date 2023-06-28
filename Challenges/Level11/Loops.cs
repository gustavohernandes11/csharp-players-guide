namespace csharp_players_guide.Challenges
{
    public static class Loops
    {
        public static void GuessTheNumber()
        {
            Console.WriteLine("User 1, enter a number between 0 and 100: ");
            string? numberToBeGuessedInput = Console.ReadLine();
            _ = int.TryParse(numberToBeGuessedInput, out int numberToBeGuessed);

            Console.WriteLine("User 2, guess the number.");

            string? proposedNumberInput;
            int proposedNumber;

            do
            {
                proposedNumberInput = Console.ReadLine();
                _ = int.TryParse(proposedNumberInput, out proposedNumber);

                if (numberToBeGuessed > proposedNumber)
                {
                    Console.WriteLine($"{proposedNumber} is too low!");
                }
                if (numberToBeGuessed < proposedNumber)
                {
                    Console.WriteLine($"{proposedNumber} is too hight!");
                }

            } while (numberToBeGuessed != proposedNumber);

            if (numberToBeGuessed == proposedNumber)
            {
                Console.WriteLine("You guessed the number!");
            };

        }
        private static bool IsDivisibleBy(int divisor, int dividend) => divisor % dividend == 0;
        public static void TheMagicCannon(int rounds)
        {
            for (int index = 1; index <= rounds; index++)
            {
                if (IsDivisibleBy(index, 5) && IsDivisibleBy(index, 3))
                {
                    Console.WriteLine($"{index}: Electric and Fire");
                    continue;
                }
                else if (IsDivisibleBy(index, 5))
                {
                    Console.WriteLine($"{index}: Electric");
                    continue;
                }
                else if (IsDivisibleBy(index, 3))
                {
                    Console.WriteLine($"{index}: Fire");
                    continue;
                }
                else
                {
                    Console.WriteLine($"{index}: Normal");
                    continue;
                }
            }
        }
    }
}
