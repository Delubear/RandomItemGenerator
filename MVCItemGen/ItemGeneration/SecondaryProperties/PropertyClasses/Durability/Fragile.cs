using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Fragile : SecondaryProperties
    {
        public Fragile()
        {
            Key = 3;
            this.PropDescription = "Fragile";
        }

        public override void Execute(BaseItemModel item)
        {
            int x = r.Next(0, 2);
            if(x == 0)
            {
                item.PrefixList.Add("Fragile" + " ");
            }
            else
            {
                item.SuffixList.Add(" " + "of Frailty");
            }

            item.MaxDurability *= (int)(item.MaxDurability * 0.75);
            item.CurrentDurability *= (int)(item.CurrentDurability * 0.75);
            item.Value = (int)(item.Value *0.85);

            if(item.ItemType == ItemTypes.Armor)
            {
                int dv = (int)item.GetType().GetProperty("ArmorValue").GetValue(item);
                dv = (int)(dv * 0.85);
                item.GetType().GetProperty("ArmorValue").SetValue(item, dv);
            }
            
        }
    }
}
