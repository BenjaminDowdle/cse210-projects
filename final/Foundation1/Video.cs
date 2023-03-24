public class Video
{
    public string _author;
    public string _title;
    public int _length;

    public Video(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Author: {_author} | Title: {_title} | Length: {_length}");
    }

}