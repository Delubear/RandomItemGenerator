namespace RPGItemGenerator.ItemGeneration
{
    public partial class RunItemGen
    {
        public void GenerateLists()
        {

            itemBaseName = new BaseNames(itemBaseName).itemBaseName;
            //BaseNames.GenerateMeleeWeaponBaseNames();
            //BaseNames.GenerateRangedWeaponBaseNames();
            //BaseNames.GenerateMagicWeaponBaseNames();
            //BaseNames.GenerateArmorBaseNames();
            //BaseNames.GeneratePotionBaseNames();
        }
    }
}
