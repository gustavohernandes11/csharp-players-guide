using System.Linq;
using csharp_players_guide.Challenges;
using csharp_players_guide.Challenges.Level24;
using csharp_players_guide.Challenges.Level25;
using csharp_players_guide.Challenges.Level26;
using csharp_players_guide.Challenges.Level27;
using csharp_players_guide.Challenges.Level28;
using csharp_players_guide.Challenges.Level30;
using csharp_players_guide.lib;
using Level32;
using Level35;
using Level36;
using Level37;
using Level39;
using Level40;
using Level42;
using static csharp_players_guide.Challenges.Arrow;


// Level3.SayHelloWorld();
// Level3.SayAnythingElse();
// Level3.SayFiveStatements();
// Level3.MakeAndDeliverBread();

// Level4.TheThingNamer3000();


// Level5.TheVariableShop();
// Level5.TheVariableShopReturns();


// Level6.TestingConvert();
// Level6.TheTriangleFarmer();
// Level6.TheFourSistersandtheDuckbear();
// Level6.TheDominionofKings();


// Level7.TheDefenseofConsolas();


// Level9.RepairingTheClocktower();
// Level9.Watchtower();


// Level10.BuyingInventory();
// Level10.GetUserName();
// Level10.BuyingInventory();


// Level11.GuessTheNumber();
// Level11.TheMagicCannon(30);


// Level13 levelExemple = new Level13();


// HuntingTheManticore.Init();

// Level16.SimulasTest();
// Level17.SimulasSoup();


// Arrow arrow1 = new Arrow(ArrowHeadOptions.Wood, FletchingTypeOptions.TurkeyFeathers, 70);
// Arrow arrow2 = new Arrow(ArrowHeadOptions.Obsidian, FletchingTypeOptions.Plastic, 80);
// Arrow arrow3 = new Arrow(ArrowHeadOptions.Steel, FletchingTypeOptions.GooseFeathers, 60);

// Console.WriteLine(arrow1.TotalPrice);
// Console.WriteLine(arrow2.TotalPrice);
// Console.WriteLine(arrow3.TotalPrice);

// Console.WriteLine(arrow3.Length);
// Console.WriteLine(arrow3.ArrowHead);
// Console.WriteLine(arrow3.FletchingType);

// Arrow staticArrow1 = Arrow.CreateEliteArrow;
// Console.WriteLine(staticArrow1.TotalPrice);
// Console.WriteLine(staticArrow1.ArrowHead);
// Console.WriteLine(staticArrow1.FletchingType);
// Console.WriteLine(staticArrow1.Length);


// Level20 testingGetOnly = new(10, 10);
// Console.WriteLine(testingGetOnly.Area);

// testingGetOnly.Height = 200;
// Console.WriteLine(testingGetOnly.Area);


// Point point1 = new Point(2, 3);
// Point point2 = new Point(-4, 0);
// Console.WriteLine(point1.Coordinates);
// Console.WriteLine(point2.Coordinates);


// Color white = new Color(255, 255, 255);
// Color black = new Color(0, 0, 0);

// Console.WriteLine(white.RGB);
// Console.WriteLine(white.Hexadecimal);

// Console.WriteLine(black.RGB);
// Console.WriteLine(black.Hexadecimal);

// Console.WriteLine(Color.Red.Hexadecimal);
// Console.WriteLine(Color.Orange.RGB);
// Console.WriteLine(Color.Blue.RGB);


// Card card1 = new Card(CardColor.Yellow, CardRank.Dollar);
// Card card2 = new Card(CardColor.Yellow, CardRank.One);

// Console.WriteLine(card1.Value);
// Console.WriteLine(card2.Value);

// Console.WriteLine(card1.IsNumber);
// Console.WriteLine(card1.IsSymbol);

// Console.WriteLine(card2.IsNumber);
// Console.WriteLine(card2.IsSymbol);

// Card[] deck = Card.CreateFullDeck();
// foreach (var card in deck)
// {
//     Console.WriteLine(card.Value);
// }


// DoorWithPassword mydoor = new(123);

// Console.WriteLine(mydoor.State);
// mydoor.Close();
// Console.WriteLine(mydoor.State);
// mydoor.Lock();
// Console.WriteLine(mydoor.State);
// mydoor.Unlock(1234);
// Console.WriteLine(mydoor.State);
// mydoor.Unlock(123);
// Console.WriteLine(mydoor.State);

// mydoor.ChangePassword(1234, 321);
// mydoor.ChangePassword(123, 321);

// mydoor.Lock();
// mydoor.Unlock(321);
// Console.WriteLine(mydoor.State);


// while (true)
// {
//     string mypassword = Helper.AskForString("Enter a password: ");
//     if (PasswordValidator.IsValid(mypassword))
//         return;

//     else
//         Console.WriteLine("Invalid password!");
// }


// RockPaperScissorsGame game = new RockPaperScissorsGame();


// MediumPack myBackPack = new MediumPack();

// Console.WriteLine(myBackPack.Add(new ArrowItem()));
// myBackPack.DisplayStatus();
// Console.WriteLine(myBackPack.Add(new Sword()));
// Console.WriteLine(myBackPack.Add(new Bow()));
// Console.WriteLine(myBackPack.Add(new Water()));
// Console.WriteLine(myBackPack.Add(new FoodRations()));
// Console.WriteLine(myBackPack.Add(new ArrowItem()));
// myBackPack.DisplayStatus();
// Console.WriteLine(myBackPack.ToString());

// Console.WriteLine(new ArrowItem().ToString());


// Robot robot1 = new Robot();
// robot1.Init();


// Coordinate coord1 = new Coordinate(1, 2);
// Coordinate coord2 = new Coordinate(2, 2);
// Coordinate coord3 = new Coordinate(3, 4);
// Console.WriteLine(coord1.IsAdjacent(coord2));
// Console.WriteLine(coord2.IsAdjacent(coord3));


// Sword original = new(Material.Iron, null, 1, 0.2f);
// Sword woodVersion = original with { SwordMaterial = Material.Wood };
// Sword woodVersionWithGem = woodVersion with { SwordGemstone = Gemstone.Emerald };

// Console.WriteLine(original.ToString());
// Console.WriteLine(woodVersion.ToString());
// Console.WriteLine(woodVersionWithGem.ToString());


// Sword sword = new();
// ColoredItem<Sword> blueSword = new(sword, ConsoleColor.Blue);
// blueSword.Display();

// Axe axe = new();
// ColoredItem<Axe> greenAxe = new(axe, ConsoleColor.Green);
// greenAxe.Display();

// Axe bow = new();
// ColoredItem<Axe> redBow = new(bow, ConsoleColor.Red);
// redBow.Display();



// MyTimer timer = new MyTimer();
// timer.Init();


// using McDroidsPig = McDroids.Pig;
// using iFieldsPig = iFields.Pig;

// McDroidsPig pig1 = new();
// iFieldsPig pig2 = new();

// iFields.Sheep sheep = new();
// McDroids.Cow cow = new();



// Random rnd = new();
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(rnd.NextString("a", "b", "c"));
// }
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(rnd.NextDouble(10));
// }
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(rnd.NextDouble(1000));
// }
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(rnd.CoinFlip(1));
// }

// ExeptisGame exeptisGame = new();


// TryingDelegates exemple = new();

// Console.WriteLine(exemple.DoOperation(10, exemple.AddOne));
// Console.WriteLine(exemple.DoOperation(10, exemple.SubtractOne));
// Console.WriteLine(exemple.DoOperation(10, exemple.Double));


// Sieve sieve = new();


// CharberryTree tree = new CharberryTree();
// Notifier notifier = new(tree);
// Harvester harvester = new(tree);

// while (true)
//     tree.MaybeGrow();



// LongGame game = new();
// game.Init();


// PotionStand potionStand = new();
// potionStand.Init();


// BlockCoordinate coord1 = new(1, 3);
// BlockOffset offset = new(4, 3);

// BlockCoordinate coord2 = coord1 + offset;
// Console.WriteLine(coord2);

// coord2 += Direction.East;
// Console.WriteLine(coord2);
// coord2 += Direction.East;
// Console.WriteLine(coord2);
// coord2 += Direction.East;
// Console.WriteLine(coord2);


// Console.WriteLine(coord2[0]);
// Console.WriteLine(coord2[1]);


// var procedural = ThreeLenses.Procedural(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
// var keywordbased = ThreeLenses.KeywordBased(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
// var methodcallbased = ThreeLenses.MethodCallBased(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });

// Console.WriteLine("procedural");
// foreach (var item in procedural) Console.WriteLine(item);
// Console.WriteLine("keywordbased");
// foreach (var item in keywordbased) Console.WriteLine(item);
// Console.WriteLine("methodcallbased");
// foreach (var item in methodcallbased) Console.WriteLine(item);


// RecentNumbers recentNumbers = new();

// Thread generateNumbersThread = new(recentNumbers.GenerateNumbers);
// generateNumbersThread.Start();

// Console.WriteLine("Press any key when the two last numbers was equal.");
// while (true)
// {
//     Console.ReadKey();
//     Console.WriteLine(recentNumbers.IsEqualLastNumbers() ? "Great job!" : "[X] Not equal!");
// }


RandomWords randomWords = new();

// randomWords.Init();
// await randomWords.InitAsync();
randomWords.InitAsyncMany();

