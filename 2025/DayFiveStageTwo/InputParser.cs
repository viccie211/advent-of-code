namespace DayFiveStageTwo;

public class InputParser
{
    public Database ParseInput(string input)
    {
        var freshIdRanges = new List<IdRange>();
        var split = input.Split(Environment.NewLine);
        var availableFreshIds = new HashSet<long>();
        var i = 0;
        while (split[i] != "")
        {
            var splitOnDash = split[i].Split('-');
            var range = new IdRange()
            {
                InclusiveMin = long.Parse(splitOnDash.First()),
                InclusiveMax = long.Parse(splitOnDash.Last())
            };
            
            freshIdRanges.Add(range);
            i++;
        }


        return new Database()
        {
            FreshIdRanges = freshIdRanges.OrderBy(r => r.InclusiveMin).ToList(),
        };
    }
}