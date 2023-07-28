using DrawingPackageSim.Widgets;
using System.Data;

namespace DrawingPackageSim;

public static class DrawingHelper
{
    public static List<IWidget> AddRectangle(this List<IWidget> drawing, int x, int y, int width, int height)
    {
        if (width > 0 && height > 0)
        {
            drawing.Add(new RectangleWidget(x, y, width, height));
        }
        else
        {
            Console.WriteLine($"ERROR: Could not add rectangle widget with a width of {width} and height of {height} as width and height must be positive integers.");
        }
        return drawing;
    }

    public static List<IWidget> AddSquare(this List<IWidget> drawing, int x, int y, int size)
    {
        if (size > 0)
        {
            drawing.Add(new SquareWidget(x, y, size));
        }
        else
        {
            Console.WriteLine($"ERROR: Could not add square widget with a size of {size} as size must be a positive integer.");
        }
        return drawing;
    }

    public static List<IWidget> AddEllipse(this List<IWidget> drawing, int x, int y, int diameterH, int diameterV)
    {
        if (diameterH > 0 && diameterV > 0)
        {
            drawing.Add(new EllipseWidget(x, y, diameterH, diameterV));
        }
        else
        {
            Console.WriteLine($"ERROR: Could not add square widget with a horizontal diameter of {diameterH} " +
                $"and a vertical diameter of {diameterV} as diameters must be positive integers.");
        }
        return drawing;
    }

    public static List<IWidget> AddCircle(this List<IWidget> drawing, int x, int y, int diameter)
    {
        if (diameter > 0)
        {
            drawing.Add(new CircleWidget(x, y, diameter));
        }
        else
        {
            Console.WriteLine($"ERROR: Could not add circle widget with a diameter of {diameter} as diameter must be a positive integer.");
        }
        return drawing;
    }

    public static List<IWidget> AddTextbox(this List<IWidget> drawing, int x, int y, int width, int height, string text)
    {
        if (width > 0 && height > 0)
        {
            drawing.Add(new TextboxWidget(x, y, width, height, text));
        }
        else
        {
            Console.WriteLine($"Could not add textbox widget with a width of {width} and height of {height} as width and height must be positive integers.");
        }
        return drawing;
    }
}
