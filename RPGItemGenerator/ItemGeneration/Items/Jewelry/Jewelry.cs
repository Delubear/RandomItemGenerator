using System;
using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Jewelry : Item
    {
        public string Effect { get; set; } = "";
        public JewelryType JewelryType { get; set; }

        public Jewelry()
        {

        }

        public Jewelry(Dictionary<string, HashSet<string>> itemBaseName)
        {
            ID = new Guid();
            this.ItemBaseNames = itemBaseName;
            Rarity = GetRarity();
            ItemType = ItemTypes.Jewelry;
            GetJewelryType();
            Value = GetNewValue();    
            GetDurability();                     
            GetNewSecondaryProperty(this);
            Name = GetNewName();  
            Description = GetNewDescription();
        }

        public Jewelry(Dictionary<string, HashSet<string>> itemBaseName, Rarity rare)
        {
            ID = new Guid();
            this.ItemBaseNames = itemBaseName;
            Rarity = rare;
            ItemType = ItemTypes.Jewelry;
            GetJewelryType();
            Value = GetNewValue();
            GetDurability();
            GetNewSecondaryProperty(this);
            Name = GetNewName();
            Description = GetNewDescription();
        }

        public Jewelry(Dictionary<string, HashSet<string>> itemBaseName, Rarity rare, JewelryType jType)
        {
            ID = new Guid();
            this.ItemBaseNames = itemBaseName;
            Rarity = rare;
            ItemType = ItemTypes.Jewelry;
            JewelryType = jType;
            Value = GetNewValue();
            GetDurability();
            GetNewSecondaryProperty(this);
            Name = GetNewName();
            Description = GetNewDescription();
        }

        private void GetJewelryType()
        {
            JewelryType = (JewelryType)r.Next(0, Enum.GetValues(typeof(JewelryType)).Length);
        }
    }
}