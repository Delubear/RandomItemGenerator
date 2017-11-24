using System;
using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class SecondaryPropertiesList
    {
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
    }
}
