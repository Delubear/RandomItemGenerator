using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Obsidian : SecondaryProperties
    {
        public Obsidian()
        {
            Key = 9; 
            this.PropDescription = "Obsidian";
        }
        public override void Execute(Item item)
        {
            item.PrefixDescriptorList.Add("Obsidian" + " ");            

            item.Value = (int)(item.Value *1.4);

            if (item.ItemType == ItemTypes.Weapon)
            {
                WeaponCategory wpnType = (WeaponCategory)item.GetType().GetProperty("WeaponCat").GetValue(item);
                if (wpnType == WeaponCategory.Melee)
                {
                    int dv = (int)item.GetType().GetProperty("DamageValue").GetValue(item);
                    dv = (int)(dv * 1.4);
                    item.GetType().GetProperty("DamageValue").SetValue(item, dv);
                }
                else if (wpnType == WeaponCategory.Magic)
                {
                    int dv = (int)item.GetType().GetProperty("DamageValue").GetValue(item);
                    dv = (int)(dv * 1.4);
                    item.GetType().GetProperty("DamageValue").SetValue(item, dv);
                }
            }
            if(item.ItemType == ItemTypes.Armor)
            {
                ArmorTypes armType = (ArmorTypes)item.GetType().GetProperty("ArmorType").GetValue(item);
                if(armType == ArmorTypes.Shield)
                {
                    int dv = (int)item.GetType().GetProperty("ArmorValue").GetValue(item);
                    dv = (int)(dv * 1.4);
                    item.GetType().GetProperty("ArmorValue").SetValue(item, dv);
                }
            }

        }
    }
}
