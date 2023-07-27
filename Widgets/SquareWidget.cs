using DrawingPackageSim.Widgets.Helpers;

namespace DrawingPackageSim.Widgets;

public class SquareWidget : IWidget
{
    public string Name { get { return "Square"; } }
    public int X { get; set; }
    public int Y { get; set; }
    public object Size { get; set; }

    public SquareWidget(int x, int y, int size)
    {
        X = x;
        Y = y;

        size.ValidateDimension();
        Size = size;
    }

    public override string ToString()
        => $"{Name} ({X},{Y}) {nameof(Size)}={Size}";
}
