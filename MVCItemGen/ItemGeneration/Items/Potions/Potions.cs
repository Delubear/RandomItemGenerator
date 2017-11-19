using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Potions : BaseItemModel
    {
        private string _effect = "Effect: ";
        public string Effect
        {
            get { return _effect; }
            set { _effect = value; }
        }


        public Potions(Dictionary<string, HashSet<string>> itemBaseName)
        {
            this.ItemBaseNames = itemBaseName;
            Rarity = GetRarity();
            ItemType = ItemTypes.Potion;
            Value = GetNewValue();
            GetDurability();
            GetNewSecondaryProperty(this);
            Name = GetNewName();
            Description = GetNewDescription();            
        }

        public Potions(Dictionary<string, HashSet<string>> itemBaseName, Rarity rare)
        {
            this.ItemBaseNames = itemBaseName;
            Rarity = rare;
            ItemType = ItemTypes.Potion;
            Value = GetNewValue();
            GetDurability();
            GetNewSecondaryProperty(this);
            Name = GetNewName();
            Description = GetNewDescription();
        }
    }
}
