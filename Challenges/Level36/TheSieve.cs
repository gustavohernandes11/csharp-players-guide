using csharp_players_guide.lib;

public class Sieve
{
    bool IsEven(int number) => number % 2 == 0;
    bool IsPositive(int number) => number >= 0;
    bool IsDivisorOfTen(int number) => number % 10 == 0;

    public delegate bool JudgeNumberDelegate(int number);
    public bool IsGood(int number, JudgeNumberDelegate operation) => operation(number);


    public Sieve()
    {
        JudgeNumberDelegate? judgementChoosen = null;
        while (judgementChoosen == null)
        {
            string input = Helper.AskForString("How do you want to judge the numbers? even, positive or 10multiplier: ");

            switch (input.ToLower())
            {
                case "even":
                    judgementChoosen = IsEven;
                    break;
                case "positive":
                    judgementChoosen = IsPositive;
                    break;
                case "10multiplier":
                    judgementChoosen = IsDivisorOfTen;
                    break;
                default: continue;
            }
        }

        while (true)
        {
            int inputNumber = Helper.AskForNumber("Digite um numero: ");
            Console.WriteLine(judgementChoosen(inputNumber));
        }
    }
}


// (1) returns true for even numbers, 
// (2) returns true for positive numbers, and 
// (3) returns true for multiples of 10.
