using System;
using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class Weapons : Item
    {
        private void GetWeaponTypes()
        {
            WeaponCat = (WeaponCategory)(r.Next(0, Enum.GetValues(typeof(WeaponCategory)).Length));
            if (WeaponCat == WeaponCategory.Melee)
            {
                WeaponType = (WeaponsType)(r.Next(0, 2));
            }
            else if (WeaponCat == WeaponCategory.Ranged)
            {
                WeaponType = (WeaponsType)(r.Next(6, 7));
            }
            else
            {
                WeaponType = (WeaponsType)(r.Next(3, 5));
            }
        }


        public int DamageValue { get; set; }
        public DamageTypes DamageType { get; set; }
        public WeaponsType WeaponType { get; set; }
        public WeaponCategory WeaponCat { get; set; }
        public double Accuracy { get; set; }

        public Weapons()
            {

            }

            public Weapons(Dictionary<string, HashSet<string>> itemBaseName)
            {
                ID = new Guid();
                this.ItemBaseNames = itemBaseName;
                Rarity = GetRarity();
                ItemType = ItemTypes.Weapon;
                GetWeaponTypes();
                GenerateAccuracy();
                GetDamageTypes();  //Needs to run before Secondary Prop generation so the properties can overwrite
                Value = GetNewValue();  //Needs to run before Secondary Prop generation so the properties can adjust
                DamageValue = GetNewDamageValue();//Needs to run before Secondary Prop generation so the properties can adjust            
                GetDurability();
                GetNewSecondaryProperty(this);
                Name = GetNewName();  //Needs to run after SecondaryProperties
                Description = GetNewDescription();
            }

            public Weapons(Dictionary<string, HashSet<string>> itemBaseName, Rarity rare)
            {
                ID = new Guid();
                this.ItemBaseNames = itemBaseName;
                Rarity = rare;
                ItemType = ItemTypes.Weapon;
                GetWeaponTypes();
                GenerateAccuracy();
                GetDamageTypes();
                Value = GetNewValue();
                DamageValue = GetNewDamageValue();
                GetDurability();
                GetNewSecondaryProperty(this);
                Name = GetNewName();
                Description = GetNewDescription();
            }

            public Weapons(Dictionary<string, HashSet<string>> itemBaseName, Rarity rare, WeaponCategory wCat, WeaponsType wType)
            {
                ID = new Guid();
                this.ItemBaseNames = itemBaseName;
                Rarity = rare;
                ItemType = ItemTypes.Weapon;
                WeaponCat = wCat;
                WeaponType = wType;
                GenerateAccuracy();
                GetDamageTypes();
                Value = GetNewValue();
                DamageValue = GetNewDamageValue();
                GetDurability();
                GetNewSecondaryProperty(this);
                Name = GetNewName();
                Description = GetNewDescription();
            }

            private int GetNewDamageValue()
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
            if (x < 1)
            {
                x = 1;
            }
            return x;
        }

        private void GetDamageTypes()
        {
            switch (WeaponType)
            {
                case WeaponsType.Bow:
                    DamageType = DamageTypes.Piercing;
                    break;
                case WeaponsType.Crossbow:
                    DamageType = DamageTypes.Piercing;
                    break;
                case WeaponsType.Dagger:
                    if (r.Next(0, 2) == 0)
                    {
                        DamageType = DamageTypes.Slashing;
                    }
                    else
                    {
                        DamageType = DamageTypes.Piercing;
                    }
                    break;
                case WeaponsType.Sword:
                    if (r.Next(0, 2) == 0)
                    {
                        DamageType = DamageTypes.Slashing;
                    }
                    else
                    {
                        DamageType = DamageTypes.Piercing;
                    }
                    break;
                case WeaponsType.Spear:
                    DamageType = DamageTypes.Piercing;
                    break;
                case WeaponsType.Wand:
                    DamageType = (DamageTypes)(r.Next(0, Enum.GetValues(typeof(DamageTypes)).Length));
                    break;
                case WeaponsType.Staff:
                    DamageType = (DamageTypes)(r.Next(0, Enum.GetValues(typeof(DamageTypes)).Length));
                    break;
                case WeaponsType.Spellbook:
                    DamageType = (DamageTypes)(r.Next(0, Enum.GetValues(typeof(DamageTypes)).Length));
                    break;
            }
        }

        private void GenerateAccuracy()
        {
            switch (Rarity)
            {
                case Rarity.Common:
                    Accuracy = Math.Round(GetNewGaussianCurve(0.6, 0.2), 2);
                    break;
                case Rarity.Uncommon:
                    Accuracy = Math.Round(GetNewGaussianCurve(0.7, 0.1), 2);
                    break;
                case Rarity.Rare:
                    Accuracy = Math.Round(GetNewGaussianCurve(0.8, 0.1), 2);
                    break;
                case Rarity.Epic:
                    Accuracy = Math.Round(GetNewGaussianCurve(0.8, 0.2), 2);
                    break;
                case Rarity.Legendary:
                    Accuracy = Math.Round(GetNewGaussianCurve(0.9, 0.2), 2);
                    break;
            }

            if(Accuracy > 1)
            {
                Accuracy = 1;
            }
            else if(Accuracy < 0.1)
            {
                Accuracy = 0.1;
            }
        }        
    }
}