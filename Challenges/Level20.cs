namespace csharp_players_guide.Challenges
{
    public class Level20
    {

        public float Width { get; set; }
        public float Height { get; set; }

        //get-only
        public float Area => Width * Height;

        public Level20(float height, float width)
        {
            Width = width;
            Height = height;
        }
    }
}
