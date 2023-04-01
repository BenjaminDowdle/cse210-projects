public class Running : Activity
{
    private double _distance;

    public Running(double minutes, double distance) : base(minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        return (Minutes / _distance);
    }

    public override string GetSummary()
    {
        DateTime date = Date;
        string summary = $"{date.ToShortDateString()} Running ({Minutes} min)- Distance: {Math.Round(GetDistance(), 1)}, Speed: {Math.Round(GetSpeed(), 1)} mph, Pace: {Math.Round(GetPace(), 1)} min per mile";

        return summary;
    }
}