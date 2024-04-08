using System;
using System.Collections.Generic;
using System.Windows;

// class Program {
//     static void Main(string[] args) {
//         Console.WriteLine("Hello");
    //     // Creating figures
    //     List<Figure> figures = new List<Figure> {
    //         new Circle(0, 0, 8),
    //         new Rectangle(0, 0, 50, 70),
    //         new Square(0, 0, 30)
    //     };

    //     foreach (var figure in figures) {
    //         figure.Draw();
    //         // Testing area functionality
    //         Console.WriteLine($"Figure area: {figure.Area()}\n");
    //     }
 
    //     // Initializing figure controller for events
    //     FigureController controller = new FigureController();

    //     // Testing figure move functionality
    //     controller.MoveFigure(figures[0], 5, 5);

    //     // Testing draw function 
    //     figures[0].Draw();
    // }

    // private static void FigureMovedTest(object sender, EventArgs e) {
    //     Console.WriteLine("Moved successfuly");
    // }
    
//     }
// }

public class HelloWorld : Form
{
    static public void Main ()
    {
        Application.Run (new HelloWorld ());
    }

    public HelloWorld ()
    {
        Text = "Hello Mono World";
    }
}
