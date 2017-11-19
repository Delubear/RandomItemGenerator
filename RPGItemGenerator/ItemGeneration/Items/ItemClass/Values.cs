using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class Item
    {
        protected int GetNewValue()
        {
            double median = 0;
            double deviation = 0;

            switch (Rarity)
            {
                case Rarity.Common:
                        median = 15;
                        deviation = 9;
                        break;
                case Rarity.Uncommon:
                        median = 45;
                        deviation = 15;
                        break;
                case Rarity.Rare:
                        median = 95;
                        deviation = 25;
                        break;
                case Rarity.Epic:
                        median = 150;
                        deviation = 50;
                        break;
                case Rarity.Legendary:
                        median = 500;
                        deviation = 200;
                        break;
            }

            int x = (int)GetNewGaussianCurve(median, deviation);
            if (x < 0) { x = 0; }
            return x;
        }

        protected void AdjustValueBasedOnDurability()
        {
            Value = (int)(((double)CurrentDurability / (double)MaxDurability) * Value);
        }
    }
}
