using DrawIt.Models.Data;
using Microsoft.AspNetCore.SignalR;
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
            Member m = member
            await NewMember(roomName, member);
            await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
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
