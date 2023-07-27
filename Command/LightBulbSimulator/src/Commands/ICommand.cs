namespace src.Commands;

/*
* The command interface with the execute method that can invorke a specific operation
*/

public interface ICommand
{
     void Execute();
     void Undo();
}