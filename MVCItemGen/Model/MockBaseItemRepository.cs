using RPGItemGenerator.ItemGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public IEnumerable<BaseItemModel> BaseItemRepository 
        {
            get
            {
                return new List<BaseItemModel>
                {
                    new Weapons(itemBaseName),
                    new Weapons(itemBaseName)

                };
            }
        }

    }
}
