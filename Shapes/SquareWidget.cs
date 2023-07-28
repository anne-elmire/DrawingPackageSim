namespace DrawingPackageSim.Widgets;

public class SquareWidget : IWidget
{
    public string Name { get { return "Square"; } }
    public int X { get; set; }
    public int Y { get; set; }
    public int Size { get; set; }
    public SquareWidget(int x, int y, int size)
    {
        X = x;
        Y = y;
        if (size > 0)
        {
            Size = size;
        }
        else
        {
            throw new ArgumentException("The size of a square must be a positive integer");
        }
    }

    public override string ToString()
        => $"{Name} ({X},{Y}) {nameof(Size)}={Size}";
}
