public class Triangle : Figure {
    public float SideLength { get; set; }

    public Triangle(float x, float y, float sideLength) : base(x, y) {
        SideLength = sideLength;
    }

    public override float Area() {
        return (float)Math.Sqrt(3) / 4 * SideLength * SideLength;
    }

    public override void Draw() {
        Console.WriteLine("Drawing Triangle at ({0}, {1}) with side length {2}", X, Y, SideLength);
    }
}
