using csharp_players_guide.lib;
namespace csharp_players_guide.Challenges.Level24;

public class Player
{
    public string Name { get; set; }
    public PlayerOptions Choice { get; set; }

    public Player(string name)
    {
        Name = name;
    }

    public PlayerOptions PickAnOption()
    {
        string userInput = Helper.AskForString($"{Name}! Rock, Paper or Scissors? ");
        bool isValidChoice = Helper.IsValidEnumValue<PlayerOptions>(userInput);

        if (isValidChoice)
        {
            Choice = (PlayerOptions)Enum.Parse(typeof(PlayerOptions), userInput, true);
            return Choice;
        }
        else return PickAnOption();
    }

}
public class RockPaperScissorsGame
{
    public Player Player1 { get; set; }
    public Player Player2 { get; set; }
    public GameRound CurrentRound { get; set; }

    public RockPaperScissorsGame()
    {
        string player1Name = Helper.AskForString("Player 1, nickname: ");
        Console.Clear();
        string player2Name = Helper.AskForString("Player 2, nickname: ");

        Player1 = new Player(player1Name);
        Player2 = new Player(player2Name);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(GameHistoric.HistoryState(Player1, Player2));
            CurrentRound = new GameRound(Player1, Player2);
            Console.WriteLine(CurrentRound.Result);
        }

    }

    public class GameRound
    {
        public ResultOptions Result { get; private set; }

        public GameRound(Player player1, Player player2)
        {
            PlayerOptions player1Option = player1.PickAnOption();
            PlayerOptions player2Option = player2.PickAnOption();
            CompareAndSaveResults(player1, player2);
        }
        private void CompareAndSaveResults(Player player1, Player player2)
        {
            if (player1.Choice == player2.Choice)
            {
                GameHistoric.AddDraw();
                Result = ResultOptions.Draw;
            }
            else if ((player1.Choice == PlayerOptions.Rock && player2.Choice == PlayerOptions.Scissors) ||
                     (player1.Choice == PlayerOptions.Paper && player2.Choice == PlayerOptions.Rock) ||
                     (player1.Choice == PlayerOptions.Scissors && player2.Choice == PlayerOptions.Paper))
            {
                GameHistoric.AddPlayer1Win();
                Result = ResultOptions.Player1;
            }
            else
            {
                GameHistoric.AddPlayer2Win();
                Result = ResultOptions.Player2;
            }
        }
    }

    public static class GameHistoric
    {
        public static int Player1Wins { get; private set; } = 0;
        public static int Player2Wins { get; private set; } = 0;
        public static int Draws { get; private set; } = 0;

        static GameHistoric()
        {
            Player1Wins = 0;
            Player2Wins = 0;
            Draws = 0;
        }

        public static void AddPlayer1Win() => Player1Wins++;
        public static void AddPlayer2Win() => Player2Wins++;
        public static void AddDraw() => Draws++;

        static public string HistoryState(Player player1, Player player2) =>
         $"{player1.Name}: {Player1Wins} wins. \n{player2.Name}: {Player2Wins} wins. \nDraws: {Draws}.";

    }

}

public enum ResultOptions
{
    Player1, Player2, Draw
}
public enum PlayerOptions
{
    Rock, Paper, Scissors
}



/*
CRC

Player 
+ Must have a name;
+ Choose rock paper or scissors;

Game
+ Control the game status, as Console messages
+ Create new GameRounds                             | GameRound

GameHistoric
+ Control historic;

GameRound
+ Store the players choices per round;              | Player[2]
+ Get the winner                                    | ComparePlayers
+ Record the winner in the GameHistory              | GameHistoric
+ Validate the players choices and return who won;

*/
