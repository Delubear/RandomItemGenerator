using RPGItemGenerator.ItemGeneration;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCItemGen.ViewModels
{
    public class ItemListViewModel
    {
        public List<Item> ItemList { get; set; }
        
        [Required]
        public string Amount { get; set; }        
    }
}
