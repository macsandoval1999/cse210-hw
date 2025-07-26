using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of videos with comments
        List<Video> videos = new List<Video>();

        // Create a video(title, author, duration)
        Video video1 = new Video("Introduction to C#", "John Wick", 300);
        // Add comments to the video
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very informative, thanks!"));
        video1.AddComment(new Comment("Alice", "Looking forward to more content!"));
        // Add the video to the list
        videos.Add(video1);

        Video video2 = new Video("C# Programming", "Keanu Reeves", 380);
        video2.AddComment(new Comment("Charlie", "Loved the examples!"));
        video2.AddComment(new Comment("Dave", "Can't wait for the next part!"));
        video2.AddComment(new Comment("Eve", "This is so helpful!"));
        video2.AddComment(new Comment("Frank", "Keep up the good work!"));
        videos.Add(video2);

        Video video3 = new Video("Learning Python", "Helen Wick", 600);
        video3.AddComment(new Comment("John Wick", "You did so well hon! I love you!"));
        video3.AddComment(new Comment("Helen Wick", "Thanks, John! I love you too!"));
        video3.AddComment(new Comment("Alice", "Wait... You're married to John Wick??!! Awesome!"));
        videos.Add(video3);

        Video video4 = new Video("JavaScript Basics", "Tony Stark", 450);
        video4.AddComment(new Comment("Peter Parker", "Excited for this one!"));
        video4.AddComment(new Comment("Natasha Romanoff", "JavaScript is so versatile!"));
        video4.AddComment(new Comment("Steve Rogers", "Can't wait to learn more!"));
        video4.AddComment(new Comment("Wanda Maximoff", "Wheres my children!!!???"));
        video4.AddComment(new Comment("Doctor Strange", "For the last time, Wanda... THEY ARENT REAL!!!"));
        videos.Add(video4);

        // Display all videos and their comments
        foreach (var video in videos)
        {
            video.Display();
            Console.WriteLine();
        }

    }
}