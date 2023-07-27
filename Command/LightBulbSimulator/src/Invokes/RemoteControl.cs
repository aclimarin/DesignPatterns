using src.Commands;

namespace src;

/*
* The RemoteControl class is the Invoker in this structure
* The invoker is responsible for executing commands
* It doesn't know anything about the logic that it will run
* It just keeps track of the command to execute or undo
*/

public class RemoteControl
{
    private Stack<ICommand> _commands = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        _commands.Push(command);
        command.Execute();
    }

    public void UndoLastCommand()
    {
        if (_commands.Count > 0)
        {
            var lastCommand = _commands.Pop();
            lastCommand.Undo();
        }
    }
}