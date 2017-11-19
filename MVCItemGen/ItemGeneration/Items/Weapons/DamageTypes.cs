using System;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class Weapons : BaseItemModel
    {
        private void GetDamageTypes()
        {
            switch (WeaponType)
            {
                case WeaponsType.Bow:
                        DamageType = DamageTypes.Piercing;
                        break;
                case WeaponsType.Crossbow:
                        DamageType = DamageTypes.Piercing;
                        break;
                case WeaponsType.Dagger:
                        if (r.Next(0, 2) == 0)
                        {
                            DamageType = DamageTypes.Slashing;
                        }
                        else
                        {
                            DamageType = DamageTypes.Piercing;
                        }
                        break;
                case WeaponsType.Sword:
                        if (r.Next(0, 2) == 0)
                        {
                            DamageType = DamageTypes.Slashing;
                        }
                        else
                        {
                            DamageType = DamageTypes.Piercing;
                        }
                        break;
                case WeaponsType.Spear:
                        DamageType = DamageTypes.Piercing;
                        break;
                case WeaponsType.Wand:
                        DamageType = (DamageTypes)(r.Next(0, Enum.GetValues(typeof(DamageTypes)).Length));
                        break;
                case WeaponsType.Staff:
                        DamageType = (DamageTypes)(r.Next(0, Enum.GetValues(typeof(DamageTypes)).Length));
                        break;
                case WeaponsType.Spellbook:
                        DamageType = (DamageTypes)(r.Next(0, Enum.GetValues(typeof(DamageTypes)).Length));
                        break;
            }
        }
    }
}