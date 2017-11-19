using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Deadeye : SecondaryProperties
    {
        public Deadeye()
        {
            Key = 6;
            this.PropDescription = "Deadeye";
        }

        public override void Execute(Item item)
        {
            item.PrefixList.Add("Deadeye" + " ");
            item.Value = (int)(item.Value *1.1);
            if(item.ItemType == ItemTypes.Weapon)
            {
                WeaponCategory wpnType = (WeaponCategory)item.GetType().GetProperty("WeaponCat").GetValue(item);
                if(wpnType == WeaponCategory.Ranged)
                {
                    int dv = (int)item.GetType().GetProperty("DamageValue").GetValue(item);
                    dv = (int)(dv * 1.1);
                    item.GetType().GetProperty("DamageValue").SetValue(item, dv);
                }                
            }
            
        }
    }
}
