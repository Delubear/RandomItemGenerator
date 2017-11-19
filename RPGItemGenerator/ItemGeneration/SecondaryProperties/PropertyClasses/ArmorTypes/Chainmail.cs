using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Chainmail : SecondaryProperties
    {
        public Chainmail()
        {
            Key = 8; 
            this.PropDescription = "Chainmail";
        }
        public override void Execute(Item item)
        {
            item.PrefixDescriptorList.Add("Chainmail" + " ");            

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
