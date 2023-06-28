namespace csharp_players_guide.Challenges
{
    public class Square
    {

        public float Width { get; set; }
        public float Height { get; set; }

        //get-only
        public float Area => Width * Height;

        public Square(float height, float width)
        {
            Width = width;
            Height = height;
        }
    }
}
