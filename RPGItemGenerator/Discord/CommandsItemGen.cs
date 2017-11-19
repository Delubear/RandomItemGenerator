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
            public async Task GenerateItem(CommandContext ctx, string rarity = "")
            {
                var itemG = new RunItemGen();
                itemG.DiscordItemGeneration(ctx, rarity);   
            }
        }
    }
}
