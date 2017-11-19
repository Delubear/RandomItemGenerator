using System;
using System.Text;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public abstract partial class Item
    {
        StringBuilder sb = new StringBuilder();
        protected string GetNewDescription()
        {
            SetDescAdjectives();            
            sb.Append(BaseName);
            sb.Append(" ");
            SetDescEnding();

            return sb.ToString();            
        }

        private void SetDescEnding()
        {
            if (Value < 10)
            {
                sb.Append("made from poor materials.");
            }
            else if (Value < 50)
            {
                sb.Append("marked with quality stamps of approval.");
            }
            else if (Value < 100)
            {
                sb.Append("set with sparkling gemstones.");
            }
            else
            {
                sb.Append("coated in gold and gems.  Truly a symbol of wealth and power.");
            }
        }

        private void SetDescAdjectives()
        {
            int x = r.Next(0,3);
            string dt = "";
            if(x == 1)
            {
                if(ItemType == ItemTypes.Weapon)
                {
                    dt = this.GetType().GetProperty("DamageType").GetValue(this).ToString();
                }                
            }            
            sb.Append("A " + dt + " ");                                      
        }
    }
}
