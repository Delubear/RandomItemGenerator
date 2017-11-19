using System;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class Weapons : BaseItemModel
    {        
        private void GenerateAccuracy()
        {
            switch (Rarity)
            {
                case Rarity.Common:
                    Accuracy = Math.Round(GetNewGaussianCurve(0.6, 0.2), 2);
                    break;
                case Rarity.Uncommon:
                    Accuracy = Math.Round(GetNewGaussianCurve(0.7, 0.1), 2);
                    break;
                case Rarity.Rare:
                    Accuracy = Math.Round(GetNewGaussianCurve(0.8, 0.1), 2);
                    break;
                case Rarity.Epic:
                    Accuracy = Math.Round(GetNewGaussianCurve(0.8, 0.2), 2);
                    break;
                case Rarity.Legendary:
                    Accuracy = Math.Round(GetNewGaussianCurve(0.9, 0.2), 2);
                    break;
            }

            if(Accuracy > 1)
            {
                Accuracy = 1;
            }
            else if(Accuracy < 0.1)
            {
                Accuracy = 0.1;
            }
        }        
    }
}