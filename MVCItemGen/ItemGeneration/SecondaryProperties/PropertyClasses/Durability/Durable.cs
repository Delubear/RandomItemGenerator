using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Durable : SecondaryProperties
    {
        public Durable()
        {
            Key = 3;
            this.PropDescription = "Durable";
        }

        public override void Execute(BaseItemModel item)
        {
            item.PrefixList.Add("Durable" + " ");
            item.MaxDurability *= (int)(item.MaxDurability * 1.3);
            item.CurrentDurability *= (int)(item.CurrentDurability * 1.3);
            item.Value = (int)(item.Value *1.1);
            if(item.ItemType == ItemTypes.Armor)
            {
                int dv = (int)item.GetType().GetProperty("ArmorValue").GetValue(item);
                dv = (int)(dv * 1.1);
                item.GetType().GetProperty("ArmorValue").SetValue(item, dv);
            }
            
        }
    }
}
