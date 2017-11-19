using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Horned : SecondaryProperties
    {
        public Horned()
        {
            Key = 8; 
            this.PropDescription = "Horned";
        }
        public override void Execute(Item item)
        {
            item.PrefixDescriptorList.Add("Horned" + " ");            

            item.Value = (int)(item.Value *1.1);

            if (item.ItemType == ItemTypes.Armor)
            {
                int dv = (int)item.GetType().GetProperty("ArmorValue").GetValue(item);
                dv = (int)(dv * 1.1);
                item.GetType().GetProperty("ArmorValue").SetValue(item, dv);
            }

        }
    }
}
