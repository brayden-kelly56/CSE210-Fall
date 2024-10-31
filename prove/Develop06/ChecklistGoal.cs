public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int points = Int32.Parse(_points);
        if (_target == _amountCompleted)
        {
            points += _bonus;
        }
        return points;
    }

    public override bool IsComplete()
    {
        if (_target == _amountCompleted)
        {
           return true; 
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if (_amountCompleted == _target)
        {
            string goalstring = $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
            return goalstring;
        }
        else 
        {
            string goalstring = $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
            return goalstring;
        }
    }

    public override string GetStringRepresentation()
    {
        string formatedString = $"ChecklistGoal,{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
        return formatedString;
    }
}