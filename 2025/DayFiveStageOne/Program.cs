using DayFiveStageOne;

var input = await File.ReadAllTextAsync("D:\\Work\\Personal\\advent-of-code\\2025\\DayFiveStageOne\\input.txt");

var inputParser = new InputParser();
var database = inputParser.ParseInput(input);


var total = 0;
foreach (var id in database.Ids)
{
    if (database.FreshIdRanges.Any(r => id >= r.InclusiveMin && id <= r.InclusiveMax))
    {
        total++;
    }
}

Console.WriteLine($"Total ids: {total}");