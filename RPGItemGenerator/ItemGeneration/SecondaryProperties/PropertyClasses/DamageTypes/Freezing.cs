using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Freezing : SecondaryProperties
    {
        public Freezing()
        {
            Key = 1;
            this.PropDescription = "Freezing";
        }

        public override void Execute(Item item)
        {
            int x = r.Next(0, 4);
            if (x == 0)
            {
                item.PrefixList.Add("Freezing" + " ");
            }
            else if (x == 1)
            {
                item.PrefixList.Add("Frost" + " ");
            }
            else if (x == 2)
            {
                item.SuffixList.Add(" " + "of Frostbite");
            }
            else
            {
                item.SuffixList.Add(" " + "of Freezing");
            }

            item.Value = (int)(item.Value *1.1);
            if(item.ItemType == ItemTypes.Weapon)
            {
                item.GetType().GetProperty("DamageType").SetValue(item, DamageTypes.Freezing);             
            }
            
        }
    }
}
