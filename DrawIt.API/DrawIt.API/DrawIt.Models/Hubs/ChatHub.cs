
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
        public async Task StartGame(string roomName)
        {
            await Clients.Group(roomName).SendAsync("StartGame");
        }

        //Start a round
        public async Task Start(string roomName, int sec)
        {
            await Clients.Group(roomName).SendAsync("Start", sec);
        }

        //Stop a round
        public async Task Stop(string roomName)
        {
            await Clients.Group(roomName).SendAsync("Stop");
        }

        //Toon aan wie de tekenaar is
        public async Task Drafted(string roomName, string user, string word)
        {
            await Clients.Group(roomName).SendAsync("Drafted", user, word);
        }

        //DRAW
        //Het tekenen van een lijn
        public async Task Draw(string roomName, string c, int b, int currX, int currY, int prevX, int prevY)
        {
            await Clients.Group(roomName).SendAsync("Draw", c, b, currX, currY, prevX, prevY);
        }

        //Het tekenen van een punt
        public async Task DrawDot(string roomName, string c, int b, int currX, int currY)
        {
            await Clients.Group(roomName).SendAsync("DrawDot", c, b, currX, currY);
        }

        //Verwijder de tekening van het canavas
        public async Task Erase(string roomName)
        {
            await Clients.Group(roomName).SendAsync("Erase");
        }


        //Message
        public async Task SendMessage(string roomName, string user, string message)
        {
            await Clients.Group(roomName).SendAsync("ReceiveMessage", user, message);
        }

        //Stuur naar elke client dat het woord is geraden
        public async Task Guessed(string roomName, string user, int seconds)
        {
            await Clients.Group(roomName).SendAsync("Guessed", user, seconds);
        }
    }
}
