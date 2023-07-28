namespace src;

//This class is the Mediator

public class Chatroom : IChatroom
{

    private Dictionary<string, User> _usersMessageDictionary = new Dictionary<string, User>();

    public void Register(User user)
    {
        if (!_usersMessageDictionary.ContainsKey(user.Name))
            _usersMessageDictionary.Add(user.Name, user);
        
        user.Chatroom = this;
    }

    public void SendMessage(User sender, string message)
    {
        foreach (var user in _usersMessageDictionary.Values)
        {
            if (user != sender)
                user.ReceiveMessage(sender.Name, message);
        }
    }
}
