using DSharpPlus.CommandsNext;
using System;
using System.Collections.Generic;
using System.Text;
using static RPGItemGenerator.ItemGeneration.Enums;

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

        public double GetRunAmount()
        {
            Console.WriteLine("How many items to generate?");
            double runAmount = 100;
            string generateTimes = Console.ReadLine();
            try
            {
                runAmount = Convert.ToDouble(generateTimes);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
            return runAmount;
        }

        public void GenerateLists()
        {
            itemBaseName = new BaseNames(itemBaseName).itemBaseName;
        }

        public Item GetNewRandomItem()
        {
            if (itemBaseName.Count < 1)
                GenerateLists();
            return GetItemType(itemBaseName);
        }

        public Item GetNewRandomItem(string rarity)
        {
            if (itemBaseName.Count < 1)
                GenerateLists();
            return GetItemType(itemBaseName, rarity);
        }

        public string GetItemStatsAsString(Item itemToProcess)
        {
            StringBuilder stB = new StringBuilder();
            stB.AppendLine($"Name: {itemToProcess.Name}");
            stB.AppendLine($"Value: {itemToProcess.Value}");
            stB.AppendLine($"Description: {itemToProcess.Description}");
            stB.AppendLine($"Rarity: {itemToProcess.Rarity}");
            stB.AppendLine($"Type: {itemToProcess.ItemType}");
            stB.AppendLine($"Durability: {itemToProcess.CurrentDurability}/{itemToProcess.MaxDurability}");

            foreach (var prop in itemToProcess.SecondaryProps.Values)
            {
                stB.AppendLine($"Has Property: " + prop.PropDescription);
            }

            if (itemToProcess.GetType().ToString() == "RPGItemGenerator.ItemGeneration.Armor")
            {
                stB.AppendLine($"ArmorType: " + itemToProcess.GetType().GetProperty("ArmorType").GetValue(itemToProcess));
                stB.AppendLine($"ArmorValue: " + itemToProcess.GetType().GetProperty("ArmorValue").GetValue(itemToProcess));
            }
            else if (itemToProcess.GetType().ToString() == "RPGItemGenerator.ItemGeneration.Weapons")
            {
                stB.AppendLine($"WeaponCategory: {itemToProcess.GetType().GetProperty("WeaponCat").GetValue(itemToProcess)}");
                stB.AppendLine($"WeaponType: {itemToProcess.GetType().GetProperty("WeaponType").GetValue(itemToProcess)}");
                stB.AppendLine($"Damage: {itemToProcess.GetType().GetProperty("DamageValue").GetValue(itemToProcess)}");
                stB.AppendLine($"Damage Type: {itemToProcess.GetType().GetProperty("DamageType").GetValue(itemToProcess)}");
                stB.AppendLine($"Accuracy: {itemToProcess.GetType().GetProperty("Accuracy").GetValue(itemToProcess)}");
            }
            else if (itemToProcess.GetType().ToString() == "RPGItemGenerator.ItemGeneration.Potions")
            {
                stB.AppendLine($"Effects: {itemToProcess.GetType().GetProperty("Effect").GetValue(itemToProcess)}");
            }
            else if (itemToProcess.GetType().ToString() == "RPGItemGenerator.ItemGeneration.Jewelry")
            {
                stB.AppendLine($"Effects: {itemToProcess.GetType().GetProperty("Effect").GetValue(itemToProcess)}");
                stB.AppendLine($"Jewelry Type: {itemToProcess.GetType().GetProperty("JewelryType").GetValue(itemToProcess)}");
            }
            return stB.ToString();
        }

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
                Console.WriteLine(sb.ToString());
            else
                ctx.RespondAsync("```" + sb.ToString() + "```");
            sb.Clear();
        }

        private void SetTextColor(Item item)
        {
            switch (item.Rarity)
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
            Item newItem;
            Rarity rare;

            if(string.Equals(rarity, "common",StringComparison.InvariantCultureIgnoreCase))
                rare = Rarity.Common;
            else if (string.Equals(rarity, "uncommon", StringComparison.InvariantCultureIgnoreCase))
                rare = Rarity.Uncommon;
            else if (string.Equals(rarity, "rare", StringComparison.InvariantCultureIgnoreCase))
                rare = Rarity.Rare;
            else if (string.Equals(rarity, "epic", StringComparison.InvariantCultureIgnoreCase))
                rare = Rarity.Epic;
            else 
                rare = Rarity.Legendary;

            if (rarity != "")
            {
                if (itemType == ItemTypes.Armor)
                    newItem = new Armor(itemBaseName, rare);
                else if (itemType == ItemTypes.Weapon)
                    newItem = new Weapons(itemBaseName, rare);
                else if (itemType == ItemTypes.Potion)
                    newItem = new Potions(itemBaseName, rare);
                else
                    newItem = new Jewelry(itemBaseName, rare);
            }
            else
            {
                if (itemType == ItemTypes.Armor)
                    newItem = new Armor(itemBaseName);
                else if (itemType == ItemTypes.Weapon)
                    newItem = new Weapons(itemBaseName);
                else if (itemType == ItemTypes.Potion)
                    newItem = new Potions(itemBaseName);
                else
                    newItem = new Jewelry(itemBaseName);
            }
            return newItem;
        }
    }
}
