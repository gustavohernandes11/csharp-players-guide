using System.Text;
using csharp_players_guide.lib;
using System.Diagnostics;

public record RandomWords
{
    public void Init()
    {
        string input = Helper.AskForString("Digite uma palavra de até 5 caracteres: ", maxLength: 5).ToLower().Trim();
        RandomlyRecreate(input);

    }
    public Task InitAsync()
    {
        string input = Helper.AskForString("Digite uma palavra de até 5 caracteres: ", maxLength: 5).ToLower().Trim();
        RandomlyRecreateAsync(input);
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

    public int RandomlyRecreate(string word)
    {
        int attemps = 0;
        string generatedWord;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

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

        stopwatch.Stop();
        long elapsed = stopwatch.ElapsedMilliseconds;

        Console.WriteLine($"word: {word} | attemps: {attemps} | elapsed: {elapsed}");

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
