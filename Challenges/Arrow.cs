namespace csharp_players_guide.Challenges
{
    // 100xp + 50xp
    public class Arrow
    {
        private const double arrowHeadSteelPrice = 10;
        private const double arrowHeadWoodPrice = 3;
        private const double arrowHeadObsidianPrice = 5;

        private const double fletchingTypePlasticPrice = 10;
        private const double fletchingTypeTurkeyFeathersPrice = 5;
        private const double fletchingTypeGooseFeathersPrice = 3;

        private const int arrowMinLength = 60;
        private const int arrowMaxLength = 100;
        private const double lengthPriceMultiplier = 0.05;


        private ArrowHead arrowHead;
        private FletchingType fletchingType;
        private int length;

        private double totalPrice;

        public Arrow(ArrowHead arrowHead, FletchingType fletchingType, int length)
        {
            if (length > arrowMaxLength || length < arrowMinLength)
            {
                throw new OutOfRangeException("Arrows should be 60 to 100 cm long.");
            }

            this.arrowHead = arrowHead;
            this.fletchingType = fletchingType;
            this.length = length;

            totalPrice = CalculateTotalPrice();

        }

        private double CalculateTotalPrice()
        {
            double arrowHeadPrice = GetArrowHeadPrice();
            double fletchingTypePrice = GetFletchingTypePrice();
            double lengthPrice = GetLengthPrice();

            return arrowHeadPrice + fletchingTypePrice + lengthPrice;
        }

        private double GetArrowHeadPrice()
        {
            return this.arrowHead switch
            {
                ArrowHead.Steel => arrowHeadSteelPrice,
                ArrowHead.Wood => arrowHeadWoodPrice,
                ArrowHead.Obsidian => arrowHeadObsidianPrice,
                _ => 0,
            };
        }

        private double GetFletchingTypePrice()
        {
            return this.fletchingType switch
            {
                FletchingType.Plastic => fletchingTypePlasticPrice,
                FletchingType.TurkeyFeathers => fletchingTypeTurkeyFeathersPrice,
                FletchingType.GooseFeathers => fletchingTypeGooseFeathersPrice,
                _ => 0,
            };

        }

        private double GetLengthPrice() => this.length * 0.05;

        public double GetLength() => this.length;
        public ArrowHead GetArrowHead() => this.arrowHead;
        public FletchingType GetFletchingType() => this.fletchingType;
        public double GetTotalPrice() => this.totalPrice;
    }
    public enum ArrowHead { Steel, Wood, Obsidian };
    public enum FletchingType { Plastic, TurkeyFeathers, GooseFeathers };
}

