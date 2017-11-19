using System;

namespace RPGItemGenerator.ItemGeneration
{
    public abstract class SecondaryProperties : Item
    {
        public int Key;

        private string _propDescription;
        public string PropDescription
        {
            get { return _propDescription; }
            set { _propDescription = value; }
        }

        public virtual void Execute(Item item)
        {
        }
    }
}
