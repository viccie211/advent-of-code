namespace DayTwoStageOne;

public class InputParser
{
    public List<IdRange> ParseInput(string inputText)
    {
        var splitInRanges = inputText.Split(',');
        return splitInRanges.Select(r =>
        {
            var splitOnDash = r.Split('-');
            return new IdRange()
            {
                Min = long.Parse(splitOnDash.First()),
                Max = long.Parse(splitOnDash.Last())
            };
        }).ToList();
    }
}