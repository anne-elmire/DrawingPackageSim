namespace DrawingPackageSim.Widgets.Helpers;

public static class DimensionsValidator
{
    public static void ValidateDimension(this int dimension)
    {
        if (dimension <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(dimension));
        }
    }
}