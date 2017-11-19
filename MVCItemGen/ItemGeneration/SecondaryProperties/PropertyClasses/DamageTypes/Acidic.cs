using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Acidic : SecondaryProperties
    {
        public Acidic()
        {
            Key = 1;  //Key 1 is for Damage Type changers
            this.PropDescription = "Acidic";
        }
        public override void Execute(BaseItemModel item)
        {     
            int x = r.Next(0, 3);
            if (x == 0)
            {
                item.PrefixList.Add("Acidic" + " ");
            }
            else if (x == 1)
            {
                item.PrefixList.Add("Corrosive" + " ");
            }
            else
            {
                item.SuffixList.Add(" " + "of Corrosion");
            }

            item.Value = (int)(item.Value *1.1);
            if(item.ItemType == ItemTypes.Weapon)
            {
                item.GetType().GetProperty("DamageType").SetValue(item, DamageTypes.Acidic);             
            }
            
        }
    }
}
