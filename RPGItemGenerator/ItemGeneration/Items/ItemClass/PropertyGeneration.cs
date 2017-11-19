using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class Item
    {        
        protected void GetNewSecondaryProperty(Item itm)
        {
            int x = CalculateNumberOfProperties();
            GetPropertys(x, itm);            

            foreach (var p in SecondaryProps.Values)
            {
                p.Execute(this);
            }
        }

        private int CalculateNumberOfProperties()
        {
            double median = 0;
            double deviation = 0;

            switch (Rarity)
            {
                case Rarity.Common:
                        median = 1;
                        deviation = 1;
                        break;
                case Rarity.Uncommon:
                        median = 2;
                        deviation = 1;
                        break;
                case Rarity.Rare:
                        median = 2;
                        deviation = 2;
                        break;
                case Rarity.Epic:
                        median = 3;
                        deviation =1;
                        break;
                case Rarity.Legendary:
                        median = 4;
                        deviation = 1;
                        break;
            }

            int x = (int)GetNewGaussianCurve(median, deviation);
            if (x < 0) { x = 0; }
            return x;
        }
    }
}
