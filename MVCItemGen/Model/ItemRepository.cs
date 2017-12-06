using RPGItemGenerator.ItemGeneration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCItemGen.Model
{
    public class ItemRepository : IBaseItemRepository
    {
        public ItemDbContext _itemDbContext;

        //Dictionary<string, HashSet<string>> itemBaseName;

        public ItemRepository(ItemDbContext itemDbContext)
        {
            _itemDbContext = itemDbContext;

            //var g = new RunItemGen();
            //g.GenerateLists();
            //itemBaseName = g.itemBaseName;
        }

        Random r = new Random();
        RunItemGen ItemGen = new RunItemGen();

        public void AddRandomItem()
        {
            //_itemDbContext.Add(ItemGen.GetItemType(itemBaseName));
            _itemDbContext.Add(ItemGen.GetNewRandomItem());
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
