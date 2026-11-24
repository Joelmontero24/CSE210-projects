public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private readonly List<Comment> _comments = new();

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Title:  {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}