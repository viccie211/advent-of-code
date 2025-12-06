using DayFourStageOne;

var input = await File.ReadAllTextAsync("D:\\Work\\Personal\\advent-of-code\\2025\\DayFourStageOne\\input.txt");

var inputParser = new InputParser();
var parsedInput = inputParser.ParseInput(input);
var paddedInput = inputParser.PadInput(parsedInput);


for (var y = 0; y < paddedInput.GetDimensionLength(0); y++)
{
    for (var x = 0; x < paddedInput.GetDimensionLength(1); x++)
    {
        Console.Write(paddedInput[y, x]);
    }

    Console.WriteLine();
}

var total = 0;

for (var y = 0; y < paddedInput.GetDimensionLength(0); y++)
{
    for (var x = 0; x < paddedInput.GetDimensionLength(1); x++)
    {
        if (paddedInput[y, x] == 0)
            continue;
        var subTotal = 0;
        for (var localY = y - 1; localY < y + 2; localY++)
        {
            for (var localX = x - 1; localX < x + 2; localX++)
            {
                if (localY != y || localX != x)
                    subTotal += paddedInput[localY, localX];
            }
        }

        if (subTotal < 4)
        {
            total++;
        }
    }
}

Console.WriteLine($"Total: {total}");