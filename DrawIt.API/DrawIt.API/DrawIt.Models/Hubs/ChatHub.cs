
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
        //GROUPS
        //User joint een groep
        public async Task JoinRoom(string roomName, string member)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
            Member m = JsonConvert.DeserializeObject<Member>(member);
            await NewMember(roomName, m);
        }

        //Stuur een geupdate lijst terug naar iedereen in de groep, omdat alleen de host een volledige lijst heeft moeten we dit zo doen.
        public async Task UpdateMembers(string roomName, List<Member> members)
        {
            await Clients.Group(roomName).SendAsync("UpdateMembers", members);
        }

        //Laat weten aan de groep dat er iemand nieuw is bijgekomen
        public async Task NewMember(string roomName, Member member)
        {
            await Clients.Group(roomName).SendAsync("NewMember", member);
        }

        //Verwijder alle mensen uit de groep
        public Task LeaveRoom(string roomName)
        {
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
        }

        //GAME MANAGER
        //Start the game, waarop elke client wordt omgeleid naar de game pagina
        public async Task StartGame()
        {
            await Clients.All.SendAsync("StartGame");
        }

        //Start a round
        public async Task Start(int sec)
        {
            await Clients.All.SendAsync("Start", sec);
        }

        //Stop a round
        public async Task Stop()
        {
            await Clients.All.SendAsync("Stop");
        }

        //Toon aan wie de tekenaar is
        public async Task Drafted(string user)
        {
            await Clients.All.SendAsync("Drafted", user);
        }

        //DRAW
        //Het tekenen van een lijn
        public async Task Draw(string c, int b, int currX, int currY, int prevX, int prevY)
        {
            await Clients.All.SendAsync("Draw", c, b, currX, currY, prevX, prevY);
        }

        //Het tekenen van een punt
        public async Task DrawDot(string c, int b, int currX, int currY)
        {
            await Clients.All.SendAsync("DrawDot", c, b, currX, currY);
        }

        //Message
        public async Task SendMessage(string roomName, string user, string message)
        {
            await Clients.Group(roomName).SendAsync("ReceiveMessage", user, message);
        }

        //Stuur naar elke client dat het woord is geraden 
        public async Task Guessed(string user)
        {
            await Clients.All.SendAsync("Guessed", user);
        }
    }
}
