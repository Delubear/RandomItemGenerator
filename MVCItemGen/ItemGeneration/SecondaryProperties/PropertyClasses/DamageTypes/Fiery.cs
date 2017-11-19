using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Fiery : SecondaryProperties
    {
        public Fiery()
        {
            Key = 1;
            this.PropDescription = "Fiery";
        }

        public override void Execute(BaseItemModel item)
        {
            int x = r.Next(0, 3);
            if (x == 0)
            {
                item.PrefixList.Add("Flaming" + " ");
            }
            else if (x == 1)
            {
                item.PrefixList.Add("Fiery" + " ");
            }
            else
            {
                item.SuffixList.Add(" " + "of Flame");
            }

            item.Value = (int)(item.Value *1.1);
            if(item.ItemType == ItemTypes.Weapon)
            {
                item.GetType().GetProperty("DamageType").SetValue(item, DamageTypes.Flaming);             
            }
            
        }
    }
}
