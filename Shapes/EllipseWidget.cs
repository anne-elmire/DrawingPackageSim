﻿namespace DrawingPackageSim.Widgets;

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
        if (diameterH > 0 && diameterV > 0)
        {
            DiameterH = diameterH;
            DiameterV = diameterV;
        }
        else
        {
            throw new ArgumentException("The horizontal and vertical diameters of an ellipse must be positive integers");
        }
    }

    public override string ToString()
        => $"{Name} ({X},{Y}) {nameof(DiameterH)} = {DiameterH} {nameof(DiameterV)} = {DiameterV}";
}