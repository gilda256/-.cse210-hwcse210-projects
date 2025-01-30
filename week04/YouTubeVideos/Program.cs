using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("What is C#", "David Fowler", 480);
        Video video2 = new Video("Java vs C#", "Stefan Mischook", 360);
        Video video3 = new Video("C# Tutorial", "Teddy Smith", 500);

        video1.AddComment(new Comment("John", "Excellent content!"));
        video1.AddComment(new Comment("Sara", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Michael", "make more videos on this topic."));

        video2.AddComment(new Comment("Sophia", "Good explanations!"));
        video2.AddComment(new Comment("Ketty", "Well-explained and brief."));
        video2.AddComment(new Comment("Braian", "That's great!"));

        video3.AddComment(new Comment("Antony", "Thank you!"));
        video3.AddComment(new Comment("Megan", "This helped me a lot, thanks!"));
        video3.AddComment(new Comment("Alic", "Great!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
