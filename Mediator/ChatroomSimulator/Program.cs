using src;

class Program
{
    static void Main(string[] args)
    {
        // Create the chatroom (mediator)
        var chatroom = new Chatroom();

        // Create users
        var john = new User("John");
        var jane = new User("Jane");
        var alice = new User("Alice");

        // Register users with the chatroom
        chatroom.Register(john);
        chatroom.Register(jane);
        chatroom.Register(alice);

        // Simulate user interactions
        john.SendMessage("Hello, everyone!");
        jane.SendMessage("Hey, John!");
        alice.SendMessage("Hi there!");
    }
}
