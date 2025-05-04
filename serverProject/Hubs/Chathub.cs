using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace serverProject.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Console.WriteLine($" Mottaget från {user}: {message}");
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}