using System.Text;
using csharp_players_guide.lib;
using System.Diagnostics;

public record RandomWords
{
    public void Init()
    {
        string input = Helper.AskForString("Digite uma palavra de até 5 caracteres: ", maxLength: 5).ToLower().Trim();
        MeasureExecutionTime(() => RandomlyRecreate(input));

    }
    public Task InitAsync()
    {
        string input = Helper.AskForString("Digite uma palavra de até 5 caracteres: ", maxLength: 5).ToLower().Trim();
        MeasureExecutionTime(async () => await RandomlyRecreateAsync(input));
        return Task.CompletedTask;
    }

    public void InitAsyncMany()
    {
        while (true)
        {
            string input = Helper.AskForString("Digite uma palavra de até 5 caracteres: ", maxLength: 5).ToLower().Trim();
            RandomlyRecreateAsync(input);
        }
    }

    static long MeasureExecutionTime(Action method)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        method.Invoke();

        stopwatch.Stop();
        long elapsed = stopwatch.ElapsedMilliseconds;
        Console.WriteLine(elapsed + " milliseconds"); // ugly!

        return elapsed;
    }
    public int RandomlyRecreate(string word)
    {
        int attemps = 0;
        string generatedWord;

        do
        {
            StringBuilder builder = new();

            foreach (var _ in word)
            {
                builder.Append(GenerateLowerChar());
            }

            generatedWord = builder.ToString();
            attemps++;

        } while (generatedWord != word);
        Console.WriteLine($"word: {word} | attemps: {attemps}");

        return attemps;
    }
    public Task<int> RandomlyRecreateAsync(string word)
    {
        return Task.Run(() => RandomlyRecreate(word));
    }


    char GenerateLowerChar()
    {
        Random rnd = new();
        return (char)('a' + rnd.Next(26));
    }
}
