using System;
using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class Weapons : Item
    {
        private int _damageValue;
        public int DamageValue
        {
            get { return _damageValue; }
            set { _damageValue = value; }
        }

        private DamageTypes _damageType;
        public DamageTypes DamageType
        {
            get { return _damageType; }
            set { _damageType = value; }
        }

        private WeaponsType _weaponType;
        public WeaponsType WeaponType
        {
            get { return _weaponType; }
            set { _weaponType = value; }
        }

        private WeaponCategory _weaponCat;
        public WeaponCategory WeaponCat
        {
            get { return _weaponCat; }
            set { _weaponCat = value; }
        }

        private double _accuracy;
        public double Accuracy
        {
            get { return _accuracy; }
            set { _accuracy = value; }
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
    }
}