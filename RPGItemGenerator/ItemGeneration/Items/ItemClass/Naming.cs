using System;
using System.Collections.Generic;
using System.Linq;
using static RPGItemGenerator.ItemGeneration.Enums;

namespace RPGItemGenerator.ItemGeneration
{
    public abstract partial class Item
    {
        private string GetNewBaseName()
        {
            string typeOfName = GetTypeOf(this);
            
            
            HashSet<string> _name = ItemBaseNames[Rarity.ToString() + ":" + typeOfName];
            return _name.ElementAt(r.Next(0, _name.Count()));
        }

        protected string GetNewName()
        {
            string result = "";
            BaseName = "";
            Prefix = "";
            PrefixDescriptor = "";
            
            int x = (int)GetNewGaussianCurve(PrefixList.Count() / 2, PrefixList.Count() / 4);
            if (x < 0) { x = 0; }
            x += (int)GetNewGaussianCurve(Convert.ToDouble(Rarity), 0.25);
            for(int i = 0; i < x; i++)
            {
                if(PrefixList.Count() > 0)
                {
                    int y = r.Next(0, PrefixList.Count());
                    Prefix += PrefixList.ElementAt(y);
                    PrefixList.RemoveAt(y);
                }                
            }
            if (PrefixDescriptorList.Count() > 0)
            {
                int y = r.Next(0, PrefixDescriptorList.Count());
                PrefixDescriptor = PrefixDescriptorList.ElementAt(y);
            }

            Suffix = SuffixList.ElementAt(r.Next(0, SuffixList.Count()));
            BaseName = GetNewBaseName();
            result = Prefix + PrefixDescriptor + BaseName + Suffix;
            return result;
        }
    }
}
