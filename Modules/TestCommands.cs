using System.Threading.Tasks;
using Discord.Commands;

namespace MafiaBotCore.Modules
{
    public class TestCommands : ModuleBase<SocketCommandContext>
    {
        [Command("Hello")]
        public async Task fdafsadf()
        {
            await Context.Channel.SendMessageAsync("World!");
        }
    }
}