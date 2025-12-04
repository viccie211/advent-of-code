namespace DayOneStageTwo;;

public class InputParser
{
    public List<Step> ParseInput(string input)
    {
        var lines = input.Split(Environment.NewLine);
        return lines.Select(l => new Step()
        {
            Direction = l[0] == 'L' ? EDirection.L : EDirection.R,
            Amount = int.Parse(l.Substring(1))
        }).ToList();
    }
}