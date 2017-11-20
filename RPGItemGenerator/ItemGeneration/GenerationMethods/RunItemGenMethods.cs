using DSharpPlus.CommandsNext;
using System;
using System.Collections.Generic;
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

        public void AppendtemProperties(Item testItem)
        {
            sb.AppendLine($"Name: {testItem.Name}");
            sb.AppendLine($"Value: {testItem.Value}");
            sb.AppendLine($"Description: {testItem.Description}");
            sb.AppendLine($"Rarity: {testItem.Rarity}");
            sb.AppendLine($"Type: {testItem.ItemType}");
            sb.AppendLine($"Durability: {testItem.CurrentDurability}/{testItem.MaxDurability}");

            foreach (var prop in testItem.SecondaryProps.Values)
            {
                sb.AppendLine($"Has Property: " + prop.PropDescription);
            }

            if (testItem.GetType().ToString() == "RPGItemGenerator.ItemGeneration.Armor")
            {
                sb.AppendLine($"ArmorType: " + testItem.GetType().GetProperty("ArmorType").GetValue(testItem));
                sb.AppendLine($"ArmorValue: " + testItem.GetType().GetProperty("ArmorValue").GetValue(testItem));
            }
            else if (testItem.GetType().ToString() == "RPGItemGenerator.ItemGeneration.Weapons")
            {
                sb.AppendLine($"WeaponCategory: {testItem.GetType().GetProperty("WeaponCat").GetValue(testItem)}");
                sb.AppendLine($"WeaponType: {testItem.GetType().GetProperty("WeaponType").GetValue(testItem)}");
                sb.AppendLine($"Damage: {testItem.GetType().GetProperty("DamageValue").GetValue(testItem)}");
                sb.AppendLine($"Damage Type: {testItem.GetType().GetProperty("DamageType").GetValue(testItem)}");
                sb.AppendLine($"Accuracy: {testItem.GetType().GetProperty("Accuracy").GetValue(testItem)}");
            }
            else if (testItem.GetType().ToString() == "RPGItemGenerator.ItemGeneration.Potions")
            {
                sb.AppendLine($"Effects: {testItem.GetType().GetProperty("Effect").GetValue(testItem)}");
            }
            sb.AppendLine();          
        }

        public void PrintItemProperties(CommandContext ctx = null, bool WriteToConsole = true)
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
            int x = 0;
            x = rnd.Next(0, 3);
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
                if (x == 0)
                {
                    testItem = new Armor(itemBaseName, rare);
                }
                else if (x == 1)
                {
                    testItem = new Weapons(itemBaseName, rare);
                }
                else
                {
                    testItem = new Potions(itemBaseName, rare);
                }
            }
            else
            {
                if (x == 0)
                {
                    testItem = new Armor(itemBaseName);
                }
                else if (x == 1)
                {
                    testItem = new Weapons(itemBaseName);
                }
                else
                {
                    testItem = new Potions(itemBaseName);
                }
            }

            return testItem;
        }
    }
}
