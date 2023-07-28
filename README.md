# DrawingPackageSim

To keep the project as simple as possible, I chose to create a class for each of the required widgets, with an IWidget interface for the common properties.
Each widget has it own ToString() method that returns the required description for the widget.
The constructor for the widget takes all the required details and throws an exception if the dimensions are zero or negative so that no invalid widget can be instantiated.
I chose this approach in order to keep the widget classes simple and easy to understand.

To keep the project as simple as possible, I decided to model the drawing as a list of widgets.

Widgets can be added to the drawing using the relevant .AddWidget() method. There is one for each widget and they live in the DrawingHelper class. 
This validates that the widget has positive dimensions and prints an error message to the console if the dimensions are negative.
While in general it would be preferable to separate the concerns, I chose to do this to keep the code and the application as simple as possible.

## Tests

I've written some unit tests using xunit to test the most important features.