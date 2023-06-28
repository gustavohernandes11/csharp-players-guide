using csharp_players_guide.lib;

namespace csharp_players_guide.Challenges
{
    public class Enumerations
    {
        private static BoxState currentBoxState = BoxState.Open;

        // 100xp
        public static void SimulasTest()
        {
            Console.WriteLine("Your options are close, open, lock and unlock!");

            while (true)
            {
                string userChoice = Helper.AskForString(GetMessage());
                HandleUserChoice(userChoice);
            }

            static string GetMessage()
            {
                string message = currentBoxState switch
                {
                    BoxState.Locked => "The chest is locked. What do you want to do?",
                    BoxState.Closed => "The chest is closed. What do you want to do?",
                    BoxState.Open => "The chest is open. What do you want to do?",
                    _ => ""
                };

                return message;
            }
            static void HandleUserChoice(string userChoice)
            {
                if (currentBoxState == BoxState.Locked && userChoice.ToLower().Trim() == "unlock")
                {
                    currentBoxState = BoxState.Closed;
                }
                if (currentBoxState == BoxState.Closed && userChoice.ToLower().Trim() == "lock")
                {
                    currentBoxState = BoxState.Locked;
                }
                if (currentBoxState == BoxState.Closed && userChoice.ToLower().Trim() == "open")
                {
                    currentBoxState = BoxState.Open;
                }
                if (currentBoxState == BoxState.Open && userChoice.ToLower().Trim() == "close")
                {
                    currentBoxState = BoxState.Closed;
                }
            }
        }

        enum BoxState
        {
            Locked,
            Closed,
            Open
        };

    }
}
