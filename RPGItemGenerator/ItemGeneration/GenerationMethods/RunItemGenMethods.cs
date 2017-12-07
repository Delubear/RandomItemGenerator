using DSharpPlus.CommandsNext;
using System;
using System.Collections.Generic;
using System.Text;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class RunItemGen
    {
        private void PrintSummary(double runAmount)
        {
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Total Items Generated: {runAmount}");
            Console.WriteLine($"Common: {common.ToString()}  -- {Math.Round(common / runAmount * 100, 2)}%");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Uncommon: {uncommon.ToString()}  -- {Math.Round(uncommon / runAmount * 100, 2)}%");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Rare: {rare.ToString()}  -- {Math.Round(rare / runAmount * 100, 2)}%");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Epic: {epic.ToString()}  -- {Math.Round(epic / runAmount * 100, 2)}%");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Legendary: {legendary.ToString()}  -- {Math.Round(legendary / runAmount * 100, 2)}%");
        }

        private void AppendtemProperties(Item testItem)
        {            
            sb.Append(GetItemStatsAsString(testItem));
            sb.AppendLine();          
        }

        private void PrintItemProperties(CommandContext ctx = null, bool WriteToConsole = true)
        {
            if(WriteToConsole == true)
            {
                Console.WriteLine(sb.ToString());
            }
            else
            {
                ctx.RespondAsync("```" + sb.ToString() + "```");
            }
            sb.Clear();
        }

        private void SetTextColor(Item testItem)
        {
            switch (testItem.Rarity)
            {
                case Rarity.Common:    { Console.ForegroundColor = ConsoleColor.White;  common++;    break; }
                case Rarity.Uncommon:  { Console.ForegroundColor = ConsoleColor.Green;  uncommon++;  break; }
                case Rarity.Rare:      { Console.ForegroundColor = ConsoleColor.Yellow; rare++;      break; }
                case Rarity.Epic:      { Console.ForegroundColor = ConsoleColor.Cyan;   epic++;      break; }
                case Rarity.Legendary: { Console.ForegroundColor = ConsoleColor.Red;    legendary++; break; }
            }
        }

        public Item GetItemType(Dictionary<string, HashSet<string>> itemBaseName, string rarity = "")
        {            
            ItemTypes itemType = (ItemTypes)rnd.Next(0, Enum.GetValues(typeof(ItemTypes)).Length);
            Item testItem;
            Rarity rare;

            if(string.Equals(rarity, "common",StringComparison.InvariantCultureIgnoreCase))
            {
                rare = Rarity.Common;
            }
            else if (string.Equals(rarity, "uncommon", StringComparison.InvariantCultureIgnoreCase))
            {
                rare = Rarity.Uncommon;
            }
            else if (string.Equals(rarity, "rare", StringComparison.InvariantCultureIgnoreCase))
            {
                rare = Rarity.Rare;
            }
            else if (string.Equals(rarity, "epic", StringComparison.InvariantCultureIgnoreCase))
            {
                rare = Rarity.Epic;
            }
            else 
            {
                rare = Rarity.Legendary;
            }
            if (rarity != "")
            {
                if (itemType == ItemTypes.Armor)
                {
                    testItem = new Armor(itemBaseName, rare);
                }
                else if (itemType == ItemTypes.Weapon)
                {
                    testItem = new Weapons(itemBaseName, rare);
                }
                else if (itemType == ItemTypes.Potion)
                {
                    testItem = new Potions(itemBaseName, rare);
                }
                else
                {
                    testItem = new Jewelry(itemBaseName, rare);
                }
            }
            else
            {
                if (itemType == ItemTypes.Armor)
                {
                    testItem = new Armor(itemBaseName);
                }
                else if (itemType == ItemTypes.Weapon)
                {
                    testItem = new Weapons(itemBaseName);
                }
                else if (itemType == ItemTypes.Potion)
                {
                    testItem = new Potions(itemBaseName);
                }
                else
                {
                    testItem = new Jewelry(itemBaseName);
                }
            }

            return testItem;
        }
    }
}
