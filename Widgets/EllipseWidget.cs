using DrawingPackageSim.Widgets.Helpers;

namespace DrawingPackageSim.Widgets;

public class EllipseWidget : IWidget
{
    public string Name { get { return "Ellipse"; } }
    public int X { get; set; }
    public int Y { get; set; }
    public int DiameterH { get; set; }
    public int DiameterV { get; set; }

    public EllipseWidget(int x, int y, int diameterH, int diameterV)
    {
        X = x;
        Y = y;

        diameterH.ValidateDimension();
        DiameterH = diameterH;

        diameterV.ValidateDimension();
        DiameterV = diameterV;
    }

    public override string ToString()
        => $"{Name} ({X},{Y}) {nameof(DiameterH)} = {DiameterH} {nameof(DiameterV)} = {DiameterV}";
}