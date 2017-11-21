using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public abstract partial class Item
    {
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
                if(value != null && value != string.Empty)
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

        private string _baseName;
        public string BaseName
        {
            get { return _baseName; }
            set { _baseName = value; }
        }


        public List<string> PrefixList = new List<string>() { "" };
        private string _prefix;
        public string Prefix
        {
            get { return _prefix; }
            set { _prefix = value; }
        }

        public List<string> PrefixDescriptorList = new List<string>() { "" };
        private string _prefixDescriptor;
        public string PrefixDescriptor
        {
            get { return _prefixDescriptor; }
            set { _prefixDescriptor = value; }
        }


        public List<string> SuffixList = new List<string>() { "" };
        private string _suffix;
        public string Suffix
        {
            get { return _suffix; }
            set { _suffix = value; }
        }

        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                if(value < 1) { value = 1; }
                _value = value;
            }
        }

        private Rarity _rarity;
        public Rarity Rarity
        {
            get { return _rarity; }
            set { _rarity = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private ItemTypes _itemType;
        public ItemTypes ItemType
        {
            get { return _itemType; }
            set { _itemType = value; }
        }

        private int _maxDurability;
        public int MaxDurability
        {
            get { return _maxDurability; }
            set { _maxDurability = value; }
        }

        private int _currentDurability;
        public int CurrentDurability
        {
            get { return _currentDurability; }
            set
            {
                if(value > MaxDurability)
                {
                    value = MaxDurability;
                }
                _currentDurability = value;
            }
        }

        protected static Random r = new Random();
        public Dictionary<int, SecondaryProperties> SecondaryProps = new Dictionary<int, SecondaryProperties>();
    }
}
