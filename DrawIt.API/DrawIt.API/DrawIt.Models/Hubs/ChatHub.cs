
using DrawIt.Models.Data;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DrawIt.Models.Hubs
{
    public class ChatHub : Hub
    {
        //Groups
        public async Task JoinRoom(string roomName, string member)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
            Member m = JsonConvert.DeserializeObject<Member>(member);
            await NewMember(roomName, m);
        }


        public async Task UpdateMembers(string roomName, List<Member> members)
        {
            await Clients.Group(roomName).SendAsync("UpdateMembers", members);
        }

        public async Task NewMember(string roomName, Member member)
        {
            await Clients.Group(roomName).SendAsync("NewMember", member);
        }

        public Task LeaveRoom(string roomName)
        {
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
        }

        //Draw
        public async Task Draw(string c, int b, int currX, int currY, int prevX, int prevY)
        {
            await Clients.All.SendAsync("Draw", c, b, currX, currY, prevX, prevY);
        }

        public async Task DrawDot(string c, int b, int currX, int currY)
        {
            await Clients.All.SendAsync("DrawDot", c, b, currX, currY);
        }

        //Message
        public async Task SendMessage(string roomName, string user, string message)
        {
            await Clients.Group(roomName).SendAsync("ReceiveMessage", user, message);
        }

        public async Task Guessed(string user)
        {
            await Clients.All.SendAsync("Guessed", user);
        }
    }
}
