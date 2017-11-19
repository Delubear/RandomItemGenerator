using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Unbreakable : SecondaryProperties
    {
        public Unbreakable()
        {
            Key = 3;
            this.PropDescription = "Unbreakable";
        }

        public override void Execute(Item item)
        {
            item.PrefixList.Add("Unbreakable" + " ");
            item.MaxDurability = (int)(item.MaxDurability * 2);
            item.CurrentDurability = (int)(item.CurrentDurability * 2);
            item.Value = (int)(item.Value *1.7);
            if(item.ItemType == ItemTypes.Armor)
            {
                int dv = (int)item.GetType().GetProperty("ArmorValue").GetValue(item);
                dv = (int)(dv * 1.75);
                item.GetType().GetProperty("ArmorValue").SetValue(item, dv);
            }
            
        }
    }
}
