using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class BaseNames
    {
        public void GenerateJewelryBaseNames()
        {
            // COMMON
            itemBaseName.Add(Rarity.Common.ToString() + ":" + JewelryType.Neck.ToString(), new HashSet<string>()
                { "Necklace", "Amulet", "Pendant", "Locket" });

            itemBaseName.Add(Rarity.Common.ToString() + ":" + JewelryType.Finger.ToString(), new HashSet<string>()
                { "Ring", "Signet" });

            itemBaseName.Add(Rarity.Common.ToString() + ":" + JewelryType.Wrist.ToString(), new HashSet<string>()
                { "Bracelet", "Bangle", "Brace", "Charm" });

            itemBaseName.Add(Rarity.Common.ToString() + ":" + JewelryType.Ear.ToString(), new HashSet<string>()
                { "Earring", "Hoop", "Stud" });

            //UNCOMMON
            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + JewelryType.Neck.ToString(), new HashSet<string>()
                { "Necklace", "Amulet", "Pendant", "Locket" });

            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + JewelryType.Finger.ToString(), new HashSet<string>()
                { "Ring", "Signet" });

            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + JewelryType.Wrist.ToString(), new HashSet<string>()
                { "Bracelet", "Bangle", "Brace", "Charm" });

            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + JewelryType.Ear.ToString(), new HashSet<string>()
                { "Earring", "Hoop", "Stud" });

            //RARE
            itemBaseName.Add(Rarity.Rare.ToString() + ":" + JewelryType.Neck.ToString(), new HashSet<string>()
                { "Necklace", "Amulet", "Pendant", "Locket" });

            itemBaseName.Add(Rarity.Rare.ToString() + ":" + JewelryType.Finger.ToString(), new HashSet<string>()
                { "Ring", "Signet" });

            itemBaseName.Add(Rarity.Rare.ToString() + ":" + JewelryType.Wrist.ToString(), new HashSet<string>()
                { "Bracelet", "Bangle", "Brace", "Charm" });

            itemBaseName.Add(Rarity.Rare.ToString() + ":" + JewelryType.Ear.ToString(), new HashSet<string>()
                { "Earring", "Hoop", "Stud" });

            //EPIC
            itemBaseName.Add(Rarity.Epic.ToString() + ":" + JewelryType.Neck.ToString(), new HashSet<string>()
                { "Necklace", "Amulet", "Pendant", "Locket" });

            itemBaseName.Add(Rarity.Epic.ToString() + ":" + JewelryType.Finger.ToString(), new HashSet<string>()
                { "Ring", "Signet" });

            itemBaseName.Add(Rarity.Epic.ToString() + ":" + JewelryType.Wrist.ToString(), new HashSet<string>()
                { "Bracelet", "Bangle", "Brace", "Charm" });

            itemBaseName.Add(Rarity.Epic.ToString() + ":" + JewelryType.Ear.ToString(), new HashSet<string>()
                { "Earring", "Hoop", "Stud" });

            //LEGENDARY
            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + JewelryType.Neck.ToString(), new HashSet<string>()
                { "Necklace", "Amulet", "Pendant", "Locket" });

            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + JewelryType.Finger.ToString(), new HashSet<string>()
                { "Ring", "Signet" });

            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + JewelryType.Wrist.ToString(), new HashSet<string>()
                { "Bracelet", "Bangle", "Brace", "Charm" });

            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + JewelryType.Ear.ToString(), new HashSet<string>()
                { "Earring", "Hoop", "Stud" });
        }
    }
}
