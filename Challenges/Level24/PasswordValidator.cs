namespace csharp_players_guide.Challenges.Level24
{
    public static class PasswordValidator
    {
        private static int minLetters = 6;
        private static int maxLetters = 13;

        public static bool IsValid(string password) =>
            IsInRange(password) &&
            HasUppercaseCharacter(password) &&
            !HasInvalidCaracters(password);

        private static bool IsInRange(string password)
        {
            if (password.Length < minLetters || password.Length > maxLetters)
                Console.WriteLine($"The password must contains from {minLetters} to {maxLetters} characters.");

            return (password.Length > minLetters && password.Length < maxLetters);
        }

        private static bool HasUppercaseCharacter(string password)
        {
            foreach (char letter in password)
            {
                if (char.IsUpper(letter)) return true;

            }
            Console.WriteLine("The password must contain at least one uppercase character.");
            return false;
        }
        private static bool HasInvalidCaracters(string password)
        {
            if (password.Contains("&"))
                Console.WriteLine("& is not allowed");

            if (password.Contains("T"))
                Console.WriteLine("T is not allowed");

            return password.Contains("&") || password.Contains("T");
        }
    }
}
