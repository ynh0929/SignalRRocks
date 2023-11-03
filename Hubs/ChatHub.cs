using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRRocks.Hubs
{
    public class ChatHub : Hub 
    {
        // the SendMessage method can be called by the client
        public async Task SendMessage(string user, string message) 
        {
            // the ReceiveMessage method is called from the server on all clients
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }

}