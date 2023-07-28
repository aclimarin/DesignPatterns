# Design Patterns
Simple implementation of Design Patterns described in the book **Agile Principles, Patterns, and Practices in C#** *(By Robert C. Martin and Micah C. Martin)*.

##### - [Command](https://github.com/aclimarin/DesignPatterns/tree/main#command)
##### - [Template Method](https://github.com/aclimarin/DesignPatterns/tree/main#template-method)
##### - [Strategy](https://github.com/aclimarin/DesignPatterns/tree/main#strategy)
##### - [Facad](https://github.com/aclimarin/DesignPatterns/tree/main#facad)
##### - [Singleton](https://github.com/aclimarin/DesignPatterns/tree/main#singleton)

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

---

## Facad

The **Facad Pattern** propouse is to simplify the usage of a complex subsystem

### Base Structure

+ **Facad**: The class that provides a simple and unified logic to the complex subsystem. It encapsulates the interactions and operations of multiple classes that the client class doesn't need to know.

+ **Subsystem Classes**: The multiple classes that compose the subsystem.

+ **Client**: The class that uses the facad without knowing the subsystem classes.

---

## Mediator

The **Mediator Pattern** is used to promote loose coupling between objects. A new object is introduced to mediate the comunication between objects without direct dependecy

### Base Structure

+ **Mediator Interface**: The interface that defines the contract for comunication between objects

+ **Concrete Mediator**: The concret class with logic for mediate the comunication.

+ **Colleague**: The objects that needs to comunicate with each other.

---

## Singleton

The **Singleton Pattern** is used to ensure that a class has only one instance with global access throughout application's lifetime.

### Base Structure

+ **Private Static Instance Variable**: A private variable tha holds the instance of the class.

+ **Private Constructor**: The private constructor to prevent external instance.

+ **Public Static Method to Access**: The method responsible to create the instance if it doesn't exists or return the instance if it already created

---

## Monostate

The **Monostate Pattern** is used ensure that all classes will share the same state. When o modify the state value in one instance of an object, any other instance will assume the same state value.

### Base Structure

+ **Shared State Variables**: A static variable that holds the shared state.

+ **Properties or Methods for Access**: The public properties or methods that access the shared variables values.

+ **Shared Behavior**: The class may have methods to operate on the shared state.