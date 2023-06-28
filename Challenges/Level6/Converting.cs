namespace csharp_players_guide.Challenges
{
    public class Converting
    {
        public static void TestingConvert()
        {
            Console.WriteLine((int)4.4);
            Console.WriteLine((int)4.5);
            Console.WriteLine((int)4.6);

            Console.WriteLine((int)0.9);

            Console.WriteLine(Convert.ToInt32(0.1));
            Console.WriteLine(Convert.ToInt32(0.5));
            Console.WriteLine(Convert.ToInt32(0.8));
            Console.WriteLine(Convert.ToInt32(0.9));
        }
        // 100xp
        public static void TheTriangleFarmer()
        {
            Console.WriteLine("Base of the triangle: ");
            string? TriangleBase = Console.ReadLine();


            Console.WriteLine("Height of the triangle: ");
            string? TriangleHeight = Console.ReadLine();

            Console.WriteLine(CalculateTriangleArea(
                    Convert.ToDouble(TriangleBase),
                    Convert.ToDouble(TriangleHeight)
                    ));
        }
        private static double? CalculateTriangleArea(double? TriangleBase, double? TriangleHeight)
        {

            return TriangleBase * TriangleHeight / 2;
        }
        // 100xp
        public static void TheFourSistersandtheDuckbear()
        {
            Console.WriteLine("How many eggs?: ");
            string? totalEggs = Console.ReadLine();
            int dividedEggs = Convert.ToInt32(totalEggs) / 4;
            int remainEggs = Convert.ToInt32(totalEggs) % 4;

            Console.WriteLine("Each sister will get " + dividedEggs + ". And remains " + remainEggs + " eggs.");
        }
        public static void TheDominionofKings()
        {
            Console.WriteLine("How many estates?: ");
            string? estatesAmountString = Console.ReadLine();
            _ = int.TryParse(estatesAmountString, out int estatesAmount);

            Console.WriteLine("How many duchies?: ");
            string? duchyAmountString = Console.ReadLine();
            _ = int.TryParse(duchyAmountString, out int duchyAmount);

            Console.WriteLine("How many provinces?: ");
            string? provincesAmountString = Console.ReadLine();
            _ = int.TryParse(provincesAmountString, out int provincesAmount);

            int estateUnitValue = 1;
            int duchyUnitValue = 3;
            int proviceUnitValue = 6;
            int totalPoints =
             (estatesAmount * estateUnitValue) +
             (duchyAmount * duchyUnitValue) +
             (provincesAmount * proviceUnitValue);

            Console.WriteLine("Total player's points: " + totalPoints);
        }

    }
}
