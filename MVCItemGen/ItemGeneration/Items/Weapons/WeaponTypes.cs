using System;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class Weapons : BaseItemModel
    {
        private void GetWeaponTypes()
        {
            WeaponCat = (WeaponCategory)(r.Next(0, Enum.GetValues(typeof(WeaponCategory)).Length));
            if (WeaponCat == WeaponCategory.Melee)
            {
                WeaponType = (WeaponsType)(r.Next(0, 2));
            }
            else if (WeaponCat == WeaponCategory.Ranged)
            {
                WeaponType = (WeaponsType)(r.Next(6, 7));
            }
            else
            {
                WeaponType = (WeaponsType)(r.Next(3, 5));
            }
        }
    }
}