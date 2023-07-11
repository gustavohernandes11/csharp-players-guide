using System.Dynamic;
using csharp_players_guide.lib;

public class RobotFactory
{
    int Count { get; set; } = 0;

    public void Init()
    {
        while (true)
        {
            Count++;
            dynamic robot = new ExpandoObject();
            Console.WriteLine($"~~~~ You are producing robot #{Count} ~~~~");

            if (Helper.AskForBool("Do you want to name this robot?"))
                robot.Name = Helper.AskForString("What is its name?");

            if (Helper.AskForBool("Does this robot have a specific size?"))
            {
                robot.Height = Helper.AskForString("What is its height?");
                robot.Width = Helper.AskForString("What is its width?");
            }

            if (Helper.AskForBool("Does this robot need to be a specific color?"))
                robot.Color = Helper.AskForString("What color");


            foreach (KeyValuePair<string, object> property in (IDictionary<string, object>)robot) Console.WriteLine($"{property.Key}: {property.Value}");
        }
    }
}

