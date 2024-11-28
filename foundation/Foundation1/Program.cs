using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        videoList.Add(new Video("Watch A Snake Eat Lunch", "CoolSnakeGuy", "12:00"));
        videoList.Add(new Video("How Does This Guy Own Snakes?", "Skeptik4Life", "8:32"));
        videoList.Add(new Video("Do Snakes Exist???", "Conspearacy42069", "69:42"));

        foreach (Video video in videoList)
        {
            Console.WriteLine($"VIDEO {videoList.IndexOf(video) + 1} INFO");
            Console.WriteLine($"{video.DisplayVideoInfo()}");
            Console.WriteLine($"Comment count: {video.ReturnCommentsCount()}");

            foreach (Comments comment in video.GetCommentsList())
            {
                Console.WriteLine($"--{comment.DisplayFullComment()}");
            }

            Console.WriteLine();
        }
    }
}