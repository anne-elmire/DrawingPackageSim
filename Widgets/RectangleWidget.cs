namespace DrawingPackageSim.Widgets;

public class RectangleWidget : IWidget
{
    public string Name { get { return "Rectangle"; } }
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public RectangleWidget(int x, int y, int width, int height)
    {
        X = x;
        Y = y;
        if (width > 0 && height > 0)
        {
            Width = width;
            Height = height;
        }
        else
        {
            throw new ArgumentException("The height and width of a rectangle must be positive integers");
        }
    }

    public override string ToString()
        => $"{Name} ({X},{Y}) {nameof(Width)}={Width} {nameof(Height)}={Height}";
}
