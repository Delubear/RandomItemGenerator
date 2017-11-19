using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Ancient : SecondaryProperties
    {
        public Ancient()
        {
            Key = 2;
            this.PropDescription = "Ancient";
        }

        public override void Execute(BaseItemModel item)
        {
            item.PrefixList.Add("Ancient" + " ");
            item.CurrentDurability *= (int)(item.CurrentDurability * 0.7);
            item.Value = (int)(item.Value *1.25);

            if (item.ItemType == ItemTypes.Weapon)
            {
                WeaponCategory wpnType = (WeaponCategory)item.GetType().GetProperty("WeaponCat").GetValue(item);
                if (wpnType == WeaponCategory.Magic)
                {
                    int dv = (int)item.GetType().GetProperty("DamageValue").GetValue(item);
                    dv = (int)(dv * 1.2);
                    item.GetType().GetProperty("DamageValue").SetValue(item, dv);
                }
            }
        }
    }
}
