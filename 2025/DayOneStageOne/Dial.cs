namespace DayOneStageOne;

public class Dial
{
    public required int Min { get; set; }
    public required int Max { get; set; }
    public required int Position { get; set; }

    public bool Turn(Step step)
    {
        switch (step.Direction)
        {
            case EDirection.L:
                
                for (int i = step.Amount; i > 0; i -= Max)
                {
                    if (i < Max)
                    {
                        Position -= i;        
                    }
                    else
                    {
                        Position -= Max;
                    }
                    if (Position < Min)
                    {
                        Position += Max+1;
                    }
                }
                
                break;
            case EDirection.R:
                for (int i = step.Amount; i > 0; i -= Max)
                {
                    if (i < Max)
                    {
                        Position += i;        
                    }
                    else
                    {
                        Position += Max;
                    }
                    if (Position > Max)
                    {
                        Position -= Max+1;
                    }
                }

                break;
        }

        return Position == Min;
    }
}