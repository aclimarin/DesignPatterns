namespace src.Commands;


/*
* This is the Concrete Command representing one of the operations
* SetColorCommand is responsable for changing the light color
*/
public class SetColorCommand : ICommand
{
    private readonly LightBulb _lightBulb;
    private readonly string _color;
    private string? _previeusColor;

    public SetColorCommand(LightBulb lightBulb, string color)
    {
        _lightBulb = lightBulb;
        _color = color;
    }

    public void Execute()
    {
        _previeusColor = _lightBulb.GetColor();
        _lightBulb.SetColor(_color);
        
    }

    public void Undo()
    {
        _lightBulb.SetColor(_previeusColor);
    }
}