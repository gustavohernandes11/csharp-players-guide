namespace csharp_players_guide.Challenges
{
    public class Level7
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

            int targetRow;
            Int32.TryParse(targetRowString, out targetRow);

            Console.WriteLine("Target Column? ");
            string? targetColumnString = Console.ReadLine();

            int targetColumn;
            Int32.TryParse(targetColumnString, out targetColumn);


            Point deployDefense1 = new Point(targetRow - 1, targetColumn);
            Point deployDefense2 = new Point(targetRow, targetColumn - 1);
            Point deployDefense3 = new Point(targetRow + 1, targetColumn);
            Point deployDefense4 = new Point(targetRow, targetColumn + 1);

            Console.BackgroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Deploy to: ");
            Console.WriteLine(deployDefense1.ToString());
            Console.Beep();
            Console.WriteLine(deployDefense2.ToString());
            Console.Beep();
            Console.WriteLine(deployDefense3.ToString());
            Console.Beep();
            Console.WriteLine(deployDefense4.ToString());
            Console.Beep(900, 1000);

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
