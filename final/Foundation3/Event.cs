public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _type;
    private Address _address;

    public Event(string title, string description, string date, string time, string type, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }

    public string Title
    {
        get { return _title; }
    }

    public string Description
    {
        get { return _description; }
    }

    public string Date
    {
        get { return _date; }
    }

    public string Time
    {
        get { return _time; }
    }

    public string Type
    {
        get { return _type; }
    }

    public string Address
    {
        get { return _address.DisplayAddress(); }
    }

    public void displayStandardDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Time: {Time}");
    }

    public void displayShortDescription()
    {
        Console.WriteLine("-----SHORT DESCRIPTION-----");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine();
    }
}

