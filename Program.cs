using DrawingPackageSim.Widgets;

namespace DrawingPackageSim;

static class Program
{
    static void Main()
    {
        List<IWidget> drawing = new();

        drawing.AddRectangle(10, 10, 30, 40);
        drawing.AddSquare(15, 30, 35);
        drawing.AddEllipse(100, 150, 300, 200);
        drawing.AddCircle(1, 1, 300);
        drawing.AddTextbox(5, 5, 200, 100, "sample text");

        PrintDrawingDetails(drawing);
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
