using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Focusing : SecondaryProperties
    {
        public Focusing()
        {
            Key = 5;
            this.PropDescription = "Focusing";
        }

        public override void Execute(Item item)
        {
            int x = r.Next(0, 2);
            if(x == 0)
            {
                item.SuffixList.Add(" " + "of Focusing");
            }
            else
            {
                item.PrefixList.Add("Focusing" + " ");
            }
            
            item.Value = (int)(item.Value *1.1);
            if(item.ItemType == ItemTypes.Weapon)
            {
                WeaponCategory wpnType = (WeaponCategory)item.GetType().GetProperty("WeaponCat").GetValue(item);
                if(wpnType == WeaponCategory.Magic)
                {
                    int dv = (int)item.GetType().GetProperty("DamageValue").GetValue(item);
                    dv = (int)(dv * 1.1);
                    item.GetType().GetProperty("DamageValue").SetValue(item, dv);
                }                
            }
            else if(item.ItemType == ItemTypes.Potion)
            {
                var currentEffectString = item.GetType().GetProperty("Effect").GetValue(item).ToString();
                var newEffectString = currentEffectString += "+Focus "; 
                item.GetType().GetProperty("Effect").SetValue(item, newEffectString);
            }
            
        }
    }
}
