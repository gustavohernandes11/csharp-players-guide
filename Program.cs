using System.Linq;
using csharp_players_guide.Challenges;
using csharp_players_guide.Challenges.Level24;
using csharp_players_guide.lib;
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


RockPaperScissorsGame game = new RockPaperScissorsGame();



