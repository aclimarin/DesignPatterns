namespace src;

public class User
{
    public string Name { get; private set; }
    public IChatroom Chatroom { get; set; }

    public User(string name)
    {
        Name = name;
    }

    public void SendMessage(string message)
    {
        Chatroom.SendMessage(this, message);
    }

    public void ReceiveMessage(string sender, string message)
    {
        Console.WriteLine($"{Name} received a message from {sender}: {message}");
    }
}