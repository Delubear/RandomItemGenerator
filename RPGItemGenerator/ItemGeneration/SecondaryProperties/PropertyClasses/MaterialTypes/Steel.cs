using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Steel : SecondaryProperties
    {
        public Steel()
        {
            Key = 9; 
            this.PropDescription = "Steel";
        }
        public override void Execute(Item item)
        {
            item.PrefixDescriptorList.Add("Steel" + " ");            

            item.Value = (int)(item.Value *1.1);

            if (item.ItemType == ItemTypes.Weapon)
            {
                WeaponCategory wpnType = (WeaponCategory)item.GetType().GetProperty("WeaponCat").GetValue(item);
                if (wpnType == WeaponCategory.Melee)
                {
                    int dv = (int)item.GetType().GetProperty("DamageValue").GetValue(item);
                    dv = (int)(dv * 1.1);
                    item.GetType().GetProperty("DamageValue").SetValue(item, dv);
                }
                else if (wpnType == WeaponCategory.Magic)
                {
                    int dv = (int)item.GetType().GetProperty("DamageValue").GetValue(item);
                    dv = (int)(dv * 1.1);
                    item.GetType().GetProperty("DamageValue").SetValue(item, dv);
                }
            }

        }
    }
}
