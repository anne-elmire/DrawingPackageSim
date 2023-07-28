namespace DrawingPackageSim;

public interface IWidget
{
    public string Name { get; }
    public int X { get; set; }
    public int Y { get; set; }
    public string ToString();
}