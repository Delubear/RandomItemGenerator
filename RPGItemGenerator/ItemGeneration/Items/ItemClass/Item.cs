using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public abstract class Item
    {
        private string GetNewBaseName()
        {
            string typeOfName = GetTypeOf(this);
            HashSet<string> _name = ItemBaseNames[Rarity.ToString() + ":" + typeOfName];
            return _name.ElementAt(r.Next(0, _name.Count()));
        }

        protected int GetNewValue()
        {
            double median = 0;
            double deviation = 0;

            switch (Rarity)
            {
                case Rarity.Common:
                    median = 15;
                    deviation = 9;
                    break;
                case Rarity.Uncommon:
                    median = 45;
                    deviation = 15;
                    break;
                case Rarity.Rare:
                    median = 95;
                    deviation = 25;
                    break;
                case Rarity.Epic:
                    median = 150;
                    deviation = 50;
                    break;
                case Rarity.Legendary:
                    median = 500;
                    deviation = 200;
                    break;
            }

            int x = (int)GetNewGaussianCurve(median, deviation);
            if (x < 0) { x = 0; }
            return x;
        }

        protected void AdjustValueBasedOnDurability()
        {
            Value = (int)(((double)CurrentDurability / (double)MaxDurability) * Value);
        }

        protected string GetNewName()
        {
            string result = "";
            BaseName = "";
            Prefix = "";
            PrefixDescriptor = "";

            int x = (int)GetNewGaussianCurve(PrefixList.Count() / 2, PrefixList.Count() / 4);
            if (x < 0) { x = 0; }
            x += (int)GetNewGaussianCurve(Convert.ToDouble(Rarity), 0.25);
            for (int i = 0; i < x; i++)
            {
                if (PrefixList.Count() > 0)
                {
                    int y = r.Next(0, PrefixList.Count());
                    Prefix += PrefixList.ElementAt(y);
                    PrefixList.RemoveAt(y);
                }
            }
            if (PrefixDescriptorList.Count() > 0)
            {
                int y = r.Next(0, PrefixDescriptorList.Count());
                PrefixDescriptor = PrefixDescriptorList.ElementAt(y);
            }

            Suffix = SuffixList.ElementAt(r.Next(0, SuffixList.Count()));
            BaseName = GetNewBaseName();
            result = Prefix + PrefixDescriptor + BaseName + Suffix;
            return result;
        }

        private string GetTypeOf(Item item)
        {
            string type = "";

            if (ItemType == ItemTypes.Weapon)
            {
                var wpnType = item.GetType().GetProperty("WeaponType").GetValue(item);
                type = wpnType.ToString();
            }
            else if (ItemType == ItemTypes.Armor)
            {
                var armType = item.GetType().GetProperty("ArmorType").GetValue(item);
                type = armType.ToString();
            }
            else if (ItemType == ItemTypes.Jewelry)
            {
                var jewelryType = item.GetType().GetProperty("JewelryType").GetValue(item);
                type = jewelryType.ToString();
            }
            else
            {
                type = item.GetType().GetProperty("ItemType").GetValue(item).ToString();
            }

            return type;
        }

        protected double GetNewGaussianCurve(double median = 0, double deviation = 1)
        {
            return r.NextGaussian(median, deviation);
        }

        protected Rarity GetRarity()
        {
            int x = (int)GetNewGaussianCurve(0, 1.75);
            if (x < 0) { x = 0; }
            else if (x > 4) { x = 4; }
            return (Rarity)x;
        }

        private void GetPropertys(int number, Item itm)
        {
            string typeOfName = GetTypeOf(itm);
            var propertyCreator = new SecondaryPropertiesList().SecondaryPropertiesSet[Rarity.ToString() + ":" + typeOfName];

            for (int i = 0; i < number; i++)
            {
                if (propertyCreator.Count() >= 1)
                {
                    var pc = propertyCreator.ElementAt(r.Next(0, propertyCreator.Count()));
                    propertyCreator.Remove(pc.Key);

                    Type type = Type.GetType("RPGItemGenerator.ItemGeneration." + pc.Key);
                    var newProp = (SecondaryProperties)Activator.CreateInstance(type);

                    if (!SecondaryProps.ContainsKey(pc.Value))
                        SecondaryProps.Add(pc.Value, newProp);

                    var temp = propertyCreator.Where(m => m.Value == pc.Value).ToList();
                    foreach (var tmp in temp)
                    {
                        propertyCreator.Remove(tmp.Key);
                    }
                }
            }
        }

        protected void GetNewSecondaryProperty(Item itm)
        {
            int x = CalculateNumberOfProperties();
            GetPropertys(x, itm);

            foreach (var p in SecondaryProps.Values)
            {
                p.Execute(this);
            }
        }

        private int CalculateNumberOfProperties()
        {
            double median = 0;
            double deviation = 0;

            switch (Rarity)
            {
                case Rarity.Common:
                    median = 1;
                    deviation = 1;
                    break;
                case Rarity.Uncommon:
                    median = 2;
                    deviation = 1;
                    break;
                case Rarity.Rare:
                    median = 2;
                    deviation = 2;
                    break;
                case Rarity.Epic:
                    median = 3;
                    deviation = 1;
                    break;
                case Rarity.Legendary:
                    median = 4;
                    deviation = 1;
                    break;
            }

            int x = (int)GetNewGaussianCurve(median, deviation);
            if (x < 0) { x = 0; }
            return x;
        }

        protected Dictionary<string, HashSet<string>> ItemBaseNames;

        [Key]
        private Guid Id;
        public Guid ID
        {
            get { return Id; }
            set { Id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value != string.Empty)
                {
                    _name = value;
                }
                else if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty.", Name);
                }
            }
        }

        public string BaseName
        {
            get { return BaseName1; }
            set { BaseName1 = value; }
        }

        public List<string> PrefixList = new List<string>() { "" };
        public string Prefix { get; set; }

        public List<string> PrefixDescriptorList = new List<string>() { "" };
        public string PrefixDescriptor { get; set; }


        public List<string> SuffixList = new List<string>() { "" };
        public string Suffix { get; set; }

        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                if (value < 1) { value = 1; }
                _value = value;
            }
        }
        public Rarity Rarity { get; set; }
        public string Description { get; set; }
        public ItemTypes ItemType { get; set; }
        public int MaxDurability { get; set; }

        private int _currentDurability;
        public int CurrentDurability
        {
            get { return _currentDurability; }
            set
            {
                if (value > MaxDurability)
                {
                    value = MaxDurability;
                }
                _currentDurability = value;
            }
        }

        public string BaseName1 { get; set; }

        protected static Random r = new Random();
        public Dictionary<int, SecondaryProperties> SecondaryProps = new Dictionary<int, SecondaryProperties>();

        protected void GetDurability()
        {
            double median = 0;
            double deviation = 0;

            switch (Rarity)
            {
                case Rarity.Common:
                    median = 50;
                    deviation = 5;
                    break;
                case Rarity.Uncommon:
                    median = 75;
                    deviation = 10;
                    break;
                case Rarity.Rare:
                    median = 100;
                    deviation = 15;
                    break;
                case Rarity.Epic:
                    median = 125;
                    deviation = 20;
                    break;
                case Rarity.Legendary:
                    median = 150;
                    deviation = 25;
                    break;
            }

            int x = (int)GetNewGaussianCurve(median, deviation);
            if (x < 15)
            {
                x = 15;
            }

            MaxDurability = x;

            int _rarityModifier = (int)Rarity;
            if (_rarityModifier == 0) { _rarityModifier = 1; }

            double y = GetNewGaussianCurve((MaxDurability / 2), (MaxDurability / 5));
            y = GetNewGaussianCurve(y, (int)Rarity * 0.1);

            if (y < 1)
            {
                y = 1;
            }

            CurrentDurability = (int)y;
            AdjustValueBasedOnDurability();
        }

        StringBuilder sb = new StringBuilder();
        protected string GetNewDescription()
        {
            SetDescAdjectives();            
            sb.Append(BaseName);
            sb.Append(" ");
            SetDescEnding();

            return sb.ToString();            
        }

        private void SetDescEnding()
        {
            if (Value < 10)
                sb.Append("made from poor materials.");
            else if (Value < 50)
                sb.Append("marked with quality stamps of approval.");
            else if (Value < 100)
                sb.Append("set with sparkling gemstones.");
            else
                sb.Append("coated in gold and gems.  Truly a symbol of wealth and power.");
        }

        private void SetDescAdjectives()
        {
            int x = r.Next(0,3);
            string dt = " ";
            if(x == 1)
            {
                if(ItemType == ItemTypes.Weapon)
                {
                    dt += this.GetType().GetProperty("DamageType").GetValue(this).ToString() + " ";
                }                
            }            
            sb.Append("A" + dt);                                      
        }
    }
}
