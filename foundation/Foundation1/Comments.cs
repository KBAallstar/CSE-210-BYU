using System;

public class Comments
{
    private string _commentorName;
    private string _commentText;

    public Comments()
    {
        _commentorName = "Unknown";
        _commentText = "Comment empty.";
    }

    public Comments(string commentorName, string commentText)
    {
        _commentorName = commentorName;
        _commentText = commentText;
    }

    public string DisplayFullComment()
    {
        return $"{_commentorName}: {_commentText}";
    }

    public string DisplayFullComment(string commentorName, string commentText)
    {
        return $"{commentorName}: {commentText}";
    }
}