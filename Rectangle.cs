public class Rectangle : Figure {
    public float Width { get; set; }
    public float Height { get; set; }

    public Rectangle(float x, float y, float width, float height) : base(x, y) {
        Width = width;
        Height = height;
    }

    public override float Area() {
        return Width * Height;
    }

    public override void Draw() {
        Console.WriteLine("Drawing Rectangle at ({0}, {1}) with width {2} and height {3}", X, Y, Width, Height);
    }
}