using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using System.Threading.Tasks;
using static RPGItemGenerator.Discord.CommandsItemGen;

namespace RPGItemGenerator
{
    public partial class Program
    {
        public static DiscordClient discord;
        static CommandsNextModule commands;

        static async Task MainAsync(string[] args)
        {     
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "MzQ3MTg1OTEzODY1OTYxNDcy.DHUtpA.tyaVq3LuwNc_1Hft7LjNvqvVYyg",
                TokenType = TokenType.Bot,
                UseInternalLogHandler = true,
                LogLevel = LogLevel.Debug
            });

            commands = discord.UseCommandsNext(new CommandsNextConfiguration
            {
                StringPrefix = "!",
                EnableDms = false
            });

            commands.RegisterCommands<ItemGenCommands>();

            discord.GuildMemberAdded += async e =>
            {
                DiscordChannel def = null;
                foreach (DiscordChannel dc in e.Guild.Channels)
                { if (dc.Name == "general") { def = dc; } }
                await discord.SendMessageAsync(def, $"👏 User {e.Member.Mention} has joined the server! 👏");
            };

            discord.GuildMemberRemoved += async e =>
            {
                DiscordChannel def = null;
                foreach (DiscordChannel dc in e.Guild.Channels)
                { if (dc.Name == "general") { def = dc; } }
                await discord.SendMessageAsync(def, $"👎 User {e.Member.Username} has died.  Please pay your respects. 👎");
            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}
