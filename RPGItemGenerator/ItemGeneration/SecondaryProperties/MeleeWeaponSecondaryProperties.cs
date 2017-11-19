using System;
using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class SecondaryPropertiesList
    {
        public Dictionary<string, Dictionary<string, int>> SecondaryPropertiesSet = new Dictionary<string, Dictionary<string, int>>();

        public SecondaryPropertiesList()
        {
            GenerateMagicWeaponSecondaryProperties();
            GenerateMeleeWeaponSecondaryProperties();
            GenerateRangedWeaponSecondaryProperties();
            GenerateArmorSecondaryProperties();
            GeneratePotionSecondaryProperties();
        }

        public void GenerateMeleeWeaponSecondaryProperties()
        {
            // COMMON
            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + WeaponsType.Dagger.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, 
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                { "Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 }, 
            });

            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + WeaponsType.Spear.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                { "Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + WeaponsType.Sword.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                { "Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 },
            });

            //UNCOMMON
            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Dagger.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Spear.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Sword.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 },
            });

            //RARE
            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Dagger.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Spear.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Sword.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 },
            });

            //EPIC
            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Dagger.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 }, {"Obsidian", 9 }, 
            });

            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Spear.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 }, {"Obsidian", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Sword.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 }, {"Obsidian", 9 },
            });


            //LEGENDARY
            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Dagger.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3 }, 
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 }, {"Obsidian", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Spear.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 }, {"Obsidian", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Sword.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Sharp", 4 }, { "Dull", 4 }, {"Deadly", 4 },
                { "Wooden", 9 }, { "Steel", 9 }, {"Obsidian", 9 },
            });

        }
    }
}
