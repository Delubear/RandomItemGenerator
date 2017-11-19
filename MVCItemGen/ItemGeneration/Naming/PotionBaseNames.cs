using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class BaseNames
    {
        public void GeneratePotionBaseNames()
        {
            // COMMON
            itemBaseName.Add(Rarity.Common.ToString() + ":" + ItemTypes.Potion.ToString(), new HashSet<string>()
                { "Bottle", "Potion", "Flask" });            
            
            //UNCOMMON
            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + ItemTypes.Potion.ToString(), new HashSet<string>()
                { "Bottle", "Potion", "Flask" });

            //RARE
            itemBaseName.Add(Rarity.Rare.ToString() + ":" + ItemTypes.Potion.ToString(), new HashSet<string>()
                { "Bottle", "Potion", "Flask" });

            //EPIC
            itemBaseName.Add(Rarity.Epic.ToString() + ":" + ItemTypes.Potion.ToString(), new HashSet<string>()
                { "Bottle", "Potion", "Flask" });


            //LEGENDARY
            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + ItemTypes.Potion.ToString(), new HashSet<string>()
                { "Bottle", "Potion", "Flask" });
        }
    }
}
