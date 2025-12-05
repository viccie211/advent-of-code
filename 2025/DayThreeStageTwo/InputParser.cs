namespace DayThreeStageTwo;

public class InputParser
{
    public List<Battery> ParseInput(string input)
    {
        var split = input.Split(Environment.NewLine);
        return split.Select(l =>
        {
            return new Battery()
            {
                Cells = l.ToCharArray().Select(c=>int.Parse(c.ToString())).ToList()
            };
        }).ToList();
    }
}