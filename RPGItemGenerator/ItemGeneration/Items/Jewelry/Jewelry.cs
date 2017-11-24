using System;
using System.Collections.Generic;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class Jewelry : Item
    {
        private string _effect = "";
        public string Effect
        {
            get { return _effect; }
            set { _effect = value; }
        }

        private JewelryType _jewelryType;
        public JewelryType JewelryType
        {
            get { return _jewelryType; }
            set { _jewelryType = value; }
        }        

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

        private void GetJewelryType()
        {
            JewelryType = (JewelryType)r.Next(0, Enum.GetValues(typeof(JewelryType)).Length);
        }
    }
}