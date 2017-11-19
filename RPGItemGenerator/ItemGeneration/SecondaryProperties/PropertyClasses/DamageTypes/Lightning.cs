using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Lightning : SecondaryProperties
    {
        public Lightning()
        {
            Key = 1;
            this.PropDescription = "Lightning";
        }

        public override void Execute(Item item)
        {
            int x = r.Next(0, 3);
            if (x == 0)
            {
                item.PrefixList.Add("Lightning" + " ");
            }
            else if (x == 1)
            {
                item.PrefixList.Add("Shocking" + " ");
            }
            else
            {
                item.SuffixList.Add(" " + "of Electricity");
            }

            item.Value = (int)(item.Value *1.1);
            if(item.ItemType == ItemTypes.Weapon)
            {
                item.GetType().GetProperty("DamageType").SetValue(item, DamageTypes.Lightning);             
            }
            
        }
    }
}
