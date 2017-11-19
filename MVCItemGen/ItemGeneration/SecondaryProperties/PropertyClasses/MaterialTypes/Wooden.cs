using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Wooden : SecondaryProperties
    {
        public Wooden()
        {
            Key = 9; 
            this.PropDescription = "Wooden";
        }
        public override void Execute(BaseItemModel item)
        {
            item.PrefixDescriptorList.Add("Wooden" + " ");            

            item.Value = (int)(item.Value *0.9);

            if (item.ItemType == ItemTypes.Weapon)
            {
                WeaponCategory wpnType = (WeaponCategory)item.GetType().GetProperty("WeaponCat").GetValue(item);
                if (wpnType == WeaponCategory.Melee)
                {
                    int dv = (int)item.GetType().GetProperty("DamageValue").GetValue(item);
                    dv = (int)(dv * 0.6);
                    item.GetType().GetProperty("DamageValue").SetValue(item, dv);
                }                    
            }

        }
    }
}
