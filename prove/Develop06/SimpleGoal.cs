public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        int points = Int32.Parse(_points);
        return points;
    }

    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        string formatedString = $"SimpleGoal,{_shortName},{_description},{_points},{_isComplete}";
        return formatedString;
    }
}