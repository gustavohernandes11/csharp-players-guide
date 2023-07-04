using csharp_players_guide.lib;

public class Sieve
{
    public delegate bool CriterionDelegate(int number);
    public bool IsGood(int number, CriterionDelegate operation) => operation(number);

    public Sieve()
    {
        CriterionDelegate? criterion = null;
        while (criterion == null)
        {
            string input = Helper.AskForString("With what criteria do you want to judge the numbers? even, positive or 10multiplier: ");

            switch (input.ToLower())
            {
                case "even":
                    criterion = (n) => n % 2 == 0;
                    break;
                case "positive":
                    criterion = (n) => n >= 0;
                    break;
                case "10multiplier":
                    criterion = (n) => n % 10 == 0;
                    break;
                default: continue;
            }
        }

        while (true)
        {
            int inputNumber = Helper.AskForNumber("Digite um numero: ");
            Console.WriteLine(criterion(inputNumber));
        }
    }
}
