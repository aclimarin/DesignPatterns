namespace src;   

//This inteface is the Mediator

public interface IChatroom
{
    void SendMessage(User sender, string message);
}

