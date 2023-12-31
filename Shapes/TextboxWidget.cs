﻿namespace DrawingPackageSim.Widgets;

public class TextboxWidget : IWidget
{
    public string Name { get { return "Textbox"; } }
    public int X { get; set; }
    public int Y { get; set; }
    public BoundingRectangle BoundingRectangle { get; set; }
    public string Text { get; set; }

    public TextboxWidget(int x, int y, int width, int height, string text)
    {
        X = x;
        Y = y;
        if (height > 0 && width > 0)
        {
            BoundingRectangle = new BoundingRectangle(width, height);
        }
        else
        {
            throw new ArgumentException("The height and width of the bouding rectangle must be positive integers");
        }
        Text = text;
    }

    public override string ToString()
        => $"{Name} ({X},{Y}) {nameof(BoundingRectangle.Width)}={BoundingRectangle.Width}" +
                $" {nameof(BoundingRectangle.Height)}={BoundingRectangle.Height} {nameof(Text)}=\"{Text}\"";
}