namespace src;

/*
* The LightBulb class is the Receiver in this structure
* The receiver object is the one will "receive" the request and perform the Action when
* when the command is executed. In this app i can turn on and off and also change the light color
*/

public class LightBulb
{
    private bool _isOn;
    private string? _color;

    public void Toggle()
    {
        if (!_isOn)
            Console.WriteLine("Light bulb turned ON.");
        else
            Console.WriteLine("Light bulb turned OFF.");

        _isOn = !_isOn;
    }

    public void SetColor(string? color)
    {
        if(_isOn)
        {
            _color = color;
            Console.WriteLine($"Light bulb color set to {color}.");
        }
        else
        {
            Console.WriteLine($"Light bulb is OFF. You can't change the color.");
        }

    }

    public string? GetColor()
    {
        return _color;
    }

    public void PrintStatus()
    {
        Console.WriteLine($"Light bulb is {( _isOn ? "ON" : "OFF")}");

        if (_isOn)
        {
            var color = string.IsNullOrEmpty(_color) ? "NONE" : _color;
            Console.WriteLine($"Light bulb Color: { color }");
        }
    }
}