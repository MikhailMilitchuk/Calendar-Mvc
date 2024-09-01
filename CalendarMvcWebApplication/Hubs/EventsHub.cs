using Microsoft.AspNetCore.SignalR;
using System.Timers;

namespace CalendarMvcWebApplication.Hubs
{
    public class EventsHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
