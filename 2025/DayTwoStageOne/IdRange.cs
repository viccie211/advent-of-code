namespace DayTwoStageOne;

public class IdRange
{
    public required long Min { get; init; }
    public required long Max { get; init; }
    public List<long> InvalidIds { get; private set; } = [];

    public void CalculateInvalidIds()
    {
        for (long i = Min; i <= Max; i++)
        {
            var stringId = i.ToString();
            if (stringId.Length % 2 != 0)
                //InvalidIds are never an uneven length
                continue;

            var middleIndex = stringId.Length / 2;
            if (stringId[..middleIndex] == stringId[middleIndex..])
                InvalidIds.Add(i);
        }
    }
}