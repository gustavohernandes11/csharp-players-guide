namespace csharp_players_guide.Challenges.Level3
{
    public class Character
    {
        // 50xp
        public static void SayHelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }
        // 50px
        public static void SayAnythingElse()
        {
            Console.WriteLine("Where am I?");
        }
        // 50px
        public static void SayFiveStatements()
        {
            Console.WriteLine("Hi there!");
            Console.WriteLine("My name is Dug.");
            Console.WriteLine("I only remember my name...");
            Console.WriteLine("How long was I unconscious?");
            Console.WriteLine("My head hurts!");
        }
        public static void MakeAndDeliverBread()
        {
            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is the bread for?");
            string? name = Console.ReadLine();
            Console.WriteLine(name + " got bread.");

        }
    }

}
