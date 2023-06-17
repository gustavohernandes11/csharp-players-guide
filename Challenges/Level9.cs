namespace csharp_players_guide.Challenges
{
    public class Level9
    {
        // 100xp
        public static void RepairingTheClocktower()
        {

            Console.WriteLine("Choose a number: ");
            string? userNumberInput = Console.ReadLine();
            int userNumber;

            Int32.TryParse(userNumberInput, out userNumber);

            if (Int32.IsEvenInteger(userNumber))
            {
                Console.WriteLine("Tick");
            }
            else if (Int32.IsOddInteger(userNumber))
            {
                Console.WriteLine("Tock");
            }
        }
        // 100xp
        public static void Watchtower()
        {
            Console.WriteLine("What is the X coordinate of the enemy? ");
            string? XCoordinateInput = Console.ReadLine();
            int XCoordinate;
            Int32.TryParse(XCoordinateInput, out XCoordinate);


            Console.WriteLine("What is the Y coordinate of the enemy? ");
            string? YCoordinateInput = Console.ReadLine();
            int YCoordinate;
            Int32.TryParse(YCoordinateInput, out YCoordinate);

            // Mandatory use of if statements in the exercise
            if (XCoordinate < 0 && YCoordinate > 0)
                Console.WriteLine("The enemy location is NW");
            if (XCoordinate == 0 && YCoordinate > 0)
                Console.WriteLine("The enemy location is N");
            if (XCoordinate > 0 && YCoordinate > 0)
                Console.WriteLine("The enemy location is NE");

            if (XCoordinate < 0 && YCoordinate == 0)
                Console.WriteLine("The enemy location is W");
            if (XCoordinate == 0 && YCoordinate == 0)
                Console.WriteLine("The enemy location is HERE!");
            if (XCoordinate > 0 && YCoordinate == 0)
                Console.WriteLine("The enemy location is E");

            if (XCoordinate < 0 && YCoordinate < 0)
                Console.WriteLine("The enemy location is SW");
            if (XCoordinate == 0 && YCoordinate < 0)
                Console.WriteLine("The enemy location is S");
            if (XCoordinate > 0 && YCoordinate < 0)
                Console.WriteLine("The enemy location is SE");



        }

    }
}
