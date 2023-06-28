namespace csharp_players_guide.Challenges
{
    public class Switches
    {
        private static string userName = "undefined";

        private class SaleItem
        {
            public int Key;
            public string Name;
            public double Price;

            public SaleItem(int key, string name, double price)
            {
                this.Key = key;
                this.Name = name;
                this.Price = price;
            }
        }

        public static void GetUserName()
        {
            Console.WriteLine("What is your username? ");
            string? userNameInput = Console.ReadLine();

            if (!String.IsNullOrEmpty(userNameInput))
                userName = userNameInput;
        }

        // 100xp + 50xp
        public static void BuyingInventory()
        {
            SaleItem[] salesOptions = new SaleItem[7];
            salesOptions[0] = new SaleItem(0, "Rope", 10);
            salesOptions[1] = new SaleItem(1, "Torches", 15);
            salesOptions[2] = new SaleItem(2, "Climbing Equipment", 10);
            salesOptions[3] = new SaleItem(3, "Clean Water", 1);
            salesOptions[4] = new SaleItem(4, "Machete", 20);
            salesOptions[5] = new SaleItem(5, "Canoe", 200);
            salesOptions[6] = new SaleItem(6, "Food Supplies", 1);

            Console.WriteLine("The following items are available: ");

            for (int i = 0; i < salesOptions.Length; i++)
            {
                Console.WriteLine(salesOptions[i].Key + " - " + salesOptions[i].Name);
            }

            Console.WriteLine("Choose an item: ");
            ConsoleKeyInfo? selectedKeyInput = Console.ReadKey();
            int selectedKey;
            Console.WriteLine("\n");

            Int32.TryParse(selectedKeyInput.Value.KeyChar.ToString(), out selectedKey);

            if (userName == "Gustavo")
            {
                Console.WriteLine("50% OFF!");
                Console.WriteLine(salesOptions[selectedKey].Name + " costs " + (salesOptions[selectedKey].Price / 2) + " gold.");
            }
            else
            {
                Console.WriteLine(salesOptions[selectedKey].Name + " costs " + salesOptions[selectedKey].Price + " gold.");
            }
        }
    }
}
