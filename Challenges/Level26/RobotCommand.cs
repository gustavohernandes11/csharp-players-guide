namespace csharp_players_guide.Challenges.Level26;

public abstract class RobotCommand
{
    internal abstract void Run(Robot robot);
}

public class OnCommand : RobotCommand
{
    internal override void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : RobotCommand
{
    internal override void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : RobotCommand
{
    internal override void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.Y++;
    }
}

public class SouthCommand : RobotCommand
{
    internal override void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.Y--;
    }
}

public class WestCommand : RobotCommand
{
    internal override void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.X--;
    }
}

public class EastCommand : RobotCommand
{
    internal override void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.Y++;
    }
}


