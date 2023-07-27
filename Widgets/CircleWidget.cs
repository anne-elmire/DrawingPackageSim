using DrawingPackageSim.Widgets.Helpers;

namespace DrawingPackageSim.Widgets;

public class CircleWidget : IWidget
{
    public string Name { get { return "Circle"; } }
    public int X { get; set; }
    public int Y { get; set; }
    public int Diameter { get; set; }

    public CircleWidget(int x, int y, int diameter)
    {
        X = x;
        Y = y;

        diameter.ValidateDimension();
        Diameter = diameter;
    }

    public override string ToString()
        => $"{Name} ({X},{Y}) {nameof(Diameter)}={Diameter}";
}
