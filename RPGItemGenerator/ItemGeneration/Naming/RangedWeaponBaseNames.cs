using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class BaseNames
    {
        public void GenerateRangedWeaponBaseNames()
        {
            // COMMON
            itemBaseName.Add(Rarity.Common.ToString() + ":" + WeaponsType.Bow.ToString(), new HashSet<string>()
                { "Bow", "Shortbow", "Longbow", "Composite-Bow" });

            itemBaseName.Add(Rarity.Common.ToString() + ":" + WeaponsType.Crossbow.ToString(), new HashSet<string>()
                { "Crossbow", "Composite-Crossbow", "Recurve-Crossbow" });
            
            
            //UNCOMMON
            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Bow.ToString(), new HashSet<string>()
                { "Bow", "Shortbow", "Longbow", "Composite-Bow" });

            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Crossbow.ToString(), new HashSet<string>()
                { "Crossbow", "Composite-Crossbow", "Recurve-Crossbow" });

            //RARE
            itemBaseName.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Bow.ToString(), new HashSet<string>()
                { "Bow", "Shortbow", "Longbow", "Composite-Bow" });

            itemBaseName.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Crossbow.ToString(), new HashSet<string>()
                { "Crossbow", "Composite-Crossbow", "Recurve-Crossbow" });

            //EPIC
            itemBaseName.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Bow.ToString(), new HashSet<string>()
                { "Bow", "Shortbow", "Longbow", "Composite-Bow" });

            itemBaseName.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Crossbow.ToString(), new HashSet<string>()
                { "Crossbow", "Composite-Crossbow", "Recurve-Crossbow" });


            //LEGENDARY
            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Bow.ToString(), new HashSet<string>()
                { "Bow", "Shortbow", "Longbow", "Composite-Bow" });

            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Crossbow.ToString(), new HashSet<string>()
                { "Crossbow", "Composite-Crossbow", "Recurve-Crossbow" });

        }
    }
}
