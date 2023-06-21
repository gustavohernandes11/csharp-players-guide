using csharp_players_guide.Challenges;


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

// levelExemple.Countdown(100);
// int numberFromUser = levelExemple.AskForNumber("Digite um número: ");

// HuntingTheManticore.Init();

// Level16.SimulasTest();
// Level17.SimulasSoup();

using static csharp_players_guide.Challenges.Arrow;

Arrow arrow1 = new Arrow(ArrowHeadOptions.Wood, FletchingTypeOptions.TurkeyFeathers, 70);
Arrow arrow2 = new Arrow(ArrowHeadOptions.Obsidian, FletchingTypeOptions.Plastic, 80);
Arrow arrow3 = new Arrow(ArrowHeadOptions.Steel, FletchingTypeOptions.GooseFeathers, 60);

Console.WriteLine(arrow1.TotalPrice);
Console.WriteLine(arrow2.TotalPrice);
Console.WriteLine(arrow3.TotalPrice);

Console.WriteLine(arrow3.Length);
Console.WriteLine(arrow3.ArrowHead);
Console.WriteLine(arrow3.FletchingType);


// Level20 testingGetOnly = new(10, 10);
// Console.WriteLine(testingGetOnly.Area);

// testingGetOnly.Height = 200;
// Console.WriteLine(testingGetOnly.Area);
