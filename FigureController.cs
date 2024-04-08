public class FigureController {
    public event Action<Figure>? FigureMoved;
    public event Action<Figure>? FigureClicked;
    private Figure? _selectedFigure;

    public void MoveFigure(Figure figure, float deltaX, float deltaY) {
        figure.SetLocation(deltaX, deltaY);
    }

     public void ClickFigure(Figure figure) {
        // Selecting the clicked
        _selectedFigure = figure;
    }

    protected virtual void OnFigureMoved(Figure figure) {
        // Some code
        FigureMoved?.Invoke(figure);
    }

    protected virtual void OnFigureClicked(Figure figure) {
        // Some code
         FigureClicked?.Invoke(figure);
    }
}