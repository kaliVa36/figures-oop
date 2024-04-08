using System;

public abstract class Figure {
    public float X { get; set; }
    public float Y { get; set; }
    
    protected Figure(float x, float y) {
        X = x;
        Y = y;
    }
    
    // Calculating figure's area
    public abstract float Area();
    
    // Drawing the figure
    public abstract void Draw();
    
    // Rotating the figure
    public virtual void Rotate() {}

    // Simulating gravity
    public virtual void Gravity() {}

    // Moving figure to a different position
    public virtual void SetLocation(float deltaX, float deltaY) {
        X += deltaX;
        Y += deltaY;
    }

    // Filling the figure
    public virtual void Fill() {}
}
