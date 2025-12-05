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
            var stringId = i.ToString();
        }
    }
}