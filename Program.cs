using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace MafiaBotCore
{
    public class Program
    {
        static void Main(string[] args)
            => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();

            new CommandHandler(_client);

            await _client.LoginAsync(TokenType.Bot, "NDY3MTcxMjE3MTIwNTU5MTE0.DiroEA.pp8Q76uIJwf-CWfAoWs_jDs1uA8");

            await _client.StartAsync();

            await Task.Delay(-1);
        }
    }
}
