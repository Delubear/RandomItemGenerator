namespace RPGItemGenerator.ItemGeneration
{
    public abstract class SecondaryProperties : Item
    {
        public int Key;
        public string PropDescription { get; set; }

        public virtual void Execute(Item item)
        {
        }
    }
}
