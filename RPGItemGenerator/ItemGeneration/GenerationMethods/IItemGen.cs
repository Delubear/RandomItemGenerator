using DSharpPlus.CommandsNext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGItemGenerator.ItemGeneration.GenerationMethods
{
    public interface IItemGen
    {
        double GetRunAmount();
        void PrintSummary(double runAmount);
        void AppendtemProperties(Item testItem);
        void PrintItemProperties(CommandContext ctx = null, bool WriteToConsole = true);
        void SetTextColor(Item testItem);
        Item GetItemType(string rarity = "");
        void ItemGenMethod();
        void ConsoleItemGeneration(double runAmount);
        void DiscordItemGeneration(CommandContext ctx = null, string rarity = "");
    }
}
