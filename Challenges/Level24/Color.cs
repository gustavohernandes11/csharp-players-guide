namespace csharp_players_guide.Challenges.Level24;

// 100xp
public class Color
{
    private byte RedRGB { get; set; }
    private byte GreenRGB { get; set; }
    private byte BlueRGB { get; set; }

    public string RGB => $"{RedRGB}, {GreenRGB}, {BlueRGB}";
    public string Hexadecimal => $"#{RedRGB:X2}{GreenRGB:X2}{BlueRGB:X2}";

    public static Color White => new Color(255, 255, 255);
    public static Color Black => new Color(0, 0, 0);
    public static Color Red => new Color(255, 0, 0);
    public static Color Orange => new Color(255, 165, 0);
    public static Color Yellow => new Color(255, 255, 0);
    public static Color Green => new Color(0, 128, 0);
    public static Color Blue => new Color(0, 0, 255);
    public static Color Purple => new Color(128, 0, 128);

    public Color(byte red, byte green, byte blue)
    {
        RedRGB = red;
        GreenRGB = green;
        BlueRGB = blue;
    }
}
