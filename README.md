# Design Patterns
Simple implementation of Design Patterns described in the book **Agile Principles, Patterns, and Practices in C#** *(By Robert C. Martin and Micah C. Martin)*.

##### - [Command](https://github.com/aclimarin/DesignPatterns/tree/main#command)
##### - [Template Method](https://github.com/aclimarin/DesignPatterns/tree/main#template-method)
##### - [Strategy](https://github.com/aclimarin/DesignPatterns/tree/main#strategy)

---

## Command
The **Command Pattern** encapsulate a request as an object. It allows the client to parameterize diferent requests in a queue and also suports undo actions.

### Base Structure

+ **Command Interface**: The interface that would have the methods *Execute()* and *Undo()* and will be used as a contract to concrete command classes.

+ **Concrete Command**: The concrete command classes will inherit from *Command Interface* and each one represents a behavior.

+ **Invoker**: The invoker class holds the commands that can be executed. It doesn't know about the logic, only knows what commands should execute or undo.

+ **Receiver**: Represents the object that performs the action. When the *Command.Execute()* is called, the concrete command holds the reference to the receiver.

+ **Client**: The client sets the concrete command passing the receiver. It decides when to execute or undo the action.

---

## Template Method
The **Template Method Pattern** uses an abstract class to define the steps of an algorithm and allow some subclasses to implement some of the steps.

### Base Structure

+ **Abstract Class (Base Class)**: Is the central class of the template method. It contains the overall algorithm as a method (called template method) that will call other methods, both abstract and concrete.

+ **Abstract Methods**: The declarations of methods that are part of the template method structure. The subclasses will provide the implamentations.

+ **Concrete Methods**: The implementation in subclasses of the abstract methods defined in the base class.

+ **Concrete Class (Subclasses)**: The concrete classes that will inherit from the abstract base class and will define a specific behavior.

---

## Strategy

The **Stategy Pattern** define a group of algorithm based in an contract (interface). The strategy uses a context that will call the interface method according to the passed concrete class. This patterns allow us to extend some behavior without change any of the existing code.

### Base Structure

+ **Strategy Interface**: The interface that will define the contract of the algorithm group.

+ **Concrete Strategies**: The concrete class that will inherit from the interface and provide a specific behavior.

+ **Context Class**: The concrete class that holds the reference to the interface and can perform any of the concrete strategies.