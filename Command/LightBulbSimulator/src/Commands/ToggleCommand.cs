namespace src.Commands;


/*
* This is the Concrete Command representing one of the operations
* ToggleCommand is responsable for turn the light ON or OFF
*/
public class ToggleCommand : ICommand
{
    private readonly LightBulb _lightBulb;

    public ToggleCommand(LightBulb lightBulb)
    {
        _lightBulb = lightBulb;
    }

    public void Execute()
    {
        _lightBulb.Toggle();
    }

    public void Undo()
    {
        _lightBulb.Toggle();
    }
}