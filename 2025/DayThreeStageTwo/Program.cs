using System.Text;
using DayThreeStageTwo;

var inputString = await File.ReadAllTextAsync("D:\\Work\\Personal\\advent-of-code\\2025\\DayThreeStageTwo\\input.txt");
var inputParser = new InputParser();
var batteries = inputParser.ParseInput(inputString);

long total = 0;
const int JOLTAGE_LENGTH = 12;
foreach (var battery in batteries)
{
    var indexes = new int[JOLTAGE_LENGTH];

    indexes[0] = 0;

    for (int i = 0; i < JOLTAGE_LENGTH; i++)
    {
        if (i > 0)
        {
            indexes[i] = indexes[i - 1] + 1;
        }

        for (int j = indexes[i]; j < battery.Cells.Count - JOLTAGE_LENGTH + i + 1; j++)
        {
            if (battery.Cells[j] > battery.Cells[indexes[i]])
            {
                indexes[i] = j;
            }
        }
    }

    var sb = new StringBuilder();
    foreach (var index in indexes)
    {
        sb.Append(battery.Cells[index]);
    }


    Console.WriteLine(sb.ToString());
    total += long.Parse(sb.ToString());
}


Console.WriteLine($"Total: {total}");