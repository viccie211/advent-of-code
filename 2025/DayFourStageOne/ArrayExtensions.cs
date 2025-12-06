namespace DayFourStageOne;

public static class ArrayExtensions
{
    public static int GetDimensionLength(this Array array, int dimension)
    {
        return array.GetUpperBound(dimension) + 1;
    }
}