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

Arrow arrow1 = new Arrow(ArrowHead.Wood, FletchingType.TurkeyFeathers, 70);
Arrow arrow2 = new Arrow(ArrowHead.Obsidian, FletchingType.Plastic, 80);
Arrow arrow3 = new Arrow(ArrowHead.Steel, FletchingType.GooseFeathers, 60);

Console.WriteLine(arrow1.GetTotalPrice());
Console.WriteLine(arrow2.GetTotalPrice());
Console.WriteLine(arrow3.GetTotalPrice());

Console.WriteLine(arrow3.GetLength());
Console.WriteLine(arrow3.GetArrowHead());
Console.WriteLine(arrow3.GetFletchingType());
