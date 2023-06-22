using System.ComponentModel;
using csharp_players_guide.lib;

namespace csharp_players_guide.Challenges.Level24
{
    // 100xp 
    public class Card
    {
        private CardColor Color { get; set; }
        private CardRank Rank { get; set; }
        public string Value => $"The {Color} {Rank}";

        public bool IsNumber => Helper.IsValidEnumValue<CardRankNumber>($"{Rank}");
        public bool IsSymbol => Helper.IsValidEnumValue<CardRankSymbol>($"{Rank}");

        public Card(CardColor color, CardRank rank)
        {
            Color = color;
            Rank = rank;
        }

        public static Card[] CreateFullDeck()
        {
            Array cardRanks = Enum.GetValues(typeof(CardRank));
            Array cardColors = Enum.GetValues(typeof(CardColor));

            Card[] deck = new Card[cardRanks.Length * cardColors.Length];
            int index = 0;

            for (int i = 0; i < cardRanks.Length; i++)
            {
                for (int j = 0; j < cardColors.Length; j++)
                {
                    deck[index] = new Card((CardColor)j, (CardRank)i);
                    index++;
                }
            }
            return deck;
        }
    }
}

public enum CardColor { Red, Green, Blue, Yellow };
public enum CardRank
{
    One = 1,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Dollar = 11,
    Percent,
    Caret,
    Ampersand,
};

enum CardRankSymbol
{
    Dollar,
    Percent,
    Caret,
    Ampersand,
};
enum CardRankNumber
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten
};
