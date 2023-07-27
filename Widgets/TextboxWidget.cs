using DrawingPackageSim.Widgets.Helpers;

namespace DrawingPackageSim.Widgets;

public class TextboxWidget : IWidget
{
    public string Name { get { return "Textbox"; } }
    public int X { get; set; }
    public int Y { get; set; }
    public Rectangle BoundingRectangle { get; set; }
    public string Text { get; set; }

    public TextboxWidget(int x, int y, int width, int height, string text)
    {
        X = x;
        Y = y;
        BoundingRectangle = new Rectangle(width, height);
        Text = text;
    }

    public override string ToString()
        => $"{Name} ({X},{Y}) {nameof(BoundingRectangle.Width)}={BoundingRectangle.Width}" +
                $" {nameof(BoundingRectangle.Height)}={BoundingRectangle.Height} {nameof(Text)}=\"{Text}\"";
}

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        width.ValidateDimension();
        Width = width;

        height.ValidateDimension();
        Height = height;
    }
}