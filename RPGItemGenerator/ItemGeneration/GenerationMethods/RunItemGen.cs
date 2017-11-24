using DSharpPlus.CommandsNext;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class RunItemGen
    {
        double common = 0;
        double uncommon = 0;
        double rare = 0;
        double epic = 0;
        double legendary = 0;
        Random rnd = new Random();
        StringBuilder sb = new StringBuilder();
        public Dictionary<string, HashSet<string>> itemBaseName = new Dictionary<string, HashSet<string>>();

        public void ConsoleItemGeneration(double runAmount)
        {
            GenerateLists();
            
            for (int i = 0; i < runAmount; i++)   
            {                
                Item testItem = GetItemType(itemBaseName);
                SetTextColor(testItem);
                AppendtemProperties(testItem);
                PrintItemProperties(WriteToConsole: true);
            }
            PrintSummary(runAmount);
            Console.ReadLine();
        }

        public void DiscordItemGeneration(CommandContext ctx = null, string rarity = "")
        {
            GenerateLists();
            Item testItem = GetItemType(itemBaseName, rarity);
            AppendtemProperties(testItem);
            PrintItemProperties(ctx, WriteToConsole: false);
        }
    }
}
