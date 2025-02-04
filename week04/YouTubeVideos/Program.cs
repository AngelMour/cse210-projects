using System;
using System.Collections.Generic;


//Class program:
//Needs to create 3-4 videos
//Set values
//For each value add a list of 3-4 comments

//attributes:
//_videos: List<Video>

//Methods;
//DysplayCommentInfo(): string (call other display methods)
class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Creating video objects
        Video video1 = new Video("The Durability Test of the iPhone 15", "JerryRigEverything", 900);
        video1.AddComment(new Comment("Alice", "That was a tough test!"));
        video1.AddComment(new Comment("Bob", "I love watching these durability tests."));
        video1.AddComment(new Comment("Charlie", "Amazing video as always!"));

        Video video2 = new Video("Samsung Galaxy Fold Bend Test!", "JerryRigEverything", 1100);
        video2.AddComment(new Comment("Dave", "I was waiting for this test!"));
        video2.AddComment(new Comment("Eva", "Crazy how much stress these phones endure."));
        video2.AddComment(new Comment("Frank", "This was super informative!"));

        Video video3 = new Video("Nothing Phone 2 Teardown!", "JerryRigEverything", 850);
        video3.AddComment(new Comment("Grace", "I love seeing the internals of phones!"));
        video3.AddComment(new Comment("Hank", "The design is impressive."));
        video3.AddComment(new Comment("Ivy", "This makes me appreciate engineering even more!"));

        Video video4 = new Video("The Tesla Cybertruck Scratch Test!", "JerryRigEverything", 1300);
        video4.AddComment(new Comment("Jack", "I was wondering how durable it really is!"));
        video4.AddComment(new Comment("Kelly", "That was a brutal test."));
        video4.AddComment(new Comment("Liam", "Incredible video as always!"));

        // Adding videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Displaying video details and comments
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}

//What does the program do

//Classes
//Video, Comment, Program


//Program
//Video, create a list of video