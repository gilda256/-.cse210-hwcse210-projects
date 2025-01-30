class Comment
{
    public string CommentName{get;}
    public string CommentText{get;}

    public Comment(string name, string text)
    {
        CommentName = name;
        CommentText = text;
    }
    public void DisplayComment()
    {
         Console.WriteLine($"- {CommentName}: {CommentText}");
    }
}
    