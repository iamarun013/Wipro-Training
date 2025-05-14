using System;

interface IMusicPlayer
{
    void Play(string song);
    void Pause();
    void Stop();
}

class SpotifyPlayer : IMusicPlayer
{
    public void Play(string song)
    {
        Console.WriteLine($"Playing {song} on Spotify");
    }

    public void Pause()
    {
        Console.WriteLine("Spotify playback paused");
    }

    public void Stop()
    {
        Console.WriteLine("Spotify playback stopped");
    }
}

class AppleMusicPlayer : IMusicPlayer
{
    public void Play(string song)
    {
        Console.WriteLine($"Playing {song} on Apple Music");
    }

    public void Pause()
    {
        Console.WriteLine("Apple Music playback paused");
    }

    public void Stop()
    {
        Console.WriteLine("Apple Music playback stopped");
    }
}

class Program
{
    public static void Main()
    {
        IMusicPlayer im;

        im = new SpotifyPlayer();
        im.Play("Bewafa");
        im.Pause();
        im.Stop();

        im = new AppleMusicPlayer();
        im.Play("Aane do humko sasan mein");
        im.Pause();
        im.Stop();
    }
}