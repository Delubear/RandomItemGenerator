using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Slashing : SecondaryProperties
    {
        public Slashing()
        {
            Key = 1;
            this.PropDescription = "Slashing";
        }

        public override void Execute(Item item)
        {
            if (r.Next(0, 2) == 0)
            {
                item.PrefixList.Add("Slashing" + " ");
            }
            else
            {
                item.SuffixList.Add(" " + "of Slashing");
            }

            item.Value = (int)(item.Value *1.1);
            if(item.ItemType == ItemTypes.Weapon)
            {
                item.GetType().GetProperty("DamageType").SetValue(item, DamageTypes.Slashing);             
            }
            
        }
    }
}
