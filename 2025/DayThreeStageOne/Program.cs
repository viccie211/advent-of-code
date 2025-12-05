using DayThreeStageOne;

var inputString = await File.ReadAllTextAsync("D:\\Work\\Personal\\advent-of-code\\2025\\DayThreeStageOne\\input.txt");
var inputParser = new InputParser();
var batteries = inputParser.ParseInput(inputString);

var total = 0;
foreach (var battery in batteries)
{
    var indexHighestFirstDigit = 0;
    for (int i = 1; i < battery.Cells.Count - 1; i++)
    {
        if (battery.Cells[i] > battery.Cells[indexHighestFirstDigit])
        {
            indexHighestFirstDigit = i;
        }
    }

    var indexHighestSecondDigit = indexHighestFirstDigit + 1;
    for (int j = indexHighestFirstDigit + 1; j < battery.Cells.Count; j++)
    {
        if (battery.Cells[j] > battery.Cells[indexHighestSecondDigit])
        {
            indexHighestSecondDigit = j;
        }
    }

    //Console.WriteLine($"{indexHighestFirstDigit} {battery.Cells[indexHighestFirstDigit]} | {indexHighestSecondDigit} {battery.Cells[indexHighestSecondDigit]}");
    total += battery.Cells[indexHighestFirstDigit] * 10 + battery.Cells[indexHighestSecondDigit];
}

Console.WriteLine($"Total: {total}");