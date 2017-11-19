using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public abstract partial class BaseItemModel
    {
        protected void GetDurability()
        {
            double median = 0;
            double deviation = 0;

            switch (Rarity)
            {
                case Rarity.Common:
                        median = 50;
                        deviation = 5;
                        break;
                case Rarity.Uncommon:
                        median = 75;
                        deviation = 10;
                        break;
                case Rarity.Rare:
                        median = 100;
                        deviation = 15;
                        break;
                case Rarity.Epic:
                        median = 125;
                        deviation = 20;
                        break;
                case Rarity.Legendary:
                        median = 150;
                        deviation = 25;
                        break;
            }

            int x = (int)GetNewGaussianCurve(median, deviation);
            if (x < 15)
            {
                x = 15;
            }

            MaxDurability = x;

            int _rarityModifier = (int)Rarity;
            if(_rarityModifier == 0)
            {
                _rarityModifier = 1;
            }

            double y = GetNewGaussianCurve((MaxDurability / 2), (MaxDurability / 5));
            y = GetNewGaussianCurve(y, (int)Rarity * 0.1);

            if(y < 1)
            {
                y = 1;
            }

            CurrentDurability = (int)y;

            AdjustValueBasedOnDurability();
        }            
    }
}
