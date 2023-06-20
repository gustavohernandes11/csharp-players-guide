using NAudio.Wave;

namespace csharp_players_guide.lib;

static class SoundEffect
{
    public static void Soundtrack() => PlaySoundtrack("sounds/soundtrack.wav");
    public static void Fail() => PlayEffect("sounds/fail.wav");
    public static void Drum() => PlayEffect("sounds/drum.wav");
    public static void Zap() => PlayEffect("sounds/zap.wav");
    public static void Explosion() => PlayEffect("sounds/explosion.wav");
    public static void Win() => PlayEffect("sounds/win.wav");
    public static void Fire() => PlayEffect("sounds/fire.wav");

    private static void PlaySoundtrack(string filePath)
    {
        using (var audioFile = new AudioFileReader(filePath))
        using (var outputDevice = new WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            Thread.Sleep(17000);
            outputDevice.Stop();

        }
    }

    public static void PlayEffect(string filePath)
    {
        using (var audioFile = new AudioFileReader(filePath))
        using (var outputDevice = new WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            Thread.Sleep(1500);
            outputDevice.Stop();
        }
    }

    internal static WaveOutEvent PlaySoundtrack()
    {
        throw new NotImplementedException();
    }
}


