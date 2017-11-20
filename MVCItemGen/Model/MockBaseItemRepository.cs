using RPGItemGenerator.ItemGeneration;
using System;
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

        Random r = new Random();

        public Item AddRandomItem()
        {
            int x = r.Next(0, 3);
            if(x == 0)
            {
                return new Weapons(itemBaseName);
            }
            else if(x == 1)
            {
                return new Armor(itemBaseName);
            }
            else
            {
                return new Potions(itemBaseName);
            }            
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
