using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using RPGItemGenerator.ItemGeneration;
using System.Threading.Tasks;

namespace RPGItemGenerator.Discord
{
    public partial class CommandsItemGen
    {
        public partial class ItemGenCommands
        {
            [Command("gen"), Description("Generate a random item")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
            public async Task GenerateItem(CommandContext ctx, string rarity = "")
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
            {
                var itemG = new RunItemGen();
                itemG.DiscordItemGeneration(ctx, rarity);   
            }
        }
    }
}
