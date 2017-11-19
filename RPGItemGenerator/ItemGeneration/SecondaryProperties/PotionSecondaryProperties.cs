using System;
using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class SecondaryPropertiesList
    {
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
    }
}
