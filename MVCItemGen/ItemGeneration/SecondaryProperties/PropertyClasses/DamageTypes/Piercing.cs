using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Piercing : SecondaryProperties
    {
        public Piercing()
        {
            Key = 1;
            this.PropDescription = "Piercing";
        }

        public override void Execute(BaseItemModel item)
        {
            if (r.Next(0, 2) == 0)
            {
                item.PrefixList.Add("Piercing" + " ");
            }
            else
            {
                item.SuffixList.Add(" " + "of Piercing");
            }

            item.Value = (int)(item.Value *1.1);
            if(item.ItemType == ItemTypes.Weapon)
            {
                item.GetType().GetProperty("DamageType").SetValue(item, DamageTypes.Piercing);             
            }
            
        }
    }
}
