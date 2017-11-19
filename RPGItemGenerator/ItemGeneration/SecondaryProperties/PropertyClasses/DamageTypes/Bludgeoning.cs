using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Bludgeoning : SecondaryProperties
    {
        public Bludgeoning()
        {
            Key = 1;
            this.PropDescription = "Bludgeoning";
        }

        public override void Execute(Item item)
        {     
            int x = r.Next(0, 3);
            if (x == 0)
            {
                item.PrefixList.Add("Bludgeoning" + " ");
            }
            else if (x == 1)
            {
                item.PrefixList.Add("Blunt" + " ");
            }
            else
            {
                item.SuffixList.Add(" " + "of Bludgeoning");
            }

            item.Value = (int)(item.Value *1.1);
            if(item.ItemType == ItemTypes.Weapon)
            {
                item.GetType().GetProperty("DamageType").SetValue(item, DamageTypes.Bludgeoning);             
            }
            
        }
    }
}
