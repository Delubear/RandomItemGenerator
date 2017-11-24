using System;
using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class SecondaryPropertiesList
    {
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
