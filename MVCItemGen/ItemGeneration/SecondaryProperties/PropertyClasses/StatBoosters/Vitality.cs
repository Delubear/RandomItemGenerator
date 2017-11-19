using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public class Vitality : SecondaryProperties
    {
        public Vitality()
        {
            Key = 10;
            this.PropDescription = "Vitality";
        }

        public override void Execute(BaseItemModel item)
        {
            int x = r.Next(0, 3);
            if(x == 0)
            {
                item.SuffixList.Add(" " + "of Vitality");
            }
            else if (x == 1)
            {
                item.SuffixList.Add(" " + "of the Life-Giver");
            }
            else
            {
                item.PrefixList.Add("Vitalizing" + " ");
            }
            
            item.Value = (int)(item.Value *1.1);            

            if (item.ItemType == ItemTypes.Potion)
            {
                var currentEffectString = item.GetType().GetProperty("Effect").GetValue(item).ToString();
                var newEffectString = currentEffectString += "+Vitality ";
                item.GetType().GetProperty("Effect").SetValue(item, newEffectString);
            }
        }
    }
}
