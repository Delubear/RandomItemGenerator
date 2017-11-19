using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Leather : SecondaryProperties
    {
        public Leather()
        {
            Key = 8; 
            this.PropDescription = "Leather";
        }
        public override void Execute(BaseItemModel item)
        {
            item.PrefixDescriptorList.Add("Leather" + " ");            

            item.Value = (int)(item.Value *1.2);

            if (item.ItemType == ItemTypes.Armor)
            {
                int dv = (int)item.GetType().GetProperty("ArmorValue").GetValue(item);
                dv = (int)(dv * 1.2);
                item.GetType().GetProperty("ArmorValue").SetValue(item, dv);
            }

        }
    }
}
