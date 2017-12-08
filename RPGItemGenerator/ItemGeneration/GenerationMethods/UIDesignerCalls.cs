using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration.GenerationMethods
{
    public class UIDesignerCalls
    {
        public Dictionary<string, HashSet<string>> itemBaseName = new Dictionary<string, HashSet<string>>();
        public Item GenerateItemFromForm(string input)
        {
            itemBaseName = new BaseNames(itemBaseName).itemBaseName;
            string[] seperatedResults = input.Split(';');

            Rarity rarity = (Rarity)Enum.Parse(typeof(Rarity),seperatedResults[0]);           
                 
            
            if(seperatedResults[1] == "Weapon")
            {
                WeaponCategory wCat = (WeaponCategory)Enum.Parse(typeof(WeaponCategory), seperatedResults[2]);
                WeaponsType wType = (WeaponsType)Enum.Parse(typeof(WeaponsType), seperatedResults[3]);
                return new Weapons(itemBaseName, rarity, wCat, wType);
            }
            else if(seperatedResults[1] == "Armor")
            {
                ArmorTypes aType = (ArmorTypes)Enum.Parse(typeof(ArmorTypes), seperatedResults[2]);
                return new Armor(itemBaseName, rarity, aType);
            }
            else if(seperatedResults[1] == "Potion")
            {
                return new Potions(itemBaseName, rarity);
            }
            else if (seperatedResults[1] == "Jewelry")
            {
                JewelryType jType = (JewelryType)Enum.Parse(typeof(JewelryType), seperatedResults[2]);
                return new Jewelry(itemBaseName, rarity, jType);
            }
            return new Weapons();
        }
    }
}
