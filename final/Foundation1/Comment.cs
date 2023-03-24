public class Comment
{
    public List<string> _names = new List<string>
    {
        "Jeffrey Highland",
        "Junior12",
        "Carlton Banks",
        "Sigfreid Raggerton",
        "BlossomWillow123",
        "ProudMama43",
        "Hillary Dougherton",
        "Dory Fisher",
        "Nikki Hanks"
    };
    public List<string> _comments = new List<string>{
        "So glad that I saw this video. This product will help me so much!",
        "Definitely seems like this product is lacking. Good video tho.",
        "Like this immensely!!!",
        "That product seems very handy! I might need to get one.",
        "Wait... I'm still kinda confused...",
        "Where can I get one of those?",
        "That IS so cool! How did you find out about that?",
        "It makes me wonder what other uses that thing has... I'll have to try it out.",
        "Seems mediocre... I bet I could totally make something better."
    };

    public void DisplayCommentInfo(int min, int max)
    {
        Console.WriteLine();
        Console.WriteLine($"   Comments: {max - min + 1}");
        while (min <= max)
        {
            Console.WriteLine($"     {_names[min]}");
            Console.WriteLine($"        {_comments[min]}\n");
            min += 1;
        }
    }
}