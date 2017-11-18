using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCItemGen.Model
{
    public class WeaponModel : BaseItemModel
    {
        

        public WeaponModel()
        {
            Value = r.Next(1, 10);
            MaxDurability = r.Next(1, 10);
            CurrentDurability = r.Next(1, MaxDurability);
        }
    }
}
