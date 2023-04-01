public class Cycling : Activity
{
    private double _speed;

    public Cycling(double minutes, double speed) : base(minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * Minutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        DateTime date = Date;
        string summary = $"{Date.ToShortDateString()} Cycling ({Minutes} min)- Distance: {Math.Round(GetDistance(), 1)}, Speed: {Math.Round(GetSpeed(), 1)} mph, Pace: {Math.Round(GetPace(), 1)} min per mile";

        return summary;
    }
}