using System.Collections.Generic;

namespace RPGItemGenerator.ItemGeneration
{
    public interface IBaseNames
    {
        void GenerateArmorBaseNames();
        void GenerateMagicWeaponBaseNames();
        void GenerateMeleeWeaponBaseNames();
        void GeneratePotionBaseNames();
        void GenerateRangedWeaponBaseNames();
        
        Dictionary<string, HashSet<string>> ItemBaseName { get; set; }
    }
}