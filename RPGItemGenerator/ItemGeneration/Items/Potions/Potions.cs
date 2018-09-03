using System;
using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Potions : Item
    {
        public string Effect { get; set; } = "";

        public Potions()
        {

        }

        public Potions(Dictionary<string, HashSet<string>> itemBaseName)
        {
            ID = new Guid();
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
            ID = new Guid();
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
