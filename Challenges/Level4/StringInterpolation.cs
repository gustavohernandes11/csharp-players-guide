namespace csharp_players_guide.Challenges
{
    public class StringInterpolation
    {
        // 100xp
        public static void TheThingNamer3000()
        {
            Console.WriteLine("What kind of thing are we talking about?");
            string? a = Console.ReadLine(); // Get the "thing" name.
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string? b = Console.ReadLine(); // Get any feature about the "thing".
            string c = "Doom";
            string d = "3000";
            Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!"); // Group up the sentence
        }
    }
}
