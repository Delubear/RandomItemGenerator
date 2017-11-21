using Microsoft.EntityFrameworkCore;
using RPGItemGenerator.ItemGeneration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MVCItemGen.Model
{
    public class ItemRepository : IBaseItemRepository
    {
        public ItemDbContext _itemDbContext;

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
                return _itemDbContext.items.ToList();
            }
        }

        public void Reset()
        {
            _itemDbContext.RemoveRange(BaseItemRepository);
            _itemDbContext.SaveChanges();
        }
    }
}
