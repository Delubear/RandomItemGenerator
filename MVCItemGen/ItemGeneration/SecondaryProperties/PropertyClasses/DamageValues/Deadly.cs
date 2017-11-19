using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Deadly : SecondaryProperties
    {
        public Deadly()
        {
            Key = 4;
            this.PropDescription = "Deadly";
        }

        public override void Execute(BaseItemModel item)
        {
            item.PrefixList.Add("Deadly" + " ");

            item.Value = (int)(item.Value *1.1);
            if(item.ItemType == ItemTypes.Weapon)
            {                
                int dv = (int)item.GetType().GetProperty("DamageValue").GetValue(item);
                dv = (int)(dv * 1.3);
                item.GetType().GetProperty("DamageValue").SetValue(item, dv);                                    
            }
            
        }
    }
}
