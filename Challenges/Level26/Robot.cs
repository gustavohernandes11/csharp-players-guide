using csharp_players_guide.lib;

namespace csharp_players_guide.Challenges.Level26;

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    List<IRobotCommand> Commands { get; } = new();

    public void Init()
    {
        Console.WriteLine("Available commands: on, off, north, south, east, west.");
        Console.WriteLine("Use 'stop' to run all the commands inserted.");

        while (true)
        {
            string inputCommand = Helper.AskForString("insert command: ");
            if (Helper.IsValidEnumValue<ValidCommands>(inputCommand))
            {
                Console.WriteLine("ok");
                Commands.Add(GetCommand(inputCommand));
            }
            else if (inputCommand == "stop")
            {
                Run();
                return;
            }
            else
            {
                Console.WriteLine("command not registered");
            }
        }


    }

    static IRobotCommand GetCommand(string inputCommand)
    {
        return inputCommand switch
        {
            "on" => new OnCommand(),
            "off" => new OffCommand(),
            "west" => new WestCommand(),
            "north" => new NorthCommand(),
            "south" => new SouthCommand(),
            "east" => new EastCommand(),
            _ => new OffCommand(),
        };
    }

    public void Run()
    {
        foreach (IRobotCommand command in Commands)
        {
            command.Run(this); Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

