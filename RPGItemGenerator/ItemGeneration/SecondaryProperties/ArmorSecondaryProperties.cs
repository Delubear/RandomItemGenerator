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

        public void GeneratePotionSecondaryProperties()
        {
            // COMMON
            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + ItemTypes.Potion.ToString(), new Dictionary<string, int>()
            {
                { "Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
            });

            //UNCOMMON
            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + ItemTypes.Potion.ToString(), new Dictionary<string, int>()
            {
                { "Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
            });

            //RARE
            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + ItemTypes.Potion.ToString(), new Dictionary<string, int>()
            {
                { "Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
            });

            //EPIC
            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + ItemTypes.Potion.ToString(), new Dictionary<string, int>()
            {
                { "Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
            });


            //LEGENDARY
            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + ItemTypes.Potion.ToString(), new Dictionary<string, int>()
            {
                { "Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
            });

        }

        public Dictionary<string, Dictionary<string, int>> SecondaryPropertiesSet = new Dictionary<string, Dictionary<string, int>>();

        public SecondaryPropertiesList()
        {
            GenerateMagicWeaponSecondaryProperties();
            GenerateMeleeWeaponSecondaryProperties();
            GenerateRangedWeaponSecondaryProperties();
            GenerateArmorSecondaryProperties();
            GeneratePotionSecondaryProperties();
            GenerateJewelrySecondaryProperties();
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

        public void GenerateMagicWeaponSecondaryProperties()
        {
            // COMMON
            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + WeaponsType.Wand.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Wooden", 9 }, {"Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + WeaponsType.Staff.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Wooden", 9 }, {"Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + WeaponsType.Spellbook.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Wooden", 9 }, {"Steel", 9 },
            });

            //UNCOMMON
            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Wand.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Deadly", 4 },
                {"Wooden", 9 }, {"Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Staff.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Deadly", 4 },
                {"Wooden", 9 }, {"Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Spellbook.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Deadly", 4 },
                {"Wooden", 9 }, {"Steel", 9 },
            });

            //RARE
            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Wand.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Deadly", 4 },
                {"Wooden", 9 }, {"Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Staff.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Deadly", 4 },
                {"Wooden", 9 }, {"Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Spellbook.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Deadly", 4 },
                {"Wooden", 9 }, {"Steel", 9 },
            });

            //EPIC
            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Wand.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Deadly", 4 },
                {"Wooden", 9 }, {"Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Staff.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Deadly", 4 },
                {"Wooden", 9 }, {"Steel", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Spellbook.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Deadly", 4 },
                {"Wooden", 9 }, {"Steel", 9 },
            });


            //LEGENDARY
            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Wand.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Deadly", 4 },
                {"Wooden", 9 }, {"Steel", 9 }, {"Obsidian", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Staff.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Deadly", 4 },
                {"Wooden", 9 }, {"Steel", 9 }, {"Obsidian", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Spellbook.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Fiery", 1 }, {"Freezing", 1}, {"Acidic", 1}, {"Lightning", 1}, {"Bludgeoning", 1}, {"Piercing", 1}, {"Slashing", 1},
                {"Deadly", 4 },
                {"Wooden", 9 }, {"Steel", 9 }, {"Obsidian", 9 },
            });

        }

        public void GenerateJewelrySecondaryProperties()
        {
            // COMMON
            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + JewelryType.Neck.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + JewelryType.Finger.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Wooden", 9},
            });

            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + JewelryType.Wrist.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Wooden", 9},
            });

            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + JewelryType.Ear.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Wooden", 9},
            });

            //UNCOMMON
            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + JewelryType.Neck.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + JewelryType.Finger.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Wooden", 9},
            });

            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + JewelryType.Wrist.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Wooden", 9},
            });

            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + JewelryType.Ear.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Wooden", 9},
            });

            //RARE
            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + JewelryType.Neck.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + JewelryType.Finger.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Wooden", 9},
            });

            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + JewelryType.Wrist.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Wooden", 9},
            });

            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + JewelryType.Ear.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Wooden", 9},
            });

            //EPIC
            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + JewelryType.Neck.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + JewelryType.Finger.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + JewelryType.Wrist.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Wooden", 9},
            });

            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + JewelryType.Ear.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Wooden", 9},
            });

            //LEGENDARY
            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + JewelryType.Neck.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3},
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Obsidian", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + JewelryType.Finger.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3},
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Wooden", 9}, {"Obsidian", 9},
            });

            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + JewelryType.Wrist.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3},
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Wooden", 9}, {"Obsidian", 9},
            });

            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + JewelryType.Ear.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3},
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 }, {"Deadeye", 6 },
                {"Steel", 9 }, {"Iron", 9 }, {"Wooden", 9}, {"Obsidian", 9},
            });
        }

        public void GenerateArmorSecondaryProperties()
        {
            // COMMON
            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + ArmorTypes.Boots.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 }, 
            });

            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + ArmorTypes.Chest.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + ArmorTypes.Gloves.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + ArmorTypes.Helm.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + ArmorTypes.Leggings.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + ArmorTypes.Pauldrons.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Common.ToString() + ":" + ArmorTypes.Shield.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, 
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            //UNCOMMON
            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + ArmorTypes.Boots.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + ArmorTypes.Chest.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + ArmorTypes.Gloves.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + ArmorTypes.Helm.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + ArmorTypes.Leggings.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + ArmorTypes.Pauldrons.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Uncommon.ToString() + ":" + ArmorTypes.Shield.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, 
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            //RARE
            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + ArmorTypes.Boots.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + ArmorTypes.Chest.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + ArmorTypes.Gloves.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + ArmorTypes.Helm.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + ArmorTypes.Leggings.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + ArmorTypes.Pauldrons.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Rare.ToString() + ":" + ArmorTypes.Shield.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, 
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            //EPIC
            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + ArmorTypes.Boots.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + ArmorTypes.Chest.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + ArmorTypes.Gloves.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + ArmorTypes.Helm.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + ArmorTypes.Leggings.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + ArmorTypes.Pauldrons.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Epic.ToString() + ":" + ArmorTypes.Shield.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 },
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, 
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            //LEGENDARY
            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + ArmorTypes.Boots.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3}, 
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + ArmorTypes.Chest.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3},
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + ArmorTypes.Gloves.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3},
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + ArmorTypes.Helm.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3},
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + ArmorTypes.Leggings.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3},
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + ArmorTypes.Pauldrons.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3},
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, {"Platemail", 8 }, {"Chainmail", 8 },{"Leather", 8 },
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 },
            });

            SecondaryPropertiesSet.Add(Rarity.Legendary.ToString() + ":" + ArmorTypes.Shield.ToString(), new Dictionary<string, int>()
            {
                {"Durable", 3 }, {"Fragile", 3 }, {"Unbreakable", 3},
                {"New", 2 }, {"Old", 2 }, {"Ancient", 2 },
                {"Horned", 8 }, 
                {"Focusing", 5 }, {"Vitality", 10 }, {"Strength", 7 },
                {"Steel", 9 }, {"Iron", 9 }, {"Obsidian", 9 }, 
            });

        }
    }
}
