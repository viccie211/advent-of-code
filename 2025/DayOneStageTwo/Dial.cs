namespace DayOneStageTwo;

public class Dial
{
    public required int Min { get; set; }
    public required int Max { get; set; }
    public required int Position { get; set; }

    public int Turn(Step step)
    {
        int result = 0;
        switch (step.Direction)
        {
            case EDirection.L:
                for (int i = step.Amount; i > 0; i--)
                {
                    Position--;

                    if (Position < Min)
                    {
                        Position = Max;
                    }

                    if (Position == Min)
                    {
                        result++;
                    }
                }

                break;
            case EDirection.R:
                for (int i = step.Amount; i > 0; i--)
                {
                    Position++;

                    if (Position > Max)
                    {
                        Position = Min;
                    }

                    if (Position == Min)
                    {
                        result++;
                    }
                }

                break;
        }

        return result;
    }
}