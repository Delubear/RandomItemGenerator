using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCItemGen.Model
{
    public abstract class BaseItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int MaxDurability { get; set; }
        public int CurrentDurability { get; set; }

        public Random r = new Random();



    }
}
