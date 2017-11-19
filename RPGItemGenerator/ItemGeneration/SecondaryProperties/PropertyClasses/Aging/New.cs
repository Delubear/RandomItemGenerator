using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class New : SecondaryProperties
    {
        public New()
        {
            Key = 2;
            this.PropDescription = "New";
        }

        public override void Execute(Item item)
        {
            item.PrefixList.Add("New" + " ");
            item.CurrentDurability *= (int)(item.CurrentDurability *1.5);
            item.Value = (int)(item.Value *1.25);            
        }
    }
}
