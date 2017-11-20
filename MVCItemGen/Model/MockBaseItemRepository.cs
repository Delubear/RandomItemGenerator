using RPGItemGenerator.ItemGeneration;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCItemGen.Model
{
    public class MockBaseItemRepository : IBaseItemRepository
    {
        Dictionary<string, HashSet<string>> itemBaseName;
        public MockBaseItemRepository()
        {
            var g = new RunItemGen();
            g.GenerateLists();
            itemBaseName = g.itemBaseName;
        }     

        public Item AddRandomItem()
        {
            return new Weapons(itemBaseName);
        }

        public List<Item> BaseItemRepository 
        {
            get
            {
                return new List<Item>
                {
                    //new Weapons(itemBaseName),
                    //new Weapons(itemBaseName),
                    //new Armor(itemBaseName),
                    //new Armor(itemBaseName),
                    //new Potions(itemBaseName),
                    //new Potions(itemBaseName),

                };
            }
        }

    }
}
