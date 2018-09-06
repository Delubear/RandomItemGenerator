using System;
using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class Armor : Item
    {
        public int ArmorValue { get; set; }
        public ArmorTypes ArmorType { get; set; }

        public Armor()
        {
        }

        private int GetNewArmorValue()
        {
            double median = 0;
            double deviation = 0;

            switch (Rarity)
            {
                case Rarity.Common:
                    median = 5;
                    deviation = 2;
                    break;
                case Rarity.Uncommon:
                    median = 10;
                    deviation = 5;
                    break;
                case Rarity.Rare:
                    median = 20;
                    deviation = 7;
                    break;
                case Rarity.Epic:
                    median = 40;
                    deviation = 15;
                    break;
                case Rarity.Legendary:
                    median = 90;
                    deviation = 25;
                    break;
            }

            int x = (int)GetNewGaussianCurve(median, deviation);
            if (x < 1) { x = 1; }
            return x;
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

        public Armor(Dictionary<string, HashSet<string>> itemBaseName, Rarity rare, ArmorTypes armorType)
        {
            ID = new Guid();
            this.ItemBaseNames = itemBaseName;
            Rarity = rare;
            ItemType = ItemTypes.Armor;
            ArmorType = armorType;
            Value = GetNewValue();
            ArmorValue = GetNewArmorValue();
            GetDurability();
            GetNewSecondaryProperty(this);
            Name = GetNewName();
            Description = GetNewDescription();
        }
    }
}