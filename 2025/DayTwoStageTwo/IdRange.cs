namespace DayTwoStageTwo;

public class IdRange
{
    public required long Min { get; init; }
    public required long Max { get; init; }
    public List<long> InvalidIds { get; private set; } = [];

    public void CalculateInvalidIds()
    {
        for (long i = Min; i <= Max; i++)
        {
            var chunkOptions = new List<int>();
            var stringId = i.ToString();
            for (int j = stringId.Length / 2; j > 0; j--)
            {
                if (stringId.Length % j == 0)
                {
                    chunkOptions.Add(j);
                }
            }

            foreach (var chunkOption in chunkOptions)
            {
                var chunks = new List<string>();
                for (int j = 0; j < stringId.Length/chunkOption; j++)
                {
                    chunks.Add(stringId.Substring(j*chunkOption, chunkOption));
                }

                if (chunks.All(c => c == chunks[0]))
                {
                    InvalidIds.Add(i);
                    break;
                }
            }
        }
    }
}