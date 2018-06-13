using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Server
{
    public class ChatHub : Hub
    {
        public ChatHub()
        {
        }

        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
            Console.WriteLine(this.Context.ConnectionId);
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await base.OnDisconnectedAsync(exception);
        }

        public async Task PostMessage(string message)
        {
            try
            {
                await this.Clients.All.SendAsync("OnSend", message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
