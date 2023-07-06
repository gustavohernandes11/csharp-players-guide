using csharp_players_guide.lib;

namespace Level39;

public record LongGame
{
    int Score { get; set; } = 0;


    public void Init()
    {
        CreateRecordsIfNotExists();
        string user = Helper.AskForString("Username: ", 3, 15);
        string file = $"{user}.txt";
        string path = $"records/{user}.txt";

        if (File.Exists(path))
        {
            Score = GetStoragedScore(path);
            Console.WriteLine("Welcome back! Storaged score: " + Score);
        }
        else
        {
            File.Create(path).Close();
            File.WriteAllText(path, Score.ToString());
            Console.WriteLine("Welcome!");
        }

        Console.WriteLine("Hit any key to get points, use Enter to save the score.");
        while (true)
        {
            ConsoleKeyInfo userkey = Console.ReadKey();
            if (userkey.Key == ConsoleKey.Enter)
            {
                File.WriteAllText(path, Score.ToString());
                Console.WriteLine("Saved score: " + Score);
            }
            else
            {
                Score++;
                Console.WriteLine(); //spacing
                Console.WriteLine("Current score: " + Score);
            }

        }
    }

    public void CreateRecordsIfNotExists()
    {
        if (!Directory.Exists("records"))
        {
            Directory.CreateDirectory("records");
        }
    }
    public int GetStoragedScore(string path) => int.Parse(File.ReadAllText(path));
}
