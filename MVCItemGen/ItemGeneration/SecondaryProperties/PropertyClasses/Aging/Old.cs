using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Old : SecondaryProperties
    {
        public Old()
        {
            Key = 2;
            this.PropDescription = "Old";
        }

        public override void Execute(BaseItemModel item)
        {
            item.PrefixList.Add("Old" + " ");
            item.CurrentDurability *= (int)(item.CurrentDurability * 0.75);
            item.Value = (int)(item.Value *0.85);            
        }
    }
}
