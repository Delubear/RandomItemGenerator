using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class BaseNames
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

        public void GenerateMagicWeaponBaseNames()
        {
            // COMMON
            itemBaseName.Add(Rarity.Common.ToString() + ":" + WeaponsType.Wand.ToString(), new HashSet<string>()
                { "Wand", "Wand", "Wand", "Stick" });

            itemBaseName.Add(Rarity.Common.ToString() + ":" + WeaponsType.Staff.ToString(), new HashSet<string>()
                { "Tree-Branch", "Staff", "Staff" });

            itemBaseName.Add(Rarity.Common.ToString() + ":" + WeaponsType.Spellbook.ToString(), new HashSet<string>()
                { "Tome", "Spellbook", "Grimoire" });

            //UNCOMMON
            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Wand.ToString(), new HashSet<string>()
                { "Twig", "Wand", "Orc-Tooth" });

            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Staff.ToString(), new HashSet<string>()
                { "Branch", "Carved-Staff" });

            itemBaseName.Add(Rarity.Uncommon.ToString() + ":" + WeaponsType.Spellbook.ToString(), new HashSet<string>()
                { "Tome", "Spellbook", "Grimoire" });

            //RARE
            itemBaseName.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Wand.ToString(), new HashSet<string>()
                { "Glittering-Twig", "Ogre-Horn", "Wererat-Tail" });

            itemBaseName.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Staff.ToString(), new HashSet<string>()
                { "Gnarled Branch", "Staff" });

            itemBaseName.Add(Rarity.Rare.ToString() + ":" + WeaponsType.Spellbook.ToString(), new HashSet<string>()
                { "Tome", "Spellbook", "Grimoire" });

            //EPIC
            itemBaseName.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Wand.ToString(), new HashSet<string>()
                { "Star-Twig", "Unicorn-Horn", "Demon-Tail" });

            itemBaseName.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Staff.ToString(), new HashSet<string>()
                { "Star-Branch", "Demon-Leg" });

            itemBaseName.Add(Rarity.Epic.ToString() + ":" + WeaponsType.Spellbook.ToString(), new HashSet<string>()
                { "Tome", "Spellbook", "Grimoire" });


            //LEGENDARY
            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Wand.ToString(), new HashSet<string>()
                { "God's Tear", "Unicorn-Heart", "Devil's Tongue" });

            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Staff.ToString(), new HashSet<string>()
                { "Rod", "Staff" });

            itemBaseName.Add(Rarity.Legendary.ToString() + ":" + WeaponsType.Spellbook.ToString(), new HashSet<string>()
                { "Tome", "Spellbook", "Grimoire" });
        }

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
