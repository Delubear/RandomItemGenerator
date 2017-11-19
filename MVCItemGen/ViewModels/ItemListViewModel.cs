using MVCItemGen.Model;
using RPGItemGenerator.ItemGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCItemGen.ViewModels
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> ItemList { get; set; }

    }
}
