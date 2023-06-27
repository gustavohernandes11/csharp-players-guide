using csharp_players_guide.lib;

namespace csharp_players_guide.Challenges.Level26;

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];

    public void Init()
    {
        for (int i = 0; i < 3; i++)
        {
            string inputCommand = Helper.AskForString("insert one command: ");
            if (Helper.IsValidEnumValue<ValidCommands>(inputCommand))
            {
                Console.WriteLine("ok");
                Commands[i] = GetCommand(inputCommand);
            }
            else
            {
                Console.WriteLine("command not registered");
                i--;
            }
        }

        Run();
    }
    IRobotCommand GetCommand(string inputCommand)
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
        foreach (IRobotCommand? command in Commands)
        {
            command?.Run(this); Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

