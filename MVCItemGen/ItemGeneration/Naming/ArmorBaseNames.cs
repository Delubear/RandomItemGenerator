using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class BaseNames
    {
        public void GenerateArmorBaseNames()
        {
            // COMMON
            itemBaseName.Add(Rarity.Common.ToString() + ":" + ArmorTypes.Boots.ToString(), new HashSet<string>()
                { "Boots", "Sandals", "Slippers" });

            itemBaseName.Add(Rarity.Common.ToString() + ":" + ArmorTypes.Chest.ToString(), new HashSet<string>()
                { "Chestpiece", "Breastplate", "Coat" });

            itemBaseName.Add(Rarity.Common.ToString() + ":" + ArmorTypes.Gloves.ToString(), new HashSet<string>()
                { "Gloves", "Fingerless-Gloves", "Knuckle-Wraps" });

            itemBaseName.Add(Rarity.Common.ToString() + ":" + ArmorTypes.Helm.ToString(), new HashSet<string>()
                { "Helm", "Cap", "Bandana", "Helmet" });

            itemBaseName.Add(Rarity.Common.ToString() + ":" + ArmorTypes.Leggings.ToString(), new HashSet<string>()
                { "Leggings", "Pants", "Pantaloons" });

            itemBaseName.Add(Rarity.Common.ToString() + ":" + ArmorTypes.Pauldrons.ToString(), new HashSet<string>()
                { "Pauldrons", "Shoulders", "Spiked-Pauldrons" });

            itemBaseName.Add(Rarity.Common.ToString() + ":" + ArmorTypes.Shield.ToString(), new HashSet<string>()
                { "Shield", "Targe", "Round-Shield" });

            //UNCOMMON
            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + ArmorTypes.Boots.ToString(), new HashSet<string>()
                { "Boots", "Sandals", "Slippers" });

            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + ArmorTypes.Chest.ToString(), new HashSet<string>()
                { "Chestpiece", "Breastplate", "Coat" });

            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + ArmorTypes.Gloves.ToString(), new HashSet<string>()
                { "Gloves", "Fingerless-Gloves", "Knuckle-Wraps" });

            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + ArmorTypes.Helm.ToString(), new HashSet<string>()
                { "Helm", "Cap", "Bandana", "Helmet" });

            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + ArmorTypes.Leggings.ToString(), new HashSet<string>()
                { "Leggings", "Pants", "Pantaloons" });

            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + ArmorTypes.Pauldrons.ToString(), new HashSet<string>()
                { "Pauldrons", "Shoulders", "Spiked-Pauldrons" });

            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + ArmorTypes.Shield.ToString(), new HashSet<string>()
                { "Shield", "Targe", "Round-Shield" });

            //RARE
            itemBaseName.Add(Rarity.Rare.ToString() + ":" + ArmorTypes.Boots.ToString(), new HashSet<string>()
                { "Boots", "Sandals", "Slippers" });

            itemBaseName.Add(Rarity.Rare.ToString() + ":" + ArmorTypes.Chest.ToString(), new HashSet<string>()
                { "Chestpiece", "Breastplate", "Coat" });

            itemBaseName.Add(Rarity.Rare.ToString() + ":" + ArmorTypes.Gloves.ToString(), new HashSet<string>()
                { "Gloves", "Fingerless-Gloves", "Knuckle-Wraps" });

            itemBaseName.Add(Rarity.Rare.ToString() + ":" + ArmorTypes.Helm.ToString(), new HashSet<string>()
                { "Helm", "Cap", "Bandana", "Helmet" });

            itemBaseName.Add(Rarity.Rare.ToString() + ":" + ArmorTypes.Leggings.ToString(), new HashSet<string>()
                { "Leggings", "Pants", "Pantaloons" });

            itemBaseName.Add(Rarity.Rare.ToString() + ":" + ArmorTypes.Pauldrons.ToString(), new HashSet<string>()
                { "Pauldrons", "Shoulders", "Spiked-Pauldrons" });

            itemBaseName.Add(Rarity.Rare.ToString() + ":" + ArmorTypes.Shield.ToString(), new HashSet<string>()
                { "Shield", "Targe", "Round-Shield" });

            //EPIC
            itemBaseName.Add(Rarity.Epic.ToString() + ":" + ArmorTypes.Boots.ToString(), new HashSet<string>()
                { "Boots", "Sandals", "Slippers" });

            itemBaseName.Add(Rarity.Epic.ToString() + ":" + ArmorTypes.Chest.ToString(), new HashSet<string>()
                { "Chestpiece", "Breastplate", "Coat" });

            itemBaseName.Add(Rarity.Epic.ToString() + ":" + ArmorTypes.Gloves.ToString(), new HashSet<string>()
                { "Gloves", "Fingerless-Gloves", "Knuckle-Wraps" });

            itemBaseName.Add(Rarity.Epic.ToString() + ":" + ArmorTypes.Helm.ToString(), new HashSet<string>()
                { "Helm", "Cap", "Bandana", "Helmet" });

            itemBaseName.Add(Rarity.Epic.ToString() + ":" + ArmorTypes.Leggings.ToString(), new HashSet<string>()
                { "Leggings", "Pants", "Pantaloons" });

            itemBaseName.Add(Rarity.Epic.ToString() + ":" + ArmorTypes.Pauldrons.ToString(), new HashSet<string>()
                { "Pauldrons", "Shoulders", "Spiked-Pauldrons" });

            itemBaseName.Add(Rarity.Epic.ToString() + ":" + ArmorTypes.Shield.ToString(), new HashSet<string>()
                { "Shield", "Targe", "Round-Shield" });


            //LEGENDARY
            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + ArmorTypes.Boots.ToString(), new HashSet<string>()
                { "Boots", "Sandals", "Slippers" });

            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + ArmorTypes.Chest.ToString(), new HashSet<string>()
                { "Chestpiece", "Breastplate", "Coat" });

            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + ArmorTypes.Gloves.ToString(), new HashSet<string>()
                { "Gloves", "Fingerless-Gloves", "Knuckle-Wraps" });

            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + ArmorTypes.Helm.ToString(), new HashSet<string>()
                { "Helm", "Cap", "Bandana", "Helmet" });

            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + ArmorTypes.Leggings.ToString(), new HashSet<string>()
                { "Leggings", "Pants", "Pantaloons" });

            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + ArmorTypes.Pauldrons.ToString(), new HashSet<string>()
                { "Pauldrons", "Shoulders", "Spiked-Pauldrons" });

            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + ArmorTypes.Shield.ToString(), new HashSet<string>()
                { "Shield", "Targe", "Round-Shield" });
        }
    }
}
