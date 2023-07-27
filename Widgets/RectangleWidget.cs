using DrawingPackageSim.Widgets.Helpers;

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

        width.ValidateDimension();
        Width = width;

        height.ValidateDimension();
        Height = height;
    }

    public override string ToString()
        => $"{Name} ({X},{Y}) {nameof(Width)}={Width} {nameof(Height)}={Height}";
}
