using System.Collections.Generic;
using Microsoft.VisualBasic;

public class Video
{
    // MEMBER VARIABLES
    private String _title; // The title of the video
    private String _author; // The author of the video
    private int _lengthInSeconds; // The length of the video in seconds
    private List<Comment> _comments = new List<Comment>(); // The comments on the video

    // CONSTRUCTOR
    public Video(String title, String author, int lengthInSeconds)
    {
        _title = title; // parameter 1 is assigned to _title
        _author = author; // parameter 2 is assigned to _author
        _lengthInSeconds = lengthInSeconds; // parameter 3 is assigned to _lengthInSeconds
    }

    // METHODS
    public void AddComment(Comment comment)
    // Adds a comment to the videos comments list
    {
        _comments.Add(comment);
    }
    private void GetCommentAmount()
    // Displays the number of comments on the video
    {
        Console.WriteLine($" {_comments.Count} people commented.");
    }
    public void Display()
    // Displays the video information and its comments
    {
        Console.WriteLine($"-Title: {_title}");
        Console.WriteLine($" Author: {_author}");
        Console.WriteLine($" Length: {_lengthInSeconds} seconds");
        GetCommentAmount();
        Console.WriteLine(" Comments:");
        // Loop through each comment
        foreach (var comment in _comments)
        {
            // and display the comment
            comment.Display();
        }
    }
}