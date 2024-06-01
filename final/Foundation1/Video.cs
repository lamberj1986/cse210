using System;
using System.Diagnostics;

public class Video
{
    private string _title;
    private string _author;
    private int _length; // Saved in seconds
    private List<Comment> _comments = new();

    public Video()
    {
        _title = "None";
        _author = "None";
        _length = 0;
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetCommentCount()
    {
        int commentCount = 0;

        return commentCount;
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}, by {_author}. Length: {_length} seconds.");

        foreach (Comment comment in _comments)
        {
            string comboComment = comment.GetCommenterHandle() + " - " + comment.GetComment();
            Console.WriteLine($"\n  * {comboComment}");
        }
    }
}