using csharp_players_guide.lib;
namespace csharp_players_guide.Challenges;

public static class HuntingTheManticore
{
    static int cityTotalHealth;
    static int cityHealth;
    static int manticoreTotalHealth;
    static int manticoreHealth;
    static int round;
    static int actualCannonDamage;
    static bool isGameRunning;

    static Thread soundThread = new Thread(SoundThread);
    static void SoundThread()
    {
        SoundEffect.Soundtrack();
    }

    public static void Init()
    {

        cityTotalHealth = 15;
        cityHealth = 15;
        manticoreTotalHealth = 10;
        manticoreHealth = 10;
        round = 1;
        isGameRunning = true;



        int manticoreDistance = Level13.AskForNumber("Player 1, how far away from the city do you want to station the Manticore (0 to 100)? ", 0, 100);

        soundThread.Start();

        Console.WriteLine("Player 2, it is your turn.");
        Console.WriteLine("-----------------------------------------------------------");

        while (isGameRunning)
        {
            int cannonRange = NewDefenserTry();
            ShootInRange(cannonRange, manticoreDistance);
            VerifyGameStatus();
        }

        static int NewDefenserTry()
        {
            actualCannonDamage = GetCannonDamage(round);

            Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/{cityTotalHealth} Manticore: {manticoreHealth}/{manticoreTotalHealth}");
            Console.WriteLine($"The cannon is expected to deal {actualCannonDamage} damage this round.");
            int cannonRange = Level13.AskForNumber("Enter desired cannon range (0 to 100)? ", 0, 100);

            return cannonRange;

        }
        static void ShootInRange(int cannonRange, int manticoreDistance)
        {
            if (cannonRange == manticoreDistance)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That round was a DIRECT HIT!");

                DecrementManticoreHealth(actualCannonDamage);
                switch (actualCannonDamage)
                {
                    case 5:
                        SoundEffect.Zap();
                        break;

                    case 3:
                        SoundEffect.Fire();
                        break;

                    case 1:
                        SoundEffect.Explosion();
                        break;


                    default:
                        break;
                }
            }
            if (cannonRange > manticoreDistance)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That round OVERSHOT the target.");
                SoundEffect.Drum();
            }
            if (cannonRange < manticoreDistance)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("That round FELL SHORT of the target.");
                SoundEffect.Drum();
            }

            Console.ResetColor();
            Console.WriteLine();

        }

        static void VerifyGameStatus()
        {
            if (manticoreHealth <= 0)
            {
                Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
                SoundEffect.Win();
                FinishGame();
            }
            else
            {
                DecrementCityHealth();
                if (cityHealth <= 0)
                {
                    Console.WriteLine("Defeat! The city of Consolas has been destroyed! And it's your fault.");
                    SoundEffect.Fail();
                    FinishGame();
                }
            }

            IncrementRound();
            Console.WriteLine("-----------------------------------------------------------");
        }

        static bool IsDivisibleBy(int divisor, int dividend) => divisor % dividend == 0;
        static void IncrementRound() => round++;
        static void DecrementManticoreHealth(int damage = 1) => manticoreHealth -= damage;
        static void DecrementCityHealth(int damage = 1) => cityHealth -= damage;
        static void FinishGame() => isGameRunning = false;


        static int GetCannonDamage(int round)
        {
            if (IsDivisibleBy(round, 5) && IsDivisibleBy(round, 3))
            {
                return 10;
            }
            else if (IsDivisibleBy(round, 5))
            {
                return 3;
            }
            else if (IsDivisibleBy(round, 3))
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }

    }

}

