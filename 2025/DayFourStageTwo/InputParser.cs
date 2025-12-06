namespace DayFourStageTwo;

public class InputParser
{
    private const int PADDING = 2;

    public int[,] ParseInput(string inputString)
    {
        var split = inputString.Split(Environment.NewLine);
        var rows = new List<int[]>();
        var maxLineLength = 0;
        foreach (var line in split)
        {
            var lineResult = line.ToCharArray().Select(c => c == '@' ? 1 : 0).ToArray();
            rows.Add(lineResult);
            if (lineResult.Length > maxLineLength)
                maxLineLength = lineResult.Length;
        }

        var result = new int[rows.Count, maxLineLength];
        for (var y = 0; y < rows.Count; y++)
        {
            for (var x = 0; x < maxLineLength; x++)
            {
                result[y, x] = rows[y][x];
            }
        }

        return result;
    }

    public int[,] PadInput(int[,] input)
    {
        var ySize = input.GetDimensionLength(0);
        var xSize = input.GetDimensionLength(1);
        var paddedYSize = ySize + PADDING;
        var paddedXSize = xSize + PADDING;
        var halfPadding = PADDING / 2;

        var paddedResult = new int[paddedYSize, paddedXSize];
        for (var y = 0; y < ySize; y++)
        {
            for (var x = 0; x < xSize; x++)
            {
                paddedResult[y + halfPadding, x + halfPadding] = input[y, x];
            }

            paddedResult[y, paddedXSize - 1] = 0;
        }

        return paddedResult;
    }
}