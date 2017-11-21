using System;
using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class Armor : Item
    {
        private int _armorValue;
        public int ArmorValue
        {
            get { return _armorValue; }
            set { _armorValue = value; }
        }

        private ArmorTypes _armorType;
        public ArmorTypes ArmorType
        {
            get { return _armorType; }
            set { _armorType = value; }
        }

        public Armor(Dictionary<string, HashSet<string>> itemBaseName)
        {
            ID = new Guid();
            this.ItemBaseNames = itemBaseName;
            Rarity = GetRarity();
            ItemType = ItemTypes.Armor;
            ArmorType = (ArmorTypes)(r.Next(0, Enum.GetValues(typeof(ArmorTypes)).Length));                                  
            Value = GetNewValue();
            ArmorValue = GetNewArmorValue();
            GetDurability();
            GetNewSecondaryProperty(this);
            Name = GetNewName();
            Description = GetNewDescription();
        }

        public Armor(Dictionary<string, HashSet<string>> itemBaseName , Rarity rare)
        {
            ID = new Guid();
            this.ItemBaseNames = itemBaseName;
            Rarity = rare;
            ItemType = ItemTypes.Armor;
            ArmorType = (ArmorTypes)(r.Next(0, Enum.GetValues(typeof(ArmorTypes)).Length));
            Value = GetNewValue();
            ArmorValue = GetNewArmorValue();
            GetDurability();
            GetNewSecondaryProperty(this);
            Name = GetNewName();
            Description = GetNewDescription();
        }
    }
}