namespace csharp_players_guide.Challenges
{
    // 100xp + 50xp + 100xp + 100xp
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


        public ArrowHeadOptions ArrowHead { get; set; }
        public FletchingTypeOptions FletchingType { get; set; }
        public int Length { get; set; }

        public double TotalPrice { get; private set; }

        public static Arrow CreateEliteArrow => new Arrow(ArrowHeadOptions.Steel, FletchingTypeOptions.Plastic, 95);
        public static Arrow CreateBeginnerArrow => new Arrow(ArrowHeadOptions.Wood, FletchingTypeOptions.GooseFeathers, 75);
        public static Arrow CreateMarksmanArrow => new Arrow(ArrowHeadOptions.Steel, FletchingTypeOptions.GooseFeathers, 65);

        public Arrow(ArrowHeadOptions arrowHead, FletchingTypeOptions fletchingType, int length)
        {
            if (length > arrowMaxLength || length < arrowMinLength)
            {
                throw new OutOfRangeException("Arrows should be 60 to 100 cm long.");
            }

            ArrowHead = arrowHead;
            FletchingType = fletchingType;
            Length = length;

            TotalPrice = CalculateTotalPrice();

        }

        private double CalculateTotalPrice()
        {
            double arrowHeadPrice = CalculateArrowHeadPrice();
            double fletchingTypePrice = CalculateFletchingTypePrice();
            double lengthPrice = CalculateLengthPrice();

            return arrowHeadPrice + fletchingTypePrice + lengthPrice;
        }

        private double CalculateArrowHeadPrice()
        {
            return ArrowHead switch
            {
                ArrowHeadOptions.Steel => arrowHeadSteelPrice,
                ArrowHeadOptions.Wood => arrowHeadWoodPrice,
                ArrowHeadOptions.Obsidian => arrowHeadObsidianPrice,
                _ => 0,
            };
        }

        private double CalculateFletchingTypePrice()
        {
            return FletchingType switch
            {
                FletchingTypeOptions.Plastic => fletchingTypePlasticPrice,
                FletchingTypeOptions.TurkeyFeathers => fletchingTypeTurkeyFeathersPrice,
                FletchingTypeOptions.GooseFeathers => fletchingTypeGooseFeathersPrice,
                _ => 0,
            };

        }

        private double CalculateLengthPrice() => Length * 0.05;

        public enum ArrowHeadOptions { Steel, Wood, Obsidian };
        public enum FletchingTypeOptions { Plastic, TurkeyFeathers, GooseFeathers };
    }
}

