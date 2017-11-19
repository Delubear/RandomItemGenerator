using System;
using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class SecondaryPropertiesList
    {
        public void GenerateRangedWeaponSecondaryProperties()
        {
            // COMMON
            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + WeaponsType.Bow.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                { "Wooden", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + WeaponsType.Crossbow.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                { "Wooden", 9 },
            });

            //UNCOMMON
            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Bow.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                { "Deadly", 4 },
                { "Wooden", 9 }, 
            });

            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Crossbow.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                { "Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 },
            });

            //RARE
            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Bow.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                { "Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Crossbow.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                { "Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 },
            });

            //EPIC
            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Bow.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                { "Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Crossbow.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, 
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                { "Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 },
            });


            //LEGENDARY
            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Bow.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                { "Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 }, {"Obsidian", 9 },                
            });

            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Crossbow.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },  {"Deadeye", 6 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},                
                { "Wooden", 9 }, { "Steel", 9 }, {"Obsidian", 9 },               
                { "Deadly", 4 },
            });

        }
    }
}
