using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class BaseNames
    {
        public Dictionary<string, HashSet<string>> itemBaseName;

        public BaseNames(Dictionary<string, HashSet<string>> itemBaseName)
        {
            this.itemBaseName = itemBaseName;
            GenerateMeleeWeaponBaseNames();
            GenerateMagicWeaponBaseNames();
            GenerateRangedWeaponBaseNames();
            GeneratePotionBaseNames();
            GenerateArmorBaseNames();
            GenerateJewelryBaseNames();
        }

        public void GenerateMeleeWeaponBaseNames()
        {
            // COMMON
            itemBaseName.Add(Rarity.Common.ToString() + ":" + WeaponsType.Dagger.ToString(), new HashSet<string>()
                { "Dirk", "Dagger", "Shiv", "Knife" });

            itemBaseName.Add(Rarity.Common.ToString() + ":" + WeaponsType.Spear.ToString(), new HashSet<string>()
                { "Spear", "Javelin", "Halberd" });

            itemBaseName.Add(Rarity.Common.ToString() + ":" + WeaponsType.Sword.ToString(), new HashSet<string>()
                { "Sword", "Shortsword", "Claymore", "Bastard-Sword" });
            
            //UNCOMMON
            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Dagger.ToString(), new HashSet<string>()
                { "Dirk", "Dagger", "Shiv", "Knife" });

            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Spear.ToString(), new HashSet<string>()
                { "Spear", "Javelin", "Halberd" });

            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Sword.ToString(), new HashSet<string>()
                {  "Sword", "Shortsword", "Claymore", "Bastard-Sword"  });

            //RARE
            itemBaseName.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Dagger.ToString(), new HashSet<string>()
                { "Dirk", "Dagger", "Shiv", "Knife" });

            itemBaseName.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Spear.ToString(), new HashSet<string>()
                { "Spear", "Javelin", "Halberd" });

            itemBaseName.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Sword.ToString(), new HashSet<string>()
                {  "Sword", "Shortsword", "Claymore", "Bastard-Sword"  });

            //EPIC
            itemBaseName.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Dagger.ToString(), new HashSet<string>()
                { "Dirk", "Dagger", "Shiv", "Knife" });

            itemBaseName.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Spear.ToString(), new HashSet<string>()
                { "Spear", "Javelin", "Halberd" });

            itemBaseName.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Sword.ToString(), new HashSet<string>()
                {  "Sword", "Shortsword", "Claymore", "Bastard-Sword"  });


            //LEGENDARY
            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Dagger.ToString(), new HashSet<string>()
                { "Dirk", "Dagger", "Shiv", "Knife" });

            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Spear.ToString(), new HashSet<string>()
                { "Spear", "Javelin", "Halberd" });

            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Sword.ToString(), new HashSet<string>()
                {  "Sword", "Shortsword", "Claymore", "Bastard-Sword"  });

        }
    }
}
