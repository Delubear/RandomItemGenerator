using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Dull : SecondaryProperties
    {
        public Dull()
        {
            Key = 4;
            this.PropDescription = "Dull";
        }

        public override void Execute(Item item)
        {
            int x = r.Next(0, 2);
            if(x == 0)
            {
                item.PrefixList.Add("Dull" + " ");
            }
            else
            {
                item.SuffixList.Add(" " + "of Dullness");
            }

            item.Value = (int)(item.Value *0.85);
            if(item.ItemType == ItemTypes.Weapon)
            {
                WeaponCategory wpnType = (WeaponCategory)item.GetType().GetProperty("WeaponCat").GetValue(item);
                if (wpnType == WeaponCategory.Melee)
                {
                    int dv = (int)item.GetType().GetProperty("DamageValue").GetValue(item);
                    dv = (int)(dv * 0.85);
                    item.GetType().GetProperty("DamageValue").SetValue(item, dv);
                }                    
            }
            
        }
    }
}
