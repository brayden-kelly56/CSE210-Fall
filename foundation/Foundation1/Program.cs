using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Programming Challenge", "Brayden Kelly", 56);
        video1.AddComment("Andrew", "Awesome Job!");
        video1.AddComment("Tysen", "This is cool.");
        video1.AddComment("Dog", "Woof");
        video1.DisplayVideoInfo();

        Video video2 = new Video("Episode 2", "Gabe", 1800);
        video2.AddComment("Christian", "Keep up this series.");
        video2.AddComment("Joey", "Idk what to put.");
        video2.AddComment("Nathan", "Sweet.");
        video2.DisplayVideoInfo();

        Video video3 = new Video("BYUI Service Challenge", "Brad", 3600);
        video3.AddComment("Blaine", "So good to see all this service!");
        video3.AddComment("Isaac", "Good job bro.");
        video3.AddComment("Thomas", "Cool.");
        video3.DisplayVideoInfo();
    }
}