namespace csharp_players_guide.Challenges
{
    public static class Level11
    {
        public static void GuessTheNumber()
        {
            Console.WriteLine("User 1, enter a number between 0 and 100: ");
            string? numberToBeGuessedInput = Console.ReadLine();
            int numberToBeGuessed;
            Int32.TryParse(numberToBeGuessedInput, out numberToBeGuessed);

            Console.WriteLine("User 2, guess the number.");

            string? proposedNumberInput;
            int proposedNumber;

            do
            {
                proposedNumberInput = Console.ReadLine();
                Int32.TryParse(proposedNumberInput, out proposedNumber);

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
    }
}
