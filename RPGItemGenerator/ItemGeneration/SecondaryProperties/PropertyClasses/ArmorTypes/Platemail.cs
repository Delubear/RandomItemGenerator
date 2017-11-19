using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Platemail : SecondaryProperties
    {
        public Platemail()
        {
            Key = 8;  
            this.PropDescription = "Platemail";
        }
        public override void Execute(Item item)
        {
            item.PrefixDescriptorList.Add("Platemail" + " ");            

            item.Value = (int)(item.Value *1.3);

            if (item.ItemType == ItemTypes.Armor)
            {
                int dv = (int)item.GetType().GetProperty("ArmorValue").GetValue(item);
                dv = (int)(dv * 1.3);
                item.GetType().GetProperty("ArmorValue").SetValue(item, dv);
            }

        }
    }
}
