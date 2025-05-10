using System;

class SocialMedia
{
    public virtual void Post()
    {
        Console.WriteLine("Posting on social Media");
    }
}

class FacebookPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Posting on Facebook");
    }
}

class TwitterPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Tweeting on Twitter");
    }
}

class InstagramPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Posting on Instagram");
    }
}

class Program
{
    static void Main()
    {
        // Creating a SocialMedia object
        SocialMedia obj1 = new SocialMedia();
        obj1.Post(); // Output: Posting on social Media

        // Creating a FacebookPost object but referencing it as SocialMedia
        SocialMedia ob2 = new FacebookPost();
        ob2.Post(); // Output: Posting on Facebook

        // Creating a TwitterPost object
        SocialMedia obj3 = new TwitterPost();
        obj3.Post(); // Output: Tweeting on Twitter

        // Creating an InstagramPost object
        SocialMedia obj4 = new InstagramPost();
        obj4.Post(); // Output: Posting on Instagram
    }
}