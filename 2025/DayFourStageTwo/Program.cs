using DayFourStageTwo;

var input = await File.ReadAllTextAsync("D:\\Work\\Personal\\advent-of-code\\2025\\DayFourStageTwo\\input.txt");

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

var previousTotal = -1;
var total = 0;
var i = 0;
while (previousTotal != total)
{
    var subTotal = 0;
    var indexesTotRemove = new List<(int, int)>();

    for (var y = 0; y < paddedInput.GetDimensionLength(0); y++)
    {
        for (var x = 0; x < paddedInput.GetDimensionLength(1); x++)
        {
            if (paddedInput[y, x] == 0)
                continue;
            var amountOfRollsNextToThis = 0;
            for (var localY = y - 1; localY < y + 2; localY++)
            {
                for (var localX = x - 1; localX < x + 2; localX++)
                {
                    if (localY != y || localX != x)
                        amountOfRollsNextToThis += paddedInput[localY, localX];
                }
            }

            if (amountOfRollsNextToThis < 4)
            {
                subTotal++;
                indexesTotRemove.Add((y, x));
            }
        }
    }
    previousTotal = total;
    total += subTotal;

    foreach (var index in indexesTotRemove)
    {
        paddedInput[index.Item1,index.Item2] = 0;
    }
}

Console.WriteLine($"Total: {total}");