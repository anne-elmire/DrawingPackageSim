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
        if (diameter > 0)
        {
            Diameter = diameter;
        }
        else
        {
            throw new ArgumentException("The diameter of a circle must be a postive integer");
        }
    }

    public override string ToString()
        => $"{Name} ({X},{Y}) {nameof(Diameter)}={Diameter}";
}
