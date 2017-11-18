using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCItemGen.Model
{
    public class MockBaseItemRepository : IBaseItemRepository
    {
        public IEnumerable<BaseItemModel> BaseItemRepository 
        {
            get
            {
                return new List<BaseItemModel>
                {
                    new WeaponModel{Id = 1, Name = "Test Item 1"},
                    new WeaponModel{Id = 2, Name = "Test 2"}

                };
            }
        }

    }
}
