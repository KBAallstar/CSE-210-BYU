using System;
using System.Runtime.InteropServices;

public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comments> _commentsList;

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
        _commentsList = new List<Comments>();
        CreateComments();
    }

    private List<Comments> CreateComments()
    {
        _commentsList.Add(new Comments("John", "This video was cool. I want to see more."));
        _commentsList.Add(new Comments("Victoria", "I didn't like this video."));
        _commentsList.Add(new Comments("Marco", "This video was okay. I've seen better."));
        return _commentsList;
    }

    public string DisplayVideoInfo()
    {
        return $"Title: {_title}. Author: {_author}. Length: {_length}.";
    }

    public void AddComment(Comments comment)
    {
        _commentsList.Add(comment);
    }

    public List<Comments> GetCommentsList()
    {
        return _commentsList;
    }

    public int ReturnCommentsCount()
    {
        return _commentsList.Count;
    }
}