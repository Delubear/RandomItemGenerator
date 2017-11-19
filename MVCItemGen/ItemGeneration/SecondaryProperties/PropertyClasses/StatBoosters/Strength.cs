using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Strength : SecondaryProperties
    {
        public Strength()
        {
            Key = 7;
            this.PropDescription = "Strength";
        }

        public override void Execute(BaseItemModel item)
        {
            int x = r.Next(0, 3);
            if(x == 0)
            {
                item.SuffixList.Add(" " + "of the Mule");
            }
            else if (x == 1)
            {
                item.SuffixList.Add(" " + "of Strength");
            }
            else
            {
                item.PrefixList.Add("Strengthening" + " ");
            }
            
            item.Value = (int)(item.Value *1.1);
            if(item.ItemType == ItemTypes.Weapon)
            {
                WeaponCategory wpnType = (WeaponCategory)item.GetType().GetProperty("WeaponCat").GetValue(item);
                if(wpnType == WeaponCategory.Melee)
                {
                    int dv = (int)item.GetType().GetProperty("DamageValue").GetValue(item);
                    dv = (int)(dv * 1.1);
                    item.GetType().GetProperty("DamageValue").SetValue(item, dv);
                }                
            }
            else if (item.ItemType == ItemTypes.Potion)
            {
                var currentEffectString = item.GetType().GetProperty("Effect").GetValue(item).ToString();
                var newEffectString = currentEffectString += "+Strength ";
                item.GetType().GetProperty("Effect").SetValue(item, newEffectString);
            }

        }
    }
}
