
public static class RandomExtension
{
    public static string NextString(this Random random, params string[] args)
    {
        int choosenIndex = random.Next(args.Length);
        return args[choosenIndex];
    }
    public static double NextDouble(this Random random, double maxValue)
    {
        return random.NextDouble() * maxValue;
    }
    public static bool CoinFlip(this Random random, double chanceOfTrue = 0.5)
    {
        return random.Next(100) < chanceOfTrue * 100;
    }

}
