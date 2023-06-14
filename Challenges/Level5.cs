
namespace csharp_players_guide.Challenges
{
    public class Level5
    {
        public static void TheVariableShop()
        {

            byte singleByte = 128;
            short smallNumber = 50;
            int integer = 10_000;
            long bigNumber = -500_000_000_000_000_000;
            sbyte singleByteWithNegatives = -128;
            ushort positiveSmallNumber = 50;
            uint positiveInteger = 10_000;
            ulong positiveBigNumber = 500_000_000_000_000_000;

            double floatingPointNumber = 1.0;
            float floatingPrecisePointNumber = 1.00000000000000000001F;
            decimal floatingPointNumberForMath = 1.654M;

            string text = "Some text";
            char character = 'b';

            bool isPrecise = true;

            Console.WriteLine(singleByte);
            Console.WriteLine(smallNumber);
            Console.WriteLine(integer);
            Console.WriteLine(bigNumber);
            Console.WriteLine(singleByteWithNegatives);
            Console.WriteLine(positiveSmallNumber);
            Console.WriteLine(positiveInteger);
            Console.WriteLine(positiveBigNumber);
            Console.WriteLine(floatingPointNumber);
            Console.WriteLine(floatingPrecisePointNumber);
            Console.WriteLine(floatingPointNumberForMath);
            Console.WriteLine(text);
            Console.WriteLine(character);
            Console.WriteLine(isPrecise);
        }

        public static void TheVariableShopReturns()
        {
            byte singleByte = 128;
            Console.WriteLine("singleByte: " + singleByte);
            singleByte = 76;
            Console.WriteLine("singleByte: " + singleByte);
            singleByte = 2;
            Console.WriteLine("singleByte: " + singleByte);
            singleByte = 34;
            Console.WriteLine("singleByte: " + singleByte);
        }

    }
}
