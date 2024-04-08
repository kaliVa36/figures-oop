public class Square : Rectangle {
    public Square(float x, float y, float side) : base(x, y, side, side) {}

    public new float Width {
        get => base.Width;
        set {
            base.Width = value;
            base.Height = value;
        }
    }

    public new float Height {
        get => base.Height;
        set {
            base.Height = value;
            base.Width = value;
        }
    }
}
