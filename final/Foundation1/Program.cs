using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("YouTube Video Manager\n");

        Video video1 = new Video("Carmichael Dreary", "How THIS product SAVED my life.", 985);
        Video video2 = new Video("Bruno and Max", "This product can do WHAT?!", 1206);
        Video video3 = new Video("Best Product Reviews", "This is one of the COOLEST products I've ever seen!!", 1002);

        Comment comments = new Comment();

        video1.DisplayVideoInfo();
        comments.DisplayCommentInfo(0, 2);

        video2.DisplayVideoInfo();
        comments.DisplayCommentInfo(3, 5);

        video3.DisplayVideoInfo();
        comments.DisplayCommentInfo(6, 8);
    }
}