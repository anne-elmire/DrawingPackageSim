using DrawingPackageSim.Widgets;

namespace DrawingPackageSim;

static class Program
{
    static void Main()
    {
        List<IWidget> drawing = new()
        {
            new RectangleWidget(15, 10, 30, 40),
            new SquareWidget(15, 30, 35),
            new EllipseWidget(100, 150, 300, 200),
            new CircleWidget(1, 1, 300),
            new TextboxWidget(5, 5, 200, 100, "sample text")
        };

        //so now all the constructors can throw exceptions we need to worry about catching and handling them
        //also unit tests !!!

        PrintDrawingDetails(drawing);

        //remember you've got two classes in the textbox file
    }

    private static void PrintDrawingDetails(List<IWidget> drawing)
    {
        Console.WriteLine(
            "----------------------------------------------------------------" +
            "\r\nRequested Drawing\r\n" +
            "----------------------------------------------------------------");

        foreach (var widget in drawing)
        {
            Console.WriteLine(widget.ToString());
        }

        Console.WriteLine("----------------------------------------------------------------");
    }
}



