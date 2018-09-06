using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using static RPGItemGenerator.Discord.CommandsItemGen;

namespace RPGItemGenerator
{
    public partial class Program
    {
        public static DiscordClient discord;
        static CommandsNextModule commands;

        class JSONClass
        {
            public string BotKey { get; set; }
            public string Value  { get; set; }
        }

        static async Task MainAsync(string[] args)
        {                        
            var token = File.ReadAllText("discordsettings.json");
            var code  = JsonConvert.DeserializeObject<JSONClass>(token);

            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = code.BotKey,
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
