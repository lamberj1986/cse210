using System;
using System.Dynamic;

public class Comment
{
    private string _commentHandle;
    private string _comment;

    public Comment(string handle, string text)
    {
        _commentHandle = handle;
        _comment = text;
    }

    public string GetCommenterHandle()
    {
        return _commentHandle;
    }

    public string GetComment()
    {
        return _comment;
    }
}