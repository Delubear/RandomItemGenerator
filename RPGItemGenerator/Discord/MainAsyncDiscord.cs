using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            string discToken;
            var assembly = Assembly.GetExecutingAssembly();
            var resource = "RPGItemGenerator.discordsettings.json";
            using (Stream stream = assembly.GetManifestResourceStream(resource))
                using(StreamReader reader = new StreamReader(stream))
            {
                discToken = reader.ReadToEnd();
            }

            //    var token = File.ReadAllText("discordsettings.json");
            //var code = JsonConvert.DeserializeObject<IList<string>>(token).FirstOrDefault();
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = discToken,
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
