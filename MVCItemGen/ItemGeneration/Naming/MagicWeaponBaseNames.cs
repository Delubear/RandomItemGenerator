using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class BaseNames
    {
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
    }
}
