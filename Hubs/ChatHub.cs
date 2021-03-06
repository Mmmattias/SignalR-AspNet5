using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Orebranch.Hubs
{
    [HubName("chatHub")]
    public class ChatHub : Hub<IChatClient>
    {
        public void SendMessage(ChatMessageModel model)
        {
            Clients.All.Broadcast(string.Format("{0}: {1}", model.Name, model.Message));
        }
    }

    public interface IChatClient
    {
        void Broadcast(string messageModel);
    }

    public class ChatMessageModel
    {
        public ChatMessageModel(string name, string message)
        {
            Name = name;
            Message = message;
        }

        public string Name { get; set; }
        public string Message { get; set; }
    }
}