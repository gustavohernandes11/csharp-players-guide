using NAudio.Wave;

namespace csharp_players_guide.lib;

static class SoundEffect
{
    public static void Soundtrack(bool shouldContinueRunning)
    {
        Thread thread = new Thread(() => PlaySoundtrack("sounds/soundtrack.wav", shouldContinueRunning));
        thread.Start();
    }

    public static void Fail() => PlayEffect("sounds/fail.wav");
    public static void Win() => PlayEffect("sounds/win.wav");
    public static void Drum() => PlayEffect("sounds/drum.wav");
    public static void NormalDamage() => PlayEffect("sounds/punch.wav");
    public static void Zap() => PlayEffect("sounds/zap.wav");
    public static void Fire() => PlayEffect("sounds/fire.wav");


    private static void PlaySoundtrack(string filePath, bool shouldContinueRunning)
    {
        using (var audioFile = new AudioFileReader(filePath))
        using (var outputDevice = new WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();

            while (shouldContinueRunning)
            {
                Thread.Sleep(100);
            }

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


}


