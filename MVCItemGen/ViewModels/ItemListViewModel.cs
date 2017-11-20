using MVCItemGen.Model;
using RPGItemGenerator.ItemGeneration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCItemGen.ViewModels
{
    public class ItemListViewModel
    {
        public List<Item> ItemList { get; set; }
        
        [Required]
        public string Amount { get; set; }
        
        
    }
}
