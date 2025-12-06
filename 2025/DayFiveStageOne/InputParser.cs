namespace DayFiveStageOne;

public class InputParser
{
    public Database ParseInput(string input)
    {
        var freshIdRanges = new List<IdRange>();
        var split = input.Split(Environment.NewLine);
        var i = 0;
        while (split[i] != "")
        {
            var splitOnDash = split[i].Split('-');
            freshIdRanges.Add(new IdRange()
            {
                InclusiveMin = long.Parse(splitOnDash.First()),
                InclusiveMax = long.Parse(splitOnDash.Last())
            });
            i++;
        }

        i++;

        var ids = new List<long>();
        while (i < split.Length)
        {
            ids.Add(long.Parse(split[i]));
            i++;
        }

        return new Database()
        {
            FreshIdRanges = freshIdRanges,
            Ids = ids,
        };
    }
}