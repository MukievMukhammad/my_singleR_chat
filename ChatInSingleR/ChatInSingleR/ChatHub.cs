﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ChatInSingleR
{
    public class ChatHub : Hub
    {
        public async Task Send(string message)
        {
            await this.Clients.All.SendAsync("Send", message);
        }
    }
}
