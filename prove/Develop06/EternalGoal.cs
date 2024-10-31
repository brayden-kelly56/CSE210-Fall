public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override int RecordEvent()
    {
        int points = Int32.Parse(_points);
        return points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string formatedString = $"EternalGoal,{_shortName},{_description},{_points}";
        return formatedString;
    }
}