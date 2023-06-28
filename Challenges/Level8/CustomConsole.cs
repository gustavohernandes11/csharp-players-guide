namespace csharp_players_guide.Challenges
{
    public class CustomConsole
    {
        private class Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        };
        // 200xp
        public static void TheDefenseofConsolas()
        {

            Console.Title = "Defense of Consolas";
            Console.Clear();


            Console.WriteLine("Target Row? ");
            string? targetRowString = Console.ReadLine();

            _ = int.TryParse(targetRowString, out int targetRow);

            Console.WriteLine("Target Column? ");
            string? targetColumnString = Console.ReadLine();

            _ = int.TryParse(targetColumnString, out int targetColumn);

            Point deployDefense1 = new(targetRow - 1, targetColumn);
            Point deployDefense2 = new(targetRow, targetColumn - 1);
            Point deployDefense3 = new(targetRow + 1, targetColumn);
            Point deployDefense4 = new(targetRow, targetColumn + 1);

            Console.BackgroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Deploy to: ");
            Console.WriteLine(deployDefense1.ToString());
            // Console.Beep();
            Console.WriteLine(deployDefense2.ToString());
            // Console.Beep();
            Console.WriteLine(deployDefense3.ToString());
            // Console.Beep();
            Console.WriteLine(deployDefense4.ToString());
            // Console.Beep(900, 1000);

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
