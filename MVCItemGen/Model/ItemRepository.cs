using RPGItemGenerator.ItemGeneration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCItemGen.Model
{
    public class ItemRepository : IBaseItemRepository
    {
        private ItemDbContext _itemDbContext;

        Dictionary<string, HashSet<string>> itemBaseName;

        public ItemRepository(ItemDbContext itemDbContext)
        {
            _itemDbContext = itemDbContext;

            var g = new RunItemGen();
            g.GenerateLists();
            itemBaseName = g.itemBaseName;
        }

        Random r = new Random();

        public void AddRandomItem()
        {
            int x = r.Next(0, 3);
            if (x == 0)
            {
                _itemDbContext.Add(new Weapons(itemBaseName));
                //return new Weapons(itemBaseName);
            }
            else if (x == 1)
            {
                _itemDbContext.Add(new Armor(itemBaseName));
                //return new Armor(itemBaseName);
            }
            else
            {
                _itemDbContext.Add(new Potions(itemBaseName));
                //return new Potions(itemBaseName);
            }
            _itemDbContext.SaveChanges();
        }

        public IEnumerable<Item> GetDatabaseItems()
        {
            return _itemDbContext.items;
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
