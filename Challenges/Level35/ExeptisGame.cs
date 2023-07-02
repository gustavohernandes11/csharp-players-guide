using csharp_players_guide.lib;

namespace Level35;

public class ExeptisGame
{
    List<int> Options { get; set; } = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    public ExeptisGame()
    {
        Random rnd = new();
        int selectedNumber = rnd.Next(Options.Count);

        while (Options.Any())
        {
            int inputNumber = Helper.AskForNumber("Insert a number from 1 to 9: ", 1, 9);

            try
            {
                if (inputNumber == selectedNumber)
                    throw new Exception();

                else if (Options.Contains(inputNumber))
                    Options.Remove(inputNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
