namespace csharp_players_guide.Challenges.Level24
{
    // 100xp
    public class DoorWithPassword
    {
        private int Password { get; set; }
        public DoorStateOptions State { get; private set; } = DoorStateOptions.Open;

        public DoorWithPassword(int password)
        {
            Password = password;
        }

        private void InvalidOption() => Console.WriteLine("No action was taken.");
        private void InvalidPassword() => Console.WriteLine("Incorrect password.");

        private bool IsValidPassword(int password) => password == Password;
        public void ChangePassword(int password, int newPassword)
        {
            if (IsValidPassword(password))
            {

                Password = newPassword;
                Console.WriteLine("The new password has been set.");
            }
            else
                InvalidPassword();
        }

        public void Close()
        {
            if (State == DoorStateOptions.Open)
            {
                State = DoorStateOptions.Closed;
                Console.WriteLine("The door was closed.");
            }
            else InvalidOption();
        }

        public void Open()
        {
            if (State == DoorStateOptions.Closed)
            {
                State = DoorStateOptions.Open;
                Console.WriteLine("The door was opened.");
            }
            else InvalidOption();
        }

        public void Lock()
        {
            if (State == DoorStateOptions.Closed)
            {
                State = DoorStateOptions.Locked;
                Console.WriteLine("The door was locked.");
            }
            else InvalidOption();
        }

        public void Unlock(int password)
        {
            if (State == DoorStateOptions.Locked && IsValidPassword(password))
            {
                State = DoorStateOptions.Closed;
                Console.WriteLine("The door was unlock");
            }
            else InvalidPassword();
        }

        public enum DoorStateOptions
        {
            Locked,
            Closed,
            Open
        };
    }
}
