using DayFiveStageTwo;

var input = await File.ReadAllTextAsync("D:\\Work\\Personal\\advent-of-code\\2025\\DayFiveStageTwo\\input.txt");

var inputParser = new InputParser();
var database = inputParser.ParseInput(input);

long lastMin = 0;
long lastMax = 0;
long total = 0;
foreach (var freshIdRange in database.FreshIdRanges)
{
    Console.Write($"R: {freshIdRange.InclusiveMin}-{freshIdRange.InclusiveMax}");
    if (freshIdRange.InclusiveMax < lastMax)
    {
        Console.Write(" skipped");
        Console.WriteLine();
        continue;
    }

    if (freshIdRange.InclusiveMin > lastMax)
    {
        Console.Write(" fully higher");
        var toAdd = freshIdRange.InclusiveMax + 1 - freshIdRange.InclusiveMin;
        total += toAdd;
        Console.Write($" added {toAdd}");
        lastMin = freshIdRange.InclusiveMin;
        lastMax = freshIdRange.InclusiveMax;
        Console.WriteLine();
        continue;
    }

    if (freshIdRange.InclusiveMin >= lastMin && freshIdRange.InclusiveMax > lastMax)
    {
        Console.Write(" partial");
        total += freshIdRange.InclusiveMax - lastMax;
        lastMax = freshIdRange.InclusiveMax;
        lastMin = freshIdRange.InclusiveMin;
    }

    Console.WriteLine();
}

Console.WriteLine($"total: {total}");