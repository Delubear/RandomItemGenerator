using System;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public abstract partial class Item
    {
        protected double GetNewGaussianCurve(double median = 0, double deviation = 1)
        {
            return r.NextGaussian(median, deviation);
        }        

        protected Rarity GetRarity()
        {
            int x = (int)GetNewGaussianCurve(0, 1.75);
            if(x < 0) { x = 0; }
            else if(x > 4) { x = 4; }
            return (Rarity)x;
        }                
    }
}
