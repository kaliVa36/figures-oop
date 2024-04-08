using System.Drawing;

public class Circle : Figure
{
    public float Radius { get; set; }
    public PointF Center => new(X, Y);

    public Circle(float x, float y, float radius) : base(x, y) {
        Radius = radius;
    }

    public override float Area() {
        return (float)Math.PI * Radius * Radius;
    }

    public override void Draw() {
        // Code
        Console.WriteLine("Drawing Circle at ({0}, {1}) with radius {2}", X, Y, Radius);
    }
}
