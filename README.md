# Design Patterns
Simple implementation of Design Patterns described in the book **Agile Principles, Patterns, and Practices in C#** *(By Robert C. Martin and Micah C. Martin)*.

## Command Pattern
The **Command Pattern** encapsulate a request as an object. It allows the client to parameterize diferent requests in a queue and also suports undo actions.

### Base Structure

+ **Command Interface**: The interface that would have the methods *Execute()* and *Undo()* and will be used as a contract to concrete command classes.

+ **Concrete Command**: The concrete command classes will inherit from *Command Interface* and each one represents a behavior.

+ **Invoker**: The invoker class holds the commands that can be executed. It doesn't know about the logic, only knows what commands should execute or undo.

+ **Receiver**: Represents the object that performs the action. When the *Command.Execute()* is called, the concrete command holds the reference to the receiver.

+ **Client**: The client sets the concrete command passing the receiver. It decides when to execute or undo the action.
