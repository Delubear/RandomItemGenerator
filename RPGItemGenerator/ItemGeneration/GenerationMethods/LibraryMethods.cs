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
            if(itemBaseName.Count < 1)
            {
                GenerateLists();
            }
            
            return GetItemType(itemBaseName);
        }

        public Item GetNewRandomItem(string rarity)
        {
            if (itemBaseName.Count < 1)
            {
                GenerateLists();
            }
            
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
    }
}
