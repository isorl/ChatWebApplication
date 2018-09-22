using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            if (!(string.IsNullOrEmpty(name)) && !(string.IsNullOrEmpty(message))) {
                Clients.All.addNewMessageToPage(name, message, DateTime.Now.ToShortTimeString());
            }
        }
    }
}